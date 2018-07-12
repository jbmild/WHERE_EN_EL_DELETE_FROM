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
using FrbaHotel.Tools;

namespace FrbaHotel.AbmHabitacion
{
    public partial class altaHabitacion : Form
    {
        SQLQueryGenerator sqlQueryGenerator;
        public altaHabitacion()
        {
            InitializeComponent();
        }

        private void altaHabitacion_Load(object sender, EventArgs e)
        {
            sqlQueryGenerator = new SQLQueryGenerator();
            sqlQueryGenerator.Ejecutar(comboBoxHotel);

            if (Sesion.hotel != null) {

                comboBoxHotel.SelectedValue = Sesion.hotel.HotelId;
                comboBoxHotel.Enabled = false;
            }
           


           
            /*Buscar numero de habitacion en el piso elegido del hotel*/
            
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlQueryGenerator = new SQLQueryGenerator();
            sqlQueryGenerator.HotelCambioEnAltaHabitacion(comboBoxPisoEnHotel, comboBoxHotel);
            
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            int r;
            if (String.IsNullOrWhiteSpace(textBoxDescripcionHabitacion.Text) || String.IsNullOrWhiteSpace(textBoxNumeroHabitacion.Text) ||
                !Int32.TryParse(textBoxNumeroHabitacion.Text, out r) || this.comboBoxHotel.Text.Equals("") || this.VistaPendiente())
            {
                if (this.comboBoxHotel.Text.Equals(""))
                {
                    labelHotelPendiente.Visible = true;
                }
                else {
                    labelHotelPendiente.Visible = false;
                }
                if (String.IsNullOrWhiteSpace(textBoxDescripcionHabitacion.Text))
                {
                    labelDescVacia.Visible = true;
                }
                else
                {
                    labelDescVacia.Visible = false;
                }
                if (String.IsNullOrWhiteSpace(textBoxNumeroHabitacion.Text))
                {
                    labelNroVacio.Visible = true;
                }
                else
                {
                    labelNroVacio.Visible = false;

                    if (!Int32.TryParse(textBoxNumeroHabitacion.Text, out r))
                    {
                        labelNroVacio.Visible = true;
                    };
                }
                if (this.radioButtonVistaExteriorNO.Checked.Equals(true) || this.radioButtonVistaExteriorSI.Checked.Equals(true))
                {
                    this.labelVistaPendiente.Visible = false;
                }
                else { this.labelVistaPendiente.Visible = true; }
            }
            else

            {
                this.labelVistaPendiente.Visible = false; 
                this.labelHotelPendiente.Visible = false;
                this.labelDescVacia.Visible = false;
                this.labelNroVacio.Visible = false;
                bool vista;
                if (this.radioButtonVistaExteriorNO.Checked) { vista = false; } else { vista = true; }
                
                /************/
                ConexionSQL busq = new ConexionSQL();
               DataTable resultado= sqlQueryGenerator.GetHabitacionesEnAltaHotel(comboBoxHotel, textBoxNumeroHabitacion, busq);
                 
                if (resultado.Rows.Count.Equals(0)) 
                {
                    SqlConnection con = ConexionSQL.obtenerConexion();
                    int result = sqlQueryGenerator.InsertIntoHabitacionesNuevaHabitacion(con, comboBoxHotel, textBoxNumeroHabitacion, comboBoxPisoEnHotel, vista, textBoxDescripcionHabitacion);


                    if (result.Equals(1))
                    {
                        //labelAgregado.Visible = true;
                        System.Windows.Forms.MessageBox.Show("¡Habitación agregada con éxito!");

                        this.Hide();
                    }


                }
                else
                {
                    labelNoSePuede.Visible = true;

                }
                }

             
        }

        private bool VistaPendiente()
        {
            return this.radioButtonVistaExteriorNO.Checked.Equals(false) && this.radioButtonVistaExteriorSI.Checked.Equals(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBoxHotel.SelectedIndex = comboBoxHotel.FindStringExact("");
            this.textBoxDescripcionHabitacion.Text = "";
            this.comboBoxPisoEnHotel.SelectedIndex = comboBoxPisoEnHotel.FindStringExact("");
            this.textBoxNumeroHabitacion.Text = "";
            this.labelAgregado.Visible = false;
            this.radioButtonVistaExteriorNO.Checked = false;
            this.radioButtonVistaExteriorSI.Checked = false;
            this.labelNoSePuede.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modificarHabitacion m = new modificarHabitacion();
            this.Hide();
            m.Show();
        }

  
    }
}
