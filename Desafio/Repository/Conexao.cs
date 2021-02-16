using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Conexao
    {
        public string DataDirectory { get; }
        public static SqlCommand Conectar()
        {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                return comando;
        }
    }
}
