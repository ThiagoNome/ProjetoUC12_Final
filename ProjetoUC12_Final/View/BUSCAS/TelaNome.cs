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

namespace ProjetoUC12_Final.View.BUSCAS
{
    public partial class TelaNome : Form
    {
        public TelaNome()
        {
            InitializeComponent();
        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Filmes.NomeFilme = textBoxNomeBusca.Text;
            FilmesMain mp = new();
            mp.BuscarNome();

            textBoxDuracao.Text = Filmes.DuracaoFilme;
            textBoxCategoria.Text = Filmes.CategoriaFilme;
            textBoxData.Text = Filmes.DataLancamento;
            textBoxFaixa.Text = Filmes.FaixaEtaria;
        }
    }
}
