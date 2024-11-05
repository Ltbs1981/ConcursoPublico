using ConcursoPublico.Core.Contratos.Controladores;
using ConcursoPublico.Core.Contratos.Servicos;
using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Controllers
{
    internal class AreaControleEGestaoController : IAreaControleEGestaoController
    {
        private readonly IServiceAreaControleEGestao _service;

        public AreaControleEGestaoController(IServiceAreaControleEGestao service)
        {
            _service = service;
        }

        public void AdicionarConcurso(AreaControleEGestao concurso)
        {
            _service.AdicionarConcurso(concurso);
        }

        public IEnumerable<AreaControleEGestao> ListarConcursos()
        {
            return _service.ObterConcursos();
        }
    }
}

