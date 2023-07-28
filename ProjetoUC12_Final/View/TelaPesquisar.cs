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
    public partial class TelaPesquisar : Form
    {
        public TelaPesquisar()
        {
            InitializeComponent();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            Filmes.NomeFilme = textBoxNomeFilme.Text;

            dataGridView1.DataSource = FilmesMain.BuscarFilmeNome();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderCell.Value = "Código";
            dataGridView1.Columns[7].HeaderCell.Value = "Nome Filme";
            dataGridView1.Columns[8].HeaderCell.Value = "Duração do Filme";
            dataGridView1.Columns[9].HeaderCell.Value = "Categoria do Filme";
            dataGridView1.Columns[10].HeaderCell.Value = "Data de Lançamento";
            dataGridView1.Columns[11].HeaderCell.Value = "Faixa Etária";

        }

        private void button1_Click(object sender, EventArgs e)
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
