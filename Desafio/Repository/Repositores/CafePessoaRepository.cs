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
            comando.CommandText = @"UPDATE cafe_pessoas SET nome_espaco = @NOME_ESPACO, id_espaco_cafe = @ID_ESPACO_CAFE, id_pessoa = @ID_PESSOA WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", cafePessoa.Id);
            comando.Parameters.AddWithValue("@NOME_ESPACO", cafePessoa.NomeEspaco);
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
            comando.CommandText = @"INSERT INTO cafe_pessoas (nome_espaco, id_espaco_cafe, id_pessoa, registro_ativo) OUTPUT INSERTED.ID VALUES (@NOME_ESPACO, @ID_ESPACO_CAFE, @ID_PESSOA, @REGISTRO_ATIVO)";
            comando.Parameters.AddWithValue("@NOME_EVENTO", cafePessoa.NomeEspaco);
            comando.Parameters.AddWithValue("@ID_ESPACO_CAFE", cafePessoa.Id);
            comando.Parameters.AddWithValue("@ID_PESSOA", cafePessoa.IdPessoa);
            cafePessoa.RegistroAtivo = true;
            comando.Parameters.AddWithValue("@REGISTRO_ATIVO", cafePessoa.RegistroAtivo);

            int id = Convert.ToInt32(comando.ExecuteScalar());
            comando.Connection.Close();
            return id;
        }

        public CafePessoa ObterPeloId(int id)
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT * FROM cafe_pessoas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            comando.Connection.Close();

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            CafePessoa cafePessoa = new CafePessoa();
            cafePessoa.Id = Convert.ToInt32(dr["id"]);
            cafePessoa.NomeEspaco = dr["nome_espaco"].ToString();
            cafePessoa.IdEspacoCafe = Convert.ToInt32(dr["id_espaco_cafe"]);
            cafePessoa.IdPessoa = Convert.ToInt32(dr["id_pessoa"]);
            return cafePessoa;
        }

        public List<CafePessoa> ObterTodos()
        {
            SqlCommand comando = Conexao.Conectar();
            comando.CommandText = @"SELECT * FROM cafe_pessoas WHERE registro_ativo = 1";

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            List<CafePessoa> cafePessoas = new List<CafePessoa>();

            foreach (DataRow dr in dt.Rows)
            {
                CafePessoa cafePessoa = new CafePessoa();
                cafePessoa.Id = Convert.ToInt32(dr["id"]);
                cafePessoa.NomeEspaco = dr["nome_espaco"].ToString();
                cafePessoa.IdEspacoCafe = Convert.ToInt32(dr["id_espaco_cafe"]);
                cafePessoa.IdPessoa = Convert.ToInt32(dr["id_pessoa"]);
                cafePessoas.Add(cafePessoa);
            }
            comando.Connection.Close();
            return cafePessoas;
        }
    }
}
