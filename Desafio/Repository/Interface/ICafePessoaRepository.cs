using Model;
using System.Collections.Generic;

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
