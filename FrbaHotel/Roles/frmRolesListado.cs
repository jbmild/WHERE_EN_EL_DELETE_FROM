using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Roles.Modelo;

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
            this.cmbHabilitado.SelectedIndex = 2;
            this.LoadGrid(Modelo.Roles.obtener(txtNombre.Text, cmbHabilitado.SelectedIndex - 1));
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.cmbHabilitado.SelectedIndex = 2;
            this.btnBuscar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.LoadGrid(Modelo.Roles.obtener(txtNombre.Text, cmbHabilitado.SelectedIndex-1));
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

                DataGridViewTextBoxColumn modificar = new DataGridViewTextBoxColumn();
                modificar.HeaderText = "Modificar";
                modificar.ReadOnly = true;
                this.dgwRoles.Columns.Add(modificar);

                DataGridViewTextBoxColumn eliminar = new DataGridViewTextBoxColumn();
                eliminar.HeaderText = "Eliminar";
                eliminar.ReadOnly = true;
                eliminar.DefaultCellStyle.ForeColor = Color.Aqua;
                this.dgwRoles.Columns.Add(eliminar);

                this.dgwRoles.DataSource = dt;
            }
        }

        private void dgwRoles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (this.dgwRoles.CurrentCell.ColumnIndex)
                {
                    case 3:
                        MessageBox.Show(String.Concat("Queria modificar a ", this.dgwRoles.Rows[e.RowIndex].Cells[1].Value, " ", this.dgwRoles.CurrentCell.ColumnIndex.ToString()));
                        break;
                    case 4:
                        this.deleteRol((int)this.dgwRoles.Rows[e.RowIndex].Cells[0].Value, this.dgwRoles.Rows[e.RowIndex].Cells[1].Value.ToString());
                        break;

                }
            }
        }

        private void deleteRol(int rolId, string name)
        {
            var confirmResult = MessageBox.Show(String.Concat("Esta seguro que desea eliminar logicamente el rol '", name, "'?"), "Confirmar eliminacion logica", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Rol rol = new Rol(rolId);
                List<KeyValuePair<string,string>> errores = rol.eliminar();
                if (errores.Count == 0)
                {
                    MessageBox.Show("Se realizo el eliminado logico exitosamente!");
                }
                else
                {
                    string impresionErrores = "";
                    foreach(KeyValuePair<string, string> data in errores){
                        if(impresionErrores.Length==0){
                            impresionErrores = data.Value;
                        }else{
                            impresionErrores = impresionErrores + Environment.NewLine + data.Value;
                        }
                    }

                    MessageBox.Show(impresionErrores, "Ocurrio un error al eliminar el rol.");
                }
            }

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol(0);
            Roles.frmRolesFicha frmFicha = new Roles.frmRolesFicha(rol);
            frmFicha.Show();
        }
    }
}
