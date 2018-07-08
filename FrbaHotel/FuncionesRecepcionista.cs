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
    public partial class FuncionesRecepcionista : Form
    {
        private int hotelid;
        private string hotelnombre;
        public FuncionesRecepcionista()
        {
            InitializeComponent();
        }

        internal void RecibirHotel(int p, string hotel)
        {
            this.hotelnombre = hotel;
            this.hotelid = p;
        }

        private void FuncionesRecepcionista_Load(object sender, EventArgs e)
        {
            this.labelhotel.Text = this.hotelnombre;
        }
    }
}
