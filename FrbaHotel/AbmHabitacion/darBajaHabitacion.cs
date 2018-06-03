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

namespace FrbaHotel.AbmHabitacion
{
    public partial class darBajaHabitacion : Form
    {
        public darBajaHabitacion()
        {
            InitializeComponent();
        }

        private void darBajaHabitacion_Load(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dtHoteles = c.cargarTablaSQL("select direccion, hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ");
            comboBoxHoteles.DataSource = dtHoteles;
            comboBoxHoteles.DisplayMember = "direccion";
            comboBoxHoteles.ValueMember = "hotel_id";

            
            DataTable dtHabitaciones = c.cargarTablaSQL("select numero from WHERE_EN_EL_DELETE_FROM.habitaciones ha" +
                " JOIN WHERE_EN_EL_DELETE_FROM.hoteles ho on ha.hoteles_id=ho.hotel_id and ho.hotel_id='" + comboBoxHoteles.SelectedValue + "'" +
                " order by 1 asc");
            comboBoxNumeroHabitacion.DataSource = dtHabitaciones;
            comboBoxNumeroHabitacion.DisplayMember = "numero";
            comboBoxNumeroHabitacion.ValueMember = "numero";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gd2018");
            con1.Open();
            string up = "UPDATE WHERE_EN_EL_DELETE_FROM.habitaciones set habilitado=@value where numero= @habitacion and hoteles_id=@hotel";
            SqlCommand sqlQuery = new SqlCommand(up);
            sqlQuery.Connection = con1;
            sqlQuery.Parameters.Add("@habitacion", SqlDbType.Int).Value = comboBoxNumeroHabitacion.SelectedValue;
            sqlQuery.Parameters.Add("@value", SqlDbType.Bit).Value = 0;
            sqlQuery.Parameters.Add("@hotel", SqlDbType.Int).Value = comboBoxHoteles.SelectedValue;
            int busqueda = sqlQuery.ExecuteNonQuery();
            if (busqueda.Equals(1))
            {
                labelInhabilitada.Visible = true;
            }
            else 
            {
                labelErrorInhabilitar.Visible = true;   
            }

        }
    }
}
