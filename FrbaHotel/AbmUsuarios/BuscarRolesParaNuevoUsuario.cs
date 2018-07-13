using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuarios
{
    class BuscarRolesParaNuevoUsuario
    {
        internal void Buscar(ListBox listBoxSeleccionados, ListBox listBoxDisponibles)
        {
            ConexionSQL c = new ConexionSQL();
            string query = "select rol_id, nombre from WHERE_EN_EL_DELETE_FROM.roles";
            if (listBoxSeleccionados.Items.Count > 0) 
            {
                query += " where ";
                int size= listBoxSeleccionados.Items.Count;
                int i = 0;
                foreach (var item in listBoxSeleccionados.Items)
                {
                    i++;
                     query += " nombre not like '" + item.ToString() + "'";
                    if(size.Equals(i)){}else{
                        query += " and ";
                   
                    }
                }
            }
                  
            DataTable rolesDB = c.cargarTablaSQL(query);
            int j;
            for (j = 0; j< rolesDB.Rows.Count; j++) 
            {
                listBoxDisponibles.Items.Add(rolesDB.Rows[j].ItemArray[1]);
            }
        }
    }
}
