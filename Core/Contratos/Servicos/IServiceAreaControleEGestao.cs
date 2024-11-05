using ConcursoPublico.Core.Entidades;
using System.Collections.Generic;

namespace ConcursoPublico.Core.Contratos.Servicos
{
    public interface IServiceAreaControleEGestao
    {
        void AdicionarConcurso(AreaControleEGestao concurso);
        IEnumerable<AreaControleEGestao> ListarConcursos();
        IEnumerable<AreaControleEGestao> ObterConcursos(); // Método esperado
    }
}
