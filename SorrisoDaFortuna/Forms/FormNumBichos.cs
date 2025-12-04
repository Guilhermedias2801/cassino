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
    public partial class FormNumBichos : Form
    {
        UsuarioRepository repo = new UsuarioRepository(BdUtil.ConnectionString);
        private Usuario usuarioLogado;
        public FormNumBichos(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormBicho bicho = new FormBicho(usuarioLogado);
            this.Hide();
            bicho.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
