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
            this.textBoxActualHotel.Text = habitacion.GetDireccion().ToString();
            this.textBoxActualPiso.Text = habitacion.GetPiso().ToString();
            this.textBoxActualDescripcion.Text = habitacion.GetDescripcion().ToString();
            if (habitacion.GetHabilitado().Equals(1))
            {
                this.checkBoxEstaHabilitadoActualmente.Checked = true;
            }
            else 
            {
                this.checkBoxNoEstaHabilitadoActualmente.Checked = true;
            }
            if (habitacion.GetVista().Equals(1))
            {
                this.checkBoxTieneVistaExteriorActualmente.Checked = true;
            }
            else 
            {
                this.checkBoxNoTieneVistaExteriorActualmente.Checked = true;
            }
            this.checkBoxEstaHabilitadoActualmente.Enabled = false;
            this.checkBoxNoEstaHabilitadoActualmente.Enabled = false;
            this.checkBoxTieneVistaExteriorActualmente.Enabled = false;
            this.checkBoxNoTieneVistaExteriorActualmente.Enabled = false;
        }
    }
}
