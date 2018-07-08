using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel
{
    class BuscarHotelesInicioSesion
    {
        public DataTable Buscar(Modelo.Usuario usuario)
        {
            if (usuario.GetRol().Equals("Administrador General")) {
                ConexionSQL con = new ConexionSQL();
                string query = "select h.hotel_id as hotel_id, isnull(h.nombre, 'Hotel ' + h.direccion) as nombre from" +
                    " WHERE_EN_EL_DELETE_FROM.hoteles h";
                DataTable hotelesSesion = con.cargarTablaSQL(query);
                return hotelesSesion;
            }else{
                ConexionSQL con = new ConexionSQL();
                string query = "select h.hotel_id as hotel_id, isnull(h.nombre, 'Hotel ' + h.direccion) as nombre from" +
                    " WHERE_EN_EL_DELETE_FROM.hoteles h join WHERE_EN_EL_DELETE_FROM.empleados_hoteles eh on h.hotel_id=eh.hotel_id" +
                    " join WHERE_EN_EL_DELETE_FROM.empleados e on e.empleado_id=eh.empleado_id join WHERE_EN_EL_DELETE_FROM.usuarios u" +
                    " on u.usuario_id=e.usuario_id" +
                    " where e.usuario_id=" + usuario.GetID() +
                    " and u.usuario_id=" + usuario.GetID();
                DataTable hotelesSesion = con.cargarTablaSQL(query);
                return hotelesSesion;
            }
            
        }
    }
}
