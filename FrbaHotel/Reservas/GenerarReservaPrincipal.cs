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
using FrbaHotel.Tools;


namespace FrbaHotel.Reservas
{
    public partial class GenerarReservaPrincipal: Form
    {

        private Reserva _reserva = null;
        public GenerarReservaPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void GenerarReservaPrincipal_Load(object sender, EventArgs e)
        {

            if (_reserva != null)
            {
                this.lblHotel.Text += (new Hotel()).getNombreById(_reserva.hotel_id);
                this.lblFechaDesde.Text += _reserva.fecha_desde.ToShortDateString();
                this.lblFechaHasta.Text += _reserva.fecha_hasta.ToShortDateString();
                this.lblTipoRegimen.Text += (new TipoRegimen()).getDescripcionById(_reserva.regimen_id);
                this.lblPrecioTotal.Text = _reserva.total.ToString();
                /*
                this.lblHotel.Text = this.lblHotel.Text.Replace("{hotel}", (new Hotel()).getNombreById(_reserva.hotel_id));
                this.lblFechaDesde.Text = this.lblFechaDesde.Text.Replace("{checkin}", _reserva.fecha_desde.ToShortDateString());
                this.lblFechaHasta.Text = this.lblFechaHasta.Text.Replace("{checkout}", _reserva.fecha_hasta.ToShortDateString());
                this.lblTipoRegimen.Text = this.lblTipoRegimen.Text.Replace("{regimen}", (new TipoRegimen()).getDescripcionById(_reserva.regimen_id));
                this.lblPrecioTotal.Text =  _reserva.total.ToString();
                */

                String strHabitaciones = String.Empty;
                foreach (Habitacion hab in _reserva.habitaciones)
                {
                    strHabitaciones += hab.numero.ToString() + ", ";
                }
                txtNrosHabitaciones.Text = strHabitaciones.Substring(0, strHabitaciones.Length - 2);
            }
            else { 
                //apenas entra al form
                cmbTiposDocumentos.Items.Add("DNI");
                cmbTiposDocumentos.Items.Add("Pasaporte");
            }
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void pasarReserva(Reserva res) {
            this._reserva = res;
        }

        private void btnBuscarHabitaciones_Click(object sender, EventArgs e)
        {
            FormSeleccionarHabitaciones f2 = null;

            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] is FormSeleccionarHabitaciones)
                {
                    f2 = (FormSeleccionarHabitaciones) Application.OpenForms[i];
                    break;
                }
            }

            if (f2 == null)
                f2 = new FormSeleccionarHabitaciones();
            f2.Owner = this;
            f2.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Armar objeto reserva con datos que tengo, tanto:
            // (A) si es nuevo (nro habitacion, tipo de regimen, hotel, fdesde, fhasta, clienteId)
            // (B) si lo está modificando (nro de reserva)

            RegexUtilities regexValidator = new RegexUtilities();
            bool isValidEmail = true;
            if(txtMail.Text.Length > 0)
            {
                isValidEmail = regexValidator.IsValidEmail(txtMail.Text);
            }
            
            if ((txtNroDocumento.Text.Length > 0 || txtMail.Text.Length > 0) && txtNrosHabitaciones.Text.Length > 0)
            {
                if (isValidEmail)
                {
                    Cliente cli = new Cliente();

                    IdentificarUsuarioExtendido frmUsuExtendido = new IdentificarUsuarioExtendido(_reserva, cmbTiposDocumentos.SelectedText,
                                                                                    txtNroDocumento.Text,
                                                                                    txtMail.Text);
                    frmUsuExtendido.Owner = this;
                    frmUsuExtendido.Show();
                }
                else {
                    System.Windows.Forms.MessageBox.Show("Debe completar nro documento o mail para poder continuar. ");
                }
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Debe completar nro documento o mail para poder continuar. ");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
