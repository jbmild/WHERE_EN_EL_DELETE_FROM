using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Roles
{
    public partial class frmRolesListado : Form
    {
        public frmRolesListado()
        {
            InitializeComponent();
        }

        private void frmRolesGrid_Load(object sender, EventArgs e)
        {
            this.dgwRoles.DataSource = Roles.Modelo.Roles.obtener();
        }
    }
}
