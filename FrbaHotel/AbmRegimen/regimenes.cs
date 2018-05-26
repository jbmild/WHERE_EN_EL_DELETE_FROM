using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel.AbmRegimen
{
    class Regimenes
    {
        public static DataTable buscarRegimenes()
        {

            List<Regimenes> Lista = new List<Regimenes>();

            using (SqlConnection conexion = ConexionSQL.obtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM [WHERE_EN_EL_DELETE_FROM].[regimenes]", conexion));

                /*SqlDataReader reader = comando.ExecuteReader();*/

                DataTable ds = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

                dataAdapter.Fill(ds);

                conexion.Close();

                return ds;

            }

        }
    }
}
