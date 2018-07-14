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
using FrbaHotel.Login.Modelo;
using FrbaHotel.Roles.Modelo;
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
            try
            {
                DBInterface.conectar();
                Sesion.obtenerFechaSistema();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                this.Close();
                return;
            }

            Sesion.usuario = new Usuario("guest");
            Sesion.rol = null;

            if (Sesion.usuario.NombreUsuario.Equals(""))
            {
                Sesion.usuario = null;
            }

            List<Rol> roles =  Sesion.usuario.obtenerRolesHabilitados();
            foreach (Rol rol in roles)
            {
                if (rol.EsDefault)
                {
                    Sesion.rol = rol;
                }
            }


            cargarFormulario();
        }

        private void cargarFormulario()
        {
            lblUsuario.Text = Sesion.usuario.NombreUsuario;

            if (Sesion.usuario == null || Sesion.usuario.NombreUsuario.Equals("guest"))
            {
                btnLogin.Text = "Ingresar";
            }
            else
            {
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

            lblRol.Hide();
            btnClientes.Hide();
            btnConsumibles.Hide();
            btnFacturacion.Hide();
            btnEstadias.Hide();
            btnHoteles.Hide();
            btnUsuarios.Hide();
            btnHabitaciones.Hide();
            btnEstadisticas.Hide();
            btnRoles.Hide();
            btnGenerarModificarReserva.Hide();
            btnCancelarReserva.Hide();
            btnRegimenes.Hide();

            lblRol.Text = "Rol: " + Sesion.rol.Nombre;
            lblRol.Show();

            if (Sesion.rol != null)
            {
                List<Roles.Modelo.Permiso> permisos = Sesion.rol.PermisosDados;
                if (permisos.Count > 0)
                {
                    foreach (Roles.Modelo.Permiso permiso in permisos)
                    {
                        switch (permiso.Nombre)
                        {
                            case "Roles":
                                btnRoles.Show();
                                break;
                            case "Clientes":
                                btnClientes.Show();
                                break;
                            case "Usuarios":
                                btnUsuarios.Show();
                                break;
                            case "Hoteles":
                                btnHoteles.Show();
                                break;
                            case "Habitaciones":
                                btnHabitaciones.Show();
                                break;
                            case "Generar o Modificar Reserva":
                                btnGenerarModificarReserva.Show();
                                break;
                            case "Cancelar Reserva":
                                btnCancelarReserva.Show();
                                break;
                            case "Estadias":
                                btnEstadias.Show();
                                break;
                            case "Consumibles":
                                btnConsumibles.Show();
                                break;
                            case "Facturacion":
                                btnFacturacion.Show();
                                break;
                            case "Estadisticas":
                                btnEstadisticas.Show();
                                break;
                            case "Regimenes":
                                btnRegimenes.Show();
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
            if (Sesion.usuario == null || Sesion.usuario.NombreUsuario.Equals("guest"))
            {
                frmLogin login = new frmLogin();
                login.ShowDialog(this);
            }
            else
            {
                Sesion.usuario = new Usuario("guest");
                Sesion.rol = null;
                Sesion.hotel = null;

                if (Sesion.usuario.NombreUsuario.Equals(""))
                {
                    Sesion.usuario = null;
                }

                if (Sesion.usuario != null)
                {
                    List<Rol> roles = Sesion.usuario.obtenerRolesHabilitados();
                    foreach (Rol rol in roles)
                    {
                        if (rol.EsDefault)
                        {
                            Sesion.rol = rol;
                        }
                    }
                }
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
            Hoteles.frmHotelesListado hotelPantalla = new Hoteles.frmHotelesListado();
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

        private void Bienvenido_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DBInterface.desconectar();
            }
            catch (Exception)
            {
            }
        }

        private void btnRegimenes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no esta disponible desde esta aplicacion. Contactese con su supervisor para obtener acceso a la misma.");
        }
    }
}
