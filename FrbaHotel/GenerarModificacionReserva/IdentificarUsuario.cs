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

        private Reserva reserva;

        public IdentificarUsuario() {
            InitializeComponent();
        }

        public IdentificarUsuario(Reserva res)
        {
            InitializeComponent();
            this.reserva = res;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IdentificarUsuario_Load(object sender, EventArgs e)
        {
            cmbTiposDocumentos.Items.Add("DNI");
            cmbTiposDocumentos.Items.Add("Pasaporte");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            
            IdentificarUsuarioExtendido frmUsuExtendido = new IdentificarUsuarioExtendido(reserva, Convert.ToInt32(cmbTiposDocumentos.SelectedValue),
                                                                            txtNroDocumento.Text,
                                                                            txtMail.Text);
            frmUsuExtendido.Show();
        }

  
    }
}
