using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
                            GROUP BY h.nombre, h.mail, h.telefono
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
            try
            {
                Estadistica estadistica = new Estadistica();

                DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
                cantidad.HeaderText = "Cantidad Items Facturados";
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
	                                INNER JOIN WHERE_EN_EL_DELETE_FROM.estadias e ON
		                                e.reserva_id = r.reserva_id
	                                INNER JOIN WHERE_EN_EL_DELETE_FROM.facturas f ON
		                                f.estadia_id = e.estadia_id
		                                AND fecha BETWEEN convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)
	                                INNER JOIN WHERE_EN_EL_DELETE_FROM.items i ON
		                                i.factura_id = f.factura_id
	                                INNER JOIN WHERE_EN_EL_DELETE_FROM.consumos c ON
		                                c.consumo_id = i.consumo_id
                                GROUP BY h.nombre, h.mail, h.telefono
                                ORDER BY cantidad DESC";
                estadistica.data = DBInterface.seleccionar(sql, parametros);

                return estadistica;
            }
            catch (Exception)
            { 
                throw new Exception("Ocurrio un error al procesar su consulta.");
            }
        }

        public static Estadistica obtenerTop5CantDiasFueraServicio(List<SqlParameter> parametros)
        {
            try
            {
                Estadistica estadistica = new Estadistica();

                DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
                cantidad.HeaderText = "Cantidad Dias Fuera de Servicio";
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
	                                SUM(c.cantidad) as cantidad,
	                                h.nombre, 
	                                h.mail, 
	                                h.telefono
                                FROM
	                                WHERE_EN_EL_DELETE_FROM.hoteles h
	                                INNER JOIN (
		                                SELECT
			                                (CASE
				                                WHEN convert(date, @fechaDesde, 110)<cc.fecha_inicio AND cc.fecha_fin<convert(date, @fechaHasta, 110) THEN DATEDIFF(day, cc.fecha_inicio, cc.fecha_fin)
				                                WHEN cc.fecha_inicio<convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)<cc.fecha_fin THEN DATEDIFF(day, convert(date, @fechaDesde, 110), convert(date, @fechaHasta, 110))
				                                WHEN cc.fecha_inicio>convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)<cc.fecha_fin THEN DATEDIFF(day, cc.fecha_inicio, convert(date, @fechaHasta, 110))
				                                WHEN cc.fecha_inicio<convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)>cc.fecha_fin THEN DATEDIFF(day, convert(date, @fechaDesde, 110), cc.fecha_fin)
			                                END) as cantidad,
			                                cc.hotel_id
		                                FROM WHERE_EN_EL_DELETE_FROM.cese_actividades cc 
	                                ) c ON
		                                c.hotel_id = h.hotel_id
                                GROUP BY h.nombre, h.mail, h.telefono
                                ORDER BY cantidad DESC";

                estadistica.data = DBInterface.seleccionar(sql, parametros);

                return estadistica;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al procesar su consulta.");
            }
        }

        public static Estadistica obtenerTop5HabitacionMayorOcupacion(List<SqlParameter> parametros)
        {
            try
            {
                Estadistica estadistica = new Estadistica();

                DataGridViewTextBoxColumn cantidadDias = new DataGridViewTextBoxColumn();
                cantidadDias.HeaderText = "Cantidad Dias Ocupada";
                cantidadDias.DataPropertyName = "cantidaddias";
                cantidadDias.ReadOnly = true;
                cantidadDias.Visible = true;
                estadistica.columnas.Add(cantidadDias);

                DataGridViewTextBoxColumn cantidadVeces = new DataGridViewTextBoxColumn();
                cantidadVeces.HeaderText = "Cantidad Veces Ocupada";
                cantidadVeces.DataPropertyName = "cantidadveces";
                cantidadVeces.ReadOnly = true;
                cantidadVeces.Visible = true;
                estadistica.columnas.Add(cantidadVeces);

                DataGridViewTextBoxColumn piso = new DataGridViewTextBoxColumn();
                piso.HeaderText = "Piso";
                piso.DataPropertyName = "piso";
                piso.ReadOnly = true;
                piso.Visible = true;
                estadistica.columnas.Add(piso);

                DataGridViewTextBoxColumn numero = new DataGridViewTextBoxColumn();
                numero.HeaderText = "Numero";
                numero.DataPropertyName = "numero";
                numero.ReadOnly = true;
                numero.Visible = true;
                estadistica.columnas.Add(numero);

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
	                            SUM(d.cantidad) as cantidaddias,
                                COUNT(*) as cantidadveces,
	                            ha.piso,
	                            ha.numero,
	                            h.nombre, 
	                            h.mail, 
	                            h.telefono
                            FROM
	                            WHERE_EN_EL_DELETE_FROM.hoteles h
	                            INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones ha ON
		                            ha.hotel_id = h.hotel_id
	                            INNER JOIN (
		                            SELECT
			                            (CASE
				                            WHEN e.ingreso_fecha IS NULL THEN 0
				                            WHEN convert(date, @fechaHasta, 110)<=convert(date, @fechaActual, 110) AND e.ingreso_fecha IS NOT NULL AND e.egreso_fecha IS NULL THEN DATEDIFF(day, e.ingreso_fecha, convert(date, @fechaHasta, 110))
                                            WHEN convert(date, @fechaHasta, 110)>=convert(date, @fechaActual, 110) AND e.ingreso_fecha IS NOT NULL AND e.egreso_fecha IS NULL THEN DATEDIFF(day, e.ingreso_fecha, convert(date, @fechaActual, 110))
				                            WHEN convert(date, @fechaDesde, 110)<=e.ingreso_fecha AND e.egreso_fecha<=convert(date, @fechaHasta, 110) THEN DATEDIFF(day, e.ingreso_fecha, e.egreso_fecha)
				                            WHEN e.ingreso_fecha<=convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)<=e.egreso_fecha THEN DATEDIFF(day, convert(date, @fechaDesde, 110), convert(date, @fechaHasta, 110))
				                            WHEN e.ingreso_fecha>=convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)<=e.egreso_fecha THEN DATEDIFF(day, e.ingreso_fecha, convert(date, @fechaHasta, 110))
				                            WHEN e.ingreso_fecha<=convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)>=e.egreso_fecha THEN DATEDIFF(day, convert(date, @fechaDesde, 110), e.egreso_fecha)
			                            END) as cantidad,
			                            rh.habitacion_id
		                            FROM 
			                            WHERE_EN_EL_DELETE_FROM.estadias e 
			                            INNER JOIN WHERE_EN_EL_DELETE_FROM.reservas r ON
				                            r.reserva_id = e.reserva_id
			                            INNER JOIN WHERE_EN_EL_DELETE_FROM.reservas_habitaciones rh ON
				                            rh.reserva_id = r.reserva_id
									WHERE
										e.ingreso_fecha BETWEEN convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110)
										OR e.egreso_fecha BETWEEN convert(date, @fechaDesde, 110) AND convert(date, @fechaHasta, 110) 
										OR (e.ingreso_fecha<=convert(date, @fechaDesde, 110) AND e.egreso_fecha>=convert(date, @fechaHasta, 110))
	                            ) d ON
		                            d.habitacion_id = ha.habitacion_id
							WHERE d.cantidad>0
                            GROUP BY ha.piso, ha.numero, h.nombre, h.mail, h.telefono
                            ORDER BY cantidaddias DESC";

                string fecha;
                try
                {
                    CultureInfo culture = new CultureInfo(ConfigurationManager.AppSettings["formatoFechaSistema"]);
                    fecha = Convert.ToDateTime(ConfigurationManager.AppSettings["fechaSistema"], culture).ToString("MM/dd/yyyy");
                }
                catch (Exception)
                {
                    throw new Exception("date_error");
                }


                SqlParameter parametro = new SqlParameter("@fechaActual", fecha); //TODO cambiar!
                parametro.DbType = DbType.String;
                parametros.Add(parametro);


                estadistica.data = DBInterface.seleccionar(sql, parametros);

                return estadistica;
            }
            catch (Exception er)
            {
                if (er.Message == "date_error")
                {
                    throw new Exception("La fecha ingresada en la configuracion no corresponde a su formato o esta incompleto.");
                }
                else
                {
                    throw new Exception("Ocurrio un error al procesar su consulta.");
                }
            }
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
