using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class modificarDatosHotel : Form
    {
        public modificarDatosHotel()
        {
            InitializeComponent();
        }

        internal void RecibirHotel(HotelElegido hotel)
        {
            this.labelCiudad.Text = hotel.GetCiudad();
            this.labelDireccion.Text = hotel.GetDireccion();
            this.labelHotel.Text = hotel.GetNombre();
            this.labelMail.Text = hotel.GetMail();
            this.labelPais.Text = hotel.GetPais();
            this.labelTelefono.Text = hotel.GetTelefono().ToString();
        }
    }
}
