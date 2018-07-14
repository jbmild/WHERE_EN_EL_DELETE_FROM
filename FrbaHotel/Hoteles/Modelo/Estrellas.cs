using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Hoteles.Modelo
{
    public static class Estrellas
    {
        public static List<int> obtener()
        {
            List<int> estrellas = new List<int>();

            estrellas.Add(1);
            estrellas.Add(2);
            estrellas.Add(3);
            estrellas.Add(4);
            estrellas.Add(5);

            return estrellas;
        }
    }
}
