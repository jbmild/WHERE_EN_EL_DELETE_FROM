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
        private string _idTipoDocumento;
        private string _nroDocumento;
        private string _email;

        public IdentificarUsuarioExtendido(int idCliente)
        {
            InitializeComponent();
        }

        public IdentificarUsuarioExtendido(Reserva reserva, string idTipoDocumento, string nroDocumento, string email)
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
            
            
            
            _cli = _cli.getClienteByTipoNroDocEmail(_idTipoDocumento, _nroDocumento, _email);

            if (_cli.idCliente == 0) // es cliente nuevo
            {
                lblMensajeLoginORegister.Text = "Usted no está registrado como cliente. Complete sus datos: ";
                txtMail.Text = _email;
                cmbTiposDocumentos.SelectedValue = _idTipoDocumento;
                TxtNroDocumento.Text = _nroDocumento;
            }
            else { 
                //prepopular campos con objeto cli
                lblMensajeLoginORegister.Text = "Usted ya es cliente del hotel. Puede modificar sus datos o directamente confirmar la reserva.";

                cmbTiposDocumentos.Text = _cli.tipoDocumento;
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
                _res.cliente_id = _cli.idCliente;

            }


        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

            

            //TODO: agregar tipo documento cuando se agregue en la tabla
            _cli.tipoDocumento = cmbTiposDocumentos.Text;
            _cli.nrodocumento = TxtNroDocumento.Text;
            _cli.nombre = txtNombre.Text;
            _cli.apellido = txtApellido.Text;
            _cli.nacionalidad = txtNacionalidad.Text;
            _cli.email = txtMail.Text;
            _cli.direccion_calle = txtDireccionCalle.Text;
            _cli.direccion_numero = txtDireccionNro.Text;
            _cli.direccion_piso = txtDireccionPiso.Text;
            _cli.direccion_depto = txtDireccionDepto.Text;
            _cli.telefono = txtTelefono.Text;
            _cli.direccion_localidad = txtLocalidad.Text;
            _cli.direccion_pais = txtPaisVivienda.Text;

            int resultGuardarCliente = _cli.guardarCliente(_cli);

            if (resultGuardarCliente != 0)
            {
                _cli.idCliente = _res.cliente_id = resultGuardarCliente;
                frmConfirmarReserva frmConfirmarReserva = new frmConfirmarReserva(_cli, _res);
                frmConfirmarReserva.Show();
            }
            else {
                //no se pudo grabar
                this.UseWaitCursor = false;
                System.Windows.Forms.MessageBox.Show("ERROR al intentar guardar datos. Reintente por favor.");
                this.Hide();
            }

            
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
