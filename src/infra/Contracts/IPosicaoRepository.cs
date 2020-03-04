using System;
using System.Collections.Generic;
using domain.Entities;

namespace infra.Contracts
{
    public interface IPosicaoRepository
    {
        Guid Add(Posicao item);
        Posicao Get(Guid id);
        IEnumerable<Posicao> GetAll();
    }
}