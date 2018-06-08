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
    public partial class IdentificarUsuarioExtendido : Form
    {
        private Reserva _res;
        //private int _idCliente;
        private Cliente _cli;
        private int _idTipoDocumento;
        private string _nroDocumento;
        private string _email;

        public IdentificarUsuarioExtendido(int idCliente)
        {
            InitializeComponent();
        }

        public IdentificarUsuarioExtendido(Reserva reserva, int idTipoDocumento, string nroDocumento, string email)
        {
            InitializeComponent();
            _cli = new Cliente();
            _cli.idCliente = 0;
            _res = reserva;
            _idTipoDocumento = idTipoDocumento;
            _nroDocumento = nroDocumento;
            _email = email;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lleno combo de tipo de documento
            cmbTiposDocumentos.Items.Add("DNI");
            cmbTiposDocumentos.Items.Add("Pasaporte");
            
            
            //Si el atributo reserva != NULL, es porque viene de una reserva.
            //Si atributo reserva == NULL, es ABM de clientes.
            
            
            
            _cli = _cli.getClienteByTipoNroDocEmail(Convert.ToInt32(_idTipoDocumento), _nroDocumento, _email);

            if (_cli.idCliente == 0) // es cliente nuevo
            {
                lblMensajeLoginORegister.Text = "Usted no está registrado como cliente. Complete sus datos: ";
            }
            else { 
                //prepopular campos con objeto cli
                lblMensajeLoginORegister.Text = "Usted ya es cliente del hotel. Puede modificar sus datos o directamente confirmar la reserva.";

                cmbTiposDocumentos.SelectedIndex = _idTipoDocumento;
                TxtNroDocumento.Text = _cli.nrodocumento;
                txtNombre.Text = _cli.nombre;
                txtApellido.Text = _cli.apellido;
                txtNacionalidad.Text = _cli.nacionalidad;
                txtMail.Text = _cli.email;
                txtDireccionCalle.Text = _cli.direccion_calle;
                txtDireccionNro.Text = _cli.direccion_numero;
                txtDireccionPiso.Text = _cli.direccion_piso;
                txtDireccionDepto.Text = _cli.direccion_depto;
                txtTelefono.Text = _cli.telefono;
                txtLocalidad.Text = _cli.direccion_localidad;
                txtPaisVivienda.Text = _cli.direccion_pais;

            }


        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

            if (_cli.idCliente == 0)
            {
                //Registro nuevo cliente
            }
            else { 
                //UPDATE cliente existente

                //TODO: agregar tipo documento cuando se agregue en la tabla
                TxtNroDocumento.Text = _cli.nrodocumento;
                txtNombre.Text = _cli.nombre;
                txtApellido.Text = _cli.apellido;
                txtNacionalidad.Text = _cli.nacionalidad;
                txtMail.Text = _cli.email;
                txtDireccionCalle.Text = _cli.direccion_calle;
                txtDireccionNro.Text = _cli.direccion_numero;
                txtDireccionPiso.Text = _cli.direccion_piso;
                txtDireccionDepto.Text = _cli.direccion_depto;
                txtTelefono.Text = _cli.telefono;
                txtLocalidad.Text = _cli.direccion_localidad;
                txtPaisVivienda.Text = _cli.direccion_pais;

            }
            
            frmConfirmarReserva frmConfirmarReserva = new frmConfirmarReserva();
            frmConfirmarReserva.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
