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

        internal void Cargar(ConexionSQL c, System.Windows.Forms.ComboBox comboBox, int hotelid)
        {
            DataTable result = c.cargarTablaSQL("SELECT distinct piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + hotelid + "order by piso asc");
            result.Rows.InsertAt(result.NewRow(), 0);
            comboBox.DataSource = result;
            comboBox.SelectedIndex = 0;
            comboBox.DisplayMember = "piso";
            comboBox.ValueMember = "piso";
        }
    }
}
