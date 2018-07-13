using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmUsuarios
{
    class BuscarUsuarios
    {
        internal DataTable Buscar(ConexionSQL c, string ape, string dir, string localidad, string numero, string pais, string piso, string mail, string nom, string numdoc, string tel, string tipodoc, string usu,  int hotelid)
        {
       // int hayfiltro=0;
        string query = "SELECT u.usuario, r.nombre, e.nombre, e.apellido, e.direccion_calle, e.direccion_nro, e.direccion_depto, e.direccion_localidad, e.direccion_pais, e.documento_tipo," +
            " e.documento_nro, e.mail, e.telefono from WHERE_EN_EL_DELETE_FROM.empleados e" +
            " join WHERE_EN_EL_DELETE_FROM.empleados_hoteles eh on e.empleado_id = eh.empleado_id" +
            " join WHERE_EN_EL_DELETE_FROM.usuarios u on e.usuario_id=u.usuario_id " +
            " join WHERE_EN_EL_DELETE_FROM.usuarios_roles ur on ur.usuario_id= u.usuario_id" + 
            " join WHERE_EN_EL_DELETE_FROM.roles r on r.rol_id=ur.rol_id where eh.hotel_id=" + hotelid ;
                    

            if (usu.Equals("")) { }
            else
            {
                query += " and u.usuario like '%" + usu + "%'";
            
            }

            if(ape.Equals("")){}else{
               
                    query += "and e.apellido like'%" + ape + "%'";
               
            };
            if(dir.Equals("")){}else{
                    query+= " and e.direccion_calle like '%" + dir + "%'";
               
            };
            if (numero.Equals("")) { }
            else
            {
                query += " and e.direccion_nro like '%" + numero + "%'"; 
            };
            if (localidad.Equals("")) { } else {
                 query += " and e.direccion_localidad like '%" + localidad + "%'"; 
                
            };
            if (pais.Equals("")) { }
            else
            {
                
                query += " and e.direccion_pais like '% " + pais + "%'"; 
                
            }
            if (piso.Equals("")) { } else {
                query += " and e.direccion_piso like '%" + piso + "%'"; 
               }
            if(mail.Equals("")){}else{
               
                    query+= " and e.mail like '%" + mail + "%'";
               
            };
            if (nom.Equals("")){}else{
               
                    query+= " and e.nombre like '%" + nom + "%'";
                          }
            if (numdoc.Equals("")){}else
            {
               
                    query+= "and e.documento_nro like '%" + numdoc + "%'";
               }
            if (tel.Equals("")){}else
            {
               
                    query+= " and e.telefono like '%" + tel + "%'";
               
            }
            if (tipodoc.Equals("")){}else{
            
                    query+= " and documento_tipo like '%" + tipodoc + "%'";
             }
            query += " order by r.nombre asc";
            return c.cargarTablaSQL(query);

        }

        internal DataTable BusquedaInicial(ConexionSQL c, int hotelID)
        {
            return c.cargarTablaSQL("select u.usuario, r.nombre, e.nombre, e.apellido, e.direccion_calle, e.direccion_nro, e.direccion_depto, e.direccion_localidad, e.direccion_pais, e.documento_tipo," +
            " e.documento_nro, e.mail, e.telefono from WHERE_EN_EL_DELETE_FROM.empleados e join "
                + " WHERE_EN_EL_DELETE_FROM.empleados_hoteles eh on e.empleado_id=eh.empleado_id "
                + " join WHERE_EN_EL_DELETE_FROM.usuarios u on u.usuario_id=e.usuario_id"
                + " join WHERE_EN_EL_DELETE_FROM.usuarios_roles ur on ur.usuario_id=u.usuario_id" +
                " join WHERE_EN_EL_DELETE_FROM.roles r on ur.rol_id=r.rol_id " 
                + " where eh.hotel_id=" + hotelID + " order by r.nombre asc");
            

        }

        internal DataTable GetHoteles()
        {
            ConexionSQL c = new ConexionSQL();
           return  c.cargarTablaSQL("select hotel_id, isnull(nombre, 'Hotel ' + direccion) as nombre from WHERE_EN_EL_DELETE_FROM.hoteles");
        }
    }
}
