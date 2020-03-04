using System;
using System.Collections.Generic;
using application.ViewModel;

namespace application.Contracts
{
  public interface IPosicaoService
  {
    Guid Add(PosicaoViewModel item);
    PosicaoViewModel Get(Guid id);
    IEnumerable<PosicaoViewModel> GetAll();
  }
}