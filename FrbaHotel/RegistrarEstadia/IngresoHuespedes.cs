using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private int codigo_reserva;
        public IngresoHuespedes(int cod_reserva)
        {
            InitializeComponent();
            codigo_reserva = cod_reserva;
        }

        private void frmRolesGrid_Load(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();

            //Cliente cli = new Cliente();
            //this.LoadGrid(cli.getClientes(cmbTipoDoc.Text, txtNroDoc.Text, txtEmail.Text, txtNombre.Text, txtApellido.Text));
            //cli.getClientes(cmbTipoDoc.Text, txtNroDoc.Text, txtEmail.Text, txtNombre.Text, txtApellido.Text);
            string sqlQuery;
            if(txtNroDoc.Text != null)
            {
            sqlQuery = " select * from WHERE_EN_EL_DELETE_FROM.clientes where documento_nro =" + txtNroDoc.Text;
            }
            else
            {
            sqlQuery = " select * from WHERE_EN_EL_DELETE_FROM.clientes";
            }
            DataTable dt = conn.cargarTablaSQL(sqlQuery);
            dataGridView1.DataSource = dt;
            this.Cursor = Cursors.Default;

            dataGridView1.Columns["consistente"].Visible = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        //public void LoadGrid(DataTable dt)
        //{
        //    this.dgvReservas2.DataSource = null;
        //    using (dt)
        //    {
        //        this.dgvReservas2.AutoGenerateColumns = false;
        //        this.dgvReservas2.Columns.Clear();

        //        DataGridViewTextBoxColumn agregar_cliente = new DataGridViewTextBoxColumn();
        //        agregar_cliente.HeaderText = "agregar_cliente";
        //        agregar_cliente.ReadOnly = true;
        //        this.dgvReservas2.Columns.Add(agregar_cliente);

        //        DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
        //        id.HeaderText = "ID";
        //        id.DataPropertyName = "cliente_id";
        //        id.Visible = false;
        //        this.dgvReservas2.Columns.Add(id);

        //        DataGridViewTextBoxColumn habilitado = new DataGridViewTextBoxColumn();
        //        habilitado.HeaderText = "Habilitado";
        //        habilitado.DataPropertyName = "EstaHabilitado";
        //        habilitado.ReadOnly = true;
        //        this.dgvReservas2.Columns.Add(habilitado);

        //        DataGridViewTextBoxColumn nombre = new DataGridViewTextBoxColumn();
        //        nombre.HeaderText = "Nombre";
        //        nombre.DataPropertyName = "nombre";
        //        nombre.ReadOnly = true;
        //        this.dgvReservas2.Columns.Add(nombre);

        //        DataGridViewTextBoxColumn apellido = new DataGridViewTextBoxColumn();
        //        apellido.HeaderText = "Apellido";
        //        apellido.DataPropertyName = "apellido";
        //        apellido.ReadOnly = true;
        //        this.dgvReservas2.Columns.Add(apellido);

        //        DataGridViewTextBoxColumn tipoDoc = new DataGridViewTextBoxColumn();
        //        tipoDoc.HeaderText = "Tipo Identificación";
        //        tipoDoc.DataPropertyName = "documento_tipo";
        //        tipoDoc.ReadOnly = true;
        //        this.dgvReservas2.Columns.Add(tipoDoc);

        //        DataGridViewTextBoxColumn nroDoc = new DataGridViewTextBoxColumn();
        //        nroDoc.HeaderText = "Nro Identificación";
        //        nroDoc.DataPropertyName = "documento_nro";
        //        nroDoc.ReadOnly = true;
        //        this.dgvReservas2.Columns.Add(nroDoc);

        //        DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
        //        email.HeaderText = "Email";
        //        email.DataPropertyName = "mail";
        //        email.ReadOnly = true;
        //        this.dgvReservas2.Columns.Add(email);

        //        DataGridViewTextBoxColumn modificar = new DataGridViewTextBoxColumn();
        //        modificar.HeaderText = "Modificar";
        //        modificar.ReadOnly = true;
        //        this.dgvReservas2.Columns.Add(modificar);

        //        DataGridViewTextBoxColumn eliminar = new DataGridViewTextBoxColumn();
        //        eliminar.HeaderText = "Eliminar";
        //        eliminar.ReadOnly = true;
        //        eliminar.DefaultCellStyle.ForeColor = Color.Aqua;
        //        this.dgvReservas2.Columns.Add(eliminar);

        //        this.dgvReservas2.DataSource = dt;
        //    }
        //}

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente(0);
            Clientes.frmClientesFicha frmFicha = new Clientes.frmClientesFicha(cli);
            frmFicha.Show();
        }

        private void IngresoHuespedes_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvReservas2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows) //(string[] rowArray in dgvReservas2.Rows)//(DataGridViewRow row in dgvReservas2.Rows)
            {

                //int row = e.RowIndex;
                int numero_cliente;

                    //DataGridViewRow selectedRow = row.Cells dgvReservas2.Rows[row];

                    numero_cliente = Int32.Parse(row.Cells[0].Value.ToString());
                    //numero_cliente = Int32.Parse(row[0].ToString());

                    ConexionSQL conexionSQL = new ConexionSQL();
                    String sqlQuery = "SELECT * FROM WHERE_EN_EL_DELETE_FROM.ESTADIAS WHERE RESERVA_ID = '" + codigo_reserva + "'";//del otro form

                    DataTable dt = conexionSQL.cargarTablaSQL(sqlQuery);
                    if (dt.Rows[0] != null)
                    {
                        //ya existía la estadía. - se actualizaría la estadia
                        string estadia = dt.Rows[0][0].ToString();
                        //string update_estadia = "UPDATE WHERE_EN_EL_DELETE_FROM.huespedes set cliente_id = @numero_cliente where estadia_id ='" + estadia +  "')";
                        string insert_estadia = "INSERT INTO WHERE_EN_EL_DELETE_FROM.huespedes (estadia_id, cliente_id) VALUES('" + estadia + "', '" + numero_cliente + "')";

                        SqlCommand sql = new SqlCommand(insert_estadia);
                        sql.Parameters.Add("@numero_cliente", SqlDbType.Int).Value = numero_cliente;

                        conexionSQL.ejecutarComando(sql);


                    }
                //}//del row
            }
        }

        private void dgvReservas2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReservas2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int id_cliente;
            DataGridViewRow selectedRow = dataGridView1.Rows[row];

            if (e.ColumnIndex.Equals(0))
            {
                id_cliente = (Int32.Parse(selectedRow.Cells[1].Value.ToString()));


                
                ConexionSQL conexionSQL = new ConexionSQL();
                String sqlQuery = "SELECT * FROM WHERE_EN_EL_DELETE_FROM.ESTADIAS WHERE RESERVA_ID = '" + codigo_reserva + "'";//del otro form

                DataTable dt = conexionSQL.cargarTablaSQL(sqlQuery);
                if (dt.Rows.Count != 0)
                {
                    //ya existía la estadía. - se actualizaría la estadia
                    string estadia = dt.Rows[0][0].ToString();
                    //string update_estadia = "UPDATE WHERE_EN_EL_DELETE_FROM.huespedes set cliente_id = @numero_cliente where estadia_id ='" + estadia +  "')";
                    string insert_estadia = "INSERT INTO WHERE_EN_EL_DELETE_FROM.huespedes (estadia_id, cliente_id) VALUES('" + estadia + "', '" + id_cliente + "')";

                    SqlCommand sql = new SqlCommand(insert_estadia);
                    sql.Parameters.Add("@numero_cliente", SqlDbType.Int).Value = id_cliente;

                    conexionSQL.ejecutarComando(sql);
                    System.Windows.Forms.MessageBox.Show("Gracias, cliente " + id_cliente.ToString() + " agregado a estadía:" + codigo_reserva.ToString());
                }
                else
                {
                    //no existia la estadia, se crea una nueva
                    string create_estadia = "insert into WHERE_EN_EL_DELETE_FROM.estadias(reserva_id, ingreso_empleado_id, ingreso_fecha, egreso_fecha) VALUES("+ codigo_reserva + "," + Tools.Sesion.usuario.UsuarioId + ", GETDATE(), GETDATE())";

                    //el codigo de reserva es el mismo que la RESERVA_ID !!
                    string insert_estadia = "INSERT INTO WHERE_EN_EL_DELETE_FROM.huespedes (estadia_id, cliente_id) VALUES('" + codigo_reserva + "', '" + id_cliente + "')";

                    SqlCommand sql = new SqlCommand(insert_estadia);
                    sql.Parameters.Add("@numero_cliente", SqlDbType.Int).Value = id_cliente;

                    conexionSQL.ejecutarComando(sql);

                    System.Windows.Forms.MessageBox.Show("Gracias, cliente " + id_cliente.ToString() + " agregado a la estadía: " + codigo_reserva.ToString() );
                }


            }
        }
    }
}
