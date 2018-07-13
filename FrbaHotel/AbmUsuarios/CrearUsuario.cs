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
    class CrearUsuario
    {
        public void Crear(ConexionSQL c, string ape, string depto, string dir, string mail, string nom, string num, string numdoc, string pais, string piso, string tel, string tipodoc, string usu, DateTime fechanac, string localidad, string pass, ListBox roles, int hID) {
            string nacimiento= fechanac.Year.ToString() + fechanac.Month.ToString() + fechanac.Date.ToString(); 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
                con.Open();
                string addUser = "INSERT INTO WHERE_EN_EL_DELETE_FROM.usuarios (usuario, contrasena,habilitado, cant_intentos) values (@usuario, HASHBYTES('SHA2_256',CONVERT(VARCHAR(32),@contrasena)), 1,0)";
                SqlCommand sqlInsertUser = new SqlCommand(addUser);
                sqlInsertUser.Connection = con;
                sqlInsertUser.Parameters.Add("@usuario", SqlDbType.NVarChar).Value=usu;
                sqlInsertUser.Parameters.Add("@contrasena", SqlDbType.NVarChar).Value = pass;
                int useradded = sqlInsertUser.ExecuteNonQuery();
                if (useradded.Equals(1))
                {
                    ConexionSQL nuevaConsulta = new ConexionSQL();
                    DataTable usuario = nuevaConsulta.cargarTablaSQL("select usuario_id from WHERE_EN_EL_DELETE_FROM.usuarios where usuario like '" + usu + "'");
                    string usuario_id = usuario.Rows[0].ItemArray[0].ToString();
                    string query = "INSERT INTO WHERE_EN_EL_DELETE_FROM.empleados (usuario_id, mail, nombre, apellido, documento_tipo, documento_nro, telefono, direccion_calle, direccion_nro, direccion_piso, direccion_depto, direccion_localidad, direccion_pais)";
                    query += " VALUES (@usuario_id, @mail, @nombre, @apellido, @documento_tipo, @documento_nro, @telefono, @direccion_calle, @direccion_nro, @direccion_piso, @direccion_depto, @direccion_localidad, @direccion_pais)";
                    SqlCommand sql = new SqlCommand(query);
                    sql.Connection = con;
                    sql.Parameters.Add("@usuario_id", SqlDbType.NVarChar).Value = usuario_id;
                    sql.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
                    sql.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nom;
                    sql.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = ape;
                    sql.Parameters.Add("@documento_tipo", SqlDbType.NVarChar).Value = tipodoc;
                    sql.Parameters.Add("@documento_nro", SqlDbType.NVarChar).Value = numdoc;
                    sql.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = tel;
                    sql.Parameters.Add("@direccion_calle", SqlDbType.NVarChar).Value = dir;
                    sql.Parameters.Add("@direccion_nro", SqlDbType.NVarChar).Value = num;
                    sql.Parameters.Add("@direccion_piso", SqlDbType.NVarChar).Value = piso;
                    sql.Parameters.Add("@direccion_depto", SqlDbType.NVarChar).Value = depto;
                    sql.Parameters.Add("@direccion_localidad", SqlDbType.NVarChar).Value = localidad;
                    sql.Parameters.Add("@direccion_pais", SqlDbType.NVarChar).Value = pais;
                    int result = sql.ExecuteNonQuery();
                    int resultadoParcial=0;
                    if (result.Equals(1)) {
                        foreach(var item in roles.Items){
                            string rol=item.ToString();

                            string addRoles = "INSERT INTO WHERE_EN_EL_DELETE_FROM.usuarios_roles values((select rol_id from WHERE_EN_EL_DELETE_FROM.roles where" +
                                " nombre like @rol), @usu_id)";
                            SqlCommand sql2 = new SqlCommand(addRoles);
                            sql2.Connection = con;
                            sql2.Parameters.Add("@rol", SqlDbType.NVarChar).Value = rol;
                            sql2.Parameters.Add("@usu_id", SqlDbType.Int).Value = usuario_id;
                            int resultInUsuariosRoles = sql2.ExecuteNonQuery();
                            if (resultInUsuariosRoles.Equals(1))
                            {
                                resultadoParcial++;
                            }
                            else
                            {
                                MessageBox.Show("Error al intentar registrar a " + usu + "con el rol " + rol);
                            }
                        }
                        if (resultadoParcial.Equals(roles.Items.Count)) {
                            string addEmpleHotel = "INSERT INTO WHERE_EN_EL_DELETE_FROM.empleados_hoteles values ((select empleado_id from" +
                                " WHERE_EN_EL_DELETE_FROM.empleados where usuario_id=@user_id), @hotel_id_)";
                            SqlCommand sql3 = new SqlCommand(addEmpleHotel);
                            sql3.Connection = con;
                            sql3.Parameters.Add("@user_id", SqlDbType.Int).Value = usuario_id;
                            sql3.Parameters.Add("@hotel_id_", SqlDbType.Int).Value = hID;
                            int resultadoEmpleHotel = sql3.ExecuteNonQuery();
                            if (resultadoEmpleHotel.Equals(1))
                            {
                                MessageBox.Show("¡Usuario agregado con éxito!");
                                
                            }
                            else { MessageBox.Show("Error al agregar usuario"); }
                            
                        }
                        else { MessageBox.Show("Error al agregar usuario"); 
                        }
                    }
                        
                }
                else { MessageBox.Show("Error al agregar el usuario"); }
        }
    }
}
