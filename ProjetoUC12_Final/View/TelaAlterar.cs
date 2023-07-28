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

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            Filmes.Codigo = Convert.ToInt32(txbCodigo.Text);
            FilmesMain mp = new();
            mp.BuscarCodigo();

            txbCodigo.Text = Filmes.Codigo.ToString();
            txbFilme.Text = Filmes.NomeFilme;
            txbDuracao.Text = Filmes.DuracaoFilme;
            txbCategoria.Text = Filmes.CategoriaFilme;
            txbDatadeLancamento.Text = Filmes.DataLancamento;
            txbFaixaEtaria.Text = Filmes.FaixaEtaria;

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Filmes.Codigo = Convert.ToInt32(txbCodigo.Text);
            Filmes.NomeFilme = txbFilme.Text;
            Filmes.DuracaoFilme = txbDuracao.Text;
            Filmes.CategoriaFilme = txbCategoria.Text;
            Filmes.DataLancamento = txbDatadeLancamento.Text;
            Filmes.FaixaEtaria = txbFaixaEtaria.Text;

            FilmesMain mp = new();
            mp.AlterarFilme();
        }
    }
}
