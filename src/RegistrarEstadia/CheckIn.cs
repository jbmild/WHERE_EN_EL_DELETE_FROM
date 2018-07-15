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
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;



namespace FrbaHotel.RegistrarEstadia
{
    public partial class CheckIn : Form
    {
        String numeroDeReserva;
        DateTime fechaDesde;
        Reserva res;
        ConexionSQL conn = new ConexionSQL();
        public CheckIn()
        {
            InitializeComponent();

            
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton aceptar
            //fechaDesde = fechaingreso.Value.Date;
            //numeroDeReserva = nroreserva.Text;
            
            //MessageBox.Show("Fecha es: " + fechaDesde.ToString() + "con reserva: " + numeroDeReserva.ToString(), fechaDesde.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //datos reserva
            //numeroDeReserva = nroreserva.Text;
            //fechaDesde = fechaingreso.Value.Date;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReservas2.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (Convert.ToInt32(row.Cells[0].Value) >= 1)
                    {

                        Reserva res = new Reserva();
                        res.fecha_desde = Convert.ToDateTime(row.Cells[2].Value);
                        res.fecha_hasta = Convert.ToDateTime(row.Cells[3].Value);
                        res.codigo = Convert.ToInt32(row.Cells[1].Value);
                        res.hotel_id = Convert.ToInt32(row.Cells[6].Value);
                        res.regimen_id = Convert.ToInt32(row.Cells[7].Value);
                        res.cliente_id = Convert.ToInt32(row.Cells[9].Value);
                        res.id = Convert.ToInt32(row.Cells[10].Value);
                        res.usuarioCancelacion = Tools.Sesion.usuario.UsuarioId;

                        string query2 = "SELECT EMPLEADO_ID FROM [WHERE_EN_EL_DELETE_FROM].[empleados] where usuario_id = " + Tools.Sesion.usuario.UsuarioId;
                        DataTable dt = conn.cargarTablaSQL(query2);
                        int empleado_id = Int32.Parse(dt.Rows[0][0].ToString());

                        string query = "INSERT INTO [WHERE_EN_EL_DELETE_FROM].[estadias]([reserva_id], [ingreso_empleado_id], [ingreso_fecha], [egreso_fecha])"
                                        + "VALUES(" + res.id + "," + empleado_id + ", convert(date, '" + Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy") + "', 110), convert(date, '" + Tools.Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy") + "', 110))";
                        conn.ejecutarComandoSQL(query);

                        string query3 = "SELECT ESTADIA_ID FROM [WHERE_EN_EL_DELETE_FROM].[estadias] where reserva_id = " + res.id;
                        DataTable dt2 = conn.cargarTablaSQL(query3);
                        int estadia_id = Int32.Parse(dt2.Rows[0][0].ToString());

                        if (DateTime.Compare(res.fecha_desde, Tools.Sesion.obtenerFechaSistema()) == 0)//si estamos en la fecha de hoy.
                        {
                            IngresoHuespedes ingresoHuespedes = new IngresoHuespedes(estadia_id);
                            ingresoHuespedes.Show();
                            //this.Close();
                        }
                        else if (DateTime.Compare(res.fecha_desde, Tools.Sesion.obtenerFechaSistema()) > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Solo se puede realizar el día de la reserva, no antes");
                        }
                        else
                        {
                            //el dia es posterior y se perdió la reserva - se cancela.
                            //ir a form de pregunta si se quiere reservar de vuelta o no. 
                            res.motivoCancelacion = "El cliente no ingresó a tiempo";
                            try
                            {
                                int exito = res.cancelarReserva();
                                System.Windows.Forms.MessageBox.Show("La reserva ha sido cancelada por llegada tarde.");
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                            }

                            //PreguntaNuevaRerva preguntaNuevaRerva = new PreguntaNuevaRerva();
                            //preguntaNuevaRerva.Show();


                        }
                        //FormGenerarModificarReserva form = new FormGenerarModificarReserva(res, Convert.ToInt32(row.Cells[8].Value));
                        //form.Owner = this;
                        //form.Show();
                    }
                    //else
                    //{
                    //    System.Windows.Forms.MessageBox.Show("No es posible modificar su reserva a menos de un día de que comience. ");
                    //}
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();

            string sqlQuery = @"select codigo, fecha_desde, fecha_hasta, isNull(h.nombre, 'Hotel ' + h.direccion) AS Hotel, datediff(dd, getdate(), fecha_desde) AS DiasHastaLaReserva, 
                    r.hotel_id, r.regimen_id, (select distinct tipos_id FROM WHERE_EN_EL_DELETE_FROM.reservas_habitaciones reshab INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones hab on hab.habitacion_id = reshab.habitacion_id AND reshab.reserva_id = r.reserva_id) AS idTipoHabitacion,
                    r.cliente_id, r.reserva_id 
                    FROM WHERE_EN_EL_DELETE_FROM.Reservas r 
                    INNER JOIN WHERE_EN_EL_DELETE_FROM.Hoteles h on h.hotel_id = r.hotel_id WHERE ";

            if (txtCodigo.Text.Length > 0)
            {
                sqlQuery += "codigo = " + txtCodigo.Text.ToString();
                sqlQuery += " AND estado not like 'cancelad%'";
                DataTable dt = conn.cargarTablaSQL(sqlQuery);
                dgvReservas2.DataSource = dt;
                this.Cursor = Cursors.Default;

                dgvReservas2.Columns["regimen_id"].Visible = false;
                dgvReservas2.Columns["hotel_id"].Visible = false;
                dgvReservas2.Columns["DiasHastaLaReserva"].Visible = false;
                dgvReservas2.Columns["idTipoHabitacion"].Visible = false;

            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvReservas2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
