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

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class FormGenerarModificarReserva : Form
    {
        public FormGenerarModificarReserva()
        {
            InitializeComponent();
        }

       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            Form form1 = new Form();
            this.Cursor = Cursors.WaitCursor;

            try
            {

                DataTable dt = conexion.cargarTablaSQL("WHERE_EN_EL_DELETE_FROM.obtenerHabitacionesDisponibles @fdesde='" + dtpFechaCheckin.Value + "'" + 
                                                        ",@fhasta='" + dtpFechaCheckout.Value + "'" +
                                                        ",@hotel_id=" + (cmbHotel.SelectedText.Length == 0 ? "null": cmbHotel.SelectedValue) +
                                                        ",@regimen_id=" + (cmbTipoRegimen.SelectedText.Length == 0? "null": cmbTipoRegimen.SelectedValue) +
                                                        ",@tipoHabitacion_id=" + (cmbTipoHab.SelectedText.Length == 0 ? "null" : cmbTipoHab.SelectedValue));

                //Se muestra por pantalla la tabla con los resultados del SELECT
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].Visible = dataGridView1.Columns[4].Visible = false;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                form1.Text = ex.Message;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGenerarModificarReserva_Load(object sender, EventArgs e)
        {
            
            ConexionSQL conexion = new ConexionSQL();
            
            DataTable dt;
            dt = conexion.cargarTablaSQL("select tipo_id, descripcion from WHERE_EN_EL_DELETE_FROM.habitaciones_tipos");
            dt.Rows.InsertAt(dt.NewRow(), 0); //DESCOMENTAR PARA QUE AGREGUE UNA ROW VACIA EN COMBO
            cmbTipoHab.DataSource = dt;
            //cmbTipoHab.SelectedIndex = 0; //DESCOMENTAR PARA QUE AGREGUE UNA ROW VACIA EN COMBO

            cmbTipoHab.DisplayMember = "descripcion";
            cmbTipoHab.ValueMember = "tipo_id";



            dt = conexion.cargarTablaSQL("select regimen_id, descripcion FROM WHERE_EN_EL_DELETE_FROM.regimenes WHERE habilitado = 1");
            dt.Rows.InsertAt(dt.NewRow(), 0);
            cmbTipoRegimen.DataSource = dt;
            cmbTipoRegimen.DisplayMember = "descripcion";
            cmbTipoRegimen.ValueMember = "regimen_id";

            dt = conexion.cargarTablaSQL("select hotel_id, 'Hotel ' + direccion AS nombre FROM WHERE_EN_EL_DELETE_FROM.hoteles");
            dt.Rows.InsertAt(dt.NewRow(), 0);
            cmbHotel.DataSource = dt;
            cmbHotel.DisplayMember = "nombre";
            cmbHotel.ValueMember = "hotel_id";


            //Ocultar combo hotel si el usuario es recepcionista. 
            //Si es admin o guest, mostrar combo hotel.
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
            List <Habitacion> habs = new List<Habitacion>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    habs.Add(new Habitacion(Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[3].Value)));
                    //Mandar datos res{erva a pantalla Ingreso datos cliente
                }

            }
            IdentificarUsuario identificarUsuario = new IdentificarUsuario(new Reserva(dtpFechaCheckin.Value,
                                                                                        dtpFechaCheckout.Value,
                                                                                        0, // Completar total de todas las habs
                                                                                        Convert.ToInt32(cmbTipoRegimen.SelectedValue),
                                                                                        Convert.ToInt32(cmbHotel.SelectedValue),
                                                                                        habs));

            identificarUsuario.Show();

        }
    }
}
