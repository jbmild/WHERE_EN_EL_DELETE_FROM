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

namespace FrbaHotel.Reservas
{
    public partial class frmConfirmarReserva : Form
    {

        private Cliente _cliente;
        private Reserva _reserva;
        private List<Habitacion> _habitacionesUpdate = null;

        public frmConfirmarReserva(Cliente cli, Reserva res, List<Habitacion> habitacionesUpdate)
        {
            _cliente = cli;
            _reserva = res;
            _habitacionesUpdate = habitacionesUpdate;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmConfirmarReserva_Load(object sender, EventArgs e)
        {
            
            lblDatosCliente.Text = lblDatosCliente.Text.Replace("{cliente}", _cliente.apellido.ToUpper() + ", " + 
                                    _cliente.nombre.ToUpper());
            string strDatosReserva = lblDatosReserva.Text;
            Hotel hotel = new Hotel();
            TipoRegimen tipoRegimen = new TipoRegimen();
            strDatosReserva = strDatosReserva.Replace("{checkin}", _reserva.fecha_desde.ToShortDateString());
            strDatosReserva = strDatosReserva.Replace("{checkout}", _reserva.fecha_hasta.ToShortDateString());
            strDatosReserva = strDatosReserva.Replace("{hotel}", hotel.getNombreById(_reserva.hotel_id));
            strDatosReserva = strDatosReserva.Replace("{regimen}", tipoRegimen.getDescripcionById(_reserva.regimen_id));
            lblDatosReserva.Text = strDatosReserva;
            lblPrecioTotal.Text = "USD " + _reserva.total.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            int codigoReserva = 0;

            try
            {
                //eliminar habitaciones
                _reserva.eliminarHabitaciones();
                codigoReserva = _reserva.GuardarReserva(_habitacionesUpdate);
            }
            catch (Exception ex){
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            if (codigoReserva != 0)
            {
                _reserva.codigo = codigoReserva;
                string mensajeExito = "La reserva y los datos del cliente han sido guardados. Codigo reserva: {codigo}. Hasta pronto!";
                mensajeExito = mensajeExito.Replace("{codigo}", _reserva.codigo.ToString());
                System.Windows.Forms.MessageBox.Show(mensajeExito);
                volverAMenuPrincipal();
            }
            else {
                System.Windows.Forms.MessageBox.Show("Se ha producido un error. Intente realizar la reserva nuevamente. ");
            }
            
        }

        private void volverAMenuPrincipal() {
            ((this.Owner).Owner).Close();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            volverAMenuPrincipal();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
