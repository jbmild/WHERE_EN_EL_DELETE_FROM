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
    public partial class FuncionesAdmin : Form
    {
        private int hotelID;
        private string nombrehotel;
        public FuncionesAdmin()
        {
            InitializeComponent();
        }

        internal void RecibirHotel(int hotelid, string hotel)
        {
            this.hotelID = hotelid;
            this.nombrehotel = hotel;
        }

        private void FuncionesAdmin_Load(object sender, EventArgs e)
        {
            this.labelhotel.Text = nombrehotel;
        }
    }
}
