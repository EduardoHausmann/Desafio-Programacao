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
            comando.CommandText = @"UPDATE evento_pessoas SET descricao = @DESCRICAO, id_sala_evento = @ID_SALA_EVENTO, id_pessoa = @ID_PESSOA WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", eventoPessoa.Id);
            comando.Parameters.AddWithValue("@DESCRICAO", eventoPessoa.Descricao);
            comando.Parameters.AddWithValue("@ID_SALA_EVENTO", eventoPessoa.IdSalaEvento);
            comando.Parameters.AddWithValue("@ID_PESSOA", eventoPessoa.IdPessoa);

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
            comando.CommandText = @"INSERT INTO evento_pessoas (descricao, id_sala_evento, id_pessoa, lotacao_atual, registro_ativo) OUTPUT INSERTED.ID VALUES (@DESCRICAO, @ID_SALA_EVENTO, @ID_PESSOA, @LOTACAO_ATUAL, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@DESCRICAO", eventoPessoa.Descricao);
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
            comando.CommandText = @"SELECT evento_pessoas.id AS 'EventoPessoaId',
            evento_pessoas.descricao AS 'EventoPessoaDescricao',
            evento_pessoas.id_sala_evento AS 'EventoPessoaIdSalaEvento',
            sala_eventos.nome AS 'SalaEventoNome',
            evento_pessoas.id_pessoa AS 'EventoPessoIdPessoa',
            pessoas.nome AS 'PessoaNome',
            pessoas.sobrenome AS 'PessoaSobrenome'
            FROM evento_pessoas
            INNER JOIN sala_eventos ON (evento_pessoas.id_sala_evento = sala_eventos.id)
            INNER JOIN pessoas ON (evento_pessoas.id_pessoa = pessoas.id)
            WHERE evento_pessoas.id = @ID";
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
            eventoPessoa.IdPessoa = Convert.ToInt32(dr["EventoPessoIdPessoa"]);
            eventoPessoa.Pessoa = new Pessoa();
            eventoPessoa.Pessoa.Nome = dr["PessoaNome"].ToString();
            eventoPessoa.Pessoa.Sobrenome = dr["PessoaSobrenome"].ToString();
            return eventoPessoa;
        }

        public List<EventoPessoa> ObterTodos(string busca)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT evento_pessoas.id AS 'EventoPessoaId',
            evento_pessoas.descricao AS 'EventoPessoaDescricao',
            evento_pessoas.id_sala_evento AS 'EventoPessoaIdSalaEvento',
            sala_eventos.nome AS 'SalaEventoNome',
            evento_pessoas.id_pessoa AS 'EventoPessoaIdPessoa',
            pessoas.nome AS 'PessoaNome',
            pessoas.sobrenome AS 'PessoaSobrenome'
            FROM evento_pessoas
            INNER JOIN sala_eventos ON (evento_pessoas.id_sala_evento = sala_eventos.id)
            INNER JOIN pessoas ON (evento_pessoas.id_pessoa = pessoas.id)
            WHERE evento_pessoas.id_pessoa LIKE @ID_PESSOA AND evento_pessoas.registro_ativo = 1";
            comando.Parameters.AddWithValue("@ID_PESSOA", busca);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<EventoPessoa> eventoPessoas = new List<EventoPessoa>();

            foreach (DataRow dr in dt.Rows)
            {
                EventoPessoa eventoPessoa = new EventoPessoa();
                eventoPessoa.Id = Convert.ToInt32(dr["EventoPessoaId"]);
                eventoPessoa.Descricao = dr["EventoPessoaDescricao"].ToString();
                eventoPessoa.IdSalaEvento = Convert.ToInt32(dr["EventoPessoaIdSalaEvento"]);
                eventoPessoa.SalaEvento = new SalaEvento();
                eventoPessoa.SalaEvento.Nome = dr["SalaEventoNome"].ToString();
                eventoPessoa.IdPessoa = Convert.ToInt32(dr["EventoPessoaIdPessoa"]);
                eventoPessoa.Pessoa = new Pessoa();
                eventoPessoa.Pessoa.Nome = dr["PessoaNome"].ToString();
                eventoPessoa.Pessoa.Sobrenome = dr["PessoaSobrenome"].ToString();
                eventoPessoas.Add(eventoPessoa);
            }
            comando.Connection.Close();
            return eventoPessoas;
        }

        public List<EventoPessoa> ObterTodosPeloEvento(string busca)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT evento_pessoas.id AS 'EventoPessoaId',
            evento_pessoas.descricao AS 'EventoPessoaDescricao',
            evento_pessoas.id_sala_evento AS 'EventoPessoaIdSalaEvento',
            sala_eventos.nome AS 'SalaEventoNome',
            evento_pessoas.id_pessoa AS 'EventoPessoaIdPessoa',
            pessoas.nome AS 'PessoaNome',
            pessoas.sobrenome AS 'PessoaSobrenome'
            FROM evento_pessoas
            INNER JOIN sala_eventos ON (evento_pessoas.id_sala_evento = sala_eventos.id)
            INNER JOIN pessoas ON (evento_pessoas.id_pessoa = pessoas.id)
            WHERE evento_pessoas.id_sala_evento LIKE @ID_SALA_EVENTO AND evento_pessoas.registro_ativo = 1";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@ID_SALA_EVENTO", busca);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<EventoPessoa> eventoPessoas = new List<EventoPessoa>();

            foreach (DataRow dr in dt.Rows)
            {
                EventoPessoa eventoPessoa = new EventoPessoa();
                eventoPessoa.Id = Convert.ToInt32(dr["EventoPessoaId"]);
                eventoPessoa.Descricao = dr["EventoPessoaDescricao"].ToString();
                eventoPessoa.IdSalaEvento = Convert.ToInt32(dr["EventoPessoaIdSalaEvento"]);
                eventoPessoa.SalaEvento = new SalaEvento();
                eventoPessoa.SalaEvento.Nome = dr["SalaEventoNome"].ToString();
                eventoPessoa.IdPessoa = Convert.ToInt32(dr["EventoPessoaIdPessoa"]);
                eventoPessoa.Pessoa = new Pessoa();
                eventoPessoa.Pessoa.Nome = dr["PessoaNome"].ToString();
                eventoPessoa.Pessoa.Sobrenome = dr["PessoaSobrenome"].ToString();
                eventoPessoas.Add(eventoPessoa);
            }
            comando.Connection.Close();
            return eventoPessoas;
        }

        public int ChecaEvento(int id_evento)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT id_sala_evento, COUNT(lotacao_atual) AS 'LotacaoAtual'
            FROM evento_pessoas
            WHERE registro_ativo = 1 AND id_sala_evento = @ID_SALA_EVENTO
            GROUP BY id_sala_evento";
            comando.Parameters.AddWithValue("@ID_SALA_EVENTO", id_evento);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return 0;

            DataRow dr = dt.Rows[0];
            EventoPessoa eventoPessoa = new EventoPessoa();
            eventoPessoa.LotacaoAtual = Convert.ToInt32(dr["LotacaoAtual"]);
            return eventoPessoa.LotacaoAtual;
        }

        public int PegaLotacao(int sala)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT sala_eventos.lotacao_maxima  AS 'SalaEventoLotacao' FROM sala_eventos WHERE sala_eventos.id = @ID";
            comando.Parameters.AddWithValue("@ID", sala);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return 0;

            DataRow dr = dt.Rows[0];
            SalaEvento salaEvento = new SalaEvento();
            salaEvento.LotacaoMaxima = Convert.ToInt32(dr["SalaEventoLotacao"]);
            return salaEvento.LotacaoMaxima;
        }
    }
}
