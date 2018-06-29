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

namespace FrbaHotel.RegistrarConsumible
{
    public partial class registrarConsumible : Form
    {
        int hotelid=1;
        public registrarConsumible()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelPrecioSugerido.Visible = false;
            /* CARGAR HABITACIONES */

            ConexionSQL c1 = new ConexionSQL();
            DataTable habitaciones = c1.cargarTablaSQL("select  distinct habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" +hotelid  + " order by numero asc" );
            habitaciones.Rows.InsertAt(habitaciones.NewRow(), 0);
            comboBoxHabitaciones.DataSource = habitaciones;
            comboBoxHabitaciones.SelectedIndex = 0;
            comboBoxHabitaciones.DisplayMember = "numero";
            comboBoxHabitaciones.ValueMember = "habitacion_id";

            /* CARGAR CONSUMIBLES */
            ConexionSQL c = new ConexionSQL();
            DataTable consumibles = c.cargarTablaSQL("select consumible_id, descripcion from WHERE_EN_EL_DELETE_FROM.consumibles");
            consumibles.Rows.InsertAt(consumibles.NewRow(), 0);
            comboBoxConsumible.DataSource = consumibles;
            comboBoxConsumible.SelectedIndex = 0;
            comboBoxConsumible.ValueMember = "consumible_id";
            comboBoxConsumible.DisplayMember = "descripcion";
        }

        private void comboBoxConsumible_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable precio = c.cargarTablaSQL("select precio from WHERE_EN_EL_DELETE_FROM.consumibles where consumible_id=" + comboBoxConsumible.SelectedValue);
            this.labelPrecioSugerido.Text = "USD" + precio.Rows[0].ItemArray[0].ToString();
            this.labelPrecioSugerido.Visible = true;
        }

        private void checkBoxMantenerPrecioSugerido_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMantenerPrecioSugerido.Checked) { textBoxPrecioSugerido.Enabled = false; textBoxPrecioSugerido.Text = this.labelPrecioSugerido.Text; } else 
            {
                textBoxPrecioSugerido.Enabled = true; textBoxPrecioSugerido.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int completo = 0;
            if (comboBoxHabitaciones.SelectedIndex.Equals(0))
            {
                this.labelHabitacion.Visible = true;
            }
            else {
                completo++; this.labelHabitacion.Visible = false;
            }

            if (comboBoxConsumible.SelectedIndex.Equals(0))
            {
                this.labelConsumible.Visible = true;
            }
            else { 
                completo++; this.labelConsumible.Visible = false; 
            }
            if (textBoxPrecioSugerido.Text.Equals(""))
            {
                this.labelPrecio.Visible = true;
            }
            else { completo++; this.labelPrecio.Visible = false; }

            if (completo.Equals(3)) 
            {
                SqlConnection sql = ConexionSQL.obtenerConexion();
                string insertConsumo = "insert into WHERE_EN_EL_DELETE_FROM.consumos values (@habitacion_id, @consumible_id, @estadia_id, @cantidad, @precio_unitario)";
                SqlCommand command = new SqlCommand(insertConsumo);
                command.Parameters.Add("@habitacion_id", SqlDbType.Int).Value = Int32.Parse(comboBoxHabitaciones.SelectedValue.ToString());
                command.Parameters.Add("@consumible_id", SqlDbType.Int).Value=Int32.Parse(comboBoxConsumible.SelectedValue.ToString());
              //  command.Parameters.Add("@estadia_id", SqlDbType.Int).Value = this.GetEstadia(Int32.Parse(comboBoxHabitaciones.SelectedValue.ToString()));

            }
        }

      
    }
}
