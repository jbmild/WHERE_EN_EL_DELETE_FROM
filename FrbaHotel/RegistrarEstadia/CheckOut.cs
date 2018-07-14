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
    public partial class CheckOut : Form
    {
        ConexionSQL conn = new ConexionSQL();
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aca redirige a facturación. 

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (Convert.ToInt32(row.Cells[0].Value) >= 1)
                    {
                        int estadia_id = Convert.ToInt32(row.Cells[1].Value);

                        //se updetea la tabla estadia con la fecha de hoy. 
                        if((estadia_id).ToString() != null)
                        {

                            string query2 = "SELECT EMPLEADO_ID FROM [WHERE_EN_EL_DELETE_FROM].[empleados] where usuario_id = " + Tools.Sesion.usuario.UsuarioId;
                            DataTable dt = conn.cargarTablaSQL(query2);
                            int empleado_id = Int32.Parse(dt.Rows[0][0].ToString());

                            string queryUpdate = "UPDATE [WHERE_EN_EL_DELETE_FROM].[estadias] SET egreso_empleado_id = " + empleado_id + ", egreso_fecha = '"
                            + Tools.Sesion.obtenerFechaSistema() + "' WHERE estadia_id = " + estadia_id;
                        conn.ejecutarComandoSQL(queryUpdate);

                        }
                        //se redirige.
                        Facturar.frmFacturasFicha facturacion = new Facturar.frmFacturasFicha(estadia_id);
                        facturacion.ShowDialog();
                    }
                }
            }


        }

        private void nroreserva_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Boton de buscar la estadia con el numero de habitación para luego facturar.
            if (nro_hab.Text != "")
            {
            string query = "select E.estadia_id, H.habitacion_id, c.apellido, c.documento_nro from WHERE_EN_EL_DELETE_FROM.estadias E JOIN WHERE_EN_EL_DELETE_FROM.reservas R ON r.reserva_id = e.reserva_id" +
                                                        " JOIN WHERE_EN_EL_DELETE_FROM.reservas_habitaciones RH ON RH.reserva_id = r.reserva_id" +
                                                        " JOIN WHERE_EN_EL_DELETE_FROM.habitaciones H ON RH.habitacion_id = H.habitacion_id" +
                                                        " JOIN WHERE_EN_EL_DELETE_FROM.clientes C ON c.cliente_id = R.cliente_id" +
                                                        " where H.numero =" + nro_hab.Text + " AND R.fecha_hasta = '" + Tools.Sesion.obtenerFechaSistema() + "' AND R.hotel_id = " + Tools.Sesion.hotel.HotelId;

                DataTable dt = conn.cargarTablaSQL(query);
                dataGridView1.DataSource = dt;
                this.Cursor = Cursors.Default;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Ingrese un numero de habitación válido");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
