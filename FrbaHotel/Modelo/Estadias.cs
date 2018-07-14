using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;

namespace FrbaHotel.Modelo
{
    static class Estadias
    {
        public static DataTable getEstadiasAFacturar(string tipoDoc, string nroDoc, string email, string nombre, string apellido, int reserva_codigo, int estadia_id, int hotel_id)
        {
            //filtrar por habitacion?
        
            ConexionSQL conn = new ConexionSQL();

            string sqlQuery = @"select e.estadia_id, r.codigo, r.fecha_desde, r.fecha_hasta, 
                                cli.nombre + ' ' + cli.apellido As Cliente,
                                cli.direccion_calle + ' ' + direccion_nro AS domicilio,
                                direccion_localidad
                                FROM 
                                    WHERE_EN_EL_DELETE_FROM.estadias e
                                    INNER JOIN WHERE_EN_EL_DELETE_FROM.reservas r on
                                    r.reserva_id = e.reserva_id
                                    INNER JOIN WHERE_EN_EL_DELETE_FROM.clientes cli on
                                    cli.cliente_id = r.cliente_id
                                    WHERE 1=1 ";

            if (hotel_id != 0) {
                sqlQuery += " AND r.hotel_id=" + hotel_id;
            }

            if (tipoDoc.Length > 0) {
                sqlQuery += " AND cli.documento_tipo = '" + tipoDoc + "'";
            }

            if (nroDoc.Length > 0) {
                sqlQuery += " AND cli.documento_nro = '" + nroDoc + "'";
            }

            if (email.Length > 0)
            {
                sqlQuery += " AND cli.mail = '" + email + "'";
            }

            if (nombre.Length > 0)
            {
                sqlQuery += " AND cli.nombre = '" + nombre + "'";
            }

            if (apellido.Length > 0)
            {
                sqlQuery += " AND cli.apellido = '" + apellido + "'";
            }

            if (reserva_codigo != 0)
            {
                sqlQuery += " AND r.codigo = " + reserva_codigo;
            }

            if (estadia_id != 0) {
                sqlQuery += " AND e.estadia_id=" + estadia_id;
            }
            
            return conn.cargarTablaSQL(sqlQuery);
        
        }

    }
}
