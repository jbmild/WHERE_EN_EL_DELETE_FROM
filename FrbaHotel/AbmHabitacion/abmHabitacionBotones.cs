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
    public partial class abmHabitacionBotones : Form
    {
        public abmHabitacionBotones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            altaHabitacion aHab = new altaHabitacion();
            aHab.Show();
        }

        private void btnBajaHabitacion_Click(object sender, EventArgs e)
        {
            darBajaHabitacion bHab = new darBajaHabitacion();
            bHab.Show();
        }

        private void btnEditarHabitacion_Click(object sender, EventArgs e)
        {
            modificarHabitacion mHab = new modificarHabitacion();
            mHab.Show();
        }
    }
}
