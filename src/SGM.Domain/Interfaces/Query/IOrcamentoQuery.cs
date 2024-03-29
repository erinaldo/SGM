﻿using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Domain.Intern.Interfaces.Query
{
    public interface IOrcamentoQuery
    {
        IList<Orcamento> GetOrcamentoByClienteVeiculoId(int clienteVeiculoId);
        Orcamento GetOrcamentoByOrcamentoId(int orcamentoId);
        IList<OrcamentoMaodeObra> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId);
        IList<OrcamentoPeca> GetOrcamentoPecaByOrcamentoId(int orcamentoId);
        IList<Orcamento> GetUltimosOrcamentos();
    }
}