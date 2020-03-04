using System;
using domain.Entities;
using infra.Contracts;

namespace infra.Repositories
{
    public class PosicaoRepository:BaseRepository<Posicao>, IPosicaoRepository
    {
        public PosicaoRepository(){

        }
  }
}