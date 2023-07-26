using ProjetoUC12_Final.Model;
using ProjetoUC12_Final.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUC12_Final.Controller
{
    internal class FilmesMain
    {
        public void CadastrosFilmes()
        {
            SqlConnection cn = new(Conexao.Conectar());
            SqlCommand cmd = new("pCadastrarFilmes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("nomeFilme", Filmes.NomeFilme);
                cmd.Parameters.AddWithValue("duracaoFilme", Filmes.DuracaoFilme);
                cmd.Parameters.AddWithValue("categoriaFilme", Filmes.CategoriaFilme);
                cmd.Parameters.AddWithValue("dataLancamento", Filmes.DataLancamento);
                cmd.Parameters.AddWithValue("faixaetaria", Filmes.FaixaEtaria);

                SqlParameter nv = cmd.Parameters.Add("id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var msg = MessageBox.Show("Filme cadastrado com Sucesso, Deseja cadastrar outro filme?", "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (msg == DialogResult.Yes)
                {
                    TelaCadastro cadastro = new();
                    cadastro.AbrirCadastro();
                }
                else
                {
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }
        } /*FEITO*/

        public void DeletarFilme()
        {
            SqlConnection cn = new(Conexao.Conectar());
            SqlCommand cmd = new("pDeletarFilme", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("id", Filmes.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var msg = MessageBox.Show("Filme deletado com Sucesso, Deseja deletar outro Filme?", "Deletar Filme", 
                    MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if (msg == DialogResult.Yes)
                {
                    TelaDeletar deletar = new TelaDeletar();
                    deletar.AbrirDeletar();

                }
                else
                {
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }
        } /*FEITO*/

        public void AlterarFilme()
        {
            SqlConnection cn = new(Conexao.Conectar());
            SqlCommand cmd = new("pAlterarFilmes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("id", Filmes.Codigo);
                cmd.Parameters.AddWithValue("nomeFilme", Filmes.NomeFilme);
                cmd.Parameters.AddWithValue("duracaoFilme", Filmes.DuracaoFilme);
                cmd.Parameters.AddWithValue("categoriaFilme", Filmes.CategoriaFilme);
                cmd.Parameters.AddWithValue("dataLancamento", Filmes.DataLancamento);
                cmd.Parameters.AddWithValue("faixaEtaria", Filmes.FaixaEtaria);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Filme Alterado com Sucesso.");
                Filmes.Codigo = 0;
                Filmes.NomeFilme = "";
                Filmes.DuracaoFilme = "";
                Filmes.CategoriaFilme = "";
                Filmes.DataLancamento = "";
                Filmes.FaixaEtaria = "";

            }
            catch (Exception)
            {

                throw;
            }
        } /*FEITO*/

        public void BuscarCodigo()
        {
            SqlConnection cn = new(Conexao.Conectar());
            SqlCommand cmd = new("pBuscaFilmeCod", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("id", Filmes.Codigo);
                cn.Open();
                var msg = cmd.ExecuteReader();

                if (msg.Read())
                {
                    Filmes.Codigo = Convert.ToInt32(msg["id"]);
                    Filmes.NomeFilme = (string)msg["nomeFilme"];
                    Filmes.DuracaoFilme = (string)msg["duracaoFilme"];
                    Filmes.CategoriaFilme = (string)msg["categoriaFilme"];
                    Filmes.DataLancamento = (string)msg["dataLancamento"];
                    Filmes.FaixaEtaria = (string)msg["faixaEtaria"];
                }
                else
                {
                    Filmes.Codigo = 0;
                    Filmes.NomeFilme = "";
                    Filmes.DuracaoFilme = "";
                    Filmes.CategoriaFilme = "";
                    Filmes.DataLancamento = "";
                    Filmes.FaixaEtaria = "";
                    MessageBox.Show("Filme não encontrado.", "Pesquisar Filme");
                }

            }
            catch (Exception)
            {

                throw;
            }
        } /*FEITO*/

        public void BuscarNome()
        {
            SqlConnection cn = new(Conexao.Conectar());
            SqlCommand cmd = new("pBuscaFilmeNome", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("nomeFilme", Filmes.NomeFilme);
                cn.Open();
                var msg = cmd.ExecuteReader();

                if (msg.Read())
                {
                    Filmes.Codigo = Convert.ToInt32(msg["id"]);
                    Filmes.NomeFilme = (string)msg["nomeFilme"];
                    Filmes.DuracaoFilme = (string)msg["duracaoFilme"];
                    Filmes.CategoriaFilme = (string)msg["categoriaFilme"];
                    Filmes.DataLancamento = (string)msg["dataLancamento"];
                    Filmes.FaixaEtaria = (string)msg["faixaEtaria"];
                }
                else
                {
                    Filmes.Codigo = 0;
                    Filmes.NomeFilme = "";
                    Filmes.DuracaoFilme = "";
                    Filmes.CategoriaFilme = "";
                    Filmes.DataLancamento = "";
                    Filmes.FaixaEtaria = "";
                    MessageBox.Show("Filme não encontrado.", "Pesquisar Filme");
                }

            }
            catch (Exception)
            {

                throw;
            }
        } /*FEITO*/

        public void BuscarCategoria()
        {
            SqlConnection cn = new(Conexao.Conectar());
            SqlCommand cmd = new("pFilmesCategorias", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("categoriaFilme", Filmes.CategoriaFilme);
                cn.Open();
                var msg = cmd.ExecuteReader();

                if (msg.Read())
                {
                    Filmes.Codigo = Convert.ToInt32(msg["id"]);
                    Filmes.NomeFilme = (string)msg["nomeFilme"];
                    Filmes.DuracaoFilme = (string)msg["duracaoFilme"];
                    Filmes.CategoriaFilme = (string)msg["categoriaFilme"];
                    Filmes.DataLancamento = (string)msg["dataLancamento"];
                    Filmes.FaixaEtaria = (string)msg["faixaEtaria"];
                }
                else
                {
                    Filmes.Codigo = 0;
                    Filmes.NomeFilme = "";
                    Filmes.DuracaoFilme = "";
                    Filmes.CategoriaFilme = "";
                    Filmes.DataLancamento = "";
                    Filmes.FaixaEtaria = "";
                    MessageBox.Show("Filme não encontrado.", "Pesquisar Filme");
                }

            }
            catch (Exception)
            {

                throw;
            }
        } /*FEITO*/
    }
}
