using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositores
{
    public class PessoaRepository : IPessoaRepository
    {
        public bool Alterar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public int Inserir(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Pessoa ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
