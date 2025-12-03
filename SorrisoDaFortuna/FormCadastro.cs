using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorrisoDaFortuna
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimparCampos()
        {
            txtEmail.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string username = txtNome.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email inválido");
                txtEmail.Clear();
                return;
            }

            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                txtSenha.Clear();
                return;
            }

            if (username.Length < 3)
            {
                MessageBox.Show("O nome de usuário deve ter pelo menos 3 caracteres.");
                txtNome.Clear();
                return;
            }

            UsuarioRepository repo = new UsuarioRepository(BdUtil.ConnectionString);
            Usuario novoUsuario = new Usuario
            {
                Email = email,
                Nome = username,
                Senha = senha
            };

            try
            {
                int linhas = repo.InserirUsuario(novoUsuario);
                if (linhas > 0)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar.");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("Já existe um usuário com este e-mail.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado:  {ex.Message}");
            }
            var loginForm = new FormLogin();
            loginForm.ShowDialog();
            this.Close();
        }

    }
}

