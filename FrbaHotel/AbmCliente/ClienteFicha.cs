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

namespace FrbaHotel.AbmCliente
{
    public partial class ClienteFicha : Form
    {
        private Reserva _res;
        //private int _idCliente;
        private Cliente _cli;
        private string _idTipoDocumento;
        private string _nroDocumento;
        private string _email;
        private bool _returnToCheckInFunctionality = false;

        public ClienteFicha(bool returnToCheckInFunctionality) {
            _returnToCheckInFunctionality = returnToCheckInFunctionality;
            _cli = new Cliente(0);
            InitializeComponent();
        }


        public ClienteFicha(Cliente cli) {
            _cli = cli;
            InitializeComponent();
        }

        public ClienteFicha()
        {
            _cli = new Cliente(0);
            InitializeComponent();

        }

        public ClienteFicha(int idCliente)
        {
            _cli = new Cliente(idCliente);
            InitializeComponent();
            
        }

        public ClienteFicha(Reserva reserva, string idTipoDocumento, string nroDocumento, string email)
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


            if (_cli.idCliente == 0) // es cliente nuevo
            {
                lblMensajeLoginORegister.Text = "Complete sus datos: ";
                txtMail.Text = _email;
                cmbTiposDocumentos.SelectedValue = _idTipoDocumento;
                txtNroDocumento.Text = _nroDocumento;
            }
            else
            {
                //prepopular campos con objeto cli
                lblMensajeLoginORegister.Text = "Modifique los datos del cliente a continuación.";

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
                chkRehabilitar.Checked = _cli.habilitado;

                if (!_cli.habilitado)
                {
                    lblMensajeLoginORegister.Text = "El cliente está inhabilitado. Puede rehabilitarlo haciendo click en el checkbox. ";
                    lblMensajeLoginORegister.ForeColor = Color.Red;
                    chkRehabilitar.Visible = true;
                    habilitarCampos(false);
                }


            }


        }

        private void habilitarCampos(bool habilitar){
            cmbTiposDocumentos.Enabled = txtNroDocumento.Enabled = txtNombre.Enabled = txtApellido.Enabled =
                    txtNacionalidad.Enabled = txtMail.Enabled = txtDireccionCalle.Enabled = txtDireccionNro.Enabled =
                    txtDireccionPiso.Enabled = txtDireccionDepto.Enabled = txtTelefono.Enabled = txtLocalidad.Enabled =
                    txtPaisVivienda.Enabled = btnGuardar.Enabled = habilitar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                    _cli.habilitado = chkRehabilitar.Checked;
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
                        int idCliente = _cli.guardarCliente(_cli);

                        if (idCliente != 0)
                        {
                            System.Windows.Forms.MessageBox.Show("El cliente ha sido guardado exitosamente. ");
                            this.Close();
                            if (_returnToCheckInFunctionality) { 
                                //TODO: @Juanma: volver a pantalla de checkin, devolver variable idCliente
                            }
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
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkRehabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRehabilitar.Checked)
            {
                habilitarCampos(true);
            }
            else {
                habilitarCampos(false);
            }

        }
    }
}
