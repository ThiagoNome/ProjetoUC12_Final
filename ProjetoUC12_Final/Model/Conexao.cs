using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUC12_Final.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thiago.pnascimento9\source\repos\ProjetoUC12_Final123\ProjetoUC12_Final\Model\filmesbd.mdf;Integrated Security=True";
        }
    }
}
