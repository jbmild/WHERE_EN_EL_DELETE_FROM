using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuarios
{
    public partial class ModificarUsuario : Form
    {
        Usuarios _usuariosPantalla;
        string usuario;
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        internal void RecibirDatosUsuario(string usu, string rol, string nombre, string apellido, string dirCalle, string dirNro, string dirDepto, string dirLocalidad,
            string dirPais, string docTipo, string docNro, string mail, string tel, Usuarios usuariosPantalla)
        {
            this.textBoxApellido.Text = apellido;
            this.textBoxUsuario.Text = usu;
            this.textBoxNombre.Text = nombre;
            this.textBoxDireccion.Text = dirCalle;
            this.textBoxNumero.Text = dirNro;
            this.textBoxDepto.Text = dirDepto;
            this.textBoxLocalidad.Text = dirLocalidad;
            this.textBoxPais.Text = dirPais;
            this.textBoxTipoDOC.Text = docTipo;
            this.textBoxNumeroDOC.Text = docNro;
            this.textBoxMail.Text = mail;
            this.textBoxTelefono.Text = tel;
            this._usuariosPantalla = usuariosPantalla;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.labelConfirmarPass.Visible.Equals(true))
            {
                if (this.textBoxPassword.Text.Equals(this.textBoxConfirmarPass.Text) && this.textBoxPassword.Text!= "")
                {
                    this.GuardarCambios(usuario, this, _usuariosPantalla);
                }
                else
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden o no ha escrito ninguna");
                }
            }
            else 
            {
                this.GuardarCambios(usuario, this, _usuariosPantalla); 
            }
        }

        private void GuardarCambios(string user, ModificarUsuario pantalla, Usuarios usuariosPantalla)
        {
            ModificarUsuarioObject modificar = new ModificarUsuarioObject();
            modificar.GuardarDatos(this.textBoxApellido.Text, this.textBoxConfirmarPass.Text, this.textBoxDepto.Text, this.textBoxDireccion.Text, this.textBoxLocalidad.Text,
                this.textBoxMail.Text, this.textBoxNombre.Text, this.textBoxNumero.Text, this.textBoxNumeroDOC.Text, this.textBoxPais.Text, this.textBoxPassword.Text,
                 this.textBoxPiso.Text, this.textBoxTelefono.Text, this.textBoxTipoDOC.Text, this.textBoxUsuario.Text, user, pantalla, usuariosPantalla, this.listBoxRolesFinales);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxPassword.Text.Equals("")) { this.labelConfirmarPass.Visible = false; this.textBoxConfirmarPass.Visible = false; } else 
            {
                this.labelConfirmarPass.Visible = true; this.textBoxConfirmarPass.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.labelContraseña.Visible = true;
            this.labelConfirmarPass.Visible = true;
            this.textBoxPassword.Visible = true;
            this.textBoxConfirmarPass.Visible = true;
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            this.usuario = textBoxUsuario.Text;
            ElegirRolesModificarUsuario buscarRoles = new ElegirRolesModificarUsuario();
            buscarRoles.BuscarRolesParaModificar(this.listBoxRolesFinales, this.usuario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBoxApellido.Text = "";
            this.textBoxConfirmarPass.Text = "";
            this.textBoxDepto.Text = "";
            this.textBoxDireccion.Text = "";
            this.textBoxLocalidad.Text = "";
            this.textBoxMail.Text = "";
            this.textBoxNombre.Text = "";
            this.textBoxNumero.Text = "";
            this.textBoxNumeroDOC.Text = "";
            this.textBoxPais.Text = "";
            this.textBoxPassword.Text = "";
            this.textBoxPiso.Text = "";
            this.textBoxTelefono.Text = "";
            this.textBoxTipoDOC.Text = "";
            
        }

        private void textBoxNumeroDOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void textBoxPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ElegirRolesModificarUsuario elegirRoles = new ElegirRolesModificarUsuario();
            elegirRoles.RecibirRolesActuales(this.listBoxRolesFinales, this);
            elegirRoles.ShowDialog();
        }

        internal void RecibirRolesActualizados(ListBox listBox)
        {
            this.listBoxRolesFinales.Items.Clear();
            foreach (var item in listBox.Items) 
            {
                this.listBoxRolesFinales.Items.Add(item);
            }
        }
    }
}
