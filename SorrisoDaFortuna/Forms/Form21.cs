using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SorrisoDaFortuna
{
    public partial class Form21 : Form
    {
        UsuarioRepository repo = new UsuarioRepository(BdUtil.ConnectionString);
        private Usuario usuarioLogado;
        private Random rng = new Random();

        private int jogador = 0;
        private int dealer = 0;
        private decimal aposta = 0;

        public Form21(Usuario usuario)
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
            if (!decimal.TryParse(txtAposta.Text, out aposta) || aposta <= 0)
            {
                lblMsg.Text = "Aposta inválida (R$ > 0)";
                return;
            }

            if (aposta > usuarioLogado.Saldo)
            {
                lblMsg.Text = "Saldo insuficiente";
                return;
            }

            AtualizarSaldoLocalEBanco(-aposta);

            jogador = rng.Next(12, 22);
            dealer = rng.Next(12, 22);

            lblJogador.Text = $"Jogador: {jogador}";
            lblDealer.Text = "Dealer: ?";

            btnHit.Enabled = true;
            btnStand.Enabled = true;
            btnApostar.Enabled = false;

            btnHit.Visible = true;
            btnStand.Visible = true;
            txtAposta.Enabled = false;

            lblMsg.Text = "HIT (pedir carta) ou STAND (parar)?";
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            jogador += rng.Next(1, 11);
            lblJogador.Text = $"Jogador: {jogador}";

            if (jogador > 21)
            {
                lblMsg.Text = "ESTOURO (BUST)! Você perdeu.";
                Finalizar(false);
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            lblDealer.Text = $"Dealer: {dealer}";

            if (dealer > 21)
            {
                lblMsg.Text = "Dealer estourou! Você venceu!";
                Finalizar(true);
            }
            else if (jogador > dealer)
            {
                lblMsg.Text = "Você venceu!";
                Finalizar(true);
            }
            else if (jogador < dealer)
            {
                lblMsg.Text = "Você perdeu!";
                Finalizar(false);
            }
            else
            {
                lblMsg.Text = "Empate (Push)";
                Finalizar(null);
            }
        }

        private void Finalizar(bool? ganhou)
        {
            decimal valorParaBanco = 0;

            if (ganhou == true)
            {
                valorParaBanco = aposta * 2;
            }
            else if (ganhou == false)
            {
                valorParaBanco = 0;
            }
            else
            {
                valorParaBanco = aposta;
            }

            if (valorParaBanco > 0)
            {
                AtualizarSaldoLocalEBanco(valorParaBanco);
            }

            aposta = 0;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnApostar.Enabled = true;

            btnHit.Visible = false;
            btnStand.Visible = false;
            txtAposta.Enabled = true;
        }

        private void AtualizarSaldoLocalEBanco(decimal valor)
        {
            usuarioLogado.Saldo += valor;

            repo.AtualizarSaldo(new Usuario
            {
                Email = usuarioLogado.Email,
                Saldo = valor
            });

            AtualizarSaldo();
        }

        private void AtualizarSaldo()
        {
            lblSaldo.Text = $"Saldo: R$ {usuarioLogado.Saldo:F2}";
        }

        private void ExibirSaldo()
        {
            AtualizarSaldo();
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {
        }
    }
}