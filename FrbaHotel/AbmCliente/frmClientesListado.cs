using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Modelo;

namespace FrbaHotel.AbmCliente
{
    public partial class frmClientesListado : Form
    {
        public frmClientesListado()
        {
            InitializeComponent();
        }

        private void frmRolesGrid_Load(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            this.LoadGrid(cli.getClientes("", "", "", "", ""));
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.btnBuscar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            this.LoadGrid(cli.getClientes(cmbTipoDoc.SelectedText, txtNroDoc.Text, txtEmail.Text, txtNombre.Text, txtApellido.Text));
        }

        public void LoadGrid(DataTable dt)
        {
            this.dgwRoles.DataSource = null;
            using (dt)
            {
                this.dgwRoles.AutoGenerateColumns = false;
                this.dgwRoles.Columns.Clear();

                DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
                id.HeaderText = "ID";
                id.DataPropertyName = "cliente_id";
                id.Visible = false;
                this.dgwRoles.Columns.Add(id);

                DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
                nombre.HeaderText = "Nombre";
                nombre.DataPropertyName = "nombre";
                nombre.ReadOnly = true;
                this.dgwRoles.Columns.Add(nombre);

                DataGridViewTextBoxColumn apellido = new DataGridViewTextBoxColumn();
                apellido.HeaderText = "Apellido";
                apellido.DataPropertyName = "apellido";
                apellido.ReadOnly = true;
                this.dgwRoles.Columns.Add(apellido);

                DataGridViewTextBoxColumn tipoDoc = new DataGridViewTextBoxColumn();
                tipoDoc.HeaderText = "Tipo Identificación";
                tipoDoc.DataPropertyName = "documento_tipo";
                tipoDoc.ReadOnly = true;
                this.dgwRoles.Columns.Add(tipoDoc);

                DataGridViewTextBoxColumn nroDoc = new DataGridViewTextBoxColumn();
                nroDoc.HeaderText = "Nro Identificación";
                nroDoc.DataPropertyName = "documento_nro";
                nroDoc.ReadOnly = true;
                this.dgwRoles.Columns.Add(nroDoc);

                DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
                email.HeaderText = "Email";
                email.DataPropertyName = "mail";
                email.ReadOnly = true;
                this.dgwRoles.Columns.Add(email);

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
                        this.modificarCliente((int)this.dgwRoles.Rows[e.RowIndex].Cells[0].Value);
                        break;
                    case 4:
                        this.deleteCliente((int)this.dgwRoles.Rows[e.RowIndex].Cells[0].Value, 
                                        this.dgwRoles.Rows[e.RowIndex].Cells[1].Value.ToString() + " " +
                                        this.dgwRoles.Rows[e.RowIndex].Cells[2].Value.ToString());
                        break;

                }
            }
        }

        private void modificarCliente(int clienteId)
        {
            Cliente cli = new Cliente(clienteId);
            AbmCliente.ClienteFicha frmFicha = new ClienteFicha(clienteId);
            frmFicha.FormClosed += new FormClosedEventHandler(frmClientesFicha_Closed);
            frmFicha.Show();
        }

        private void deleteCliente(int rolId, string name)
        {
            /*
            var confirmResult = MessageBox.Show(String.Concat("Esta seguro que desea eliminar logicamente el rol '", name, "'?"), "Confirmar eliminacion logica", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Rol rol = new Rol(rolId);
                List<KeyValuePair<string,string>> errores = rol.eliminar();
                if (errores.Count == 0)
                {
                    this.LoadGrid(Modelo.Roles.obtener(txtNombre.Text, cmbHabilitado.SelectedIndex - 1));
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
             * */

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente(0);
            ClienteFicha frmFicha = new ClienteFicha(cli);
            frmFicha.FormClosed += new FormClosedEventHandler(frmClientesFicha_Closed);
            frmFicha.Show();
                        
        }


        private void frmClientesFicha_Closed(object sender, FormClosedEventArgs e)
        {
            Cliente cli = new Cliente();
            this.LoadGrid(cli.getClientes("", "", "", "", ""));
        }
    }
}
