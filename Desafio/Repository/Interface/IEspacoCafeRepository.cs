using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IEspacoCafeRepository
    {
        int Inserir(EspacoCafe espacoCafe);

        bool Alterar(EspacoCafe espacoCafe);

        List<EspacoCafe> ObterTodos();

        bool Apagar(int id);

        EspacoCafe ObterPeloId(int id);
    }
}
