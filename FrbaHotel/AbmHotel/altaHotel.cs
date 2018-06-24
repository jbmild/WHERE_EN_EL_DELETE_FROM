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
    public partial class altaHotel : Form
    {
        private RegimenElegido regimen;
        buscadorRegimenes b;
        int reg;

        public void SetRegimenCompleto() 
        {
            b.SetRegimenesCompletos(1);
        }

        public altaHotel()
        {
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            b = new buscadorRegimenes();
            b.Enviarme(this.listBoxRegimenes, this, b);
            if (reg.Equals(1))
            {
                System.Windows.Forms.MessageBox.Show("No hay más regímenes disponibles para agregarle a este hotel");
                b.Hide();
            }
            else 
            {
                b.Show();
            }
            
           
        }

        internal void RecibirListBox(ListBox list, int regimenCompleto)
        {
            for (int i=0; i < list.Items.Count; i++) 
            {
                this.listBoxRegimenes.Items.Add(list.Items[i].ToString());
            };
            this.reg = regimenCompleto; 

           
        }

        private void altaHotel_Load(object sender, EventArgs e)
        {
            this.listBoxRegimenes.Visible = true;
        }
    }
}
