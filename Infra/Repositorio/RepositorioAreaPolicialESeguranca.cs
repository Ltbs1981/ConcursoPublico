using ConcursoPublico.Core.Contratos.Repositorios;
using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Infra.Repositorio
{
    public class RepositorioAreaPolicialESeguranca : IRepositorioAreaPolicialESeguranca
    {
        private readonly List<AreaPolicialESeguranca> _concursos = new List<AreaPolicialESeguranca>();

        public void Adicionar(AreaPolicialESeguranca concurso)
        {
            _concursos.Add(concurso);
        }

        public IEnumerable<AreaPolicialESeguranca> Listar()
        {
            return _concursos;
        }
    }
}