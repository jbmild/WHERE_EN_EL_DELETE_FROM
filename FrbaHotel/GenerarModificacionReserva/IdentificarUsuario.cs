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
    public partial class IdentificarUsuario : Form
    {

        private Reserva res;

        public IdentificarUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IdentificarUsuario_Load(object sender, EventArgs e)
        {
            //Recibo ID de otro form.
            //Reserva res = new Reserva();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdentificarUsuarioExtendido frmUsuExtendido = new IdentificarUsuarioExtendido();

            frmUsuExtendido.Show();
        }

  
    }
}
