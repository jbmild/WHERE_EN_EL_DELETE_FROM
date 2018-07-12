using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmUsuarios
{
    class BuscarUsuarios
    {
        internal DataTable Buscar(ConexionSQL c, string ape, string dir, string localidad, string numero, string pais, string piso, string mail, string nom, string numdoc, string tel, string tipodoc, string usu, DateTime naci, int hotelid)
        {
        int hayfiltro=0;
        string query = "SELECT * from WHERE_EN_EL_DELETE_FROM.empleados e join WHERE_EN_EL_DELETE_FROM.empleados_hoteles eh on e.empleado_id = eh.empleado_id";
                    

            if (usu.Equals("")) { }
            else
            {
                query += " join WHERE_EN_EL_DELETE_FROM.usuarios u on e.usuario_id=u.usuario_id where u.usuario like '%" + usu + "%'";
                hayfiltro = 1;
            }

            if(ape.Equals("")){}else{
                if (hayfiltro.Equals(1))
                {
                    query += "and e.apellido like'%" + ape + "%'";
                }
                else {
                    query += "where e.apellido like'%" + ape + "%'";
                    hayfiltro = 1;
                }
            };
            if(dir.Equals("")){}else{
                if(hayfiltro.Equals(1))
                {
                    query+= " and e.direccion_calle like '%" + dir + "%'";
                }
                else{
                    query += " where e.direccion_calle like '%" + dir + "%'"; hayfiltro = 1;
                }
            };
            if (numero.Equals("")) { }
            else
            {
                if (hayfiltro.Equals(1)) { query += " and e.direccion_nro like '%" + numero + "%'"; }
                else
                {
                    query += " where e.direccion_nro like '%" + numero + "%'";
                    hayfiltro = 1;
                }
            };
            if (localidad.Equals("")) { } else {
                if (hayfiltro.Equals(1)) { query += " and e.direccion_localidad like '%" + localidad + "%'"; }
                else
                {
                    query += " where e.direccion_localidad like '%" + localidad + "%'";
                    hayfiltro = 1;
                }
            };
            if (pais.Equals("")) { }
            else
            {
                if (hayfiltro.Equals(1)) { query += " and e.direccion_pais like '% " + pais + "%'"; }
                else
                {
                    query += " where e.direccion_pais like '% " + pais + "%'";
                    hayfiltro = 1;
                }
            }
            if (piso.Equals("")) { } else {
                if (hayfiltro.Equals(1)) { query += " and e.direccion_piso like '%" + piso + "%'"; }
                else {
                    query += " where e.direccion_piso like '%" + piso + "%'";
                    hayfiltro = 1;
                }
            }
            if(mail.Equals("")){}else{
                if(hayfiltro.Equals(1)){
                    query+= " and e.mail like '%" + mail + "%'";
                }
                else{
                    query+= " where e.mail like '%" + mail + "%'"; hayfiltro=1;
                }
            };
            if (nom.Equals("")){}else{
                if (hayfiltro.Equals(1)){
                    query+= " and e.nombre like '%" + nom + "%'";
                }else
                {
                    query+= " where e.nombre like '%" + nom + "%'";
                    hayfiltro=1;
                }
            }
            if (numdoc.Equals("")){}else
            {
                if (hayfiltro.Equals(1)){
                    query+= " and e.documento_nro like '%" + numdoc + "%'";
                }else{
                    query+= "where e.documento_nro like '%" + numdoc + "%'";
                    hayfiltro=1;
                }
            }
            if (tel.Equals("")){}else
            {
                if (hayfiltro.Equals(1)){
                    query+= " and e.telefono like '%" + tel + "%'";
                }else{
                    query+= " where e.telefono like '%" + tel + "%'";
                    hayfiltro=1;
                }
            }
            if (tipodoc.Equals("")){}else{
                if (hayfiltro.Equals(1)){
                    query+= " and documento_tipo like '%" + tipodoc + "%'";
                    }else{
                    query+= " where documento_tipo like '%" + tipodoc + "%'";
                    hayfiltro=1;
                }
            }
            
            return c.cargarTablaSQL(query);

        }

        internal DataTable BusquedaInicial(ConexionSQL c, int hotelID)
        {
            return c.cargarTablaSQL("select e.*, isnull(ho.nombre, 'Hotel ' + direccion) as hotel_nombre from WHERE_EN_EL_DELETE_FROM.empleados e join "
                + " WHERE_EN_EL_DELETE_FROM.empleados_hoteles eh on e.empleado_id=eh.empleado_id join WHERE_EN_EL_DELETE_FROM.hoteles ho on eh.hotel_id=ho.hotel_id"
                + " where ho.hotel_id=" + hotelID + " and eh.hotel_id=" + hotelID);

        }

        internal DataTable GetHoteles()
        {
            ConexionSQL c = new ConexionSQL();
           return  c.cargarTablaSQL("select hotel_id, isnull(nombre, 'Hotel ' + direccion) as nombre from WHERE_EN_EL_DELETE_FROM.hoteles");
        }
    }
}
