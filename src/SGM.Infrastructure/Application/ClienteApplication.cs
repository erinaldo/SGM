﻿using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Command;
using SGM.Domain.Intern.Interfaces.Query;
using SGM.Domain.Intern.Interfaces.Query.External;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Application
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly IClienteCommand _clienteCommand;
        private readonly IClienteQuery _clienteQuery;
        private readonly IClienteVeiculoQuery _clienteVeiculoQuery;
        private readonly ICorreiosQuery _correiosQuery;

        public ClienteApplication(IClienteCommand clienteCommand, IClienteQuery clienteQuery, IClienteVeiculoQuery clienteVeiculoQuery, ICorreiosQuery correiosQuery)
        {
            _clienteCommand = clienteCommand;
            _clienteQuery = clienteQuery;
            _clienteVeiculoQuery = clienteVeiculoQuery;
            _correiosQuery = correiosQuery;
        }

        public Cliente GetClienteById(int clienteId)
        {
            var cliente = _clienteQuery.GetClienteById(clienteId);

            return cliente;
        }

        public void SalvarCliente(Cliente cliente)
        {
            _clienteCommand.SalvarCliente(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _clienteCommand.AtualizarCliente(cliente);
        }

        public void InativarCliente(int clienteId)
        {
            _clienteCommand.InativarCliente(clienteId);
        }

        public Cliente GetClienteByDocumentoCliente(string documentoCliente)
        {
            return _clienteQuery.GetClienteByDocumentoCliente(documentoCliente);
        }

        public Cliente GetClienteByLikePlacaOrNomeOrApelido(string valor)
        {
            return _clienteQuery.GetClienteByLikePlacaOrNomeOrApelido(valor);
        }

        public Cliente GetClienteByPlaca(string placaVeiculo)
        {
            return _clienteQuery.GetClienteByPlaca(placaVeiculo);
        }
    }
}