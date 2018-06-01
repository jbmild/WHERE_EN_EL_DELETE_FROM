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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            Form form1 = new Form();

            try
            {
                DataTable dt = conexion.cargarTablaSQL("select * from WHERE_EN_EL_DELETE_FROM.Reservas");

                form1.Text = dt.Rows[0].ItemArray[0].ToString() + dt.Rows[0].ItemArray[4].ToString();
                form1.ShowDialog(this);
                
                
                
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
    }
}
