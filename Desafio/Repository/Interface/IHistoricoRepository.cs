using Model;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IHistoricoRepository
    {
        int Inserir(Historico historico);

        List<Historico> ObterTodos(string busca);
    }
}
