using ConcursoPublico.Core.Contratos.Servicos;
using ConcursoPublico.Core.Contratos.Repositorios;
using ConcursoPublico.Core.Entidades;
using System.Collections.Generic;

namespace ConcursoPublico.Services
{
    public class ServiceAreaControleEGestao : IServiceAreaControleEGestao
    {
        private readonly IRepositorioAreaControleEGestao _repositorio;

        public ServiceAreaControleEGestao(IRepositorioAreaControleEGestao repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdicionarConcurso(AreaControleEGestao concurso)
        {
            _repositorio.Adicionar(concurso);
        }

        public IEnumerable<AreaControleEGestao> ListarConcursos()
        {
            return _repositorio.Listar();
        }

        public IEnumerable<AreaControleEGestao> ObterConcursos() // Implementação do método
        {
            return _repositorio.Listar();
        }
    }
}
