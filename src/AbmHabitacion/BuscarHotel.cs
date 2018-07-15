using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class BuscarHotel
    {

        internal void ejecutar(Consulta consulta, string idHotel, Busqueda b)
        {
            if (idHotel == "")
            {
                b.SetHotel(false);
            }
            else 
            {
                consulta.ConcatToQuery(" where ha.hotel_id=" + Int32.Parse(idHotel));
                b.SetHotel(true);
            }

            
        }
    }
}
