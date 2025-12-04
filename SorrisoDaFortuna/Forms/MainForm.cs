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
    public partial class MainForm : Form
    {
        UsuarioRepository repo = new UsuarioRepository(BdUtil.ConnectionString);
        private Usuario usuarioLogado;
        public MainForm(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
            label2.Text = $"Olá {usuarioLogado.Nome}! Seu saldo é R${usuarioLogado.Saldo}";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            Form21 black = new Form21(usuarioLogado);
            this.Close();
            black.ShowDialog();
        }

        private void btnBicho_Click(object sender, EventArgs e)
        {
            FormBicho bicho = new FormBicho(usuarioLogado);
            this.Close();
            bicho.ShowDialog();
        }

        private void btnRoleta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormSlotMachine(usuarioLogado, BdUtil.ConnectionString);
            form.ShowDialog();
            this.Show();
        }


        private void btnDepositar_Click(object sender, EventArgs e)
        {
            FormDeposito depo = new FormDeposito(usuarioLogado);
            this.Close();
            depo.ShowDialog();
        }
    }
}
