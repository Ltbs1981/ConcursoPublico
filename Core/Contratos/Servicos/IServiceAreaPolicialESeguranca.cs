﻿using ConcursoPublico.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoPublico.Core.Contratos.Servicos
{
    internal interface IServiceAreaPolicialESeguranca
    {
        void AdicionarConcurso(AreaPolicialESeguranca concurso);
        IEnumerable<AreaPolicialESeguranca> ObterConcursos();
    }
}
