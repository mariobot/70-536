using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaUnoTH
{
    class Persona : PersonaDireccion, IPersona,IPersonaGeneral
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }
        public int Talla { get; set; }

        public void validaEdad()
        {
            throw new NotImplementedException();
        }

        public void validaTalla()
        {
            throw new NotImplementedException();
        }
    }
}
