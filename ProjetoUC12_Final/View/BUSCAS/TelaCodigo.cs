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
    public partial class TelaCodigo : Form
    {
        public TelaCodigo()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Filmes.Codigo = Convert.ToInt32(textBoxCod.Text);
            FilmesMain mp = new();
            mp.BuscarCodigo();

            textBoxCod.Text = Filmes.Codigo.ToString();
            textBoxNome.Text = Filmes.NomeFilme;
            textBoxDuracao.Text = Filmes.DuracaoFilme;
            textBoxCategoria.Text = Filmes.CategoriaFilme;
            textBoxData.Text = Filmes.DataLancamento;
            textBoxFaixa.Text = Filmes.FaixaEtaria;
        }
    }
}
