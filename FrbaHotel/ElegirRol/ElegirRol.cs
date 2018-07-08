using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ElegirRol
{
    public partial class ElegirRol : Form
    {

        String rol;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ComboBox comboBoxRolesUsuario=new ComboBox();
        private Label label1;
        private Button button1;
        FrbaHotel.Modelo.Usuario user;
        
        String nombreUsuario;

        public ElegirRol(FrbaHotel.Modelo.Usuario u)
        {
            this.user = new Modelo.Usuario();
            this.user = u;
            this.InitializeComponent();
            //InitializeComponent();
            nombreUsuario = u.GetNombre();
            string query = "SELECT NOMBRE FROM[WHERE_EN_EL_DELETE_FROM].[usuarios_roles] U_ROLES JOIN[WHERE_EN_EL_DELETE_FROM].[usuarios] USUARIOS ON(USUARIOS.USUARIO_ID = U_ROLES.USUARIO_ID) JOIN[WHERE_EN_EL_DELETE_FROM].[ROLES] ROLES ON(U_ROLES.rol_id = ROLES.rol_id) WHERE USUARIOS.USUARIO = '" + nombreUsuario + "' AND USUARIOS.HABILITADO = 1 AND ROLES.habilitado = 1";

            ConexionSQL.SetUsuarioLog("ROL ELEGIDO");
            string user = ConexionSQL.GetRolUsuarioLog();

            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            comboBoxRolesUsuario.DataSource = dt;
            comboBoxRolesUsuario.ValueMember = "NOMBRE";

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL.SetUsuarioLog("ROL ELEGIDO");
            string user = ConexionSQL.GetRolUsuarioLog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ElegirRol_Load(object sender, EventArgs e)
        {

        }

        private void ElegirRol_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //String Username = (new ConexionSQL()).usuariologeado);
        }

        private void InitializeComponent()
        {
            this.comboBoxRolesUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxRolesUsuario
            // 
            this.comboBoxRolesUsuario.FormattingEnabled = true;
            this.comboBoxRolesUsuario.Location = new System.Drawing.Point(246, 39);
            this.comboBoxRolesUsuario.Name = "comboBoxRolesUsuario";
            this.comboBoxRolesUsuario.Size = new System.Drawing.Size(201, 24);
            this.comboBoxRolesUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roles disponibles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar rol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ElegirRol
            // 
            this.ClientSize = new System.Drawing.Size(647, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRolesUsuario);
            this.Name = "ElegirRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            user.SetRol(comboBoxRolesUsuario.SelectedValue.ToString());
            if (user.GetRol().Equals("Recepcionista"))
            {
                HotelSesionActual hotelForm = new HotelSesionActual();
                hotelForm.RecibirDatosUsuario(this.user);
                hotelForm.Show();
            }
        }
    }
}
