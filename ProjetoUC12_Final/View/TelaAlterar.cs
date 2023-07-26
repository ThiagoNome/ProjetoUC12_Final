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
    public partial class TelaAlterar : Form
    {
        public TelaAlterar()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Filmes.Codigo = Convert.ToInt32(textBoxCod.Text);
            FilmesMain mp = new();
            mp.BuscarCodigo();

            textBoxCodigo.Text = Filmes.Codigo.ToString();
            textBoxNome.Text = Filmes.NomeFilme;
            textBoxDuracao.Text = Filmes.DuracaoFilme;
            textBoxCategoria.Text = Filmes.CategoriaFilme;
            textBoxData.Text = Filmes.DataLancamento;
            textBoxFaixa.Text = Filmes.FaixaEtaria;
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Filmes.Codigo = Convert.ToInt32(textBoxCod.Text);
            Filmes.NomeFilme = textBoxNome.Text;
            Filmes.DuracaoFilme = textBoxDuracao.Text;
            Filmes.CategoriaFilme = textBoxCategoria.Text;
            Filmes.DataLancamento = textBoxData.Text;
            Filmes.FaixaEtaria = textBoxFaixa.Text;

            FilmesMain mp = new();
            mp.AlterarFilme();
        }
    }
}
