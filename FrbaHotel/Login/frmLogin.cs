using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using FrbaHotel.Login.Modelo;
using FrbaHotel.Tools;


namespace FrbaHotel.Login
{
    public partial class frmLogin : Form
    {
        private string username, contrasenia;
        private FrbaHotel.Modelo.Usuario usuarioForm;
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void AccesoUsuarioHotel_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                username = txtUsuario.Text;
                contrasenia = txtPassword.Text;

                if (username == null || contrasenia == null || contrasenia == "" || username == "")
                {
                    MessageBox.Show("Debe ingresar su nombre de usuario y contraseña", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Usuario usuario = new Usuario();
                if (!usuario.Login(username, contrasenia))
                {
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    txtUsuario.Focus();
                    MessageBox.Show("Datos de acceso inválidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Sesion.usuario = usuario;
                frmSeleccionRoles seleccionRol = new frmSeleccionRoles();
                seleccionRol.ShowDialog();

                if (Sesion.rol == null || Sesion.rol.RolId == 0)
                {
                    throw new Exception("No se pudo seleccionar un rol valido. No es posible loguearse.");
                }

                frmSeleccionHotel seleccionHotel = new frmSeleccionHotel();
                seleccionHotel.ShowDialog();

                if (Sesion.hotel == null || Sesion.hotel.HotelId == 0)
                {
                    throw new Exception("No se pudo seleccionar un hotel valido. No es posible loguearse.");
                }

                MessageBox.Show("Se logueo correctamente. Bienvenido " + Sesion.usuario.NombreUsuario, this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            catch (Exception er)
            {
                Sesion.usuario = null;
                Sesion.rol = null;
                Sesion.hotel = null;

                MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
            }
        }
    }
}
