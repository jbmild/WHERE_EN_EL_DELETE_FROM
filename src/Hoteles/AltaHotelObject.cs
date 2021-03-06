﻿using FrbaHotel.Tools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Hoteles
{
    class AltaHotelObject
    {
        internal void darDeAlta()
        {
            throw new NotImplementedException();
        }
        
        internal void darDeAlta(System.Windows.Forms.TextBox textBoxCiudadNuevoHotel, System.Windows.Forms.TextBox textBoxDireccionNuevoHotel, 
            System.Windows.Forms.TextBox textBoxEstrellasRecargo, System.Windows.Forms.TextBox textBoxMailNuevoHotel, System.Windows.Forms.TextBox textBoxNombreNuevoHotel,
            System.Windows.Forms.TextBox textBoxPaisNuevoHotel, System.Windows.Forms.TextBox textBoxTelefonoNuevo, ComboBox comboBoxEstrellas,ListBox  listBoxRegimenes)
        {
             SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
                con.Open();
                string query = "INSERT INTO WHERE_EN_EL_DELETE_FROM.hoteles";
                query+=" VALUES (@nombre, @mail ,@telefono, @direccion, @ciudad, @pais, @estrellas, @estrellasRecargo, @fecha)";
                SqlCommand sql = new SqlCommand(query);
                sql.Connection = con;
                sql.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = textBoxNombreNuevoHotel.Text;
                sql.Parameters.Add("@mail", SqlDbType.NVarChar).Value = textBoxMailNuevoHotel.Text;
                sql.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = textBoxTelefonoNuevo.Text;
                sql.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = textBoxDireccionNuevoHotel.Text;
                sql.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = textBoxCiudadNuevoHotel.Text;
                sql.Parameters.Add("@pais", SqlDbType.NVarChar).Value = textBoxPaisNuevoHotel.Text;
                sql.Parameters.Add("@estrellas", SqlDbType.Int).Value = comboBoxEstrellas.SelectedItem;
                sql.Parameters.Add("@estrellasRecargo", SqlDbType.Int).Value = Int32.Parse(textBoxEstrellasRecargo.Text.ToString());
                sql.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                int result = sql.ExecuteNonQuery();

/*************HOTEL_EMPLEADO*******************/
                SqlConnection conToEmpl = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
                conToEmpl.Open();
                ConexionSQL IDHOTEL= new ConexionSQL();
                DataTable IDHOTELBusqueda= IDHOTEL.cargarTablaSQL("select top 1 hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles order by hotel_id desc");
                string insertEmpleHotel = "INSERT INTO WHERE_EN_EL_DELETE_FROM.empleados_hoteles values (@emple, @hotel)";
                SqlCommand sql1 = new SqlCommand(insertEmpleHotel);
                sql1.Connection = conToEmpl;
                ConexionSQL getEmpleadoByUser= new ConexionSQL();
                DataTable GETEMPLEADOBYUSER = getEmpleadoByUser.cargarTablaSQL("select empleado_id from WHERE_EN_EL_DELETE_FROM.empleados where usuario_id=" + Sesion.usuario.UsuarioId);
                sql1.Parameters.Add("@emple", SqlDbType.Int).Value = GETEMPLEADOBYUSER.Rows[0].ItemArray[0];
                sql1.Parameters.Add("@hotel", SqlDbType.Int).Value = IDHOTELBusqueda.Rows[0].ItemArray[0];
                int resultEmpleHotel = sql1.ExecuteNonQuery();



                if (result.Equals(1) && resultEmpleHotel.Equals(1))
                {
                    ConexionSQL getRegimen = new ConexionSQL();
                    DataTable resultados = getRegimen.cargarTablaSQL("select regimen_id from WHERE_EN_EL_DELETE_FROM.regimenes where descripcion like'" +
                        listBoxRegimenes.Items[0].ToString() + "'");
                    int id_regimen = Int32.Parse(resultados.Rows[0].ItemArray[0].ToString());

                    ConexionSQL getHotel = new ConexionSQL();
                    DataTable resultados_ = getHotel.cargarTablaSQL("select hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ho where ho.nombre like '" + textBoxNombreNuevoHotel.Text +
                       "' and ho.direccion like'" + textBoxDireccionNuevoHotel.Text + "' and ho.ciudad like'" + textBoxCiudadNuevoHotel.Text +
                       "' and ho.pais like'" + textBoxPaisNuevoHotel.Text + "'");
                    int id_hotel = Int32.Parse(resultados_.Rows[0].ItemArray[0].ToString());


                    SqlConnection con2 = ConexionSQL.obtenerConexion();//"Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gdhotel2018");
                    //con2.Open();
                    string query2 = "INSERT INTO [GD1C2018].[WHERE_EN_EL_DELETE_FROM].[regimenes_hoteles] (hotel_id, regimen_id) values(@hotel, @regimen)";
                    SqlCommand sql2 = new SqlCommand(query2);
                    sql2.Connection = con2;
                    sql2.Parameters.Add("@hotel", SqlDbType.Int).Value = id_hotel;
                    sql2.Parameters.Add("@regimen", SqlDbType.Int).Value = id_regimen;
                    int result2 = sql2.ExecuteNonQuery();
                    if (result2.Equals(1)) { System.Windows.Forms.MessageBox.Show("¡Hotel agregado con éxito!"); } else { System.Windows.Forms.MessageBox.Show("Error!"); }
                    //labelAgregado.Visible = true;
                }      
        }
    }
}
