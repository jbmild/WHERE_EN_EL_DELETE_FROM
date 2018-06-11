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
    public partial class modificarHabitacion : Form
    {
        string habitacion_numero;
        MostrarHoteles mHoteles=new MostrarHoteles();
        MostrarHabitaciones mHabitaciones = new MostrarHabitaciones();
        public modificarHabitacion()
        {
            InitializeComponent();
        }


        private void comboBoxNuevoHotel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.BuscarPisoParaHotelSeleccionado();
            
        }

        private void BuscarPisoParaHotelSeleccionado()
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dtpisosNuevos = c.cargarTablaSQL("select distinct piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hoteles_id=" +
              this.comboBoxNuevoHotel.SelectedValue + " order by piso asc");
            comboBoxNuevoPiso.DataSource = dtpisosNuevos;
            comboBoxNuevoPiso.DisplayMember = "piso";
            comboBoxNuevoPiso.ValueMember = "piso";
        }
        private void modificarHabitacion_Load(object sender, EventArgs e)
        {
            mHoteles.CargarHoteles(this.comboBoxHoteles);
            //this.CargarHoteles();
            mHabitaciones.CargarHabitacionesParaHotelElegido(this.comboBoxNumeroHabitacion, this.comboBoxHoteles);
          //  this.CargarHabitacionesParaHotelElegido();
         }

        private void CargarHabitacionesParaHotelElegido()
        {
            
        }

        private void CargarHoteles()
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dt = c.cargarTablaSQL("select direccion, hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ");
            comboBoxHoteles.DataSource = dt;
            comboBoxHoteles.DisplayMember = "direccion";
            comboBoxHoteles.ValueMember = "hotel_id";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            /*Hago visibles los demas componentes*/
            this.VisibilizarComponentes();
          

            /*Guardo el numero de habitacion conocido por el empleado*/
            habitacion_numero = comboBoxNumeroHabitacion.Text;

            //textBoxNuevaDescripcion.Text = Convert.ToString(habitacion_numero);
            ConexionSQL con2 = new ConexionSQL();
            DataTable habitacionElegida = con2.cargarTablaSQL("select ha.numero as 'Numero_Habitacion', ha.piso as 'Piso', ha.descripcion as 'Descripcion'," +
            "t.descripcion 'Tipo_Habitacion', convert(bit,ha.frente) as 'Tiene_vista_al_exterior', convert(bit,habilitado) as 'Esta_habilitada' from" +
                " WHERE_EN_EL_DELETE_FROM.habitaciones ha join WHERE_EN_EL_DELETE_FROM.habitaciones_tipos t on ha.tipos_id=t.tipo_id  where habitacion_id=" + 
                comboBoxNumeroHabitacion.SelectedValue + " and hoteles_id=" + comboBoxHoteles.SelectedValue);
            
            dataGridView1.DataSource = habitacionElegida;
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[4].Width = 130;
            ConexionSQL con = new ConexionSQL();
            DataTable dtHotelesAct = con.cargarTablaSQL("select direccion, hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles");
            comboBoxNuevoHotel.DataSource = dtHotelesAct;
            comboBoxNuevoHotel.DisplayMember = "direccion";
            comboBoxNuevoHotel.ValueMember = "hotel_id";
            DataTable dtPisosHotelAct = con.cargarTablaSQL("select distinct piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hoteles_id=" + comboBoxNuevoHotel.SelectedValue);
            comboBoxNuevoPiso.DataSource = dtPisosHotelAct;
            comboBoxNuevoPiso.DisplayMember = "piso";
            comboBoxNuevoPiso.ValueMember = "piso";
        }

        private void VisibilizarComponentes()
        {
            groupBoxModificarHabitacion.Visible = true;
            buttonGuardarCambios.Visible = true;
            labelNuevosCambios.Visible = true;
            labelDescripcionNueva.Visible = true;
            labelHotelNuevo.Visible = true;
            labelPisoNuevo.Visible = true;
            comboBoxNuevoHotel.Visible = true;
            comboBoxNuevoPiso.Visible = true;
            checkBoxEstaHabilitado.Visible = true;
            checkBoxTieneVistaExterior.Visible = true;
            textBoxNuevaDescripcion.Visible = true;
        }

        private void comboBoxHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dtpisos = c.cargarTablaSQL("select numero, habitacion_id from WHERE_EN_EL_DELETE_FROM.habitaciones where hoteles_id=" + comboBoxHoteles.SelectedValue + " order by numero");
            comboBoxNumeroHabitacion.DataSource = dtpisos;
            comboBoxNumeroHabitacion.DisplayMember = "numero";
            comboBoxNumeroHabitacion.ValueMember = "habitacion_id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor=true;

            ConexionSQL conBusqueda = new ConexionSQL();
            DataTable busquedaHab = conBusqueda.cargarTablaSQL("select numero from WHERE_EN_EL_DELETE_FROM.habitaciones where numero=" + comboBoxNumeroHabitacion.SelectedValue
                + " and hoteles_id=" + comboBoxNuevoHotel.SelectedValue);
            if (busquedaHab.Rows.Count.Equals(0))
            {
                labelNotificarError.Visible = false;
                this.ModificarHabitacion();
            }
            else 
            {
                this.NotificarHabitacionExistente();
            }
        }

        private void NotificarHabitacionExistente()
        {
            labelNotificarError.Visible = true;
            this.UseWaitCursor = false;
        }

        private void ModificarHabitacion()
        {
            SqlConnection con1 = new SqlConnection("Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gd2018");
            con1.Open();
            string select = String.Concat("update WHERE_EN_EL_DELETE_FROM.habitaciones set hoteles_id=@hotel, descripcion=@descripcion, frente=@frente, habilitado=@habilitado where habitacion_id=@id");
            SqlCommand sqlQuery = new SqlCommand(select);
            sqlQuery.Connection = con1;
            sqlQuery.Parameters.Add("@hotel", SqlDbType.Int).Value = comboBoxNuevoHotel.SelectedValue;
            sqlQuery.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = textBoxNuevaDescripcion.Text;
            sqlQuery.Parameters.Add("@frente", SqlDbType.Bit).Value = checkBoxTieneVistaExterior.Checked;
            sqlQuery.Parameters.Add("@habilitado", SqlDbType.Bit).Value = checkBoxEstaHabilitado.Checked;
            sqlQuery.Parameters.Add("@id", SqlDbType.Int).Value = comboBoxNumeroHabitacion.SelectedValue;
            int busqueda = sqlQuery.ExecuteNonQuery();

            if (busqueda.Equals(1))
            {
                this.UseWaitCursor = false;
                System.Windows.Forms.MessageBox.Show("¡La modificación se ha efectuado correctamente! La ventana se cerrará al presionar Aceptar");
                this.Hide();
            }
            else 
            {
                this.UseWaitCursor = false;
                System.Windows.Forms.MessageBox.Show("ERROR al intentar modificar");
                this.Hide();
            }
        }

        private void BorrarCamposModificados()
        {
            textBoxNuevaDescripcion.Text = "";
            checkBoxEstaHabilitado.Checked = false;
            checkBoxTieneVistaExterior.Checked = false;
        }

        private void labelDescripcionNueva_Click(object sender, EventArgs e)
        {

        }



    
    }
}
