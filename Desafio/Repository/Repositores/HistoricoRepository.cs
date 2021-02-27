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
    public class HistoricoRepository : IHistoricoRepository
    {
        public int Inserir(Historico historico)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"INSERT INTO historico_evento_pessoas (descricao, id_sala_evento, id_pessoa, lotacao_atual, registro_ativo) OUTPUT INSERTED.ID VALUES (@DESCRICAO, @ID_SALA_EVENTO, @ID_PESSOA, @LOTACAO_ATUAL, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@DESCRICAO", historico.Descricao);
            comando.Parameters.AddWithValue("@ID_SALA_EVENTO", historico.IdSalaEvento);
            comando.Parameters.AddWithValue("@ID_PESSOA", historico.IdPessoa);
            comando.Parameters.AddWithValue("@LOTACAO_ATUAL", historico.LotacaoAtual);
            historico.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", historico.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public List<Historico> ObterTodos(string busca)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT historico_evento_pessoas.id AS 'HistoricoId',
            historico_evento_pessoas.descricao AS 'HistoricoDescricao',
            historico_evento_pessoas.id_sala_evento AS 'HistoricoIdSalaEvento',
            sala_eventos.nome AS 'SalaEventoNome',
            historico_evento_pessoas.id_pessoa AS 'HistoricoIdPessoa',
            pessoas.nome AS 'PessoaNome',
            pessoas.sobrenome AS 'PessoaSobrenome'
            FROM historico_evento_pessoas
            INNER JOIN sala_eventos ON (historico_evento_pessoas.id_sala_evento = sala_eventos.id)
            INNER JOIN pessoas ON (historico_evento_pessoas.id_pessoa = pessoas.id)
            WHERE historico_evento_pessoas.id_pessoa LIKE @ID_PESSOA AND historico_evento_pessoas.registro_ativo = 1";
            comando.Parameters.AddWithValue("@ID_PESSOA", busca);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<Historico> historicos = new List<Historico>();

            foreach (DataRow dr in dt.Rows)
            {
                Historico historico = new Historico();
                historico.Id = Convert.ToInt32(dr["HistoricoId"]);
                historico.Descricao = dr["HistoricoDescricao"].ToString();
                historico.IdSalaEvento = Convert.ToInt32(dr["HistoricoIdSalaEvento"]);
                historico.SalaEvento = new SalaEvento();
                historico.SalaEvento.Nome = dr["SalaEventoNome"].ToString();
                historico.IdPessoa = Convert.ToInt32(dr["HistoricoIdPessoa"]);
                historico.Pessoa = new Pessoa();
                historico.Pessoa.Nome = dr["PessoaNome"].ToString();
                historico.Pessoa.Sobrenome = dr["PessoaSobrenome"].ToString();
                historicos.Add(historico);
            }
            comando.Connection.Close();
            return historicos;
        }
    }
}
