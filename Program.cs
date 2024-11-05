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
            areaPolicialController.AdicionarConcurso(new AreaPolicialESeguranca
            {
                Banca = "Cespe",
                PeriodoInscricoes = "01/08/2024 - 01/09/2024",
                DataProva = new DateTime(2024, 10, 15),
                Vagas = 100,
                Salario = 5500m
            });
            areaPolicialController.AdicionarConcurso(new AreaPolicialESeguranca
            {
                Banca = "Vunesp",
                PeriodoInscricoes = "15/09/2024 - 15/10/2024",
                DataProva = new DateTime(2024, 11, 20),
                Vagas = 50,
                Salario = 4500m
            });
            areaPolicialController.AdicionarConcurso(new AreaPolicialESeguranca
            {
                Banca = "FCC",
                PeriodoInscricoes = "01/10/2024 - 31/10/2024",
                DataProva = new DateTime(2024, 12, 10),
                Vagas = 75,
                Salario = 5000m
            });

            foreach (var concurso in areaPolicialController.ListarConcursos())
            {
                Console.WriteLine($"Banca: {concurso.Banca}, Inscrições: {concurso.PeriodoInscricoes}, Prova: {concurso.DataProva.ToShortDateString()}, Vagas: {concurso.Vagas}, Salário: {concurso.Salario}");
            }

            // Exemplos de uso para AreaControleEGestao
            Console.WriteLine("\nExemplos de AreaControleEGestao:");
            areaControleController.AdicionarConcurso(new AreaControleEGestao
            {
                Banca = "FGV",
                PeriodoInscricoes = "05/07/2024 - 05/08/2024",
                DataProva = new DateTime(2024, 09, 10),
                Vagas = 30,
                Salario = 7000m
            });
            areaControleController.AdicionarConcurso(new AreaControleEGestao
            {
                Banca = "Quadrix",
                PeriodoInscricoes = "10/08/2024 - 10/09/2024",
                DataProva = new DateTime(2024, 10, 25),
                Vagas = 40,
                Salario = 7500m
            });
            areaControleController.AdicionarConcurso(new AreaControleEGestao
            {
                Banca = "Cesgranrio",
                PeriodoInscricoes = "15/09/2024 - 15/10/2024",
                DataProva = new DateTime(2024, 11, 30),
                Vagas = 35,
                Salario = 8000m
            });

            foreach (var concurso in areaControleController.ListarConcursos())
            {
                Console.WriteLine($"Banca: {concurso.Banca}, Inscrições: {concurso.PeriodoInscricoes}, Prova: {concurso.DataProva.ToShortDateString()}, Vagas: {concurso.Vagas}, Salário: {concurso.Salario}");
            }

            Console.WriteLine("\nOperação concluída.");
        }
    }
}
