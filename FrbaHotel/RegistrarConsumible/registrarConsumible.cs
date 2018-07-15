using FrbaHotel.AbmHabitacion;
using FrbaHotel.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class registrarConsumible : Form
    {
        string fecha = "2018-07-05";
        int hotel_id;
        string nombrehotel;
        
        public registrarConsumible()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy");
            this.labelHotel.Text = this.nombrehotel;
            this.labelPrecioSugerido.Visible = false;
            /* CARGAR HABITACIONES */
            
                //convert(Date, @fechaDesde, 110)

           GeneradorConsumo gen= new GeneradorConsumo();
            gen.CargarEstadia(this.habi_id, Sesion.hotel.HotelId);

            /* CARGAR CONSUMIBLES */
            ConexionSQL c = new ConexionSQL();
            DataTable consumibles = c.cargarTablaSQL("select consumible_id, descripcion from WHERE_EN_EL_DELETE_FROM.consumibles");
            consumibles.Rows.InsertAt(consumibles.NewRow(), 0);
            comboBoxConsumible.DataSource = consumibles;
            comboBoxConsumible.SelectedIndex = 0;
            comboBoxConsumible.ValueMember = "consumible_id";
            comboBoxConsumible.DisplayMember = "descripcion";
        }

        private void comboBoxConsumible_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxConsumible.SelectedIndex.Equals(0)) 
            {
                this.labelPrecioSugerido.Text = "";
            } else
            {
                ConexionSQL c = new ConexionSQL();
                DataTable precio = c.cargarTablaSQL("select precio from WHERE_EN_EL_DELETE_FROM.consumibles where consumible_id=" + comboBoxConsumible.SelectedValue);
                this.labelPrecioSugerido.Text = precio.Rows[0].ItemArray[0].ToString();
                this.labelPrecioSugerido.Visible = true;
            }
            
        }

        private void checkBoxMantenerPrecioSugerido_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMantenerPrecioSugerido.Checked) { textBoxPrecioSugerido.Enabled = false; textBoxPrecioSugerido.Text = this.labelPrecioSugerido.Text; } else 
            {
                textBoxPrecioSugerido.Enabled = true; textBoxPrecioSugerido.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int completo = 1;
            if (textBoxCantidad.Text.Equals("")) { this.labelCantidad.Visible = true; } else { this.labelCantidad.Visible = false; completo++; }
           

            if (comboBoxConsumible.SelectedIndex.Equals(0))
            {
                this.labelConsumible.Visible = true;
            }
            else { 
                completo++; this.labelConsumible.Visible = false; 
            }
            if (textBoxPrecioSugerido.Text.Equals(""))
            {
                this.labelPrecio.Visible = true;
            }
            else { completo++; this.labelPrecio.Visible = false; }

            if (completo.Equals(4)) 
            {
                    SQLQueryGenerator q = new SQLQueryGenerator();
                    SqlConnection sql = ConexionSQL.obtenerConexion();
                    GeneradorConsumo consumoGenerado = new GeneradorConsumo();
                    Consumo consumo = new Consumo();
                    consumo.SetCantidad(Int32.Parse(this.textBoxCantidad.Text));
                    consumo.SetConsumible(Int32.Parse(comboBoxConsumible.SelectedValue.ToString()));
                    consumo.SetHabitacion(this.habi_id);
                    if (consumoGenerado.EstadiaAllInclusive(consumo, fecha, hotel_id)) { consumo.SetPrecio("0"); } else { consumo.SetPrecio(textBoxPrecioSugerido.Text.ToString()); }


                    consumoGenerado.registrarConsumible(q, sql, consumo, fecha, hotel_id, this);
                                   }
        }



        internal void RecibirHotel(string hotelnombre, int hotelid, int habiID)
        {
            this.habi_id = habiID;
            this.hotel_id = hotelid;
            this.nombrehotel = hotelnombre;
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxCantidad.Text = "";
            this.textBoxPrecioSugerido.Text = "";
            this.comboBoxConsumible.SelectedIndex = 0;
           
            this.checkBoxMantenerPrecioSugerido.Checked = false;
        }

        public int habi_id { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1_Click(sender, e);
        }

        internal void MostrarGrid(int habi, object estad)
        {
            ConexionSQL c = new ConexionSQL();
            string query = "select co.descripcion, c.precio_unitario" +
                " from WHERE_EN_EL_DELETE_FROM.consumos c " +
                " join WHERE_EN_EL_DELETE_FROM.estadias e on c.estadia_id=e.estadia_id " +
                " join WHERE_EN_EL_DELETE_FROM.consumibles co on c.consumible_id=co.consumible_id" +
                " where e.estadia_id=" + estad +
                " and c.habitacion_id=" + habi +
                " order by e.ingreso_fecha desc";
            DataTable consumos = c.cargarTablaSQL(query);
            dataGridView1.DataSource = consumos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
