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
    public partial class frmConfirmarReserva : Form
    {

        private Cliente _cliente;
        private Reserva _reserva;

        public frmConfirmarReserva(Cliente cli, Reserva res)
        {
            _cliente = cli;
            _reserva = res;
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
            lblDatosCliente.Text = lblDatosCliente.Text.Replace("{cliente}", _cliente.apellido + " " + 
                                    _cliente.nombre);
            string strDatosReserva = lblDatosReserva.Text;
            Hotel hotel = new Hotel();
            TipoRegimen tipoRegimen = new TipoRegimen();
            strDatosReserva = strDatosReserva.Replace("{checkin}", _reserva.fecha_desde.ToShortDateString());
            strDatosReserva = strDatosReserva.Replace("{checkout}", _reserva.fecha_hasta.ToShortDateString());
            strDatosReserva = strDatosReserva.Replace("{hotel}", hotel.getNombreById(_reserva.hotel_id));
            strDatosReserva = strDatosReserva.Replace("{regimen}", tipoRegimen.getDescripcionById(_reserva.regimen_id));
            lblDatosReserva.Text = strDatosReserva;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            int exito = 0;

            try
            {
                exito = _reserva.GuardarReserva();
            }
            catch (Exception ex){
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            if (exito != 0)
            {
                string mensajeExito = "La reserva y los datos del cliente han sido guardados. Codigo reserva: {codigo}. Hasta pronto!";
                mensajeExito = mensajeExito.Replace("{codigo}", _reserva.codigo);
                System.Windows.Forms.MessageBox.Show("La reserva y los datos del cliente han sido guardados. Codigo reserva: {codigo}. Hasta pronto!");
            }
            else {
                System.Windows.Forms.MessageBox.Show("Se ha producido un error. Intente realizar la reserva nuevamente. ");
            }
            
        }
    }
}
