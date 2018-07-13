﻿using System;
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

        internal bool EstadiaAllInclusive(Consumo c, string fecha, int hotel_id)
        {
            AbmHabitacion.SQLQueryGenerator q = new AbmHabitacion.SQLQueryGenerator();
            int estadia;
            ConexionSQL cons = new ConexionSQL();
            string consulta = "SELECT distinct rg.descripcion from WHERE_EN_EL_DELETE_FROM.regimenes rg join"
                + " WHERE_EN_EL_DELETE_FROM.reservas rs on rs.regimen_id=rg.regimen_id join WHERE_EN_EL_DELETE_FROM.estadias es on " +
                " es.reserva_id=rs.reserva_id join WHERE_EN_EL_DELETE_FROM.consumos consu on consu.estadia_id = es.estadia_id "
                + " where consu.estadia_id=" + q.GetEstadia(c.GetHabitacion(), fecha, hotel_id);
            DataTable estadiaResult = cons.cargarTablaSQL(consulta);
            if(estadiaResult.Rows.Count.Equals(0)){MessageBox.Show("No hay regímenes cargado para esta estadía"); return false;}
            else{
                string regimen=estadiaResult.Rows[0].ItemArray[0].ToString();
                   return regimen.Equals("All inclusive");
            }
            
            
        }
    }
}
