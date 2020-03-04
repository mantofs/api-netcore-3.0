using System;
using application.Contracts;
using application.Services;
using infra.Contracts;
using infra.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace application
{
  public class Bootstrap
  {
    public static void Configure(IServiceCollection services, IConfiguration config)
    {
        services.AddSingleton<IPosicaoRepository, PosicaoRepository>();
        services.AddScoped<IPosicaoService, PosicaoService>();
    }

  }
}
