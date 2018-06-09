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
    public partial class frmConfirmarReserva : Form
    {

        private Cliente _cliente;
        private Reserva _reserva;

        public frmConfirmarReserva(Cliente cli, Reserva res)
        {
            _cliente = cli;
            _reserva = res;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmConfirmarReserva_Load(object sender, EventArgs e)
        {
            lblDatosCliente.Text.Replace("{cliente}", _cliente.apellido + " " + _cliente.nombre);
            //TODO: mostrar datos reserva
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //TODO: Salvar reserva
            System.Windows.Forms.MessageBox.Show("La reserva ha sido guardada. Lo esperamos!");
        }
    }
}
