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
            //VALIDACION: si el cliente esta inhablitado, no lo dejo continuar.
            _cli = _cli.getClienteByTipoNroDocEmail(_idTipoDocumento, _nroDocumento, _email, "", "");

            if (_cli.idCliente != 0) {
                if (!_cli.habilitado)
                {
                    System.Windows.Forms.MessageBox.Show("Usted está inhabilitado, por lo que no puede realizar ninguna reserva. Para más información, contacte al responsable del hotel. ");
                    this.Close();
                }
            }
            

            //Lleno combo de tipo de documento
            cmbTiposDocumentos.Items.Add("DNI");
            cmbTiposDocumentos.Items.Add("Pasaporte");
            

            if (_cli.idCliente == 0) // es cliente nuevo
            {
                lblMensajeLoginORegister.Text = "Usted no está registrado como cliente. Complete sus datos: ";
                txtMail.Text = _email;
                cmbTiposDocumentos.SelectedValue = _idTipoDocumento;
                txtNroDocumento.Text = _nroDocumento;
            }
            else { 
                //prepopular campos con objeto cli
                lblMensajeLoginORegister.Text = "Usted ya es cliente del hotel. Puede modificar sus datos o directamente confirmar la reserva.";

                cmbTiposDocumentos.Text = _cli.tipoDocumento;
                txtNroDocumento.Text = _cli.nrodocumento;
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

            RegexUtilities regexValidator = new RegexUtilities();
            bool isValidEmail = true;
            if(txtMail.Text.Length > 0)
            {
                isValidEmail = regexValidator.IsValidEmail(txtMail.Text);
            }

            if (txtNroDocumento.Text.Length > 0 && txtMail.Text.Length > 0 && txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0
                        && txtDireccionCalle.Text.Length > 0 && txtDireccionNro.Text.Length > 0 
                        && txtDireccionPiso.Text.Length > 0 && txtDireccionDepto.Text.Length > 0)
            {
                if (isValidEmail)
                {
                    _cli.tipoDocumento = cmbTiposDocumentos.Text;
                    _cli.nrodocumento = txtNroDocumento.Text;
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

                    bool datosDuplicados = _cli.existeClientePorDatosUnicos();
                    if (!datosDuplicados)
                    {
                        int resultGuardarCliente = _cli.guardarCliente(_cli);

                        if (resultGuardarCliente != 0)
                        {
                            _res.cliente_id = _cli.idCliente;
                            frmConfirmarReserva frmConfirmarReserva = new frmConfirmarReserva(_cli, _res, null);
                            frmConfirmarReserva.Owner = this;
                            frmConfirmarReserva.Show();
                        }
                        else
                        {
                            //no se pudo grabar
                            this.UseWaitCursor = false;
                            System.Windows.Forms.MessageBox.Show("ERROR al intentar guardar datos. Reintente por favor.");
                            this.Hide();
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(this, "El mail y/o tipo+nro de documento que ha ingresado ya existen. Corrija los datos para poder continuar. ", "Error!");
                    }
                    

                }
                else {
                    System.Windows.Forms.MessageBox.Show("El mail tiene un formato incorrecto. Corríjalo para poder continuar. ");
                }
            }
            else {
                System.Windows.Forms.MessageBox.Show("Complete los datos obligatorios para poder continuar. ");
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
            ((GenerarReservaPrincipal)this.Owner).Close();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
