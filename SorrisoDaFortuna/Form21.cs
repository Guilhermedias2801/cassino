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
    public partial class Form21 : Form
    {
        UsuarioRepository repo = new UsuarioRepository(BdUtil.ConnectionString);
        private Usuario usuarioLogado;
        public Form21(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(usuarioLogado);
            this.Hide();
            main.ShowDialog();
        }

    }
}

