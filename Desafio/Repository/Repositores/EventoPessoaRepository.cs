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
            comando.CommandText = @"UPDATE evento_pessoas SET descricao = @DESCRICAO, id_sala_evento = @ID_SALA_EVENTO, id_pessoa_evento = @ID_PESSOA_EVENTO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", eventoPessoa.Id);
            comando.Parameters.AddWithValue("@DESCRICAO", eventoPessoa.Descricao);
            comando.Parameters.AddWithValue("@ID_SALA_EVENTO", eventoPessoa.IdSalaEvento);
            comando.Parameters.AddWithValue("@ID_PESSOA_EVENTO", eventoPessoa.IdPessoaEvento);

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
            comando.CommandText = @"INSERT INTO evento_pessoas (descricao, id_sala_evento, id_pessoa_evento, registro_ativo) OUTPUT INSERTED.ID VALUES (@DESCRICAO, @ID_SALA_EVENTO, @ID_PESSOA_EVENTO, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@DESCRICAO", eventoPessoa.Descricao);
            comando.Parameters.AddWithValue("@ID_SALA_EVENTO", eventoPessoa.IdSalaEvento);
            comando.Parameters.AddWithValue("@ID_PESSOA_EVENTO", eventoPessoa.IdPessoaEvento);
            eventoPessoa.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", eventoPessoa.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public EventoPessoa ObterPeloId(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT evento_pessoas.id AS 'EventoPessoaId',
            evento_pessoas.descricao AS 'EventoPessoaDescricao',
            evento_pessoas.id_sala_evento AS 'EventoPessoaIdSalaEvento',
            sala_eventos.nome AS 'SalaEventoNome',
            evento_pessoas.id_pessoa_evento AS 'EventoPessoIdPessoaEvento',
            FROM evento_pessoas
            INNER JOIN sala_eventos ON (evento_pessoas.id_sala_evento = sala_eventos.id)
            WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            EventoPessoa eventoPessoa = new EventoPessoa();
            eventoPessoa.Id = Convert.ToInt32(dr["EventoPessoaId"]);
            eventoPessoa.Descricao = dr["EventoPessoaDescricao"].ToString();
            eventoPessoa.IdSalaEvento = Convert.ToInt32(dr["EventoPessoaIdSalaEvento"]);
            eventoPessoa.SalaEvento = new SalaEvento();
            eventoPessoa.SalaEvento.Nome = dr["SalaEventoNome"].ToString();
            eventoPessoa.IdPessoaEvento = Convert.ToInt32(dr["EventoPessoIdPessoaEvento"]);
            return eventoPessoa;
        }

        public List<EventoPessoa> ObterTodos()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT evento_pessoas.id AS 'EventoPessoaId',
            evento_pessoas.descricao AS 'EventoPessoaDescricao',
            evento_pessoas.id_sala_evento AS 'EventoPessoaIdSalaEvento',
            sala_eventos.nome AS 'SalaEventoNome',
            evento_pessoas.id_pessoa_evento AS 'EventoPessoIdPessoaEvento',
            FROM evento_pessoas
            INNER JOIN sala_eventos ON (evento_pessoas.id_sala_evento = sala_eventos.id)
            WHERE registro_ativo = 1";

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<EventoPessoa> eventoPessoas = new List<EventoPessoa>();

            foreach(DataRow dr in dt.Rows)
            {
                EventoPessoa eventoPessoa = new EventoPessoa();
                eventoPessoa.Id = Convert.ToInt32(dr["EventoPessoaId"]);
                eventoPessoa.Descricao = dr["EventoPessoaDescricao"].ToString();
                eventoPessoa.IdSalaEvento = Convert.ToInt32(dr["EventoPessoaIdSalaEvento"]);
                eventoPessoa.SalaEvento = new SalaEvento();
                eventoPessoa.SalaEvento.Nome = dr["SalaEventoNome"].ToString();
                eventoPessoa.IdPessoaEvento = Convert.ToInt32(dr["EventoPessoIdPessoaEvento"]);
                eventoPessoas.Add(eventoPessoa);
            }
            comando.Connection.Close();
            return eventoPessoas;
        }
    }
}
