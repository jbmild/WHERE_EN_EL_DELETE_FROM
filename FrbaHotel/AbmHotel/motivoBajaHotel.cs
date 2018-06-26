using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class motivoBajaHotel : Form
    {
        DateTime fechaIn;
        DateTime fechaOut;
        int hotelID;
        public motivoBajaHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = ConexionSQL.obtenerConexion();
            string insertCeseActividad = "insert into WHERE_EN_EL_DELETE_FROM.cese_actividades (hotel_id, fecha_inicio, fecha_fin, titulo, descripcion)";
            insertCeseActividad += " values(@hotel_id, @fecha_inicio, @fecha_fin, @titulo, @descripcion)";
            SqlCommand sql = new SqlCommand(insertCeseActividad);
            sql.Connection = c;
            sql.Parameters.Add("@hotel_id", SqlDbType.Int).Value = hotelID;
            sql.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fechaIn;
            sql.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fechaOut;
            sql.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = textBoxTitulo.Text;
            sql.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = textBoxDetalle.Text;
            int result = sql.ExecuteNonQuery();
            if (result.Equals(1))
            {
                System.Windows.Forms.MessageBox.Show("¡Se ha añadido un nuevo cese de actividad!");
            }
            else { System.Windows.Forms.MessageBox.Show("Error al intentar añadir un nuevo cese de actividad"); }
        }

        internal void RecibirDatosBaja(DateTime dateTime1, DateTime dateTime2, string _hotelID)
        {
            fechaIn = dateTime1;
            fechaOut = dateTime2;
            hotelID = Int32.Parse(_hotelID);
        }
    }
}
