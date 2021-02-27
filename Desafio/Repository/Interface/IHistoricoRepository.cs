using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IHistoricoRepository
    {
        int Inserir(Historico historico);

        List<Historico> ObterTodos(string busca);
    }
}
