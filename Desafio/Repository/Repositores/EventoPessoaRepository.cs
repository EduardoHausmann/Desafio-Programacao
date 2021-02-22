using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
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
            comando.CommandText = @"UPDATE evento_pessoas SET";

            int quantidadeAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            comando.Connection.Close();
            return quantidadeAfetada == 1;
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(EventoPessoa eventoPessoa)
        {
            throw new NotImplementedException();
        }

        public EventoPessoa ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<EventoPessoa> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
