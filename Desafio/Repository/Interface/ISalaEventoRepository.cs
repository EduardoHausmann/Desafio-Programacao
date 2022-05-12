using Model;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface ISalaEventoRepository
    {
        int Inserir(SalaEvento salaEvento);

        bool Alterar(SalaEvento salaEvento);

        List<SalaEvento> ObterTodos(string busca);

        bool Apagar(int id);

        SalaEvento ObterPeloId(int id);
    }
}
