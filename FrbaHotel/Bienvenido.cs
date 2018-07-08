using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Tools;

namespace FrbaHotel
{
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void Bienvenido_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void cargarFormulario()
        {
            if (Sesion.usuario == null)
            {
                lblUsuario.Hide();
                btnLogin.Text = "Ingresar";
            }
            else
            {
                lblUsuario.Text = Sesion.usuario.NombreUsuario;
                lblUsuario.Show();
                btnLogin.Text = "Salir";
            }

            if (Sesion.hotel == null)
            {
                lblHotel.Hide();
            }
            else
            {
                lblHotel.Text = "Hotel: " + Sesion.hotel.nombre;
                lblHotel.Show();
            }

            if (Sesion.rol == null)
            {
                lblRol.Hide();
                btnClientes.Enabled = false;
                btnConsumibles.Enabled = false;
                btnFacturacion.Enabled = false;
                btnEstadias.Enabled = false;
                btnHoteles.Enabled = false;
                btnUsuarios.Enabled = false;
                btnHabitaciones.Enabled = false;
                btnEstadisticas.Enabled = false;
                btnRoles.Enabled = false;
            }
            else
            {
                lblRol.Text = "Rol: " + Sesion.rol.Nombre;
                lblRol.Show();
                //TODO mostrar los botones disponibles
            }
        }
    }
}
