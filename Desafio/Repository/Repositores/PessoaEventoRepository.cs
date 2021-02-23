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
    public class PessoaEventoRepository : IPessoaEventoRepository
    {
        public bool Alterar(PessoaEvento pessoaEvento)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"UPDATE pessoa_eventos SET id_pessoa = @ID_PESSOA WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", pessoaEvento.Id);
            comando.Parameters.AddWithValue("@ID_PESSOA", pessoaEvento.IdPessoa);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"UPDATE pessoa_eventos SET registro_ativo = @REGISTRO_ATIVO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id );
            PessoaEvento pessoaEvento = new PessoaEvento();
            pessoaEvento.RegistroAtivo = false;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", pessoaEvento.RegistroAtivo);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public int Inserir(PessoaEvento pessoaEvento)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"INSERT INTO pessoa_eventos (id_pessoa, registro_ativo) OUTPUT INSERTED.ID VALUES (@ID_PESSOA, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@ID_PESSOA", pessoaEvento.IdPessoa);
            pessoaEvento.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", pessoaEvento.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public PessoaEvento ObterPeloId(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT pessoa_eventos.id AS 'PessoaEventoId',
            pessoa_eventos.id_pessoa AS 'PessoaEventoIdPessoa', 
            pessoas.nome AS 'PessoaNome'
            FROM pessoa_eventos
            INNER JOIN pessoas ON (pessoa_eventos.id_pessoa = pessoas.id)
            WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            PessoaEvento pessoaEvento = new PessoaEvento();
            pessoaEvento.Id = Convert.ToInt32(dr["PessoaEventoId"]);
            pessoaEvento.IdPessoa = Convert.ToInt32(dr["PessoaEventoIdPessoa"]);
            pessoaEvento.Pessoa = new Pessoa();
            pessoaEvento.Pessoa.Nome = dr["PessoaNome"].ToString();
            return pessoaEvento;

            
        }

        public List<PessoaEvento> ObterTodos(string busca)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT pessoa_eventos.id AS 'PessoaEventoId',
            pessoa_eventos.id_pessoa AS 'PessoaEventoIdPessoa', 
            pessoas.nome AS 'PessoaNome'
            FROM pessoa_eventos
            INNER JOIN pessoas ON (pessoa_eventos.id_pessoa = pessoas.id)
            WHERE registro_ativo = 1";

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<PessoaEvento> pessoaEventos = new List<PessoaEvento>();

            foreach (DataRow dr in dt.Rows)
            {
                PessoaEvento pessoaEvento = new PessoaEvento();
                pessoaEvento.Id = Convert.ToInt32(dr["PessoaEventoId"]);
                pessoaEvento.IdPessoa = Convert.ToInt32(dr["PessoaEventoIdPessoa"]);
                pessoaEvento.Pessoa = new Pessoa();
                pessoaEvento.Pessoa.Nome = dr["PessoaNome"].ToString();
                pessoaEventos.Add(pessoaEvento);
            }

            comando.Connection.Close();
            return pessoaEventos;
        }
    }
}
