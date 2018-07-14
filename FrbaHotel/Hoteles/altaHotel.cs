using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FrbaHotel.Tools;

namespace FrbaHotel.Hoteles
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
            this.listBoxRegimenes.Items.Clear();
            for (int i = 0; i < list.Items.Count; i++)
            {
                this.listBoxRegimenes.Items.Add(list.Items[i].ToString());
            };
            this.reg = regimenCompleto;


        }

        private void altaHotel_Load(object sender, EventArgs e)
        {
            this.listBoxRegimenes.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.TodosLosCamposEstanCompletados())
            {
                AltaHotelObject altaObject = new AltaHotelObject();
                altaObject.darDeAlta(this.textBoxCiudadNuevoHotel, this.textBoxDireccionNuevoHotel, this.textBoxEstrellasRecargo, this.textBoxMailNuevoHotel,
                    this.textBoxNombreNuevoHotel, this.textBoxPaisNuevoHotel, this.textBoxTelefonoNuevo, this.comboBoxEstrellas, this.listBoxRegimenes);


                this.Hide();
            }


        }

        private bool TodosLosCamposEstanCompletados()
        {
            int completo = 0;
            if (this.textBoxEstrellasRecargo.Text.Equals(""))
            {
                this.labelEstrellasRecargo.Visible = true;
            }
            else
            {
                completo++;
                this.labelEstrellasRecargo.Visible = false;
            }
            if (this.comboBoxEstrellas.SelectedIndex.Equals(-1))
            {
                this.labelEstrellasPendiente.Visible = true;
            }
            else
            {
                completo++;
                this.labelEstrellasPendiente.Visible = false;
            }

            if (this.textBoxCiudadNuevoHotel.Text.Equals(""))
            {
                this.labelCiudadPendiente.Visible = true;
            }
            else
            {
                completo++;
                this.labelCiudadPendiente.Visible = false;
            }

            if (this.textBoxDireccionNuevoHotel.Text.Equals(""))
            {
                this.labelDireccionPendiente.Visible = true;
            }
            else
            {
                completo++;
                this.labelDireccionPendiente.Visible = false;
            }

            if (this.textBoxMailNuevoHotel.Text.IndexOf('@').Equals(-1))
            {
                this.labelMailPendiente.Visible = true;
            }
            else
            {
                completo++;
                this.labelMailPendiente.Visible = false;
            }

            if (this.textBoxNombreNuevoHotel.Text.Equals(""))
            {
                this.labelNombrePendiente.Visible = true;
            }
            else
            {
                completo++;
                this.labelNombrePendiente.Visible = false;
            }

            if (this.textBoxTelefonoNuevo.Text.Equals(""))
            {
                this.labelTelefonoPendiente.Visible = true;
            }
            else
            {
                completo++;
                this.labelTelefonoPendiente.Visible = false;
            }

            if (this.textBoxPaisNuevoHotel.Text.Equals(""))
            {
                this.labelPaisPendiente.Visible = true;
            }
            else
            {
                completo++;
                this.labelPaisPendiente.Visible = false;
            }

            if (this.listBoxRegimenes.Items.Count.Equals(0)) { this.labelRegimenesPendiente.Visible = true; }
            else
            {
                completo++;
                this.labelRegimenesPendiente.Visible = false;
            }

            if (completo.Equals(9)) { return true; } else { return false; }
        }




    }
}
