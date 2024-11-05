using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Core.Contratos.Repositorios
{
    public interface IRepositorioAreaPolicialESeguranca
    {
        void Adicionar(AreaPolicialESeguranca concurso);
        IEnumerable<AreaPolicialESeguranca> Listar();
    }
}