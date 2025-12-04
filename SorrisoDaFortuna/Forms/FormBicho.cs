using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SorrisoDaFortuna
{
    public partial class FormBicho : Form
    {
        UsuarioRepository repo = new UsuarioRepository(BdUtil.ConnectionString);
        private Usuario usuarioLogado;

        public FormBicho(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
            usuarioLogado.Saldo = repo.ObterSaldoAtual(usuarioLogado.Email);
            ExibirSaldo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(usuarioLogado);
            this.Hide();
            main.ShowDialog();
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            int numAposta = Convert.ToInt32(numericUpDown1.Value);

            decimal valorAposta = 10.00m;

            if (usuarioLogado.Saldo < valorAposta)
            {
                MessageBox.Show($"Saldo insuficiente! Você tem R$ {usuarioLogado.Saldo:F2}");
                return;
            }

            AtualizarSaldoLocalEBanco(-valorAposta);

            Random rnd = new Random();
            int numeroSorteado = rnd.Next(1, 26);
            ExibirSaldo();

            string animalAposta = ObterAnimalDoJogoDoBicho(numAposta);
            string animalSorteado = ObterAnimalDoJogoDoBicho(numeroSorteado);

            if (numAposta == numeroSorteado)
            {
                decimal premio = valorAposta * 20;

                AtualizarSaldoLocalEBanco(premio);

                MessageBox.Show(
                    $"🎉 Você GANHOU!\n\n" +
                    $"Seu bicho: {numAposta} - {animalAposta}\n" +
                    $"Sorteado: {numeroSorteado} - {animalSorteado}\n\n" +
                    $"Ganhou: R$ {premio:F2}\n" +
                    $"Saldo atual: R$ {usuarioLogado.Saldo:F2}"
                );
            }
            else
            {
                MessageBox.Show(
                    $"😢 Você PERDEU!\n\n" +
                    $"Seu bicho: {numAposta} - {animalAposta}\n" +
                    $"Sorteado: {numeroSorteado} - {animalSorteado}\n\n" +
                    $"Saldo atual: R$ {usuarioLogado.Saldo:F2}"
                );
            }
        }

        private void AtualizarSaldoLocalEBanco(decimal valor)
        {
            usuarioLogado.Saldo += valor;

            repo.AtualizarSaldo(new Usuario
            {
                Email = usuarioLogado.Email,
                Saldo = valor
            });
        }

        public static string ObterAnimalDoJogoDoBicho(int numero)
        {
            Dictionary<int, string> animais = new Dictionary<int, string>()
            {
                { 1,  "Avestruz" },
                { 2,  "Águia" },
                { 3,  "Burro" },
                { 4,  "Borboleta" },
                { 5,  "Cachorro" },
                { 6,  "Cabra" },
                { 7,  "Carneiro" },
                { 8,  "Camelo" },
                { 9,  "Cobra" },
                { 10, "Coelho" },
                { 11, "Cavalo" },
                { 12, "Elefante" },
                { 13, "Galo" },
                { 14, "Gato" },
                { 15, "Jacaré" },
                { 16, "Leão" },
                { 17, "Macaco" },
                { 18, "Porco" },
                { 19, "Pavão" },
                { 20, "Peru" },
                { 21, "Touro" },
                { 22, "Tigre" },
                { 23, "Urso" },
                { 24, "Veado" },
                { 25, "Vaca" }
            };

            if (animais.ContainsKey(numero))
                return animais[numero];

            return "Número inválido (válido somente de 1 a 25).";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNumBichos bichos = new FormNumBichos(usuarioLogado);
            this.Hide();
            bichos.ShowDialog();
        }
        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
        private void ExibirSaldo()
        {
            lblSaldo.Text = $"Saldo: R$ {usuarioLogado.Saldo:F2}";
        }
    }
}

