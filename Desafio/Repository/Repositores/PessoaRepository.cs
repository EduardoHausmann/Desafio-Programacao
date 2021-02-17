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
    public class PessoaRepository : IPessoaRepository
    {
        SqlCommand comando = Conexao.Conectar();

        public bool Alterar(Pessoa pessoa)
        {
            comando.CommandText = @"UPDATE pessoas SET nome = @NOME, sobrenome = @SOBRENOME, cpf = @CPF, endereco = @ENDERECO, telefone = @TELEFONE, email = @EMAIL, data_nascimento = @DATA_NASCIMENTO, nome_mae = @NOME_MAE, sexo = @SEXO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", pessoa.Id);
            comando.Parameters.AddWithValue("@NOME", pessoa.Nome);
            comando.Parameters.AddWithValue("@SOBRENOME", pessoa.Sobrenome);
            comando.Parameters.AddWithValue("@CPF", pessoa.CPF);
            comando.Parameters.AddWithValue("@ENDERECO", pessoa.Endereco);
            comando.Parameters.AddWithValue("@TELEFONE", pessoa.Telefone);
            comando.Parameters.AddWithValue("@EMAIL", pessoa.Email);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", pessoa.DataNascimento);
            comando.Parameters.AddWithValue("@NOME_MAE", pessoa.NomeMae);
            comando.Parameters.AddWithValue("@SEXO", pessoa.Sexo);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            Pessoa pessoa = new Pessoa();
            comando.CommandText = @"UPDATE pessoas SET registro_ativo = @REGISTRO_ATIVO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            pessoa.RegistroAtivo = false;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", pessoa.RegistroAtivo);

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public int Inserir(Pessoa pessoa)
        {
            comando.CommandText = @"INSERT INTO pessoas (nome, sobrenome, cpf, endereco, telefone, email, data_nascimento, nome_mae, sexo, registro_ativo) OUTPUT INSERTED.ID VALUES (@NOME, @SOBRENOME, @CPF, @ENDERECO, @TELEFONE, @EMAIL, @DATA_NASCIMENTO, @NOME_MAE, @SEXO, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@NOME", pessoa.Nome);
            comando.Parameters.AddWithValue("@SOBRENOME", pessoa.Sobrenome);
            comando.Parameters.AddWithValue("@CPF", pessoa.CPF);
            comando.Parameters.AddWithValue("@ENDERECO", pessoa.Endereco);
            comando.Parameters.AddWithValue("@TELEFONE", pessoa.Telefone);
            comando.Parameters.AddWithValue("@EMAIL", pessoa.Email);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", pessoa.DataNascimento);
            comando.Parameters.AddWithValue("@NOME_MAE", pessoa.NomeMae);
            comando.Parameters.AddWithValue("@SEXO", pessoa.Sexo);
            pessoa.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", pessoa.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public Pessoa ObterPeloId(int id)
        {
            comando.CommandText = @"SELECT * FROM pessoas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            Pessoa pessoa = new Pessoa();
            pessoa.Id = Convert.ToInt32(dr["id'"]);
            pessoa.Nome = dr["nome"].ToString();
            pessoa.Sobrenome = dr["sobrenome"].ToString();
            pessoa.CPF = dr["cpf"].ToString();
            pessoa.Endereco = dr["endereco"].ToString();
            pessoa.Telefone = dr["telefone"].ToString();
            pessoa.Email = dr["email"].ToString();
            pessoa.DataNascimento = Convert.ToDateTime(dr["data_nascimento"]);
            pessoa.NomeMae = dr["nome_mae"].ToString();
            pessoa.Sexo = dr["sexo"].ToString();
            return pessoa;

        }

        public List<Pessoa> ObterTodos(string busca)
        {
            comando.CommandText = @"SELECT * FROM pessoas WHERE nome LIKE @NOME AND registro_ativo = 1";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<Pessoa> pessoas = new List<Pessoa>();

            foreach (DataRow dr in dt.Rows)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Id = Convert.ToInt32(dr["id'"]);
                pessoa.Nome = dr["nome"].ToString();
                pessoa.Sobrenome = dr["sobrenome"].ToString();
                pessoa.CPF = dr["cpf"].ToString();
                pessoa.Endereco = dr["endereco"].ToString();
                pessoa.Telefone = dr["telefone"].ToString();
                pessoa.Email = dr["email"].ToString();
                pessoa.DataNascimento = Convert.ToDateTime(dr["data_nascimento"]);
                pessoa.NomeMae = dr["nome_mae"].ToString();
                pessoa.Sexo = dr["sexo"].ToString();
                pessoas.Add(pessoa);
            }
            comando.Connection.Close();
            return pessoas;
        }
    }
}
