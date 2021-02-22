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
    public class EventoPessoaRepository : IEventoPessoaRepository
    {
        public bool Alterar(EventoPessoa eventoPessoa)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"UPDATE evento_pessoas SET nome_evento = @NOME_EVENTO, id_sala_evento = @ID_SALA_EVENTO, id_pessoa = @ID_PESSOA, lotacao_atual = @LOTACAO_ATUAL WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", eventoPessoa.Id);
            comando.Parameters.AddWithValue("@NOME_EVENTO", eventoPessoa.NomeEvento);
            comando.Parameters.AddWithValue("@ID_SALA_EVENTO", eventoPessoa.IdSalaEvento);
            comando.Parameters.AddWithValue("@ID_PESSOA", eventoPessoa.IdPessoa);
            comando.Parameters.AddWithValue("@LOTACAO_ATUAL", eventoPessoa.LotacaoAtual);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            EventoPessoa eventoPessoa = new EventoPessoa();
            comando.CommandText = @"UPDATE evento_pessoas SET registro_ativo = @REGISTRO_ATIVO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            eventoPessoa.RegistroAtivo = false;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", eventoPessoa.RegistroAtivo);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public int Inserir(EventoPessoa eventoPessoa)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"INSERT INTO evento_pessoas (nome_evento, id_sala_evento, id_pessoa, lotacao_atual, registro_ativo) OUTPUT INSERTED.ID VALUES (@NOME_EVENTO, @ID_SALA_EVENTO, @ID_PESSOA, @LOTACAO_ATUAL, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@NOME_EVENTO", eventoPessoa.NomeEvento);
            comando.Parameters.AddWithValue("@ID_SALA_EVENTO", eventoPessoa.IdSalaEvento);
            comando.Parameters.AddWithValue("@ID_PESSOA", eventoPessoa.IdPessoa);
            comando.Parameters.AddWithValue("@LOTACAO_ATUAL", eventoPessoa.LotacaoAtual);
            eventoPessoa.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", eventoPessoa.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public EventoPessoa ObterPeloId(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT * FROM evento_pessoas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            EventoPessoa eventoPessoa = new EventoPessoa();
            eventoPessoa.Id = Convert.ToInt32(dr["id"]);
            eventoPessoa.NomeEvento = dr["nome_evento"].ToString();
            eventoPessoa.IdSalaEvento = Convert.ToInt32(dr["id_sala_evento"]);
            eventoPessoa.IdPessoa = Convert.ToInt32(dr["id_pessoa"]);
            return eventoPessoa;
        }

        public List<EventoPessoa> ObterTodos()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT * FROM evento_pessoas WHERE registro_ativo = 1";

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<EventoPessoa> eventoPessoas = new List<EventoPessoa>();

            foreach(DataRow dr in dt.Rows)
            {
                EventoPessoa eventoPessoa = new EventoPessoa();
                eventoPessoa.Id = Convert.ToInt32(dr["id"]);
                eventoPessoa.NomeEvento = dr["nome_evento"].ToString();
                eventoPessoa.IdSalaEvento = Convert.ToInt32(dr["id_sala_evento"]);
                eventoPessoa.IdPessoa = Convert.ToInt32(dr["id_pessoa"]);
                eventoPessoas.Add(eventoPessoa);
            }
            comando.Connection.Close();
            return eventoPessoas;
        }
    }
}
