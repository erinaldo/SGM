﻿using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Command;
using SGM.Domain.Entities;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Net.Http;
using System.Text;

namespace SGM.Infrastructure.Command
{
    public class VeiculoCommand : IVeiculoCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public VeiculoCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public int SalvarVeiculo(Veiculo veiculo)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(veiculo), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/veiculo", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR veiculo. Modelo: {veiculo.Modelo}");
                }

                var response = result.Content.ReadAsStringAsync();

                return Convert.ToInt32(response.Result);
            }
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(veiculo), Encoding.UTF8, "application/json");
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/veiculo/{veiculo.VeiculoId}", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao ATUALIZAR veiculo. Modelo: {veiculo.Modelo}");
                }
            }
        }

        public void InativarVeiculo(int veiculoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/veiculo/inativar/{veiculoId}", null).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao INATIVAR veiculo. Identificador: {veiculoId}");
                }
            }
        }
    }
}