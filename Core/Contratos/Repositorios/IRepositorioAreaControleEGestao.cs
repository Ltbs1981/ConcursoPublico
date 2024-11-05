using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Core.Contratos.Repositorios
{
    internal interface IRepositorioAreaControleEGestao
    {
        void Adicionar(AreaControleEGestao concurso);
        IEnumerable<AreaControleEGestao> Listar();
    }
}
