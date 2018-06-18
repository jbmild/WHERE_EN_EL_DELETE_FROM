using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class CheckIn : Form
    {
        String numeroDeReserva;
        DateTime fechaDesde;
        public CheckIn()
        {
            InitializeComponent();

            numeroDeReserva = nroreserva.Text;
            fechaDesde = fechaingreso.Value.Date;
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton aceptar
            MessageBox.Show("Fecha es" + fechaDesde.ToString(), fechaDesde.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //datos reserva
            //numeroDeReserva = nroreserva.Text;
            //fechaDesde = fechaingreso.Value.Date;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
