using System;
using System.Collections.Generic;

namespace NavegacionDinamica.Models
{    
    public class Formulario
    {
        public int IdFormulario { get; set; }
        public string NombreFormulario { get; set; }
        public List<Campo> Campos { get; set; }
    }
}
