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
    public partial class modificarHabitacion : Form
    {
        public modificarHabitacion()
        {
            InitializeComponent();
        }

      

        private void modificarHabitacion_Load(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dt = c.cargarTablaSQL("select direccion, hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ");
            comboBoxHoteles.DataSource = dt;
            comboBoxHoteles.DisplayMember = "direccion";
            comboBoxHoteles.ValueMember = "hotel_id";

            DataTable dtpisos = c.cargarTablaSQL("select numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hoteles_id=" + this.comboBoxHoteles.SelectedValue + " order by numero asc");
            comboBoxNumeroHabitacion.DataSource = dtpisos;
            comboBoxNumeroHabitacion.DisplayMember = "numero";
            comboBoxNumeroHabitacion.ValueMember = "numero";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL con=new ConexionSQL();
            DataTable dtHabitacion = con.cargarTablaSQL("select numero, piso, convert(bit, frente) as Vista_Exterior, descripcion, convert(bit,habilitado) as Habilitado, tipos_id from WHERE_EN_EL_DELETE_FROM.habitaciones where numero=" + comboBoxNumeroHabitacion.SelectedValue + " and hoteles_id=" + comboBoxHoteles.SelectedValue);
            dataGridView1.DataSource = dtHabitacion;
            

            

        }
    }
}
