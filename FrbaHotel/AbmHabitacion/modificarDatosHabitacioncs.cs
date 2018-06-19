using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class modificarDatosHabitacioncs : Form
    {
        public modificarDatosHabitacioncs()
        {
            InitializeComponent();
        }

        private void modificarDatosHabitacioncs_Load(object sender, EventArgs e)
        {

        }
        public void  RecibirHabitacion(HabitacionElegida habitacion) 
        {
            this.labelHotelActual.Text = habitacion.GetDireccion().ToString();
            this.labelPisoEnHotel.Text = habitacion.GetPiso().ToString();
            if (habitacion.GetDescripcion().ToString().Equals(""))
            {
                this.labelDescripcionActual.Text = "(vacio)";
            }
            else 
            {
                this.labelDescripcionActual.Text = habitacion.GetDescripcion().ToString();
            }
            
            if (habitacion.GetHabilitado().Equals(1))
            {
                this.labelHabilitadoActualmente.Text="Sí";
            }
            else 
            {
                this.labelHabilitadoActualmente.Text="No";
            }
            if (habitacion.GetVista().Equals(1))
            {
                this.labelTieneVistaExterior.Text="Sí";
            }
            else 
            {
                this.labelTieneVistaExterior.Text = "No";
            }
            }
    }
}
