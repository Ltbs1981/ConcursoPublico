using ConcursoPublico.Core.Entidades;
using System.Collections.Generic;

namespace ConcursoPublico.Core.Contratos.Servicos
{
    public interface IServiceAreaPolicialESeguranca
    {
        void AdicionarConcurso(AreaPolicialESeguranca concurso);
        IEnumerable<AreaPolicialESeguranca> ListarConcursos();
        IEnumerable<AreaPolicialESeguranca> ObterConcursos(); // Método esperado
    }
}
