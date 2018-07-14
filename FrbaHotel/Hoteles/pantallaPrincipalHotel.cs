using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Hoteles
{
    public partial class pantallaPrincipalHotel : Form
    {
        public pantallaPrincipalHotel()
        {
            InitializeComponent();
        }

        private void altaHotel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hoteles.altaHotel alta = new Hoteles.altaHotel();
            alta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hoteles.frmHotelesListado m = new Hoteles.frmHotelesListado();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hoteles.bajaHotel b = new Hoteles.bajaHotel(1);
            b.Show();
        }
    }
}
