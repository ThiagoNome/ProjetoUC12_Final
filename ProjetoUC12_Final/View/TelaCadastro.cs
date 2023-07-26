using ProjetoUC12_Final.Controller;
using ProjetoUC12_Final.Model;
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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Filmes.NomeFilme = textBoxFilme.Text;
            Filmes.DuracaoFilme = textBoxDuracao.Text;
            Filmes.CategoriaFilme = textBoxCategoria.Text;
            Filmes.DataLancamento = textBoxData.Text;
            Filmes.FaixaEtaria = textBoxFaixa.Text;

            FilmesMain eFilmes = new();
            eFilmes.CadastrosFilmes();
        }
        public void AbrirCadastro()
        {
            this.ShowDialog();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
