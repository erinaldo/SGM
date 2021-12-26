﻿using SGM.Domain.Entities;

namespace SGM.Infrastructure.Command.Interface
{
    public interface IPecaCommand
    {
        void SalvarPeca(Peca peca);
        void AtualizarPeca(Peca peca);
        void InativarPeca(int pecaId);
    }
}