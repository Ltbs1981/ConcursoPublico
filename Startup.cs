using ConcursoPublico.Controllers;
using ConcursoPublico.Core.Contratos.Controladores;
using ConcursoPublico.Core.Contratos.Repositorios;
using ConcursoPublico.Core.Contratos.Servicos;
using ConcursoPublico.Infra.Repositorio;
using ConcursoPublico.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConcursoPublico
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Registros para AreaPolicialESeguranca
            services.AddSingleton<IRepositorioAreaPolicialESeguranca, RepositorioAreaPolicialESeguranca>();
            services.AddSingleton<IServiceAreaPolicialESeguranca, ServiceAreaPolicialESeguranca>();
            services.AddSingleton<IAreaPolicialESegurancaController, AreaPolicialESegurancaController>();

            // Registros para AreaControleEGestao
            services.AddSingleton<IRepositorioAreaControleEGestao, RepositorioAreaControleEGestao>();
            services.AddSingleton<IServiceAreaControleEGestao, ServiceAreaControleEGestao>();
            services.AddSingleton<IAreaControleEGestaoController, AreaControleEGestaoController>();
        }
    }
}
