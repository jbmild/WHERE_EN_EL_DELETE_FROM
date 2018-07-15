using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.Modelo
{
    class Factura
    {
        private int _estadia_id;
        private int _cliente_id;
        private int _numero;
        private DateTime _fecha;
        private decimal _total;
        string _cuit;
        bool _responsableInscripto;
        private string _domicilio;
        private string _localidad;
        private string _razonSocial;
        private int _formpago_id;
        private string _tipo_iva;
        private List<Item_factura> _items;

        public Factura(int estadia_id, int cliente_id, int numero, DateTime fecha, decimal total,
            string cuit, bool responsableInscripto, string razonSocial, int formapago_id, List<Item_factura> items) {
            _estadia_id = estadia_id;
            _cliente_id = cliente_id;
            _numero = numero;
            _fecha = fecha;
            _total = total;
            _cuit = cuit;
            _responsableInscripto = responsableInscripto;
            _razonSocial = razonSocial;
            _formpago_id = formapago_id;
            _items = items;
        }

        public int guardarFactura()
        {

            SqlCommand command = new SqlCommand();
            SqlTransaction trans;
            SqlConnection conn = ConexionSQL.obtenerConexion();
            int numero;

            trans = conn.BeginTransaction();
            command.Connection = conn;
            command.Transaction = trans;

            command.CommandText = @"INSERT INTO WHERE_EN_EL_DELETE_FROM.Facturas 
                                    (estadia_id, cliente_id, numero, fecha, total, cuit, razon_social, direccion, localidad, formapago_id, tipo_iva)
                                    VALUES (@estadia_id, @cliente_id, @numero, convert(date, @fecha, 110), @total, @cuit, @razon_social, @direccion, @localidad, @formapago_id, @tipo_iva)
                                    SELECT SCOPE_IDENTITY() ";
            
            command.Parameters.Add("@estadia_id", SqlDbType.Int).Value = _estadia_id;
            command.Parameters.Add("@cliente_id", SqlDbType.Int).Value = _cliente_id;
            command.Parameters.Add("@numero", SqlDbType.Int).Value = _numero;
            command.Parameters.Add("@fecha", SqlDbType.NVarChar).Value = _fecha.ToString("MM/dd/yyyy");
            command.Parameters.Add("@total", SqlDbType.Decimal).Value = _total;
            command.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = _cuit;
            command.Parameters.Add("@razon_social", SqlDbType.NVarChar).Value = _razonSocial;
            command.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = _domicilio;
            command.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = _localidad;
            command.Parameters.Add("@formapago_id", SqlDbType.Int).Value = _formpago_id;
            command.Parameters.Add("@tipo_iva", SqlDbType.NVarChar).Value = _tipo_iva;
        
            try{
                numero = Convert.ToInt32(command.ExecuteScalar());
            }
            catch(Exception ex) {
                throw(ex);
            }
            
            
            //TODO: Guardar items factura, lo saco de Consumibles. 
            command.CommandText = @"INSERT INTO WHERE_EN_EL_DELETE_FROM.items (factura_id, consumo_id, codigo, descripcion, cantidad, precio_unitario)
                                            SELECT
                                                @factura_id,
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
	                                            estadia_id = @estadia_id
                                            UNION
                                            select
                                                @factura_id,
                                                NULL
	                                            '',
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
	                                            e.estadia_id = @estadia_id
                                            ORDER BY
	                                            concepto desc";

            command.Parameters.Clear();
            command.Parameters.Add("@factura_id", SqlDbType.Int);
            command.Parameters.Add("@estadia_id", SqlDbType.Int);

            try {
                int exito = command.ExecuteNonQuery();
                trans.Commit();
            }
            catch(Exception ex){
                trans.Rollback();
                throw (ex);
            }
            return numero;
        }

    }
}
