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
        string usuario;
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        internal void RecibirDatosUsuario(string usu, string rol, string nombre, string apellido, string dirCalle, string dirNro, string dirDepto, string dirLocalidad,
            string dirPais, string docTipo, string docNro, string mail, string tel)
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.labelConfirmarPass.Visible.Equals(true))
            {
                if (this.textBoxPassword.Text.Equals(this.textBoxConfirmarPass.Text))
                {
                    this.GuardarCambios(usuario);
                }
                else
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden. Por favor, corríjalas");
                }
            }
            else 
            {
                this.GuardarCambios(usuario); 
            }
        }

        private void GuardarCambios(string user)
        {
            ModificarUsuarioObject modificar = new ModificarUsuarioObject();
            modificar.GuardarDatos(this.textBoxApellido.Text, this.textBoxConfirmarPass.Text, this.textBoxDepto.Text, this.textBoxDireccion.Text, this.textBoxLocalidad.Text,
                this.textBoxMail.Text, this.textBoxNombre.Text, this.textBoxNumero.Text, this.textBoxNumeroDOC.Text, this.textBoxPais.Text, this.textBoxPassword.Text,
                 this.textBoxPiso.Text, this.textBoxTelefono.Text, this.textBoxTipoDOC.Text, this.textBoxUsuario.Text, user);
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
        }
    }
}
