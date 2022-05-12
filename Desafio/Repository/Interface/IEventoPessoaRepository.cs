using Model;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IEventoPessoaRepository
    {
        int Inserir(EventoPessoa eventoPessoa);

        bool Alterar(EventoPessoa eventoPessoa);

        List<EventoPessoa> ObterTodosIdPessoa(string busca);

        bool Apagar(int id);

        EventoPessoa ObterPeloId(int id);
    }
}
