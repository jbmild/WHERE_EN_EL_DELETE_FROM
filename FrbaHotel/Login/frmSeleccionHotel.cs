using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Hoteles.Modelo;
using FrbaHotel.Login.Modelo;
using FrbaHotel.Tools;

namespace FrbaHotel.Login
{
    public partial class frmSeleccionHotel : Form
    {
        public frmSeleccionHotel()
        {
            InitializeComponent();
        }

        private void frmSeleccionHotel_Load(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            if (empleado.loadByUsuario(Sesion.usuario.UsuarioId))
            {

                List<Hotel> hoteles = empleado.obtenerHoteles();
                if (hoteles.Count == 1)
                {
                    Sesion.hotel = hoteles[0];
                    this.Close();
                }
                else if (hoteles.Count > 1)
                {
                    foreach (Hotel hotel in hoteles)
                    {
                        cmbHoteles.Items.Add(new Option(hotel.HotelId.ToString(), hotel.Nombre));
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {

                MessageBox.Show("No hay ningun empleado asociado a este usuario. No se puede loguear.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (cmbHoteles.SelectedIndex >= 0)
            {
                Option opcion = (Option)cmbHoteles.Items[cmbHoteles.SelectedIndex];
                int hotelId = Convert.ToInt32(opcion.Value);
                Sesion.hotel = new Hotel(hotelId);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel con el que desea continuar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
