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

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterar alterar = new TelaAlterar();
            alterar.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrar cadastrar = new TelaCadastrar();
            cadastrar.Show();

        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletar deletar = new TelaDeletar();
            deletar.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisar pesquisar = new TelaPesquisar();
            pesquisar.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
