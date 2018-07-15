using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FrbaHotel.Modelo
{
    static class FormasPago
    {
        public static DataTable getFormasPago() {
            ConexionSQL conn = new ConexionSQL();
            return conn.cargarTablaSQL("SELECT formapago_id, nombre FROM WHERE_EN_EL_DELETE_FROM.FormasPago WHERE habilitado=1");
        }
    }
}
