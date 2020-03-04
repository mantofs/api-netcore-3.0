using System;
using System.Collections.Generic;
using application.Contracts;
using application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PosicaoController : ControllerBase
  {

    private readonly IPosicaoService _posicaoService;
    public PosicaoController(IPosicaoService posicaoService)
    {
      _posicaoService = posicaoService;
    }

    [HttpPost]
    public Guid Add(PosicaoViewModel posicao)
    {
      return _posicaoService.Add(posicao);
    }

    [HttpGet]
    public IEnumerable<PosicaoViewModel> GetAll()
    {
      return _posicaoService.GetAll();
    }

    [HttpGet]
    [Route("{*id}")]
    public PosicaoViewModel Get(Guid id)
    {
      return _posicaoService.Get(id);
    }
  }
}