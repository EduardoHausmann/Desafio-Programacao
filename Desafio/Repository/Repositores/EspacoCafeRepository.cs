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
    public class EspacoCafeRepository : IEspacoCafeRepository
    {
        public bool Alterar(EspacoCafe espacoCafe)
        {
            SqlCommand comando = Conexao.Conectar();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(EspacoCafe espacoCafe)
        {
            throw new NotImplementedException();
        }

        public EspacoCafe ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<EspacoCafe> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
