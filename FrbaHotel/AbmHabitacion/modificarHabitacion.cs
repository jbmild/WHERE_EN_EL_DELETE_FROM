using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dt = c.cargarTablaSQL("select nombre, hotel_id WHERE_EN_EL_DELETE_FROM.hoteles ");
            comboBoxHoteles.DataSource = dt;
            comboBoxHoteles.DisplayMember = "nombre";
            comboBoxHoteles.ValueMember = "hotel_id";
        }
    }
}
