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
using FrbaHotel.Tools;


namespace FrbaHotel.Hoteles
{
    public partial class frmHotelesListado : Form

        
    {
        AbmHoteles abm = new AbmHoteles();
        public frmHotelesListado()
        {
            InitializeComponent();
            

        }

        private void frmHotelesListado_Load(object sender, EventArgs e)
        {
            List<int> estrellas = Estrellas.obtener();

            cmbEstrellas.Items.Clear();
            foreach (int estrella in estrellas)
            {
                cmbEstrellas.Items.Add(new Option(estrella.ToString(), estrella.ToString()));
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int estrellas = 0;
            if (cmbEstrellas.SelectedIndex != -1)
            {
                Option opcion = (Option)cmbEstrellas.Items[cmbEstrellas.SelectedIndex];
                estrellas = Convert.ToInt32(opcion.Value);
            }

            this.CargarGrilla(Hoteles.Modelo.Hoteles.obtener(txtNombre.Text, txtCiudad.Text, txtPais.Text, estrellas));

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPais.Text = "";
            txtNombre.Text = "";
            txtCiudad.Text = "";
            cmbEstrellas.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgwHoteles.Rows[e.RowIndex];

            if (e.ColumnIndex.Equals(0))
            {
                abm.SetVentanaAbierta();
                this.Hide();
               
                HotelElegido hotel = new HotelElegido();
                
                hotel.SetNombre(selectedRow.Cells[3].Value.ToString());
                hotel.SetMail(selectedRow.Cells[4].Value.ToString());
                hotel.SetTelefono(selectedRow.Cells[5].Value.ToString());
                hotel.SetDireccion(selectedRow.Cells[6].Value.ToString());
                hotel.SetCiudad(selectedRow.Cells[7].Value.ToString());
                hotel.SetPais(selectedRow.Cells[8].Value.ToString());
                hotel.SetEstrellas_Cant(Int32.Parse(selectedRow.Cells[9].Value.ToString()));
                hotel.SetEstrellas_Recargo(Int32.Parse(selectedRow.Cells[10].Value.ToString()));
                hotel.SetFechaCreacion(DateTime.Parse(selectedRow.Cells[11].Value.ToString()));
                hotel.SetID(Int32.Parse(selectedRow.Cells[2].Value.ToString()));
                modificarDatosHotel datosHotel = new modificarDatosHotel();
                datosHotel.RecibirHotel(hotel);
                datosHotel.Show();
                this.Hide();
            }else if (e.ColumnIndex.Equals(1)) {

                bajaHotel frmBaja = new bajaHotel(Int32.Parse(selectedRow.Cells[2].Value.ToString()));
                frmBaja.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            altaHotel alta = new altaHotel();
            alta.ShowDialog();
        }

        private void CargarGrilla(DataTable data)
        {
            dgwHoteles.DataSource = data;
        }

       
    }
}
