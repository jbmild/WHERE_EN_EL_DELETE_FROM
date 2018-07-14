using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FrbaHotel.Modelo
{
    static class Facturas
    {
        public static DataTable getItemsFacturables(int estadia_id)
        {

            ConexionSQL conn = new ConexionSQL();
            string sqlQuery = @"select 
	                                c.consumo_id,
                                    con.codigo,
                                    'En concepto de ' + con.descripcion + ' para la habitacion ' + convert(varchar, hab.numero) AS concepto,
	                                c.cantidad,
	                                c.precio_unitario
                                From 
	                                WHERE_EN_EL_DELETE_FROM.consumos c
                                INNER JOIN
	                                WHERE_EN_EL_DELETE_FROM.consumibles con on
	                                con.consumible_id = c.consumible_id
                                INNER JOIN
	                                WHERE_EN_EL_DELETE_FROM.habitaciones hab on
	                                hab.habitacion_id = c.habitacion_id
                                WHERE
	                                estadia_id = {estadia_id}
                                UNION
                                select
	                                'Hospedaje bajo regimen ' + reg.descripcion AS concepto,
	                                1,
	                                r.total
                                FROM
	                                WHERE_EN_EL_DELETE_FROM.estadias e
                                INNER JOIN
	                                WHERE_EN_EL_DELETE_FROM.reservas r on
	                                r.reserva_id = e.reserva_id
                                INNER JOIN
	                                WHERE_EN_EL_DELETE_FROM.regimenes reg on
	                                reg.regimen_id = r.regimen_id
                                WHERE
	                                e.estadia_id = {estadia_id}
                                ORDER BY
	                                concepto desc";
            sqlQuery = sqlQuery.Replace("{estadia_id}", estadia_id.ToString());

            return conn.cargarTablaSQL(sqlQuery);

        }

    }
}
