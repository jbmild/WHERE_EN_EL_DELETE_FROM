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
        private FrbaHotel.Modelo.Hotel hotel; //Es el hotel elegido al momento del log in
        private FrbaHotel.Modelo.Usuario usuario; //Es el usuario que se logueó
        private Roles.Modelo.Rol rol; //Es el rol elegido al momento del log in
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
            GenerarModificacionReserva.MenuCRUDReserva formMenu = new GenerarModificacionReserva.MenuCRUDReserva();
            formMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmHabitacion.abmHabitacionBotones formHabitacion = new AbmHabitacion.abmHabitacionBotones();
           formHabitacion.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login.View.AccesoUsuarioHotel acceso = new Login.View.AccesoUsuarioHotel();
            acceso.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            AbmHotel.pantallaPrincipalHotel alta = new AbmHotel.pantallaPrincipalHotel();
            alta.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrarConsumible.registrarConsumible consumible = new RegistrarConsumible.registrarConsumible();
            consumible.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbmCliente.ClienteFicha form = new AbmCliente.ClienteFicha();
            form.Show();
        }

    }
}
