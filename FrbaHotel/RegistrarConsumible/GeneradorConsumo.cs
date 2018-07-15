using FrbaHotel.Tools;
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
        private registrarConsumible pantallita;
        internal void registrarConsumible(AbmHabitacion.SQLQueryGenerator q, System.Data.SqlClient.SqlConnection sql, Consumo consumo, string fecha, int hotel_id, registrarConsumible pantalla)
        {
            this.pantallita = pantalla;
            string insertConsumo = "insert into WHERE_EN_EL_DELETE_FROM.consumos values (@habitacion_id, @consumible_id, @estadia_id, @cantidad, REPLACE(@precio_unitario, ',' ,'.'))";
            SqlCommand command = new SqlCommand(insertConsumo);
            command.Parameters.Add("@habitacion_id", SqlDbType.Int).Value = consumo.GetHabitacion();
            command.Parameters.Add("@consumible_id", SqlDbType.Int).Value = consumo.GetConsumible();
            
            command.Parameters.Add("@estadia_id", SqlDbType.Int).Value = q.GetEstadia(consumo.GetHabitacion(), fecha, hotel_id);
            command.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = consumo.GetCantidad();

            command.Parameters.Add("@precio_unitario", SqlDbType.NVarChar).Value = consumo.GetPrecio();
            command.Connection = sql;
            int resultado = command.ExecuteNonQuery();
            if (resultado.Equals(1))
            {
                this.pantallita.MostrarGrid(consumo.GetHabitacion(), q.GetEstadia(consumo.GetHabitacion(), fecha, hotel_id));
                //MessageBox.Show("¡Consumible registrado correctamente!");
                //pantallita.Hide();

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

        internal void CargarEstadia(int hotel, int habi)
        {
            ConexionSQL c = new ConexionSQL();
            string query= " select  consu.descripcion, c.precio_unitario "+
                     " from WHERE_EN_EL_DELETE_FROM.consumos c join WHERE_EN_EL_DELETE_FROM.consumibles consu on c.consumible_id=consu.consumible_id " + 
                     " join WHERE_EN_EL_DELETE_FROM.estadias e on c.estadia_id=e.estadia_id " +
                     " join WHERE_EN_EL_DELETE_FROM.reservas r on e.reserva_id=r.reserva_id " +
                     " join WHERE_EN_EL_DELETE_FROM.habitaciones h on r.hotel_id=h.hotel_id "+
                     " where h.hotel_id=" + hotel + " and h.habitacion_id=" + habi + " and e.ingreso_fecha<=CONVERT(DATE, '" + Sesion.obtenerFechaSistema().ToString("MM-dd-yyyy") + "', 110) " +
                     " order by e.ingreso_fecha desc";
            DataTable t = c.cargarTablaSQL(query);

        }
    }
}
