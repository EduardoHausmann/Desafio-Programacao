using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositores
{
    public class EspacoCafeRepository : IEspacoCafeRepository
    {
        public bool Alterar(EspacoCafe espacoCafe)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"UPDATE espaco_cafes SET nome = @NOME WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", espacoCafe.Id);
            comando.Parameters.AddWithValue("@NOME", espacoCafe.Nome);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            EspacoCafe espacoCafe = new EspacoCafe();
            comando.CommandText = @"UPDATE espaco_cafes SET registro_ativo = @REGISTRO_ATIVO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            espacoCafe.RegistroAtivo = false;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", espacoCafe.RegistroAtivo);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public int Inserir(EspacoCafe espacoCafe)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"INSERT INTO espaco_cafes (nome, registro_ativo) OUTPUT INSERTED.ID VALUES (@NOME, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@NOME", espacoCafe.Nome);
            espacoCafe.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", espacoCafe.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public EspacoCafe ObterPeloId(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT * FROM espaco_cafes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return null;
            DataRow dr = dt.Rows[0];
            EspacoCafe espacoCafe = new EspacoCafe();
            espacoCafe.Id = Convert.ToInt32(dr["id"]);
            espacoCafe.Nome = dr["nome"].ToString();
            return espacoCafe;
        }

        public List<EspacoCafe> ObterTodos(string busca)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT * FROM espaco_cafes WHERE nome LIKE @NOME AND registro_ativo = 1";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<EspacoCafe> espacoCafes = new List<EspacoCafe>();

            foreach (DataRow dr in dt.Rows)
            {
                EspacoCafe espacoCafe = new EspacoCafe();
                espacoCafe.Id = Convert.ToInt32(dr["id"]);
                espacoCafe.Nome = dr["nome"].ToString();
                espacoCafes.Add(espacoCafe);
            }
            comando.Connection.Close();
            return espacoCafes;
        }
    }
}
