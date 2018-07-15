using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class BuscarPiso
    {
        internal void ejecutar(Consulta consulta, string piso, Busqueda b)
        {
            if (b.GetHotel().Equals(true))
            {
                if (piso != "")
                {
                    consulta.ConcatToQuery(" and ");
                    consulta.ConcatToQuery(" piso= " + Int32.Parse(piso));
                    b.SetPiso(true);
                }
                else
                {
                    b.SetPiso(false);
                }

            }
            else 
            {
                if (piso != "")
                {
                    consulta.ConcatToQuery(" where piso= " + Int32.Parse(piso));
                    b.SetPiso(true);
                }
                else 
                {
                    b.SetPiso(false);
                }
                
            }
            
        }
    }
}
