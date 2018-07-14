using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaHotel.AbmUsuarios
{
    class TraerRolesFaltantes
    {
        internal void traer(System.Windows.Forms.ListBox listBoxRolesIncluidos, System.Windows.Forms.ListBox listBoxRolesExcluidos)
        {
            string query = "select nombre from WHERE_EN_EL_DELETE_FROM.roles";
            ConexionSQL c = new ConexionSQL();
            if (listBoxRolesIncluidos.Items.Count>0)
            {
                query += "  where ";
                int i=0;
                foreach(var rolExistente in listBoxRolesIncluidos.Items)
                {
                    if(i.Equals(listBoxRolesIncluidos.Items.Count - 1)){
                    query+=" nombre not like '" + rolExistente.ToString()+"'" ;

                    }else
                    {
                        i++;
                        query+=" nombre not like '" + rolExistente.ToString()  + "' and " ;


                    }
                }

            }

            DataTable rolesFaltantes = c.cargarTablaSQL(query);
            int j;
            for (j = 0; j < rolesFaltantes.Rows.Count; j++) 
            {
                listBoxRolesExcluidos.Items.Add(rolesFaltantes.Rows[j].ItemArray[0]);
            }
        }
    }
}
