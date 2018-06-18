using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHabitacion
{
    class BuscadorHabitacion
    {
        internal string ejecutar(string consulta, System.Windows.Forms.ComboBox comboBoxHabitaciones,  int hayHotel, int hayHabitacion)
        {
            

            if (comboBoxHabitaciones.SelectedText == "") 
            {
                
            } 
            else {
                if (hayHotel.Equals(1))
                {
                    hayHabitacion = 1;
                    consulta = consulta + " and ";
                    consulta = consulta + "ha.numero = " + comboBoxHabitaciones.SelectedValue;
                }
                else 
                {
                    hayHabitacion = 1;
                    consulta = consulta + " where ";
                    consulta = consulta + "ha.numero = " + comboBoxHabitaciones.SelectedValue;
                }
            }
            return consulta;   
        }

    }
}
