using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUC12_Final.Model
{
    internal class Filmes
    {
        private static int codigo;
        private static string nomeFilme;
        private static string duracaoFilme;
        private static string categoriaFilme;
        private static string dataLancamento;
        private static string faixaEtaria;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeFilme { get => nomeFilme; set => nomeFilme = value; }
        public static string DuracaoFilme { get => duracaoFilme; set => duracaoFilme = value; }
        public static string CategoriaFilme { get => categoriaFilme; set => categoriaFilme = value; }
        public static string DataLancamento { get => dataLancamento; set => dataLancamento = value; }
        public static string FaixaEtaria { get => faixaEtaria; set => faixaEtaria = value; }
    }
}
