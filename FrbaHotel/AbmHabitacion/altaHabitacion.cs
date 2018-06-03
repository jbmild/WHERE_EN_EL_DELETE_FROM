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
            comboBoxHotel.DataSource = dtHoteles;
            comboBoxHotel.DisplayMember = "direccion";
            comboBoxHotel.ValueMember = "hotel_id";

            /*Buscar pisos dentro del hotel elegido*/
            DataTable dtPisos = c.cargarTablaSQL("select hoteles_id, piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hoteles_id='" + this.comboBoxHotel.SelectedValue + "'" + " " + "group by hoteles_id, piso order by hoteles_id desc, piso desc");
            comboBoxPisoEnHotel.DataSource=dtPisos;
            comboBoxPisoEnHotel.DisplayMember="piso";
            comboBoxPisoEnHotel.ValueMember="piso";
            /*Buscar numero de habitacion en el piso elegido del hotel*/
            
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

            ConexionSQL c = new ConexionSQL();
            DataTable dtPisos = c.cargarTablaSQL("select hoteles_id, piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hoteles_id='" +comboBoxHotel.SelectedValue + "'" + " group by hoteles_id, piso order by hoteles_id desc, piso desc");
            comboBoxPisoEnHotel.DataSource = dtPisos;
            comboBoxPisoEnHotel.DisplayMember = "piso";
            comboBoxPisoEnHotel.ValueMember = "piso";
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            int r;
            if (String.IsNullOrWhiteSpace(textBoxDescripcionHabitacion.Text) || String.IsNullOrWhiteSpace(textBoxNumeroHabitacion.Text) ||
                !Int32.TryParse(textBoxNumeroHabitacion.Text, out r))
            {
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
            }
            else
            {
                SqlConnection con1 = new SqlConnection("Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gd2018");
                con1.Open();
                string select = String.Concat("SELECT ha.numero FROM WHERE_EN_EL_DELETE_FROM.habitaciones ha JOIN WHERE_EN_EL_DELETE_FROM.hoteles ho on ha.hoteles_id=ho.hotel_id where ",
                    "ho.hotel_id=@hotelBusqueda and ha.numero=@numeroBusqueda");
                SqlCommand sqlQuery = new SqlCommand(select);
                sqlQuery.Connection = con1;
                sqlQuery.Parameters.Add("@hotelBusqueda", SqlDbType.Int).Value = comboBoxHotel.SelectedValue;
                sqlQuery.Parameters.Add("@numeroBusqueda", SqlDbType.Int).Value = textBoxNumeroHabitacion.Text;
                int busqueda = sqlQuery.ExecuteNonQuery();
                if (busqueda.Equals(0)) 
                {
                    SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gd2018");
                    con.Open();
                    string query = String.Concat("INSERT INTO WHERE_EN_EL_DELETE_FROM.habitaciones (hoteles_id, numero, piso, frente, descripcion, habilitado, tipos_id)", " VALUES ( " + "@hotel" + ", " + "@numeroHabitacion" + ", " + "@piso" + ", " + "@vista" + ", " + "@descripcion" + ", " + 1 + ", " + 1 + ")");
                    SqlCommand sql = new SqlCommand(query);
                    sql.Connection = con;
                    sql.Parameters.Add("@hotel", SqlDbType.Int).Value = comboBoxHotel.SelectedValue;
                    sql.Parameters.Add("@numeroHabitacion", SqlDbType.Int).Value = textBoxNumeroHabitacion.Text;
                    sql.Parameters.Add("@piso", SqlDbType.Int).Value = comboBoxPisoEnHotel.SelectedValue;
                    sql.Parameters.Add("@vista", SqlDbType.Bit).Value = checkBoxVistaExterior.Checked;
                    sql.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = textBoxDescripcionHabitacion.Text;

                    int result = sql.ExecuteNonQuery();


                    if (result.Equals(1))
                    {
                        labelAgregado.Visible = true;
                    }

                    
                }else{
                        labelNoSePuede.Visible = true;
 
                }

            }
        }  
    }
}
