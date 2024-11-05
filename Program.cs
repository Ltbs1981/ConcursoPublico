using ConcursoPublico.Core.Contratos.Controladores;
using ConcursoPublico.Core.Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConcursoPublico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configuração dos serviços
            var serviceCollection = new ServiceCollection();
            var startup = new Startup();
            startup.ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolução das dependências dos controllers
            var areaPolicialController = serviceProvider.GetService<IAreaPolicialESegurancaController>();
            var areaControleController = serviceProvider.GetService<IAreaControleEGestaoController>();

            // Exemplos de uso para AreaPolicialESeguranca
            Console.WriteLine("Exemplos de AreaPolicialESeguranca:");
            areaPolicialController.AdicionarConcurso(new AreaPolicialESeguranca { /* Preencha com dados de exemplo */ });
            areaPolicialController.AdicionarConcurso(new AreaPolicialESeguranca { /* Preencha com dados de exemplo */ });
            areaPolicialController.AdicionarConcurso(new AreaPolicialESeguranca { /* Preencha com dados de exemplo */ });

            foreach (var concurso in areaPolicialController.ListarConcursos())
            {
                Console.WriteLine(concurso); // Exibir detalhes do concurso
            }

            // Exemplos de uso para AreaControleEGestao
            Console.WriteLine("\nExemplos de AreaControleEGestao:");
            areaControleController.AdicionarConcurso(new AreaControleEGestao { /* Preencha com dados de exemplo */ });
            areaControleController.AdicionarConcurso(new AreaControleEGestao { /* Preencha com dados de exemplo */ });
            areaControleController.AdicionarConcurso(new AreaControleEGestao { /* Preencha com dados de exemplo */ });

            foreach (var concurso in areaControleController.ListarConcursos())
            {
                Console.WriteLine(concurso); // Exibir detalhes do concurso
            }

            Console.WriteLine("\nOperação concluída.");
        }
    }
}
