using Model;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IPessoaRepository
    {
        int Inserir(Pessoa pessoa);

        bool Alterar(Pessoa pessoa);

        List<Pessoa> ObterTodos(string busca);

        bool Apagar(int id);

        Pessoa ObterPeloId(int id);
    }
}
