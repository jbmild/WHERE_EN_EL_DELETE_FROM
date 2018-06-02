using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                                                        ",@hotel_id=" + cmbHotel.SelectedValue +
                                                        ",@regimen_id=" + cmbTipoRegimen.SelectedValue +
                                                        ",@tipoHabitacion_id=" + cmbTipoHab.SelectedValue);

                //Se muestra por pantalla la tabla con los resultados del SELECT
                dataGridView1.DataSource = dt;
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
            //dt.Rows.InsertAt(dt.NewRow(), 0);
            cmbTipoHab.DataSource = dt;
            //cmbTipoHab.SelectedIndex = 0;

            cmbTipoHab.DisplayMember = "descripcion";
            cmbTipoHab.ValueMember = "tipo_id";



            dt = conexion.cargarTablaSQL("select regimen_id, descripcion FROM WHERE_EN_EL_DELETE_FROM.regimenes WHERE habilitado = 1");
            cmbTipoRegimen.DataSource = dt;
            cmbTipoRegimen.DisplayMember = "descripcion";
            cmbTipoRegimen.ValueMember = "regimen_id";

            dt = conexion.cargarTablaSQL("select hotel_id, 'Hotel ' + direccion AS nombre FROM WHERE_EN_EL_DELETE_FROM.hoteles");
            cmbHotel.DataSource = dt;
            cmbHotel.DisplayMember = "nombre";
            cmbHotel.ValueMember = "hotel_id";

        }
    }
}
