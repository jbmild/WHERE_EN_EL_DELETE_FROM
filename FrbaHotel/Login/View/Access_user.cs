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
        private FrbaHotel.Modelo.Usuario usuarioForm;
       
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
            this.txtContraseña.PasswordChar = '*';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            username = txtUsuario.Text;
            contrasenia = txtContraseña.Text;

            if (username == null || contrasenia == null || contrasenia == "" || username == "")
            {
                MessageBox.Show("Debe ingresar su nombre de usuario y contraseña", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string code = Encripter.GetHash(SHA256.Create(), contrasenia);
            code = code.ToUpper();
            string sha = "0x";
            sha += code;
            
            
            
            string query = "SELECT * FROM [WHERE_EN_EL_DELETE_FROM].[usuarios] WHERE USUARIO like '" + username + "' and contrasena like cast(" + sha + " as binary(32))";
            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Datos inválidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuarioForm = new Modelo.Usuario();
                this.usuarioForm.SetID(Int32.Parse(dt.Rows[0].ItemArray[0].ToString()));
                this.usuarioForm.SetNombre(username);
                
                    string resetearIntentos = "UPDATE [WHERE_EN_EL_DELETE_FROM].[usuarios] SET CANT_INTENTOS = 0 WHERE USUARIO = '" + username + "'";
                    //(new ConexionSQL()).ejecutarComandoSQL(resetearIntentos);
                    //string query5 = "SELECT HABILITADO FROM [WHERE_EN_EL_DELETE_FROM].[usuarios] WHERE USUARIO = '" + username + "'";
                    //DataTable dt5 = (new ConexionSQL()).cargarTablaSQL(query5);
                    //string habilitado = dt5.Rows[0][0].ToString();
                    if (dt.Rows[0].ItemArray[3].Equals(true))
                    {
                        this.usuarioForm.SetHabilitado(true);
                        string query2 = "SELECT nombre FROM[WHERE_EN_EL_DELETE_FROM].[usuarios_roles] U_ROLES JOIN[WHERE_EN_EL_DELETE_FROM].[usuarios] USUARIOS ON(USUARIOS.USUARIO_ID = U_ROLES.USUARIO_ID) JOIN[WHERE_EN_EL_DELETE_FROM].[ROLES] ROLES ON(U_ROLES.rol_id = ROLES.rol_id) WHERE USUARIOS.USUARIO = '"+ username +"' AND USUARIOS.HABILITADO = 1";
                        
                        //string query2 = "SELECT COUNT(*) FROM [WHERE_EN_EL_DELETE_FROM].[roles] ROLES JOIN [WHERE_EN_EL_DELETE_FROM].[usuarios] USUARIOS ON (USUARIOS.USUARIO_ID = ROLES.USUARIO_ID) WHERE USUARIOS.USUARIO = '" + username + "' AND USUARIOS.HABILITADO = 1";
                        DataTable dt2 = (new ConexionSQL()).cargarTablaSQL(query2);
                        //
                        int cantRoles = dt2.Rows.Count;
                        if (cantRoles > 1)
                        {
                            ConexionSQL.SetUsuarioLog(username);
                            ElegirRol.ElegirRol elegirRol = new ElegirRol.ElegirRol(this.usuarioForm);
                            elegirRol.Show();
                        }
                        else {
                            string rol = dt2.Rows[0][0].ToString();
                        if (rol == "Administrador General")
                        {
                            FuncionesAdmin f = new FuncionesAdmin();
                            f.Show();
                            //ingresa de una! * JCARUCCI *
                        }
                        if (rol=="Recepcionista")
                        {
                            FuncionesRecepcionista r = new FuncionesRecepcionista();
                            r.Show();
                            //MessageBox.Show("El usuario no tiene roles habilitados", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }}
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("El usuario no esta habilitado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                
                
                    //string query4 = "SELECT CANT_INTENTOS FROM [WHERE_EN_EL_DELETE_FROM].[usuarios] WHERE USUARIO = '" + username + "'";
                    //DataTable dt4 = (new ConexionSQL()).cargarTablaSQL(query4);
                    //string cantidadIntentos = dt4.Rows[0][0].ToString();
                    //string texto = "";
                    //if (cantidadIntentos == "0")
                    //{
                    //    cantidadIntentos = "1";
                    //    texto = "";
                    //}
                    //else if (cantidadIntentos == "1")
                    //{
                    //    cantidadIntentos = "2";
                    //    texto = "";
                    //}
                    //else if (cantidadIntentos == "2")
                    //{
                    //    cantidadIntentos = "3";
                    //    texto = ": Usuario inhabilitado";
                    //    string inhabilitarUsuario = "UPDATE [WHERE_EN_EL_DELETE_FROM].[usuarios] SET HABILITADO = 0 WHERE USUARIO = '" + username + "'";
                    //    (new ConexionSQL()).ejecutarComandoSQL(inhabilitarUsuario);

                    //}
                    //string sumarIntento = "UPDATE [WHERE_EN_EL_DELETE_FROM].[usuarios] SET CANT_INTENTOS = '" + cantidadIntentos + "' WHERE USUARIO = '" + username + "'";
                    //(new ConexionSQL()).ejecutarComandoSQL(sumarIntento);
                    //MessageBox.Show("Contraseña incorrecta" + texto, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        

        }

       
    }
}
