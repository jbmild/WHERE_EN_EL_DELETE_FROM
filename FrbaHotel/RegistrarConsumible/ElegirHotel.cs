using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class ElegirHotel : Form
    {
        public ElegirHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxHabitaciones.SelectedIndex.Equals(0)) { }
            {
                RegistrarConsumible.registrarConsumible r = new RegistrarConsumible.registrarConsumible();
                r.RecibirHotel(FrbaHotel.Tools.Sesion.hotel.Nombre, FrbaHotel.Tools.Sesion.hotel.HotelId, Int32.Parse(comboBoxHabitaciones.SelectedValue.ToString()));
                r.ShowDialog(this);
            }
        }

        private void ElegirHotel_Load(object sender, EventArgs e)
        {
            ConexionSQL c1 = new ConexionSQL();
            DataTable habitaciones = c1.cargarTablaSQL("select  distinct habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + FrbaHotel.Tools.Sesion.hotel.HotelId + " order by numero asc");
            habitaciones.Rows.InsertAt(habitaciones.NewRow(), 0);
            comboBoxHabitaciones.DataSource = habitaciones;
            comboBoxHabitaciones.SelectedIndex = 0;
            comboBoxHabitaciones.DisplayMember = "numero";
            comboBoxHabitaciones.ValueMember = "habitacion_id";
        }
    }
}
