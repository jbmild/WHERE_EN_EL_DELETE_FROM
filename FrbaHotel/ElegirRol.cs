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
        public ElegirRol()
        {
            InitializeComponent();
        }

        String rol;
        String nombreUsuario;

        public ElegirRol(String username)
        {
            InitializeComponent();

            nombreUsuario = username;
            DataTable dt = (new ConexionSQL()).cargarTablaSQL("SELECT R.nombre FROM[WHERE_EN_EL_DELETE_FROM].usuarios_roles RU JOIN[WHERE_EN_EL_DELETE_FROM].USUARIOS U ON(U.usuario_id = RU.usuario_id) JOIN[WHERE_EN_EL_DELETE_FROM].ROLES R ON(R.rol_id = RU.rol_id) WHERE U.usuario = '" + username + "' AND R.HABILITADO = 0 AND U.HABILITADO = 0");
            comboBoxRoles.DataSource = dt.DefaultView;
            comboBoxRoles.ValueMember = "NOMBRE_ROL";

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
    }
}
