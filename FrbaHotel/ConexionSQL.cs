using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace FrbaHotel
{
    class ConexionSQL
    {

        private SqlConnection miConexionSQL;
        private String miConnectionStringSQL;

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
            miConexionSQL = new SqlConnection();

            /*se usa para las conexiones tcp/ip*/
            string gd20 = "Data Source=SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gd2018;Password=gd2018";

            /*se usa para las conexiones locales*/
            //string gd20 = "Data source=.\\SQLSERVER2012; Initial Catalog=GD1C2018;User Id=gd2018; Password=gd2018";

            miConnectionStringSQL = gd20;
            miConexionSQL.ConnectionString = miConnectionStringSQL;
        }

        public ConexionSQL(String _connectionString)
        {
            miConexionSQL = new SqlConnection();
            miConnectionStringSQL = _connectionString;
            miConexionSQL.ConnectionString = miConnectionStringSQL;
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
    }
}