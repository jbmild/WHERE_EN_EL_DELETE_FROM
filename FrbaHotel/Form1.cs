using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmRegimen.ABM_regimen regimen = new AbmRegimen.ABM_regimen();
            regimen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.GenerarReservaPrincipal formReserva = new GenerarModificacionReserva.GenerarReservaPrincipal();
            formReserva.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmHabitacion.abmHabitacionBotones formHabitacion = new AbmHabitacion.abmHabitacionBotones();
           formHabitacion.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login.SeleccionUsuario seleccionUsuario = new Login.SeleccionUsuario();
            seleccionUsuario.Show();
        }

        private void btnRegistrarEstadia_Click(object sender, EventArgs e)
        {
            RegistrarEstadia.RegistrarEstadia registrarEstadia = new RegistrarEstadia.RegistrarEstadia();
            registrarEstadia.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Roles.frmRolesListado frmListado = new Roles.frmRolesListado();
            frmListado.Show();
        }
    }
}
