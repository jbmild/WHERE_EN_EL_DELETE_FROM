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
            
                DataTable dt = conexion.cargarTablaSQL("select * from WHERE_EN_EL_DELETE_FROM.Reservas");

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

        }
    }
}
