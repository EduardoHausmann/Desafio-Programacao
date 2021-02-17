﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
