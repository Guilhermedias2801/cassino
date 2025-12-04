using System;
using System.Globalization;
using System.Windows.Forms;
// As referências que causavam erro foram removidas.
// Se Usuario, UsuarioRepository, BdUtil e MainForm estiverem em sub-pastas,
// seus arquivos .cs devem ter o namespace correspondente.

// Presumindo que todas as classes de suporte estão aqui:
namespace SorrisoDaFortuna
{
    // A classe partial FormDeposito DEVE herdar de Form
    public partial class FormDeposito : Form
    {
        // Certifique-se de que BdUtil.ConnectionString e MainForm existem
        // O compilador tentará encontrar UsuarioRepository, Usuario, BdUtil e MainForm dentro de SorrisoDaFortuna
        UsuarioRepository repo = new UsuarioRepository(BdUtil.ConnectionString);
        private Usuario usuarioLogado;

        // CONSTRUTOR
        public FormDeposito(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
        }

        // ==============================================
        // MÉTODO: btnDepositar_Click (Lógica de depósito)
        // ==============================================
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            // O nome "txtValor" é reconhecido pelo arquivo Designer.cs
            if (decimal.TryParse(txtValor.Text, NumberStyles.Currency | NumberStyles.Number, CultureInfo.CurrentCulture, out decimal valorDeposito))
            {
                if (valorDeposito > 0)
                {
                    // 1. Atualizar o saldo no BANCO DE DADOS (usando o valor POSITIVO)
                    int linhasAfetadas = repo.AtualizarSaldo(new Usuario
                    {
                        Email = usuarioLogado.Email,
                        // Assumindo que a classe Usuario tem um campo Email e Saldo.
                        Saldo = valorDeposito
                    });

                    if (linhasAfetadas > 0)
                    {
                        // 2. Atualizar o objeto do usuário em MEMÓRIA
                        usuarioLogado.Saldo += valorDeposito;

                        MessageBox.Show($"Depósito de R$ {valorDeposito:F2} realizado com sucesso!", "Sucesso");
                        txtValor.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar o depósito no banco de dados. Tente novamente.", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("O valor do depósito deve ser positivo e maior que zero.", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para o depósito.", "Erro de Formato");
            }
        }

        // ==============================================
        // MÉTODO: btnVoltar_Click
        // ==============================================
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Assumindo que 'MainForm' é o nome da tela principal/slot machine
            MainForm main = new MainForm(usuarioLogado);
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
