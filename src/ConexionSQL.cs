﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;


namespace FrbaHotel
{
    public class ConexionSQL
    {

        private SqlConnection miConexionSQL;
        private String miConnectionStringSQL;
        public static String UsuarioLogeado;
        public static String RolUsuarioLogeado;

        #region "Propiedades"

        public SqlConnection getMiConexionSQL()
        {
            return miConexionSQL;
        }

        public String getMiConnectionString()
        {
            return miConnectionStringSQL;
        }

        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor, toma el connectionString de la aplicacion
        /// </summary>
        /// <remarks></remarks>
        public ConexionSQL()
        {
            miConexionSQL = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);


            /*se usa para las conexiones tcp/ip*/
            //comento el string porque ahora lo saco del app.config
            //string gd20 = "Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gdhotel2018";

            /*se usa para las conexiones locales*/
            //string gd20 = "Data source=.\\SQLSERVER2012; Initial Catalog=GD1C2018;User Id=gd2018; Password=gd2018";

            //miConnectionStringSQL = gd20;
            //miConnectionStringSQL = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            //miConexionSQL.ConnectionString = miConnectionStringSQL;
        }

        public static void SetUsuarioLog(string Username)
        {
            UsuarioLogeado = Username;
        }
        public static void SetRolUsuarioLog(string Rol)
        {
            RolUsuarioLogeado = Rol;
        }
        public static String GetUsuarioLog()
        {
            return UsuarioLogeado;
        }
        public static String GetRolUsuarioLog()
        {
            return RolUsuarioLogeado;
        }

        public ConexionSQL(String _connectionString)
        {
            miConexionSQL = new SqlConnection();
            miConnectionStringSQL = _connectionString;
            miConexionSQL.ConnectionString = miConnectionStringSQL;
        }

        public static SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
         
            
            conexion.Open();
            return conexion;

        }


        public DataTable cargarTablaSQL(string miCommand)
        {
            SqlCommand coman2 = new SqlCommand(string.Format(miCommand), miConexionSQL);

            DataTable ds = this.cargarTabla(coman2);
            return ds;
        }   

        public DataTable cargarTabla(SqlCommand miCommand)
        {
            DataTable ds = new DataTable();
            // REM CONFIGURO EL OBJETO COMMAND
            this.conectar();
            // REM INDICO LA CONEXION ACTIVA
            miCommand.Connection = miConexionSQL;
            // REM INDICO EL TIPO QUE SE PASARA EN COMMANDTEXT
            miCommand.CommandType = CommandType.Text;

            // REM CREO UN DATAREADER
            SqlDataAdapter dataAdapter = new SqlDataAdapter(miCommand);
            // REM CARGO EL DATATABLE PRODUCTOS A TRAVEZ DEL DATAREADER
            try
            {
                dataAdapter.Fill(ds);
            }
            catch (Exception ex) {
                throw (ex);
            }
            
            this.desconectar();
            return ds;
        }

        public int actualizarDatos(string query) {

            SqlCommand miCommand = new SqlCommand(string.Format(query), miConexionSQL);



            DataTable ds = new DataTable();
            // REM CONFIGURO EL OBJETO COMMAND
            this.conectar();
            // REM INDICO LA CONEXION ACTIVA
            miCommand.Connection = miConexionSQL;
            // REM INDICO EL TIPO QUE SE PASARA EN COMMANDTEXT
            miCommand.CommandType = CommandType.Text;


            // REM CREO UN DATAREADER
            SqlDataAdapter dataAdapter = new SqlDataAdapter(miCommand);
            
            // REM CARGO EL DATATABLE PRODUCTOS A TRAVEZ DEL DATAREADER
            int rowsAffected = dataAdapter.UpdateBatchSize;
            this.desconectar();

            return rowsAffected;
        }

        public int insertarDatos(string query)
        {

            SqlCommand miCommand = new SqlCommand(string.Format(query), miConexionSQL);



            DataTable ds = new DataTable();
            // REM CONFIGURO EL OBJETO COMMAND
            this.conectar();
            // REM INDICO LA CONEXION ACTIVA
            miCommand.Connection = miConexionSQL;
            // REM INDICO EL TIPO QUE SE PASARA EN COMMANDTEXT
            miCommand.CommandType = CommandType.Text;


            // REM CREO UN DATAREADER
            SqlDataAdapter dataAdapter = new SqlDataAdapter(miCommand);

            // REM CARGO EL DATATABLE PRODUCTOS A TRAVEZ DEL DATAREADER
            int id = Convert.ToInt32(miCommand.ExecuteScalar());
            this.desconectar();

            return id;
        }

        public int ejecutarComandoSQL(string miCommand)
        {
            SqlCommand coman2 = new SqlCommand(string.Format(miCommand), miConexionSQL);
            return this.ejecutarComando(coman2);
        }
        public int ejecutarComando(SqlCommand miCommand)
        {
            DataTable ds = new DataTable();
            // REM CONFIGURO EL OBJETO COMMAND
            this.conectar();
            // REM INDICO LA CONEXION ACTIVA
            miCommand.Connection = miConexionSQL;
            // REM INDICO EL TIPO QUE SE PASARA EN COMMANDTEXT
            miCommand.CommandType = CommandType.Text;

            int rowsAffected = miCommand.ExecuteNonQuery();
            this.desconectar();

            return rowsAffected;
        }
        #endregion

        #region "Metodos"

        public SqlConnection conectar()
        {

            // INTENTO CONECTARME
            try
            {
                miConexionSQL.Open();

                // SI NO PUEDO, RETORNO FALSE
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return miConexionSQL;

        }

        public Boolean desconectar()
        {

            Boolean conexionOK = true;

            // INTENTO DESCONECTARME
            try
            {
                miConexionSQL.Close();

                // SI NO PUEDO, RETORNO FALSE
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexionOK = false;
            }

            return conexionOK;
        }
        #endregion

        ~ConexionSQL(){
            desconectar();
        }
    }
}