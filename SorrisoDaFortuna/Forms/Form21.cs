using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorrisoDaFortuna
{
    using System;
    using System.Windows.Forms;

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
            lblSaldo.Text = $"Saldo: R$ {usuarioLogado.Saldo:F2}";
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(usuarioLogado);
            this.Hide();
            main.ShowDialog();
        }
        
        private void btnApostar_Click(object sender, EventArgs e)
        { 
            if (!decimal.TryParse(txtAposta.Text, out aposta) ||aposta <= 0)
            {
                lblMsg.Text = "Aposta inválida";
                return;
            }

            if (aposta > usuarioLogado.Saldo)
            {
                lblMsg.Text = "Saldo insuficiente";
                return;
            }

            usuarioLogado.Saldo -= aposta;
            AtualizarSaldo();

            jogador = rng.Next(12, 22); // jogador recebe um valor aleatório entre 12 e 21
            dealer = rng.Next(12, 22);

            lblJogador.Text = $"Jogador: {jogador}";
            lblDealer.Text = "Dealer: ?";

            btnHit.Enabled = true;
            btnStand.Enabled = true;
            btnApostar.Enabled = false;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            jogador += rng.Next(1, 11); // compra de 1 a 10
            lblJogador.Text = $"Jogador: {jogador}";

            if (jogador > 21)
            {
                Finalizar(false);
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            dealer = rng.Next(16, 23); // dealer joga até pelo menos 16
            lblDealer.Text = $"Dealer: {dealer}";

            if (dealer > 21) Finalizar(true);
            else if (jogador > dealer) Finalizar(true);
            else if (jogador < dealer) Finalizar(false);
            else Finalizar(null); // empate
        }

        private void Finalizar(bool? ganhou)
        {
            if (ganhou == true)
            {
                usuarioLogado.Saldo += aposta * 2;
                lblMsg.Text = "Você venceu!";
            }
            else if (ganhou == false)
            {
                lblMsg.Text = "Você perdeu!";
            }
            else
            {
                usuarioLogado.Saldo += aposta;
                lblMsg.Text = "Empate (Push)";
            }

            AtualizarSaldo();

            aposta = 0;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnApostar.Enabled = true;
        }

        private void AtualizarSaldo()
        {
            lblSaldo.Text = $"Saldo: R$ {usuarioLogado.Saldo:F2}";
        }
       /* private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(usuarioLogado);
            this.Hide();
            main.ShowDialog();
        }*/
        private void ExibirSaldo()
        {
            lblSaldo.Text = $"Saldo: R$ {usuarioLogado.Saldo:F2}";
        }
    }
}


