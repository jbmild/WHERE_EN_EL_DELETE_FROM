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

namespace FrbaHotel.Clientes
{
    public partial class frmFacturasListado : Form
    {
        public frmFacturasListado()
        {
            InitializeComponent();
        }

        private void frmRolesGrid_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.Items.Add("DNI");
            cmbTipoDoc.Items.Add("Pasaporte");

            Cliente cli = new Cliente();
            this.Cursor = Cursors.WaitCursor;
            this.LoadGrid(cli.getClientes("", "", "", "", ""));
            this.Cursor = Cursors.Default;
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = txtApellido.Text = txtNroDoc.Text = txtEmail.Text = "";
            cmbTipoDoc.SelectedIndex = -1;
            this.btnBuscar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            this.LoadGrid(cli.getClientes(cmbTipoDoc.Text, txtNroDoc.Text, txtEmail.Text, txtNombre.Text, txtApellido.Text));
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

                DataGridViewTextBoxColumn habilitado = new DataGridViewTextBoxColumn();
                habilitado.HeaderText = "Habilitado";
                habilitado.DataPropertyName = "EstaHabilitado";
                habilitado.ReadOnly = true;
                this.dgwRoles.Columns.Add(habilitado);

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
                    case 7:
                        this.modificarCliente((int)this.dgwRoles.Rows[e.RowIndex].Cells[0].Value);
                        break;
                    case 8:
                        this.deleteCliente((int)this.dgwRoles.Rows[e.RowIndex].Cells[0].Value, 
                                        this.dgwRoles.Rows[e.RowIndex].Cells[2].Value.ToString() + " " +
                                        this.dgwRoles.Rows[e.RowIndex].Cells[3].Value.ToString());
                        break;

                }
            }
        }

        private void modificarCliente(int clienteId)
        {
            Cliente cli = new Cliente(clienteId);
            Clientes.frmClientesFicha frmFicha = new frmClientesFicha(cli);
            frmFicha.FormClosed += new FormClosedEventHandler(frmClientesFicha_Closed);
            frmFicha.Show();
        }

        private void deleteCliente(int clienteId, string name)
        {
            
            var confirmResult = MessageBox.Show(String.Concat("Confirma que desea eliminar lógicamente a '", name, "'?"), "Confirmar eliminación logica", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Cliente cli = new Cliente(clienteId);
                List<KeyValuePair<string,string>> errores = cli.eliminar();
                if (errores.Count == 0)
                {
                    MessageBox.Show("Se realizó el eliminado lógico exitosamente!");
                    this.LoadGrid(cli.getClientes("", "", "", "", ""));
                    
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

                    MessageBox.Show(impresionErrores, "Ocurrió un error al eliminar el cliente. Intente de nuevo o contacte al administrador. ");
                }
                 
            }

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente(0);
            frmClientesFicha frmFicha = new frmClientesFicha(cli);
            frmFicha.FormClosed += new FormClosedEventHandler(frmClientesFicha_Closed);
            frmFicha.Show();
                        
        }


        private void frmClientesFicha_Closed(object sender, FormClosedEventArgs e)
        {
            Cliente cli = new Cliente();
            this.LoadGrid(cli.getClientes("", "", "", "", ""));
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgwRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }
    }
}
