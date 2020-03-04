using System;
using System.Collections.Generic;
using System.Linq;
using application.Contracts;
using application.ViewModel;
using domain.Entities;
using infra.Contracts;

namespace application.Services
{
  public class PosicaoService : IPosicaoService
  {
    IPosicaoRepository _posicaoRepository;
    public PosicaoService(IPosicaoRepository posicaoRepository)
    {
      _posicaoRepository = posicaoRepository;
    }

    public Guid Add(PosicaoViewModel item)
    {

      Posicao posicao = new Posicao
      {
        Id = item.Id
      };

      return _posicaoRepository.Add(posicao);

    }

    public PosicaoViewModel Get(Guid id)
    {
      Posicao posicao = _posicaoRepository.Get(id);

      return new PosicaoViewModel { Id = posicao.Id };
    }

    public IEnumerable<PosicaoViewModel> GetAll()
    {
      return _posicaoRepository.GetAll().Select(x => new PosicaoViewModel { Id = x.Id });
    }
  }
}