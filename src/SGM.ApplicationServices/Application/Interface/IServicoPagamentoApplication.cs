﻿using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IServicoPagamentoApplication
    {
        IList<FormaPagamento> GetFormaPagamentoByAll();
        ServicoPagamento GetServicoPagamentoByServicoId(int servicoId);
    }
}