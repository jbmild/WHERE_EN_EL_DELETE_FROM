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
    class ModificarUsuarioObject
    {
        bool hayCambios;
        
        int modificacionUsuarioClave;
        
        string updateUsuarioClave;
        internal void GuardarDatos(string apellido, string confirmarPass, string depto, string dir, string localidad, string mail, string nombre, string num,
            string numdoc, string pais, string pass, string piso, string tel, string tipodoc, string usu, string currentUser)
        {
            SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
            con1.Open();
           string update = "UPDATE WHERE_EN_EL_DELETE_FROM.empleados set apellido= @apellido , direccion_depto= @depto , direccion_calle=@calle" +
                ", direccion_localidad=@localidad, mail=@mail, nombre=@nombre, direccion_nro= @num, documento_nro= @numdoc, direccion_pais=@pais, direccion_piso= @piso"
                + ", telefono= @tel, documento_tipo= @tipodoc where usuario_id= (select u.usuario_id from WHERE_EN_EL_DELETE_FROM.usuarios u where u.usuario like @usu);";
            SqlCommand sqlQuery = new SqlCommand(update);
            sqlQuery.Connection = con1;
  
            sqlQuery.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido; //}
            sqlQuery.Parameters.Add("@depto", SqlDbType.NVarChar).Value = depto; //}
            sqlQuery.Parameters.Add("@calle", SqlDbType.NVarChar).Value = dir; //}
            sqlQuery.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = localidad; //}
          sqlQuery.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail; //}
          sqlQuery.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre; //}
          sqlQuery.Parameters.Add("@num", SqlDbType.NVarChar).Value = num; //}
          sqlQuery.Parameters.Add("@numdoc", SqlDbType.NVarChar).Value = numdoc; //}
          sqlQuery.Parameters.Add("@pais", SqlDbType.NVarChar).Value = pais; //}
          sqlQuery.Parameters.Add("@piso", SqlDbType.NVarChar).Value = piso; //}
           sqlQuery.Parameters.Add("@tel", SqlDbType.NVarChar).Value = tel; //}
          sqlQuery.Parameters.Add("@tipodoc", SqlDbType.NVarChar).Value = tipodoc; //}
          sqlQuery.Parameters.Add("@usu", SqlDbType.NVarChar).Value = currentUser;

         
         int  modificacionUsuario = sqlQuery.ExecuteNonQuery();
         ConexionSQL c = new ConexionSQL();
         DataTable res = c.cargarTablaSQL("select usuario_id from WHERE_EN_EL_DELETE_FROM.usuarios where usuario like '" + currentUser + "'");
         int id = Int32.Parse(res.Rows[0].ItemArray[0].ToString());
         if (pass != "")
         {
             SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
             con2.Open();
             updateUsuarioClave += "UPDATE WHERE_EN_EL_DELETE_FROM.usuarios set contrasena=HASHBYTES('SHA2_256', CONVERT(VARCHAR(32),@pass)) where usuario_id='@id'";
             SqlCommand sqlQuery2 = new SqlCommand(updateUsuarioClave);
             sqlQuery2.Connection = con2;

             //if (usu != "" || pass != "" || confirmarPass != "") {  

             sqlQuery2.Parameters.Add("@usu", SqlDbType.NVarChar).Value = usu;
             sqlQuery2.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;//}
             modificacionUsuarioClave = sqlQuery2.ExecuteNonQuery();
            
         }
         else {
             SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
             con2.Open();
             updateUsuarioClave += "UPDATE WHERE_EN_EL_DELETE_FROM.usuarios set usuario=@usu where usuario_id=@id";
             SqlCommand sqlQuery2 = new SqlCommand(updateUsuarioClave);
             sqlQuery2.Connection = con2;
             sqlQuery2.Parameters.Add("@usu", SqlDbType.NVarChar).Value = usu;
             sqlQuery2.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
             modificacionUsuarioClave = sqlQuery2.ExecuteNonQuery();
         }
         
       

            if (modificacionUsuario.Equals(1) && modificacionUsuarioClave.Equals(1))
            {
                MessageBox.Show("¡Usuario modificado con éxito!");
            }
            else 
            {
                MessageBox.Show("Error modificando el usuario: " + usu);
            }
            
        }
    }
}
