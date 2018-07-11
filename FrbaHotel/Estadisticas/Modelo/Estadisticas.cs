using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Tools;

namespace FrbaHotel.Estadisticas.Modelo
{
    public static class Estadisticas
    {
        public static Estadistica obtener(int anio, int trimestre, string tipo)
        {
            Estadistica estadistica = null;

            List<SqlParameter> parametros = Estadisticas.obtenerParametrosBusqueda(anio, trimestre);
            switch (tipo)
            {
                case "cantReservasCanceladas":
                    estadistica = Estadisticas.obtenerTop5CantReservasCanceladas(parametros);
                    break;
                case "cantConsumiblesFacturados":
                    estadistica = Estadisticas.obtenerTop5CantConsumiblesFacturados(parametros);
                    break;
                case "cantDiasFueraServicio":
                    estadistica = Estadisticas.obtenerTop5CantDiasFueraServicio(parametros);
                    break;
                case "habitacionMayorOcupacion":
                    estadistica = Estadisticas.obtenerTop5HabitacionMayorOcupacion(parametros);
                    break;
                case "clienteMasPuntos":
                    estadistica = Estadisticas.obtenerTop5ClienteMasPuntos(parametros);
                    break;
            }

            return estadistica;
        }

        public static Estadistica obtenerTop5CantReservasCanceladas(List<SqlParameter> parametros)
        {
            try
            {
                Estadistica estadistica = new Estadistica();

                DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
                cantidad.HeaderText = "Cantidad Reservas Canceladas";
                cantidad.DataPropertyName = "cantidad";
                cantidad.ReadOnly = true;
                cantidad.Visible = true;
                estadistica.columnas.Add(cantidad);

                DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
                nombre.HeaderText = "Nombre";
                nombre.DataPropertyName = "nombre";
                nombre.ReadOnly = true;
                nombre.Visible = true;
                estadistica.columnas.Add(nombre);

                DataGridViewTextBoxColumn mail = new DataGridViewTextBoxColumn();
                mail.HeaderText = "E-mail";
                mail.DataPropertyName = "mail";
                mail.ReadOnly = true;
                mail.Visible = true;
                estadistica.columnas.Add(mail);

                DataGridViewTextBoxColumn telefono = new DataGridViewTextBoxColumn();
                telefono.HeaderText = "Telefono";
                telefono.DataPropertyName = "telefono";
                telefono.ReadOnly = true;
                telefono.Visible = true;
                estadistica.columnas.Add(telefono);

                string sql = @"SELECT
	                            TOP 5
	                            count(*) as cantidad,
	                            h.nombre, 
	                            h.mail, 
	                            h.telefono
                            FROM
	                            WHERE_EN_EL_DELETE_FROM.hoteles h
	                            INNER JOIN WHERE_EN_EL_DELETE_FROM.reservas r ON
		                            r.hotel_id = h.hotel_id
		                            AND r.cancelacion_fecha IS NOT NULL
		                            AND r.cancelacion_usuario_id IS NOT NULL
		                            AND r.cancelacion_fecha BETWEEN convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)
                            GROUP BY h.nombre, h.mail, h.telefono, h.direccion, h.ciudad, h.pais
                            ORDER BY cantidad DESC";
                estadistica.data = DBInterface.seleccionar(sql, parametros);

                return estadistica;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al procesar su consulta.");
            }
        }

        public static Estadistica obtenerTop5CantConsumiblesFacturados(List<SqlParameter> parametros)
        {
            return null;
        }

        public static Estadistica obtenerTop5CantDiasFueraServicio(List<SqlParameter> parametros)
        {
            return null;
        }

        public static Estadistica obtenerTop5HabitacionMayorOcupacion(List<SqlParameter> parametros)
        {
            return null;
        }

        public static Estadistica obtenerTop5ClienteMasPuntos(List<SqlParameter> parametros)
        {
            return null;
        }

        private static List<SqlParameter> obtenerParametrosBusqueda(int anio, int trimestre)
        {
            string fechaDesde = "";
            string fechaHasta = "";

            switch (trimestre) //mm-dd-aaaa
            {
                case 1:
                    fechaDesde = "01-01-" + anio.ToString();
                    fechaHasta = "03-31-" + anio.ToString();
                    break;
                case 2:
                    fechaDesde = "04-01-" + anio.ToString();
                    fechaHasta = "06-30-" + anio.ToString();
                    break;
                case 3:
                    fechaDesde = "07-01-" + anio.ToString();
                    fechaHasta = "09-30-" + anio.ToString();
                    break;
                case 4:
                    fechaDesde = "10-01-" + anio.ToString();
                    fechaHasta = "12-31-" + anio.ToString();
                    break;
            }

            if (fechaDesde == "" || fechaHasta == "" || fechaDesde.Length != 10 || fechaHasta.Length != 10)
            {
                throw new Exception("Los valores de la fecha solicitada no son validos.");
            }

            List<SqlParameter> parametros = new List<SqlParameter>();

            SqlParameter parametro = new SqlParameter("@fechaDesde", fechaDesde);
            parametro.DbType = DbType.String;
            parametros.Add(parametro);

            parametro = new SqlParameter("@fechaHasta", fechaHasta);
            parametro.DbType = DbType.String;
            parametros.Add(parametro);

            return parametros;
        }
    }
}
