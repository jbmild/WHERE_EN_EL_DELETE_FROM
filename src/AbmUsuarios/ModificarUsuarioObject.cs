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
        int result_usu_roles;
        int vecesUsuRoles = 0;
        int modificacionUsuarioClave=0;
        
        string updateUsuarioClave;
        internal void GuardarDatos(string apellido, string confirmarPass, string depto, string dir, string localidad, string mail, string nombre, string num,
            string numdoc, string pais, string pass, string piso, string tel, string tipodoc, string usu, string currentUser, ModificarUsuario pantalla, Usuarios usuariosPantalla, ListBox roles)
        {

/*****************Modificar EMPLEADOS**************/
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
/*****************Modifico USUARIOS_ROLES**********/
            ConexionSQL con= new ConexionSQL();
            DataTable usuario= con.cargarTablaSQL("select usuario_id from WHERE_EN_EL_DELETE_FROM.usuarios where usuario like'" + usu + "'");
            string usuarioTOUSE=usuario.Rows[0].ItemArray[0].ToString();
            string deleteUsuariosRoles = "DELETE FROM WHERE_EN_EL_DELETE_FROM.usuarios_roles where usuario_id=@usuarioDelete";
            
            SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
            con3.Open();
            SqlCommand sqlQuery3 = new SqlCommand(deleteUsuariosRoles);
            sqlQuery3.Connection = con3;
            sqlQuery3.Parameters.Add("@usuarioDelete", SqlDbType.Int).Value = Int32.Parse(usuarioTOUSE);
            sqlQuery3.ExecuteNonQuery();
        
            foreach(var usuRol in roles.Items)
            {
                ConexionSQL conrol= new ConexionSQL();
                DataTable conrol_res= conrol.cargarTablaSQL("select rol_id from WHERE_EN_EL_DELETE_FROM.roles where nombre like '" + usuRol.ToString() + "'");
                string insertUsuariosRoles = "INSERT INTO WHERE_EN_EL_DELETE_FROM.usuarios_roles values (@rolNuevo,@usuarioMismo)";
                SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
                con4.Open();
                SqlCommand sqlQuery4 = new SqlCommand(insertUsuariosRoles);
                sqlQuery4.Connection = con4;
                sqlQuery4.Parameters.Add("@rolNuevo", SqlDbType.Int).Value = Int32.Parse(conrol_res.Rows[0].ItemArray[0].ToString());
                sqlQuery4.Parameters.Add("@usuarioMismo", SqlDbType.Int).Value = Int32.Parse(usuarioTOUSE);
                result_usu_roles=sqlQuery4.ExecuteNonQuery();
                vecesUsuRoles++;
               

            }
            



  /************Modifico USUARIO*****************/
       
         int  modificacionUsuario = sqlQuery.ExecuteNonQuery();
         ConexionSQL c = new ConexionSQL();
         DataTable res = c.cargarTablaSQL("select usuario_id from WHERE_EN_EL_DELETE_FROM.usuarios where usuario like '" + currentUser + "'");
         int id = Int32.Parse(res.Rows[0].ItemArray[0].ToString());
         if (pass != "")
         {
             SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
             con2.Open();
             updateUsuarioClave += "UPDATE WHERE_EN_EL_DELETE_FROM.usuarios set contrasena=HASHBYTES('SHA2_256', CONVERT(VARCHAR(32),@pass)) where usuario_id=@id";
             SqlCommand sqlQuery2 = new SqlCommand(updateUsuarioClave);
             sqlQuery2.Connection = con2;

             //if (usu != "" || pass != "" || confirmarPass != "") {  

             sqlQuery2.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
             sqlQuery2.Parameters.Add("@id", SqlDbType.Int).Value = id;//}
             modificacionUsuarioClave = sqlQuery2.ExecuteNonQuery();

         }

          
         else { modificacionUsuarioClave = 1; }
         
       

            if (modificacionUsuario.Equals(1) && modificacionUsuarioClave.Equals(1) &&  vecesUsuRoles.Equals(roles.Items.Count))
            {
                MessageBox.Show("¡Usuario modificado con éxito!");
                pantalla.Hide();
                usuariosPantalla.Hide();
                usuariosPantalla.Show();
                usuariosPantalla.Usuarios_Load(new object(), new EventArgs());
                
            }
            else 
            {
                MessageBox.Show("Error modificando el usuario: " + usu);
            }
            
        }
    }
}
