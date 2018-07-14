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
using FrbaHotel.Tools;

namespace FrbaHotel.Facturar
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
            this.LoadGrid(Estadias.getEstadiasAFacturar(cmbTipoDoc.Text, txtNroDoc.Text, txtEmail.Text, txtNombre.Text, txtApellido.Text, txtCodigoReserva.Text.Length <= 0 ? 0 : Convert.ToInt32(txtCodigoReserva.Text), 0, Sesion.hotel.HotelId));
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = txtApellido.Text = txtNroDoc.Text = txtEmail.Text = "";
            cmbTipoDoc.SelectedIndex = -1;
            this.btnBuscar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.LoadGrid(Estadias.getEstadiasAFacturar(cmbTipoDoc.Text, txtNroDoc.Text, txtEmail.Text, txtNombre.Text, txtApellido.Text, txtCodigoReserva.Text.Length <= 0? 0: Convert.ToInt32(txtCodigoReserva.Text), 0, Sesion.hotel.HotelId));
            
        }

        public void LoadGrid(DataTable dt)
        {
            this.dgwRoles.DataSource = null;
            using (dt)
            {
                this.dgwRoles.AutoGenerateColumns = false;
                this.dgwRoles.Columns.Clear();
                //r.codigo, r.fecha_desde, r.fecha_hasta, cli.nombre + ' ' + cli.apellido As Cliente
                DataGridViewTextBoxColumn codigo = new DataGridViewTextBoxColumn();
                codigo.HeaderText = "Codigo Reserva";
                codigo.DataPropertyName = "codigo";
                codigo.Visible = false;
                this.dgwRoles.Columns.Add(codigo);

                DataGridViewTextBoxColumn fdesde = new DataGridViewTextBoxColumn();
                fdesde.HeaderText = "Desde";
                fdesde.DataPropertyName = "fecha_desde";
                fdesde.ReadOnly = true;
                this.dgwRoles.Columns.Add(fdesde);

                DataGridViewTextBoxColumn fhasta = new DataGridViewTextBoxColumn();
                fhasta.HeaderText = "Hasta";
                fhasta.DataPropertyName = "fecha_hasta";
                fhasta.ReadOnly = true;
                this.dgwRoles.Columns.Add(fhasta);

                DataGridViewTextBoxColumn cliente = new DataGridViewTextBoxColumn();
                cliente.HeaderText = "Cliente";
                cliente.DataPropertyName = "Cliente";
                cliente.ReadOnly = true;
                this.dgwRoles.Columns.Add(cliente);

                DataGridViewTextBoxColumn domicilio = new DataGridViewTextBoxColumn();
                domicilio.DataPropertyName = "domicilio";
                domicilio.ReadOnly = true;
                domicilio.Visible = false;
                this.dgwRoles.Columns.Add(domicilio);

                DataGridViewTextBoxColumn localidad = new DataGridViewTextBoxColumn();
                localidad.DataPropertyName = "direccion_localidad";
                localidad.ReadOnly = true;
                localidad.Visible = false;
                this.dgwRoles.Columns.Add(localidad);

                DataGridViewTextBoxColumn estadia_id = new DataGridViewTextBoxColumn();
                estadia_id.DataPropertyName = "estadia_id";
                estadia_id.ReadOnly = true;
                estadia_id.Visible = false;
                this.dgwRoles.Columns.Add(estadia_id);

                DataGridViewTextBoxColumn Facturar = new DataGridViewTextBoxColumn();
                Facturar.HeaderText = "Facturar";
                Facturar.ReadOnly = true;
                this.dgwRoles.Columns.Add(Facturar);

                /*
                DataGridViewTextBoxColumn eliminar = new DataGridViewTextBoxColumn();
                eliminar.HeaderText = "Eliminar";
                eliminar.ReadOnly = true;
                eliminar.DefaultCellStyle.ForeColor = Color.Aqua;
                this.dgwRoles.Columns.Add(eliminar);
                */
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

                        string apYNomCliente = this.dgwRoles.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string DomicilioCliente = this.dgwRoles.Rows[e.RowIndex].Cells[4].Value.ToString();
                        string localidadCliente = this.dgwRoles.Rows[e.RowIndex].Cells[5].Value.ToString();
                        this.irAFacturar((int)this.dgwRoles.Rows[e.RowIndex].Cells[6].Value);
                        break;
                    case 8:
                        this.deleteCliente((int)this.dgwRoles.Rows[e.RowIndex].Cells[0].Value, 
                                        this.dgwRoles.Rows[e.RowIndex].Cells[2].Value.ToString() + " " +
                                        this.dgwRoles.Rows[e.RowIndex].Cells[3].Value.ToString());
                        break;

                }
            }
        }

        private void irAFacturar(int estadia_id)
        {
            frmFacturasFicha frm = new frmFacturasFicha(estadia_id);
            frm.Show();
            /*Clientes.frmClientesFicha frmFicha = new frmClientesFicha(cli);
            frmFicha.FormClosed += new FormClosedEventHandler(frmClientesFicha_Closed);
            frmFicha.Show();
             * */
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
            /*frmClientesFicha frmFicha = new frmClientesFicha(cli);
            frmFicha.FormClosed += new FormClosedEventHandler(frmClientesFicha_Closed);
            frmFicha.Show();
             * */
                        
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
            //HOLa
            int a;
        }
    }
}
