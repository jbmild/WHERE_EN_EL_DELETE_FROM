using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Estadisticas;
using FrbaHotel.Login;
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
                lblHotel.Text = "Hotel: " + Sesion.hotel.Nombre;
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
                //btnGenerarModificarReserva.Enabled = false;
                //btnCancelarReserva.Enabled = false;
            }
            else
            {
                lblRol.Text = "Rol: " + Sesion.rol.Nombre;
                lblRol.Show();

                List<Roles.Modelo.Permiso> permisos = Sesion.rol.PermisosDados;
                if (permisos.Count > 0)
                {
                    foreach (Roles.Modelo.Permiso permiso in permisos)
                    {
                        switch (permiso.Nombre)
                        {
                            case "Roles":
                                btnRoles.Enabled = true;
                                break;
                            case "Clientes":
                                btnClientes.Enabled = true;
                                break;
	                        case "Usuarios":
                                btnUsuarios.Enabled = true;
                                break;
	                        case "Hoteles":
                                btnHoteles.Enabled = true;
                                break;
	                        case "Habitaciones":
                                btnHabitaciones.Enabled = true;
                                break;
	                        //case "Generar o Modificar Reserva":
                                //btnGenerarModificarReserva.Enabled = true;
                                //break;
	                        //case "Cancelar Reserva":
                                //btnCancelarReserva.Enabled = true;
                                //break;
	                        case "Estadias":
                                btnEstadias.Enabled = true;
                                break;
	                        case "Consumibles":
                                btnConsumibles.Enabled = true;
                                break;
	                        case "Facturacion":
                                btnFacturacion.Enabled = true;
                                break;
                            case "Estadisticas":
                                btnEstadisticas.Enabled = true;
                                break;
                        }
                    }
                }
            }
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Roles.frmRolesListado frmListado = new Roles.frmRolesListado();
            frmListado.ShowDialog(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Sesion.usuario == null)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog(this);
            }
            else
            {
                Sesion.usuario = null;
                Sesion.rol = null;
                Sesion.hotel = null;
            }

            this.cargarFormulario();
        }

        private void btnConsumibles_Click(object sender, EventArgs e)
        {
            RegistrarConsumible.registrarConsumible r = new RegistrarConsumible.registrarConsumible();
            r.RecibirHotel(Sesion.hotel.Nombre, Sesion.hotel.HotelId);
            r.ShowDialog(this);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes.frmFacturasListado listadoClientes = new Clientes.frmFacturasListado();
            listadoClientes.ShowDialog(this);
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            AbmHabitacion.modificarHabitacion formHabitacion = new AbmHabitacion.modificarHabitacion();
            formHabitacion.EnviarHotel(Sesion.hotel.Nombre, Sesion.hotel.HotelId);
            formHabitacion.ShowDialog(this);
        }

        private void btnHoteles_Click(object sender, EventArgs e)
        {
            AbmHotel.modificarHotel hotelPantalla = new AbmHotel.modificarHotel();
            hotelPantalla.ShowDialog(this);
        }

        private void btnEstadias_Click(object sender, EventArgs e)
        {
            RegistrarEstadia.RegistrarEstadia registrarEstadia = new RegistrarEstadia.RegistrarEstadia();
            registrarEstadia.ShowDialog(this);
        }

        private void btnGenerarModificarReserva_Click(object sender, EventArgs e)
        {
            Reservas.MenuGenerarModificarReserva formMenu = new Reservas.MenuGenerarModificarReserva();
            formMenu.ShowDialog(this);
        }


        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            Reservas.ModificarCancelarReserva frm = new Reservas.ModificarCancelarReserva(true);
            frm.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            frmEstadisticas estadisticas = new frmEstadisticas();
            estadisticas.ShowDialog(this);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbmUsuarios.Usuarios u = new AbmUsuarios.Usuarios();
            u.RecibirHotel(Sesion.hotel.HotelId, Sesion.hotel.Nombre);
            u.Show();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            Facturar.frmFacturasListado frm = new Facturar.frmFacturasListado();
            frm.Show();
        }
    }
}
