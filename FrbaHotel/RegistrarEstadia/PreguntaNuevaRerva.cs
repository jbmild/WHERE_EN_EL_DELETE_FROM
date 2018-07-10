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
    public partial class PreguntaNuevaRerva : Form
    {
        public PreguntaNuevaRerva()
        {
            InitializeComponent();
        }

        private void PreguntaNuevaRerva_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Si
            Reservas.GenerarReservaPrincipal generarReservaPrincipal = new Reservas.GenerarReservaPrincipal();
            generarReservaPrincipal.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //No
            Bienvenido bienvenido = new Bienvenido();
            this.Hide();
            bienvenido.Show();
        }
    }
}
