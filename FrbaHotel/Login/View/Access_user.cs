using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace FrbaHotel.Login.View
{
    public partial class AccesoUsuarioHotel : Form
    {
        private string username, contrasenia;

        public AccesoUsuarioHotel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AccesoUsuarioHotel_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            username = txtUsuario.Text;
            contrasenia = txtContraseña.Text;

            if (username == null || contrasenia == null || contrasenia == "" || username == "")
            {
                MessageBox.Show("Debe ingresar su nombre de usuario y contraseña", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            string query = "SELECT CONTRASENA FROM [WHERE_EN_EL_DELETE_FROM].[usuarios] WHERE USUARIO = '" + username + "'";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nombre de usuario incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String passwordSistema = dt.Rows[0][0].ToString();
                if (getSha256(contrasenia) == passwordSistema)
                {
                    string resetearIntentos = "UPDATE [WHERE_EN_EL_DELETE_FROM].[usuarios] SET CANT_INTENTOS = 0 WHERE USUARIO = '" + username + "'";
                    (new ConexionSQL()).ejecutarComandoSQL(resetearIntentos);
                    string query5 = "SELECT HABILITADO FROM [WHERE_EN_EL_DELETE_FROM].[usuarios] WHERE USUARIO = '" + username + "'";
                    DataTable dt5 = (new ConexionSQL()).cargarTablaSQL(query5);
                    string habilitado = dt5.Rows[0][0].ToString();
                    if (habilitado == "1")
                    {
                        string query2 = "SELECT COUNT(*) FROM [WHERE_EN_EL_DELETE_FROM].[roles] ROLES JOIN [WHERE_EN_EL_DELETE_FROM].[usuarios] USUARIOS ON (USUARIOS.ID_USUARIO = ROLES.ID_USUARIO) WHERE USUARIOS.USUARIO = '" + username + "' AND USUARIOS.HABILITADO = 1";
                        DataTable dt2 = (new ConexionSQL()).cargarTablaSQL(query2);
                        string cantidadRoles = dt2.Rows[0][0].ToString();
                        if (cantidadRoles == "1")
                        {
                               //ACA DEBERIAMOS DE HACER QUE TENGA UNA U OTRA FUNCIONALIDAD RESPECTO AL ROL QUE TENGA. * JUANMA CARUCCI * 
                        }
                        else if (cantidadRoles == "0")
                        {
                            MessageBox.Show("El usuario no tiene roles habilitados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                               //ACA DEBERIA DE ELEGIR EL ROL QUE TENGA (YA QUE VA A TENER VARIOS) * JCARUCCI * 
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no esta habilitado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string query4 = "SELECT CANT_INTENTOS FROM [WHERE_EN_EL_DELETE_FROM].[usuarios] WHERE USUARIO = '" + username + "'";
                    DataTable dt4 = (new ConexionSQL()).cargarTablaSQL(query4);
                    string cantidadIntentos = dt4.Rows[0][0].ToString();
                    string texto = "";
                    if (cantidadIntentos == "0")
                    {
                        cantidadIntentos = "1";
                        texto = "";
                    }
                    else if (cantidadIntentos == "1")
                    {
                        cantidadIntentos = "2";
                        texto = "";
                    }
                    else if (cantidadIntentos == "2")
                    {
                        cantidadIntentos = "3";
                        texto = ": Usuario inhabilitado";
                        string inhabilitarUsuario = "UPDATE [WHERE_EN_EL_DELETE_FROM].[usuarios] SET HABILITADO = 0 WHERE USUARIO = '" + username + "'";
                        (new ConexionSQL()).ejecutarComandoSQL(inhabilitarUsuario);

                    }
                    string sumarIntento = "UPDATE [WHERE_EN_EL_DELETE_FROM].[usuarios] SET CANT_INTENTOS = '" + cantidadIntentos + "' WHERE USUARIO = '" + username + "'";
                    (new ConexionSQL()).ejecutarComandoSQL(sumarIntento);
                    MessageBox.Show("Contraseña incorrecta" + texto, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        }

        public String getSha256(String input)
        {
            SHA256Managed encriptador = new SHA256Managed();
            byte[] inputEnBytes = Encoding.UTF8.GetBytes(input);
            byte[] inputHashBytes = encriptador.ComputeHash(inputEnBytes);
            return BitConverter.ToString(inputHashBytes).Replace("-", String.Empty).ToLower();
        }
    }
}
