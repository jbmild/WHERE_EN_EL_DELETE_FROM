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
    public partial class modificarHotel : Form

        
    {
        AbmHoteles abm = new AbmHoteles();
        public modificarHotel()
        {
            InitializeComponent();
            

        }

        private void modificarHotel_Load(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable estrellas = c.cargarTablaSQL("select distinct estrellas_cant from WHERE_EN_EL_DELETE_FROM.hoteles");
            estrellas.Rows.InsertAt(estrellas.NewRow(),0);
            comboBoxEstrellas.DataSource=estrellas;    
            comboBoxEstrellas.SelectedIndex=0;
            comboBoxEstrellas.DisplayMember="estrellas_cant";
            comboBoxEstrellas.ValueMember="estrellas_cant";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombreNoVacio=0;
            int estrellasNoVacio=0;
            int ciudadNoVacio=0;
            
            ConexionSQL c = new ConexionSQL();
            string consulta = "select hotel_id, isNull(nombre, 'hotel ' + direccion) as 'nombre', mail, telefono, direccion, ciudad, pais, estrellas_cant, estrellas_recargo, convert(varchar(10), fecha_creacion, 110) As [Fecha Creacion] from WHERE_EN_EL_DELETE_FROM.hoteles";
            if(textBoxHotelNombre.Text.Equals("")){}else{nombreNoVacio=1; consulta+=" where nombre like '%" + textBoxHotelNombre.Text + "%'";}
            if(comboBoxEstrellas.Text.Equals("")){}else
            {
                estrellasNoVacio=1;
                if(nombreNoVacio.Equals(1))
                {
                    consulta+=" and estrellas_cant=" + comboBoxEstrellas.SelectedValue;
                }else
                {
                    consulta+=" where estrellas_cant=" + comboBoxEstrellas.SelectedValue;
                }
            }
            if(textBoxCiudad.Text.Equals("")){}else
            {
                ciudadNoVacio=1;
                if (estrellasNoVacio.Equals(1) || nombreNoVacio.Equals(1))
                {
                    consulta+=" and ciudad like '%" + textBoxCiudad.Text + "%'";
                }
                else
                {
                    consulta+=" where ciudad like '%" + textBoxCiudad.Text + "%'";
                }
            }
            if (textBoxPais.Text.Equals("")){}else
            {
                if (estrellasNoVacio.Equals(1) || nombreNoVacio.Equals(1) || ciudadNoVacio.Equals(1))
                {
                    consulta+=" and pais like '%" + textBoxPais.Text + "%'";
                }
                else
                {
                    consulta+= " where pais like '%" + textBoxPais.Text + "%'";
                }
            }
            DataTable resultados = c.cargarTablaSQL(consulta);
            dataGridView1.DataSource = resultados;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPais.Text = "";
            textBoxHotelNombre.Text = "";
            textBoxCiudad.Text = "";
            comboBoxEstrellas.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[row];

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

                //hotel.SetNombre(selectedRow.Cells[3].Value.ToString());
                //habitacion.SetTipo(selectedRow.Cells[4].Value.ToString());
                //habitacion.SetDireccion(selectedRow.Cells[7].Value.ToString());
                //habitacion.SetHabiID(Int32.Parse(selectedRow.Cells[8].Value.ToString()));
                //habitacion.SetHotelID(this.ObtenerHotelID(habitacion));


              
            }
            if (e.ColumnIndex.Equals(1)) {

                bajaHotel frmBaja = new bajaHotel(Int32.Parse(selectedRow.Cells[2].Value.ToString()));
                frmBaja.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (abm.GetVentanaAbierta().Equals(1)) 
            {
                MessageBox.Show("No se puede dar de alta un hotel mientras la ventana de edición está abierta");
            }
            else
            {
                altaHotel alta = new altaHotel();
                alta.Show();
            }
        }

       
    }
}
