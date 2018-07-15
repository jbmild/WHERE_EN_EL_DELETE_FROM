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
using System.Data.SqlClient;
using FrbaHotel.Tools;


namespace FrbaHotel.Reservas
{
    public partial class ModificarCancelarReserva : Form
    {
        int usuario = 1;
        Reserva res;
        bool _cancelarReserva;

        public ModificarCancelarReserva(bool cancelarReserva)
        {
            _cancelarReserva = cancelarReserva;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();

            string sqlQuery = @"select codigo, c.nombre + ' ' + c.apellido As Cliente, fecha_desde, fecha_hasta, isNull(h.nombre, 'Hotel ' + h.direccion) AS Hotel, datediff(dd, getdate(), fecha_desde) AS DiasHastaLaReserva, 
                    r.hotel_id, r.regimen_id, (select distinct tipos_id FROM WHERE_EN_EL_DELETE_FROM.reservas_habitaciones reshab INNER JOIN WHERE_EN_EL_DELETE_FROM.habitaciones hab on hab.habitacion_id = reshab.habitacion_id AND reshab.reserva_id = r.reserva_id) AS idTipoHabitacion,
                    r.cliente_id, r.reserva_id
                    FROM WHERE_EN_EL_DELETE_FROM.Reservas r 
                    INNER JOIN WHERE_EN_EL_DELETE_FROM.Hoteles h on h.hotel_id = r.hotel_id 
                    INNER JOIN WHERE_EN_EL_DELETE_FROM.Clientes c on c.cliente_id = r.cliente_id WHERE ";

            if (txtCodigo.Text.Length > 0)
            {
                sqlQuery += "codigo = " + txtCodigo.Text.ToString();
                sqlQuery += " AND estado in ('correcta', 'modificada') ";

                if (Sesion.hotel != null) {
                    sqlQuery += " AND h.hotel_id = " + Sesion.hotel.HotelId.ToString();
                }

                DataTable dt = conn.cargarTablaSQL(sqlQuery);
                dgvReservas.DataSource = dt;
                this.Cursor = Cursors.Default;

                dgvReservas.Columns["regimen_id"].Visible = false;
                dgvReservas.Columns["hotel_id"].Visible = false;
                dgvReservas.Columns["DiasHastaLaReserva"].Visible = false;
                dgvReservas.Columns["idTipoHabitacion"].Visible = false;
                dgvReservas.Columns["reserva_id"].Visible = false;
                dgvReservas.Columns["cliente_id"].Visible = false;

            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (Convert.ToInt32(row.Cells[0].Value) >= 1)
                    {
                        //TODO: MUESTRO FORM PARA MODIFICAR RESERVA
                        Reserva res = new Reserva();
                        res.fecha_desde = Convert.ToDateTime(row.Cells[3].Value);
                        res.fecha_hasta = Convert.ToDateTime(row.Cells[4].Value);
                        res.codigo = Convert.ToInt32(row.Cells[1].Value);
                        res.hotel_id = Convert.ToInt32(row.Cells[7].Value);
                        res.regimen_id = Convert.ToInt32(row.Cells[8].Value);
                        res.cliente_id = Convert.ToInt32(row.Cells[10].Value);
                        res.id = Convert.ToInt32(row.Cells[11].Value);

                        int tipohabitacion_id = Convert.ToInt32(row.Cells[9].Value);
                        FormSeleccionarHabitaciones form = new FormSeleccionarHabitaciones(res, tipohabitacion_id);
                        form.Owner = this;
                        form.Show();
                    }
                    else {
                        System.Windows.Forms.MessageBox.Show("No es posible modificar su reserva a menos de un día de que comience. ");
                    }
                            
                }
            }    
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (Convert.ToInt32(row.Cells[0].Value) >= 1)
                    {
                        Reserva res = new Reserva();
                        res.codigo = Convert.ToInt32(row.Cells[1].Value);
                        res.usuarioCancelacion = Sesion.usuario.UsuarioId;
                        frmMotivoCancelacion form = new frmMotivoCancelacion(res);
                        form.Owner = this;
                        form.Show();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No es posible modificar su reserva a menos de un día de que comience. ");
                    }
                }
            }
        }

        private void ModificarCancelarReserva_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            dgvReservas.Rows.Clear();
            if (_cancelarReserva)
            {
                btnEliminar.Visible = true;
                btnModificar.Visible = false;
                this.Text = "Cancelar Reserva";
            }
            else {
                btnEliminar.Visible = false;
                btnModificar.Visible = true;
                this.Text = "Modificar Reserva";
            }
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
