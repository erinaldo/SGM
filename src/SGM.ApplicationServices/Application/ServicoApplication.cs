﻿using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application
{
    public class ServicoApplication : IServicoApplication
    {
        private readonly IServicoQuery _servicoQuery;
        private readonly IServicoCommand _servicoCommand;

        public ServicoApplication(IServicoQuery servicoQuery, IServicoCommand servicoCommand)
        {
            _servicoQuery = servicoQuery;
            _servicoCommand = servicoCommand;
        }

        public int SalvarServico(Servico servico)
        {
            return _servicoCommand.SalvarServico(servico);
        }

        public Servico GetServicoByServicoId(int servicoId)
        {
            return _servicoQuery.GetServicoByServicoId(servicoId);
        }

        public void AtualizarServico(Servico servico)
        {
            _servicoCommand.AtualizarServico(servico);
        }

        public int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            return _servicoCommand.SalvarServicoMaodeObra(servicoMaodeObra);
        }

        public int SalvarServicoPeca(ServicoPeca servicoPeca)
        {
            return _servicoCommand.SalvarServicoPeca(servicoPeca);
        }

        public void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            _servicoCommand.DeletarServicoMaodeObra(servicoMaodeObra);
        }

        public void DeletarServicoPeca(ServicoPeca servicoPeca)
        {
            _servicoCommand.DeletarServicoPeca(servicoPeca);
        }

        public IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int servicoId)
        {
            return _servicoQuery.GetServicoMaodeObraByServicoId(servicoId);
        }

        public IList<ServicoPeca> GetServicoPecaByServicoId(int servicoId)
        {
            return _servicoQuery.GetServicoPecaByServicoId(servicoId);
        }
    }
}