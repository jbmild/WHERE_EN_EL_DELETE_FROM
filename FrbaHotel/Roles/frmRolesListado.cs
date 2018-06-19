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
            using (DataTable dt = Roles.Modelo.Roles.obtener())
            {
                this.dgwRoles.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
                id.HeaderText = "Id";
                id.DataPropertyName = "rol_id";
                id.ReadOnly = true;
                id.Visible = false;
                this.dgwRoles.Columns.Add(id);

                DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
                nombre.HeaderText = "Nombre";
                nombre.DataPropertyName = "nombre";
                nombre.ReadOnly = true;
                this.dgwRoles.Columns.Add(nombre);

                DataGridViewCheckBoxColumn habilitado = new DataGridViewCheckBoxColumn();
                habilitado.HeaderText = "Habilitado";
                habilitado.DataPropertyName = "habilitado";
                nombre.ReadOnly = true;
                habilitado.FalseValue = "0";
                habilitado.TrueValue = "1";
                this.dgwRoles.Columns.Add(habilitado);

                this.dgwRoles.DataSource = dt;
            }
        }
    }
}
