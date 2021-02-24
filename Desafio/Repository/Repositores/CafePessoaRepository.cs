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
    public class CafePessoaRepository : ICafePessoaRepository
    {
        public bool Alterar(CafePessoa cafePessoa)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"UPDATE cafe_pessoas SET id_espaco_cafe = @ID_ESPACO_CAFE, id_pessoa = @ID_PESSOA WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", cafePessoa.Id);
            comando.Parameters.AddWithValue("@ID_ESPACO_CAFE", cafePessoa.IdEspacoCafe);
            comando.Parameters.AddWithValue("@ID_PESSOA", cafePessoa.IdPessoa);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            CafePessoa cafePessoa = new CafePessoa();
            comando.CommandText = @"UPDATE cafe_pessoas SET registro_ativo = @REGISTRO_ATIVO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            cafePessoa.RegistroAtivo = false;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", cafePessoa.RegistroAtivo);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public int Inserir(CafePessoa cafePessoa)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"INSERT INTO cafe_pessoas (id_espaco_cafe, id_pessoa, lotacao_atual, registro_ativo) OUTPUT INSERTED.ID VALUES (@ID_ESPACO_CAFE, @ID_PESSOA, @LOTACAO_ATUAL, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@ID_ESPACO_CAFE", cafePessoa.IdEspacoCafe);
            comando.Parameters.AddWithValue("@ID_PESSOA", cafePessoa.IdPessoa);
            comando.Parameters.AddWithValue("@LOTACAO_ATUAL", cafePessoa.LotacaoAtual);
            cafePessoa.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", cafePessoa.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public CafePessoa ObterPeloId(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT cafe_pessoas.id AS 'CafePessoaId',
            cafe_pessoas.id_espaco_cafe AS 'CafePessoaIdEspacoCafe',
            espaco_cafes.nome AS 'EspacoCafeNome',
            cafe_pessoas.id_pessoa AS 'CafePessoaIdPessoa',
            pessoas.nome AS 'PessoaNome',
            pessoas.sobrenome AS 'PessoaSobrenome'
            FROM cafe_pessoas 
            INNER JOIN espaco_cafes ON (cafe_pessoas.id_espaco_cafe = espaco_cafes.id)
            INNER JOIN pessoa ON (cafe_pessoas.id_pessoa = pessoas.id)
            WHERE cafe_pessoas.id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            CafePessoa cafePessoa = new CafePessoa();
            cafePessoa.Id = Convert.ToInt32(dr["CafePessoaId"]);
            cafePessoa.IdEspacoCafe = Convert.ToInt32(dr["CafePessoaIdEspacoCafe"]);
            cafePessoa.EspacoCafe = new EspacoCafe();
            cafePessoa.EspacoCafe.Nome = dr["EspacoCafeNome"].ToString();
            cafePessoa.IdPessoa = Convert.ToInt32(dr["CafePessoaIdPessoa"]);
            cafePessoa.Pessoa = new Pessoa();
            cafePessoa.Pessoa.Nome = dr["PessoaNome"].ToString();
            cafePessoa.Pessoa.Sobrenome = dr["PessoaSobrenome"].ToString();
            return cafePessoa;
        }

        public List<CafePessoa> ObterTodos()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT cafe_pessoas.id AS 'CafePessoaId',
            cafe_pessoas.id_espaco_cafe AS 'CafePessoaIdEspacoCafe',
            espaco_cafes.nome AS 'EspacoCafeNome',
            cafe_pessoas.id_pessoa AS 'CafePessoaIdPessoa',
            pessoas.nome AS 'PessoaNome',
            pessoas.sobrenome AS 'PessoaSobrenome'
            FROM cafe_pessoas 
            INNER JOIN espaco_cafes ON (cafe_pessoas.id_espaco_cafe = espaco_cafes.id)
            INNER JOIN pessoas ON (cafe_pessoas.id_pessoa = pessoas.id)
            WHERE cafe_pessoas.registro_ativo = 1";

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<CafePessoa> cafePessoas = new List<CafePessoa>();

            foreach (DataRow dr in dt.Rows)
            {
                CafePessoa cafePessoa = new CafePessoa();
                cafePessoa.Id = Convert.ToInt32(dr["CafePessoaId"]);
                cafePessoa.IdEspacoCafe = Convert.ToInt32(dr["CafePessoaIdEspacoCafe"]);
                cafePessoa.EspacoCafe = new EspacoCafe();
                cafePessoa.EspacoCafe.Nome = dr["EspacoCafeNome"].ToString();
                cafePessoa.IdPessoa = Convert.ToInt32(dr["CafePessoaIdPessoa"]);
                cafePessoa.Pessoa = new Pessoa();
                cafePessoa.Pessoa.Nome = dr["PessoaNome"].ToString();
                cafePessoa.Pessoa.Sobrenome = dr["PessoaSobrenome"].ToString();
                cafePessoas.Add(cafePessoa);
            }
            comando.Connection.Close();
            return cafePessoas;
        }
    }
}
