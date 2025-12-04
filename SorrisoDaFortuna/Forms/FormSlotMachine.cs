using System;
using System.Globalization;
using System.Windows.Forms;

namespace SorrisoDaFortuna
{
    public partial class FormSlotMachine : Form
    {
        private readonly Random _rand = new Random();
        private readonly Usuario _usuarioLogado;
        private readonly UsuarioRepository _repo;

        private const decimal PREMIO_MAXIMO_BASE = 50.00m;
        private const decimal PREMIO_ALTO_BASE = 20.00m;
        private const decimal PREMIO_MEDIO_BASE = 5.00m;
        private const decimal PREMIO_PEQUENO_BASE = 2.00m;

        public FormSlotMachine(Usuario usuario, string connectionString)
        {
            InitializeComponent();
            _repo = new UsuarioRepository(connectionString);
            _usuarioLogado = usuario;
            _usuarioLogado.Saldo = _repo.ObterSaldoAtual(_usuarioLogado.Email);
            InicializarListaDeApostas();
            ExibirSaldo();
        }

        private void InicializarListaDeApostas()
        {
            cmbApostas.Items.Clear();
            cmbApostas.Items.Add("R$ 2,00");
            cmbApostas.Items.Add("R$ 5,00");
            cmbApostas.Items.Add("R$ 10,00");
            cmbApostas.Items.Add("R$ 50,00");
            cmbApostas.SelectedIndex = 0;
        }

        private void ExibirSaldo()
        {
            lblSaldo.Text = $"Saldo: R$ {_usuarioLogado.Saldo:F2}";
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            if (!TryObterValorAposta(out decimal custoJogada))
                return;

            if (_usuarioLogado.Saldo < custoJogada)
            {
                MessageBox.Show($"Saldo insuficiente! Você tem R$ {_usuarioLogado.Saldo:F2}", "Erro");
                return;
            }

            AtualizarSaldoLocalEBanco(-custoJogada);

            int num1 = _rand.Next(10);
            int num2 = _rand.Next(10);
            int num3 = _rand.Next(10);

            Number1label1.Text = num1.ToString();
            Number2label2.Text = num2.ToString();
            Number3label3.Text = num3.ToString();

            decimal ganhoFinal = CalcularGanho(num1, num2, num3, custoJogada, out string mensagem);
            if (ganhoFinal > 0)
                AtualizarSaldoLocalEBanco(ganhoFinal);

            MessageBox.Show($"{mensagem}\nGanhou: R$ {ganhoFinal:F2}\nSaldo atual: R$ {_usuarioLogado.Saldo:F2}",
                            "Resultado da Jogada");
        }

        private bool TryObterValorAposta(out decimal custoJogada)
        {
            custoJogada = 0;

            if (cmbApostas.SelectedItem == null)
            {
                MessageBox.Show("Selecione um valor de aposta.", "Aviso");
                return false;
            }

            string textoAposta = cmbApostas.SelectedItem.ToString();
            string valorString = textoAposta.Split(' ')[1].Replace(",", ".");

            return decimal.TryParse(valorString, NumberStyles.Currency, CultureInfo.InvariantCulture, out custoJogada);
        }

        private decimal CalcularGanho(int num1, int num2, int num3, decimal custoJogada, out string mensagem)
        {
            decimal ganhoBase = 0m;

            if (num1 == 7 && num2 == 7 && num3 == 7)
            {
                ganhoBase = PREMIO_MAXIMO_BASE;
                mensagem = "JACKPOT! 777!";
            }
            else if (num1 == num2 && num2 == num3)
            {
                ganhoBase = PREMIO_ALTO_BASE;
                mensagem = $"Trinca de {num1}{num2}{num3}!";
            }
            else if (num1 == num2 || num2 == num3 || num1 == num3)
            {
                ganhoBase = PREMIO_MEDIO_BASE;
                mensagem = "Dois números iguais!";
            }
            else if ((num2 == num1 + 1 && num3 == num2 + 1) ||
                     (num2 == num1 - 1 && num3 == num2 - 1))
            {
                ganhoBase = PREMIO_PEQUENO_BASE;
                mensagem = "Sequência!";
            }
            else
            {
                mensagem = "Nada dessa vez!";
            }

            return ganhoBase * (custoJogada / 1.00m);
        }

        private void AtualizarSaldoLocalEBanco(decimal valor)
        {
            _usuarioLogado.Saldo += valor;
            ExibirSaldo();

            if (_repo != null)
            {
                _repo.AtualizarSaldo(new Usuario
                {
                    Email = _usuarioLogado.Email,
                    Saldo = valor
                });
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
