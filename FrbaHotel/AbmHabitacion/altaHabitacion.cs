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

namespace FrbaHotel.AbmHabitacion
{
    public partial class altaHabitacion : Form
    {
        public altaHabitacion()
        {
            InitializeComponent();
        }

        private void altaHabitacion_Load(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dtHoteles = c.cargarTablaSQL("select direccion, hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ");
            dtHoteles.Rows.InsertAt(dtHoteles.NewRow(), 0);
            comboBoxHotel.DataSource = dtHoteles;
            comboBoxHotel.SelectedIndex = 0;
            comboBoxHotel.DisplayMember = "direccion";
            comboBoxHotel.ValueMember = "hotel_id";

           
            /*Buscar numero de habitacion en el piso elegido del hotel*/
            
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

            ConexionSQL c = new ConexionSQL();
            DataTable dtPisos = c.cargarTablaSQL("select hotel_id, piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id='" +comboBoxHotel.SelectedValue + "'" + " group by hotel_id, piso order by hotel_id desc, piso desc");
            dtPisos.Rows.InsertAt(dtPisos.NewRow(), 0);
            comboBoxPisoEnHotel.DataSource = dtPisos;
            comboBoxPisoEnHotel.SelectedIndex = 0;
            comboBoxPisoEnHotel.DisplayMember = "piso";
            comboBoxPisoEnHotel.ValueMember = "piso";
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
                DataTable resultado = busq.cargarTablaSQL("SELECT ha.numero FROM WHERE_EN_EL_DELETE_FROM.habitaciones ha JOIN WHERE_EN_EL_DELETE_FROM.hoteles ho on ha.hotel_id=ho.hotel_id where " +
                    " ho.hotel_id=" + this.comboBoxHotel.SelectedValue + " and ha.numero=" + this.textBoxNumeroHabitacion.Text);
                if (resultado.Rows.Count.Equals(0)) 
                {
                    SqlConnection con = ConexionSQL.obtenerConexion();
                    
                    string query = String.Concat("INSERT INTO WHERE_EN_EL_DELETE_FROM.habitaciones (hotel_id, numero, piso, frente, descripcion, habilitado, tipos_id)", " VALUES ( " + "@hotel" + ", " + "@numeroHabitacion" + ", " + "@piso" + ", " + "@vista" + ", " + "@descripcion" + ", " + 1 + ", " + 1 + ")");
                    SqlCommand sql = new SqlCommand(query);
                    sql.Connection = con;
                    sql.Parameters.Add("@hotel", SqlDbType.Int).Value = comboBoxHotel.SelectedValue;
                    sql.Parameters.Add("@numeroHabitacion", SqlDbType.Int).Value = textBoxNumeroHabitacion.Text;
                    sql.Parameters.Add("@piso", SqlDbType.Int).Value = comboBoxPisoEnHotel.SelectedValue;
                    sql.Parameters.Add("@vista", SqlDbType.Bit).Value = vista;
                    sql.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = textBoxDescripcionHabitacion.Text;

                    int result = sql.ExecuteNonQuery();


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

  
    }
}
