using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen
{
    public partial class bajaRegimen : Form
    {
        public bajaRegimen()
        {
            InitializeComponent();

            DataTable dt = (new ConexionSQL()).cargarTablaSQL("SELECT * FROM [WHERE_EN_EL_DELETE_FROM].[regimenes]");
            comboBoxBajaRegimen.DataSource = dt.DefaultView;
            comboBoxBajaRegimen.ValueMember = "NOMBRE_REGIMEN";


        }

        private void bajaRegimen_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
