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
            //InitializeComponent();
            nombreUsuario = username;
            string query = "SELECT NOMBRE FROM[WHERE_EN_EL_DELETE_FROM].[usuarios_roles] U_ROLES JOIN[WHERE_EN_EL_DELETE_FROM].[usuarios] USUARIOS ON(USUARIOS.USUARIO_ID = U_ROLES.USUARIO_ID) JOIN[WHERE_EN_EL_DELETE_FROM].[ROLES] ROLES ON(U_ROLES.rol_id = ROLES.rol_id) WHERE USUARIOS.USUARIO = '" + username + "' AND USUARIOS.HABILITADO = 1 AND ROLES.habilitado = 1";

            ConexionSQL.SetUsuarioLog("ROL ELEGIDO");
            string user = ConexionSQL.GetRolUsuarioLog();

            DataTable dt = (new ConexionSQL()).cargarTablaSQL(query);
            comboBoxRoles.DataSource = dt.DefaultView;
            comboBoxRoles.ValueMember = "NOMBRE";

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
    }
}
