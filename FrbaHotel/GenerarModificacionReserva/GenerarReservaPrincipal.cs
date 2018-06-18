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

        public void GenerarReservaPrincipal_Load(object sender, EventArgs e)
        {
            if (reserva != null) {
                this.lblHotel.Text = this.lblHotel.Text.Replace("{hotel}", (new Hotel()).getNombreById(reserva.hotel_id));
                this.lblFechaDesde.Text = this.lblFechaDesde.Text.Replace("{checkin}", reserva.fecha_desde.ToShortDateString());
                this.lblFechaHasta.Text = this.lblFechaHasta.Text.Replace("{checkout}", reserva.fecha_hasta.ToShortDateString());
                this.lblTipoRegimen.Text = this.lblTipoRegimen.Text.Replace("{regimen}", (new TipoRegimen()).getDescripcionById(reserva.regimen_id));
                
                String strHabitaciones = String.Empty;
                foreach (Habitacion hab in reserva.habitaciones) {
                    strHabitaciones += hab.numero.ToString() + ", ";
                }
                txtNrosHabitaciones.Text = strHabitaciones.Substring(0, strHabitaciones.Length - 2);
                
            }
            
            
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
            f2.Owner = this;
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
