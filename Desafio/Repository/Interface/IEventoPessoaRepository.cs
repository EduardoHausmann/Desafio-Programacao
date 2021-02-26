using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IEventoPessoaRepository
    {
        int Inserir(EventoPessoa eventoPessoa);

        bool Alterar(EventoPessoa eventoPessoa);

        List<EventoPessoa> ObterTodos(string busca);

        bool Apagar(int id);

        EventoPessoa ObterPeloId(int id);
    }
}
