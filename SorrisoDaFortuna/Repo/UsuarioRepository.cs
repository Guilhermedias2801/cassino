using System;
using MySql.Data.MySqlClient;
using System.Linq;

namespace SorrisoDaFortuna
{
    internal class UsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Usuario ObterPorEmailESenha(string email, string senha)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string hashSenha = HashUtil.GerarHashSha256(senha);
                    string query = @"SELECT email, nome, saldo, senha FROM usuario WHERE email = @Email AND senha = @Senha";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", hashSenha);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Usuario
                                {
                                    Email = reader.GetString("email"),
                                    Nome = reader.GetString("nome"),
                                    Senha = reader.GetString("senha"),
                                    Saldo = reader.GetDecimal("saldo")
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int InserirUsuario(Usuario usuario)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO usuario (email, nome, senha) VALUES (@Email, @Username, @Senha)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        string hashSenha = HashUtil.GerarHashSha256(usuario.Senha);
                        command.Parameters.AddWithValue("@Email", usuario.Email);
                        command.Parameters.AddWithValue("@Username", usuario.Nome);
                        command.Parameters.AddWithValue("@Senha", hashSenha);
                        linhasAfetadas = command.ExecuteNonQuery();
                    }

                    return linhasAfetadas;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        public int AtualizarSaldo(Usuario usuario)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE usuario SET saldo = saldo+@Saldo WHERE email = @Email";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Saldo", usuario.Saldo);
                        command.Parameters.AddWithValue("@Email", usuario.Email);
                        linhasAfetadas = command.ExecuteNonQuery();

                    }

                    return linhasAfetadas;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
        public decimal ObterSaldoAtual(string email)
        {
            decimal saldo = 0m;

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "SELECT saldo FROM usuario WHERE email = @Email LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        saldo = Convert.ToDecimal(result);
                    }
                }
            }

            return saldo;
        }

    }
}