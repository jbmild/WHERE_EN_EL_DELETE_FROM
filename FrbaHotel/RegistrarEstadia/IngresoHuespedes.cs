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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class IngresoHuespedes : Form
    {
        public IngresoHuespedes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            this.LoadGrid(cli.getClientes(cmbTipoDoc.Text, txtNroDoc.Text, txtEmail.Text, txtNombre.Text, txtApellido.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                //int row = e.RowIndex;
                //int tieneVista = 0;
                //int estaHabilitado = 0;

                //DataGridViewRow selectedRow = dgwRoles.Rows[row];
                //int piso = this.mapearPiso(selectedRow);
                //HabitacionElegida habitacion = new HabitacionElegida();
                ////System.Windows.Forms.MessageBox.Show(dataGridView1.Columns.Count.ToString());


                //habitacion.SetNumero(Int32.Parse(selectedRow.Cells[1].Value.ToString()));
                //if (piso.Equals(0))
                //{
                //    habitacion.SetPiso(Int32.Parse(selectedRow.Cells[2].Value.ToString()));
                //}
                //else
                //{
                //    habitacion.SetPiso(piso);
                //}

                //habitacion.SetDescripcion(selectedRow.Cells[3].Value.ToString());
                //habitacion.SetTipo(selectedRow.Cells[4].Value.ToString());
                //habitacion.SetDireccion(selectedRow.Cells[7].Value.ToString());
                //habitacion.SetHabiID(Int32.Parse(selectedRow.Cells[8].Value.ToString()));
                //habitacion.SetHotelID(this.ObtenerHotelID(habitacion));


                //if (selectedRow.Cells[5].Value.Equals(true))
                //{
                //    tieneVista = 1;
                //}
                //if (selectedRow.Cells[6].Value.Equals(true))
                //{
                //    estaHabilitado = 1;
                //}
                //habitacion.SetVista(tieneVista);
                //habitacion.SetHabilitado(estaHabilitado);
                //modificarDatosHabitacioncs modifDatos = new modificarDatosHabitacioncs();
                //modifDatos.RecibirHabitacion(habitacion);
                //modifDatos.Show();
            }
        }
    }
}
