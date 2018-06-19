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
            this.cmbHabilitado.SelectedIndex = 0;
            this.LoadGrid(Roles.Modelo.Roles.obtener());
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.cmbHabilitado.SelectedIndex = 0;
            this.btnBuscar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.LoadGrid(Roles.Modelo.Roles.obtener(txtNombre.Text, cmbHabilitado.SelectedIndex-1));
        }

        private void LoadGrid(DataTable dt)
        {
            this.dgwRoles.DataSource = null;
            using (dt)
            {
                this.dgwRoles.AutoGenerateColumns = false;
                this.dgwRoles.Columns.Clear();

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
                habilitado.ReadOnly = true;
                habilitado.FalseValue = "0";
                habilitado.TrueValue = "1";
                this.dgwRoles.Columns.Add(habilitado);

                this.dgwRoles.DataSource = dt;
            }
        }
    }
}
