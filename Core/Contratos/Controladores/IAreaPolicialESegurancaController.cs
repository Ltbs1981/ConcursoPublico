using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Core.Contratos.Controladores
{
    internal interface IAreaPolicialESegurancaController
    {
        void AdicionarConcurso(AreaPolicialESeguranca concurso);
        IEnumerable<AreaPolicialESeguranca> ListarConcursos();
    }
}
