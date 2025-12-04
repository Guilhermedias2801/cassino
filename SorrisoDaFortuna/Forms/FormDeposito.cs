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
    public partial class FormDeposito : System.Windows.Forms.Form
    {
        UsuarioRepository repo = new UsuarioRepository(BdUtil.ConnectionString);
        private Usuario usuarioLogado;
        public FormDeposito(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(usuarioLogado);
            this.Hide();
            main.ShowDialog();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            repo.AtualizarSaldo(usuarioLogado, valor);
            MessageBox.Show("Valor depositado com sucesso! Jogue com responsabilidade.");
            repo.ObterPorEmailESenha(usuarioLogado.Email, usuarioLogado.Senha);
            usuarioLogado.Saldo += valor;
            
        }
    }
}
