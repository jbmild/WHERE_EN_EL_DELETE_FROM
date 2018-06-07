using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmRegimen.ABM_regimen regimen = new AbmRegimen.ABM_regimen();
            regimen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.FormGenerarModificarReserva formReserva = new GenerarModificacionReserva.FormGenerarModificarReserva();
            formReserva.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmHabitacion.abmHabitacionBotones formHabitacion = new AbmHabitacion.abmHabitacionBotones();
           formHabitacion.Show();
        }
    }
}
