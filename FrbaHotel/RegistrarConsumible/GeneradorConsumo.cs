using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible
{
    class GeneradorConsumo
    {
        internal void registrarConsumible(AbmHabitacion.SQLQueryGenerator q, System.Data.SqlClient.SqlConnection sql, Consumo consumo, string fecha, int hotel_id)
        {
            string insertConsumo = "insert into WHERE_EN_EL_DELETE_FROM.consumos values (@habitacion_id, @consumible_id, @estadia_id, @cantidad, REPLACE(@precio_unitario, ',' ,'.'))";
            SqlCommand command = new SqlCommand(insertConsumo);
            command.Parameters.Add("@habitacion_id", SqlDbType.Int).Value = consumo.GetHabitacion();
            command.Parameters.Add("@consumible_id", SqlDbType.Int).Value = consumo.GetConsumible();
            command.Parameters.Add("@estadia_id", SqlDbType.Int).Value = q.GetEstadia(consumo.GetHabitacion(), fecha, hotel_id);
            command.Parameters.Add("@cantidad", SqlDbType.Decimal).Value =

            command.Parameters.Add("@precio_unitario", SqlDbType.NVarChar).Value = consumo.GetPrecio();
            command.Connection = sql;
            int resultado = command.ExecuteNonQuery();
            if (resultado.Equals(1))
            {
                MessageBox.Show("¡Consumible registrado correctamente!");
            }
            else
            {
                MessageBox.Show("Error al registra consumible");
            }
                
 
        }
    }
}
