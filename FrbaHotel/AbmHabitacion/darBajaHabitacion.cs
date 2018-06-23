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
            dtHoteles.Rows.InsertAt(dtHoteles.NewRow(), 0);
            comboBoxHoteles.DataSource = dtHoteles;
            comboBoxHoteles.SelectedIndex = 0;
            comboBoxHoteles.DisplayMember = "direccion";
            comboBoxHoteles.ValueMember = "hotel_id";


            DataTable dtHabitaciones = c.cargarTablaSQL("select numero, habitacion_id from WHERE_EN_EL_DELETE_FROM.habitaciones ha" +
                " JOIN WHERE_EN_EL_DELETE_FROM.hoteles ho on ha.hotel_id=ho.hotel_id and ho.hotel_id='" + comboBoxHoteles.SelectedValue + "'" +
                " order by 1 asc");
            comboBoxNumeroHabitacion.DataSource = dtHabitaciones;
            comboBoxNumeroHabitacion.DisplayMember = "numero";
            comboBoxNumeroHabitacion.ValueMember = "habitacion_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool habi = false; bool hotel = false;
            if (this.comboBoxNumeroHabitacion.Text.Equals(""))
            {
                this.labelNumeroVacio.Visible = true;
            }
            else 
            {
                this.labelNumeroVacio.Visible = false;
                habi = true; }
            if(this.comboBoxHoteles.Text.Equals(""))
            {
                this.labelHotelVacio.Visible = true;
            }else{
                hotel=true;
                this.labelHotelVacio.Visible = false;
            }
            if (habi.Equals(true) && hotel.Equals(true))
            {
                this.labelHotelVacio.Visible = false;
                this.labelNumeroVacio.Visible = false;
                SqlConnection con1 = new SqlConnection("Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gd2018");
                con1.Open();
                string up = "UPDATE WHERE_EN_EL_DELETE_FROM.habitaciones set habilitado=@value where habitacion_id=@habitacion";
                SqlCommand sqlQuery = new SqlCommand(up);
                sqlQuery.Connection = con1;
                sqlQuery.Parameters.Add("@habitacion", SqlDbType.Int).Value = comboBoxNumeroHabitacion.SelectedValue;
                sqlQuery.Parameters.Add("@value", SqlDbType.Bit).Value = 0;
                //sqlQuery.Parameters.Add("@hotel", SqlDbType.Int).Value = comboBoxHoteles.SelectedValue;
                int busqueda = sqlQuery.ExecuteNonQuery();
                if (busqueda.Equals(1))
                {
                  //  labelInhabilitada.Visible = true;
                    System.Windows.Forms.MessageBox.Show("¡Habitación inhabilitada con éxito!");
                    this.Hide();
                }
                else
                {
                    labelErrorInhabilitar.Visible = true;
                }

            }  
            
        }

        private void comboBoxHoteles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.comboBoxHoteles.SelectedValue.ToString() != "")
            {
                this.comboBoxNumeroHabitacion.Enabled = true;

                ConexionSQL c = new ConexionSQL();
                DataTable dthabi = c.cargarTablaSQL("select numero, habitacion_id from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + comboBoxHoteles.SelectedValue + " order by numero asc");
                comboBoxNumeroHabitacion.DataSource = dthabi;
                dthabi.Rows.InsertAt(dthabi.NewRow(), 0);
                comboBoxNumeroHabitacion.DisplayMember = "numero";
                comboBoxNumeroHabitacion.SelectedIndex = 0;
                comboBoxNumeroHabitacion.ValueMember = "habitacion_id";

            }
        }

        private void comboBoxNumeroHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
