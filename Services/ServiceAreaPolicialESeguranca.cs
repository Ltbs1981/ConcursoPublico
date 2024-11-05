using ConcursoPublico.Core.Contratos.Servicos;
using ConcursoPublico.Core.Contratos.Repositorios;
using ConcursoPublico.Core.Entidades;
using System.Collections.Generic;

namespace ConcursoPublico.Services
{
    public class ServiceAreaPolicialESeguranca : IServiceAreaPolicialESeguranca
    {
        private readonly IRepositorioAreaPolicialESeguranca _repositorio;

        public ServiceAreaPolicialESeguranca(IRepositorioAreaPolicialESeguranca repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdicionarConcurso(AreaPolicialESeguranca concurso)
        {
            _repositorio.Adicionar(concurso);
        }

        public IEnumerable<AreaPolicialESeguranca> ListarConcursos()
        {
            return _repositorio.Listar();
        }

        public IEnumerable<AreaPolicialESeguranca> ObterConcursos() // Implementação do método
        {
            return _repositorio.Listar();
        }
    }
}
