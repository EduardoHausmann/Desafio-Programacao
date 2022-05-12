using Model;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IEspacoCafeRepository
    {
        int Inserir(EspacoCafe espacoCafe);

        bool Alterar(EspacoCafe espacoCafe);

        List<EspacoCafe> ObterTodos(string busca);

        bool Apagar(int id);

        EspacoCafe ObterPeloId(int id);
    }
}
