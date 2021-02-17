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
    public class SalaEventoRepository : ISalaEventoRepository
    {
        SqlCommand comando = Conexao.Conectar();

        public bool Alterar(SalaEvento salaEvento)
        {
            comando.CommandText = @"UPDATE sala_eventos SET nome = @NOME, lotação = @LOTACAO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", salaEvento.Id);
            comando.Parameters.AddWithValue("@NOME", salaEvento.Nome);
            comando.Parameters.AddWithValue("@LOTACAO", salaEvento.Lotacao);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            SalaEvento salaEvento = new SalaEvento();
            comando.CommandText = @"UPDATE espaco_cafes SET registro_ativo = @REGISTRO_ATIVO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            salaEvento.RegistroAtivo = false;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", salaEvento.RegistroAtivo);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public int Inserir(SalaEvento salaEvento)
        {
            comando.CommandText = @"INSERT INTO sala_eventos (nome, lotacao, registro_ativo) OUTPUT INSERTED.ID VALUES (@NOME, @LOTACAO, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@NOME", salaEvento.Nome);
            comando.Parameters.AddWithValue("@LOTACAO", salaEvento.Lotacao);
            salaEvento.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", salaEvento.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public SalaEvento ObterPeloId(int id)
        {
            comando.CommandText = @"SELECT * FROM sala_eventos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            SalaEvento salaEvento = new SalaEvento();
            salaEvento.Id = Convert.ToInt32(dr["id"]);
            salaEvento.Nome = dr["nome"].ToString();
            salaEvento.Lotacao = Convert.ToInt32(dr["lotacao"]);
            return salaEvento;
        }

        public List<SalaEvento> ObterTodos(string busca)
        {
            comando.CommandText = @"SELECT * FROM sala_eventos WHERE nome LIKE @NOME AND registro_ativo = 1";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<SalaEvento> salaEventos = new List<SalaEvento>();

            foreach (DataRow dr in dt.Rows)
            {
                SalaEvento salaEvento = new SalaEvento();
                salaEvento.Id = Convert.ToInt32(dr["id"]);
                salaEvento.Nome = dr["nome"].ToString();
                salaEvento.Lotacao = Convert.ToInt32(dr["lotacao"]);
                salaEventos.Add(salaEvento);
            }
            comando.Connection.Close();
            return salaEventos;
        }
    }
}
