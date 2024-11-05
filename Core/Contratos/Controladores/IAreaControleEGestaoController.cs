using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Core.Contratos.Controladores
{
    internal interface IAreaControleEGestaoController
    {
        void AdicionarConcurso(AreaControleEGestao concurso);
        IEnumerable<AreaControleEGestao> ListarConcursos();
    }
}
