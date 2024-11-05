using ConcursoPublico.Core.Contratos.Controladores;
using ConcursoPublico.Core.Contratos.Servicos;
using ConcursoPublico.Core.Entidades;

namespace ConcursoPublico.Controllers
{
    internal class AreaPolicialESegurancaController: IAreaPolicialESegurancaController
    {
        private readonly IServiceAreaPolicialESeguranca _service;

        public AreaPolicialESegurancaController(IServiceAreaPolicialESeguranca service)
        {
            _service = service;
        }

        public void AdicionarConcurso(AreaPolicialESeguranca concurso)
        {
            _service.AdicionarConcurso(concurso);
        }

        public IEnumerable<AreaPolicialESeguranca> ListarConcursos()
        {
            return _service.ObterConcursos();
        }
    }
}

