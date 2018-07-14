using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmHotel
{
    class BuscarRegimenes
    {
        internal System.Data.DataTable Buscar(System.Windows.Forms.ListBox regimenesActuales)
        {
            ConexionSQL c = new ConexionSQL();
            string query = "select descripcion from WHERE_EN_EL_DELETE_FROM.regimenes";
            if (regimenesActuales.Items.Count.Equals(0)) { }
            else
            {
                query += " where ";
                int size= regimenesActuales.Items.Count;
                int i=0;
                foreach (var item in regimenesActuales.Items) {
                    query += " descripcion not like '" + item.ToString() + "'";
                    i++;
                    if (i.Equals(size)) { } else { query += " and ";}
                }
            }
            DataTable regimenesEncontrados = c.cargarTablaSQL(query);
            return regimenesEncontrados;
        }
    }
}
