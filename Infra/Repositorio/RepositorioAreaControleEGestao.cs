using ConcursoPublico.Core.Contratos.Repositorios;
using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Infra.Repositorio
{
    public class RepositorioAreaControleEGestao : IRepositorioAreaControleEGestao
    {
        private readonly List<AreaControleEGestao> _concursos = new List<AreaControleEGestao>();

        public void Adicionar(AreaControleEGestao concurso)
        {
            _concursos.Add(concurso);
        }

        public IEnumerable<AreaControleEGestao> Listar()
        {
            return _concursos;
        }
    }
}
