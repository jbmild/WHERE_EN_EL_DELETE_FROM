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

                //byte[] claveObtenida = Encoding.ASCII.GetBytes(dt.Rows[0][0].ToString());

                //var binWriter = new BinaryWriter(new MemoryStream());
                //byte[] result = reader.ReadBytes((int)binWriter.BaseStream.Length);


                //System.Text.Encoding enc = System.Text.Encoding.ASCII;
                //String passwordSistema = enc.GetString(claveObtenida);
                //String passwordSistema = System.Text.Encoding.ASCII.GetString(claveObtenida);

                //if (getSha256(contrasenia) == passwordSistema)
                if (contrasenia == passwordSistema)
                {
                    string resetearIntentos = "UPDATE [WHERE_EN_EL_DELETE_FROM].[usuarios] SET CANT_INTENTOS = 0 WHERE USUARIO = '" + username + "'";
                    (new ConexionSQL()).ejecutarComandoSQL(resetearIntentos);
                    string query5 = "SELECT HABILITADO FROM [WHERE_EN_EL_DELETE_FROM].[usuarios] WHERE USUARIO = '" + username + "'";
                    DataTable dt5 = (new ConexionSQL()).cargarTablaSQL(query5);
                    string habilitado = dt5.Rows[0][0].ToString();
                    if (habilitado == "True")
                    {
                        string query2 = "SELECT COUNT(*) FROM[WHERE_EN_EL_DELETE_FROM].[usuarios_roles] U_ROLES JOIN[WHERE_EN_EL_DELETE_FROM].[usuarios] USUARIOS ON(USUARIOS.USUARIO_ID = U_ROLES.USUARIO_ID) JOIN[WHERE_EN_EL_DELETE_FROM].[ROLES] ROLES ON(U_ROLES.rol_id = ROLES.rol_id) WHERE USUARIOS.USUARIO = '"+ username +"' AND USUARIOS.HABILITADO = 1";

                        //string query2 = "SELECT COUNT(*) FROM [WHERE_EN_EL_DELETE_FROM].[roles] ROLES JOIN [WHERE_EN_EL_DELETE_FROM].[usuarios] USUARIOS ON (USUARIOS.USUARIO_ID = ROLES.USUARIO_ID) WHERE USUARIOS.USUARIO = '" + username + "' AND USUARIOS.HABILITADO = 1";
                        DataTable dt2 = (new ConexionSQL()).cargarTablaSQL(query2);
                        string cantidadRoles = dt2.Rows[0][0].ToString();
                        if (cantidadRoles == "1")
                        {
                            //ingresa de una! * JCARUCCI *
                        }
                        if (cantidadRoles == "0")
                        {
                            MessageBox.Show("El usuario no tiene roles habilitados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ElegirRol.ElegirRol elegirRol = new ElegirRol.ElegirRol(username);
                            elegirRol.Show();
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
