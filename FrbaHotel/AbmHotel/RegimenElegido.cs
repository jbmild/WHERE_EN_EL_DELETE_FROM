using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHotel
{
    class RegimenElegido
    {
        private string nombre;

        public void SetNombre(string nombre) 
        {
            this.nombre = nombre;
        }
        public string GetNombre() 
        {
            return this.nombre;
        }
    }
}
