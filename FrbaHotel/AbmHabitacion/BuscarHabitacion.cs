using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class BuscarHabitacion
    {
        internal void ejecutar(Consulta consulta, string p, Busqueda b)
        {
            if (p != "")
            {
                if (b.GetHotel().Equals(false) && b.GetPiso().Equals(false))
                {
                    consulta.ConcatToQuery(" where numero=" + Int32.Parse(p.ToString()));
                }
                else
                {
                    consulta.ConcatToQuery(" and numero=" + Int32.Parse(p.ToString()));
                }
                b.SetHabitacion(true);
            }
            else {
                b.SetHabitacion(false);
            }
            
        }
    }
}
