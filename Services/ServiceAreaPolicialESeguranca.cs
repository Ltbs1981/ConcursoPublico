using ConcursoPublico.Core.Contratos.Repositorios;
using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Services
{
    internal class ServiceAreaPolicialESeguranca
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

        public IEnumerable<AreaPolicialESeguranca> ObterConcursos()
        {
            return _repositorio.Listar();
        }
    }
}

