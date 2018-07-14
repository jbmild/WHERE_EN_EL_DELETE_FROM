using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuarios
{
    class BuscarUsuarioBaja
    {
        internal void BuscarUsuario(string nombreUsuario, BajaUsuarios pantallaBaja)
        {
            SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
            con1.Open();
            string update = "update WHERE_EN_EL_DELETE_FROM.usuarios set habilitado=0 where usuario like @usuario";
            SqlCommand sqlQuery = new SqlCommand(update);
            sqlQuery.Connection = con1;
            sqlQuery.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = nombreUsuario;
            int usuarioInhabilitado = sqlQuery.ExecuteNonQuery();
            if (usuarioInhabilitado.Equals(1)) { MessageBox.Show("Usuario inhabilitado correctamente"); pantallaBaja.Hide(); } else { MessageBox.Show("Error al inhabilitar usuario"); pantallaBaja.Hide(); }
            
        }
    }
}
