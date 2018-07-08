using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class CheckIn : Form
    {
        String numeroDeReserva;
        DateTime fechaDesde;
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
                dgvReservas.DataSource = dt;
                this.Cursor = Cursors.Default;

                dgvReservas.Columns["regimen_id"].Visible = false;
                dgvReservas.Columns["hotel_id"].Visible = false;
                dgvReservas.Columns["DiasHastaLaReserva"].Visible = false;
                dgvReservas.Columns["idTipoHabitacion"].Visible = false;

            }
        }
    }
}
