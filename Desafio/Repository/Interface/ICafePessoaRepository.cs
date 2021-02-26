using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface ICafePessoaRepository
    {
        int Inserir(CafePessoa cafePessoa);

        bool Alterar(CafePessoa cafePessoa);

        List<CafePessoa> ObterTodos(string busca);

        bool Apagar(int id);

        CafePessoa ObterPeloId(int id);
    }
}
