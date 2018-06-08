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
    public partial class IdentificarUsuarioExtendido : Form
    {
        private Reserva res;

        public IdentificarUsuarioExtendido(int idCliente)
        {
            InitializeComponent();
        }

        public IdentificarUsuarioExtendido(Reserva reserva, int idCliente)
        {
            InitializeComponent();
            res = reserva;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            frmConfirmarReserva frmConfirmarReserva = new frmConfirmarReserva();
            frmConfirmarReserva.Show();
        }
    }
}
