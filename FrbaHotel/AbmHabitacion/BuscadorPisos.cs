using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class BuscadorPisos
    {
        internal string ejecutar(string consulta, System.Windows.Forms.ComboBox comboBoxPiso, int hayHabitacion, int hayPiso)
        {
            
            if (comboBoxPiso.SelectedText == "")
            { }
            else 
            {
                if (hayHabitacion.Equals(1))
                {
                    consulta = consulta + " and ";
                    consulta = consulta + "ha.piso=" + comboBoxPiso.SelectedValue;
                }
                else 
                {
                    consulta = consulta + " where ";
                    consulta = consulta + "ha.piso=" + comboBoxPiso.SelectedValue;
                }

            }
            return consulta;
        }
    }
}
