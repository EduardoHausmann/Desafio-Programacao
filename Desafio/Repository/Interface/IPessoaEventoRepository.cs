using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IPessoaEventoRepository
    {
        int Inserir(PessoaEvento pessoaEvento);

        bool Alterar(PessoaEvento pessoaEvento);

        List<PessoaEvento> ObterTodos(string busca);

        bool Apagar(int id);

        PessoaEvento ObterPeloId(int id);
    }
}
