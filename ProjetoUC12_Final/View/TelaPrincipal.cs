using ProjetoUC12_Final.View.BUSCAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoUC12_Final.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletar deletar = new TelaDeletar();
            deletar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterar alterar = new TelaAlterar();
            alterar.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCodigo telaCodigo = new TelaCodigo();
            telaCodigo.Show();
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaNome telaNome = new TelaNome();
            telaNome.Show();
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCategoria categoria = new TelaCategoria();
            categoria.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
