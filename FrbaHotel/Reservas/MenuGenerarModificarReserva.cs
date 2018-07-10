using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Reservas
{
    public partial class MenuGenerarModificarReserva : Form
    {
        public MenuGenerarModificarReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarReservaPrincipal form = new GenerarReservaPrincipal();
            form.Show();
        }

        private void btnModificarCancelar_Click(object sender, EventArgs e)
        {
            ModificarCancelarReserva form = new ModificarCancelarReserva(false);
            form.Show();
        }
    }
}
