using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Modelo;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarReservaPrincipal: Form
    {

        private Reserva reserva = null;
        public GenerarReservaPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            ConexionSQL sql = new ConexionSQL();  
            this.lblHotel.Text = this.reserva.hotel_id
             */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void pasarReserva(Reserva res) {
            this.reserva = res;
        }

        private void btnBuscarHabitaciones_Click(object sender, EventArgs e)
        {
            FormGenerarModificarReserva f2 = null;

            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] is FormGenerarModificarReserva)
                {
                    f2 = (FormGenerarModificarReserva) Application.OpenForms[i];
                    break;
                }
            }

            if (f2 == null)
                f2 = new FormGenerarModificarReserva();

            f2.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Armar objeto reserva con datos que tengo, tanto:
            // (A) si es nuevo (nro habitacion, tipo de regimen, hotel, fdesde, fhasta, clienteId)
            // (B) si lo está modificando (nro de reserva)
            IdentificarUsuarioExtendido form = new IdentificarUsuarioExtendido(1); // va a romper.
            form.Show();
        }
    }
}
