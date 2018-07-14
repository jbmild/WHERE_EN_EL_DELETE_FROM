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

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.TodosLosCamposEstanCompletados()) 
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
                con.Open();
                string query = "INSERT INTO WHERE_EN_EL_DELETE_FROM.hoteles";
                query+=" VALUES (@nombre, @mail ,@telefono, @direccion, @ciudad, @pais, @estrellas, @estrellasRecargo, @fecha)";
                SqlCommand sql = new SqlCommand(query);
                sql.Connection = con;
                sql.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = textBoxNombreNuevoHotel.Text;
                sql.Parameters.Add("@mail", SqlDbType.NVarChar).Value = textBoxMailNuevoHotel.Text;
                sql.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = textBoxTelefonoNuevo.Text;
                sql.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = textBoxDireccionNuevoHotel.Text;
                sql.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = textBoxCiudadNuevoHotel.Text;
                sql.Parameters.Add("@pais", SqlDbType.NVarChar).Value = textBoxPaisNuevoHotel.Text;
                sql.Parameters.Add("@estrellas", SqlDbType.Int).Value = this.comboBoxEstrellas.SelectedItem;
                sql.Parameters.Add("@estrellasRecargo", SqlDbType.Int).Value = Int32.Parse(this.textBoxEstrellasRecargo.Text.ToString());
                sql.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.Now;
                int result = sql.ExecuteNonQuery();

/*************HOTEL_EMPLEADO*******************/
                SqlConnection conToEmpl = new SqlConnection(ConfigurationManager.ConnectionStrings["FrbaHotel.Properties.Settings.Setting"].ConnectionString);
                conToEmpl.Open();
                ConexionSQL IDHOTEL= new ConexionSQL();
                DataTable IDHOTELBusqueda= IDHOTEL.cargarTablaSQL("select top 1 hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles order by hotel_id desc");
                string insertEmpleHotel = "INSERT INTO WHERE_EN_EL_DELETE_FROM.empleados_hoteles values (@emple, @hotel)";
                SqlCommand sql1 = new SqlCommand(insertEmpleHotel);
                sql1.Connection = conToEmpl;
                ConexionSQL getEmpleadoByUser= new ConexionSQL();
                DataTable GETEMPLEADOBYUSER = getEmpleadoByUser.cargarTablaSQL("select empleado_id from WHERE_EN_EL_DELETE_FROM.empleados where usuario_id=" + Sesion.usuario.UsuarioId);
                sql1.Parameters.Add("@emple", SqlDbType.Int).Value = GETEMPLEADOBYUSER.Rows[0].ItemArray[0];
                sql1.Parameters.Add("@hotel", SqlDbType.Int).Value = IDHOTELBusqueda.Rows[0].ItemArray[0];
                int resultEmpleHotel = sql1.ExecuteNonQuery();



                if (result.Equals(1) && resultEmpleHotel.Equals(1))
                {
                    ConexionSQL getRegimen = new ConexionSQL();
                    DataTable resultados = getRegimen.cargarTablaSQL("select regimen_id from WHERE_EN_EL_DELETE_FROM.regimenes where descripcion like'" + 
                        this.listBoxRegimenes.Items[0].ToString() + "'");
                    int id_regimen = Int32.Parse(resultados.Rows[0].ItemArray[0].ToString());

                    ConexionSQL getHotel = new ConexionSQL();
                    DataTable resultados_ = getHotel.cargarTablaSQL("select hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ho where ho.nombre like '" + this.textBoxNombreNuevoHotel.Text +
                       "' and ho.direccion like'" + this.textBoxDireccionNuevoHotel.Text + "' and ho.ciudad like'" + this.textBoxCiudadNuevoHotel.Text +
                       "' and ho.pais like'" + this.textBoxPaisNuevoHotel.Text + "'");
                    int id_hotel = Int32.Parse(resultados_.Rows[0].ItemArray[0].ToString());


                    SqlConnection con2 = ConexionSQL.obtenerConexion();//"Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gdhotel2018");
                    //con2.Open();
                    string query2 = "INSERT INTO [GD1C2018].[WHERE_EN_EL_DELETE_FROM].[regimenes_hoteles] (hotel_id, regimen_id) values(@hotel, @regimen)";
                    SqlCommand sql2 = new SqlCommand(query2);
                    sql2.Connection = con2;
                    sql2.Parameters.Add("@hotel", SqlDbType.Int).Value = id_hotel;
                    sql2.Parameters.Add("@regimen", SqlDbType.Int).Value = id_regimen;
                    int result2 = sql2.ExecuteNonQuery();
                    if (result2.Equals(1)) { System.Windows.Forms.MessageBox.Show("¡Hotel agregado con éxito!"); } else { System.Windows.Forms.MessageBox.Show("Error!"); }
                    //labelAgregado.Visible = true;
                    

                    this.Hide();
                }

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
                this.labelCiudadPendiente.Visible = false; }

            if (this.textBoxDireccionNuevoHotel.Text.Equals(""))
            {
                this.labelDireccionPendiente.Visible = true;
            }
            else { completo++; 
                this.labelDireccionPendiente.Visible = false; }

            if (this.textBoxMailNuevoHotel.Text.IndexOf('@').Equals(-1))
            {
                this.labelMailPendiente.Visible = true;
            }
            else {
                completo++;
                this.labelMailPendiente.Visible = false; }

            if (this.textBoxNombreNuevoHotel.Text.Equals(""))
            {
                this.labelNombrePendiente.Visible = true;
            }
            else {
                completo++;
                this.labelNombrePendiente.Visible = false; }
            
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
            else { completo++; 
                this.labelPaisPendiente.Visible = false; }

            if (this.listBoxRegimenes.Items.Count.Equals(0)) { this.labelRegimenesPendiente.Visible = true; } else
            {
                completo++;
                this.labelRegimenesPendiente.Visible = false;
            }

            if (completo.Equals(9)) { return true; } else { return false; }
        }

        private void textBoxTelefonoNuevo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTelefonoNuevo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
