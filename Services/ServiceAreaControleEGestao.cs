using ConcursoPublico.Core.Contratos.Repositorios;
using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Services
{
    internal class ServiceAreaControleEGestao
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

        public IEnumerable<AreaControleEGestao> ObterConcursos()
        {
            return _repositorio.Listar();
        }
    }
}
