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
        String nombreUsuario;

        public ElegirRol(String username)
        {
            InitializeComponent();
            nombreUsuario = username;
            string query = "SELECT NOMBRE FROM[WHERE_EN_EL_DELETE_FROM].[usuarios_roles] U_ROLES JOIN[WHERE_EN_EL_DELETE_FROM].[usuarios] USUARIOS ON(USUARIOS.USUARIO_ID = U_ROLES.USUARIO_ID) JOIN[WHERE_EN_EL_DELETE_FROM].[ROLES] ROLES ON(U_ROLES.rol_id = ROLES.rol_id) WHERE USUARIOS.USUARIO = '" + username + "' AND USUARIOS.HABILITADO = 1 AND ROLES.habilitado = 1";

            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            comboBoxRoles.DataSource = dt.DefaultView;
            comboBoxRoles.ValueMember = "NOMBRE";

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ElegirRol_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // ElegirRol
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ElegirRol";
            this.Load += new System.EventHandler(this.ElegirRol_Load_1);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ElegirRol_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //String Username = (new ConexionSQL()).usuariologeado);
        }
    }
}
