using ProjetoUC12_Final.Controller;
using ProjetoUC12_Final.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoUC12_Final.View
{
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {

            Filmes.NomeFilme = txbFilme.Text;
            Filmes.DuracaoFilme = txbDuracao.Text;
            Filmes.CategoriaFilme = txbCategoria.Text;
            Filmes.DataLancamento = txbDatadeLancamento.Text;
            Filmes.FaixaEtaria = txbFaixaEtaria.Text;

            FilmesMain mp = new();
            mp.CadastrosFilmes();
        }
        public void AbrirCadastro()
        {
            this.ShowDialog();
        }
    }
}
