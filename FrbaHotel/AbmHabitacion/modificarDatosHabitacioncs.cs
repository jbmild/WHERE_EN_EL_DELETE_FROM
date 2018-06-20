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
    public partial class modificarDatosHabitacioncs : Form
    {
        private int habitacionID;
        private int hotel_ID;
        public modificarDatosHabitacioncs()
        {
            InitializeComponent();
        }

        private void modificarDatosHabitacioncs_Load(object sender, EventArgs e)
        {
            //ConexionSQL cont = new ConexionSQL();
            //DataTable dt = cont.cargarTablaSQL("select hotel_id, direccion from WHERE_EN_EL_DELETE_FROM.Hoteles");
            //this.comboBoxNuevoHotel.DataSource = dt;
            //this.comboBoxNuevoHotel.DisplayMember = "direccion";
            //this.comboBoxNuevoHotel.ValueMember = "hotel_id";

            MostrarHoteles mbuscar = new MostrarHoteles();
            mbuscar.CargarHoteles(this.comboBoxNuevoHotel);

        }
        public void  RecibirHabitacion(HabitacionElegida habitacion) 
        {
            this.habitacionID = habitacion.GetHabiID();
            this.hotel_ID = habitacion.GetHotelID();
            this.labelHotelActual.Text = habitacion.GetDireccion().ToString();
            this.labelPisoEnHotel.Text = habitacion.GetPiso().ToString();
            if (habitacion.GetDescripcion().ToString().Equals(""))
            {
                this.labelDescripcionActual.Text = "(vacio)";
            }
            else 
            {
                this.labelDescripcionActual.Text = habitacion.GetDescripcion().ToString();
            }
            
            if (habitacion.GetHabilitado().Equals(1))
            {
                this.labelHabilitadoActualmente.Text="Sí";
            }
            else 
            {
                this.labelHabilitadoActualmente.Text="No";
            }
            if (habitacion.GetVista().Equals(1))
            {
                this.labelTieneVistaExterior.Text="Sí";
            }
            else 
            {
                this.labelTieneVistaExterior.Text = "No";
            }
            this.labelNumeroHabitacionActual.Text = habitacion.GetNumero().ToString();
            }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            DataTable resultadoDeBuscar = conexion.cargarTablaSQL("select ho.hotel_id from WHERE_EN_EL_DELETE_FROM.Hoteles ho join WHERE_EN_EL_DELETE_FROM.Habitaciones ha"
                + " on ha.hotel_id=ho.hotel_id " + " where ho.direccion='" + this.labelHotelActual.Text + "' and ha.numero=" + this.textBoxNumeroHabitacionNuevo.Text);
            if (resultadoDeBuscar.Rows.Count.Equals(0))
            {

                SqlConnection con1 = new SqlConnection("Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gd2018");
                con1.Open();
                string update = "update WHERE_EN_EL_DELETE_FROM.Habitaciones set hotel_id=@hotel_id, numero=@numero, piso=@piso, habilitado=@habilitado, frente=@frente, descripcion=@descripcion where habitacion_id=" + this.habitacionID;
                SqlCommand sqlQuery = new SqlCommand(update);
                sqlQuery.Connection = con1;
                sqlQuery.Parameters.Add("@hotel_id", SqlDbType.Int).Value = this.hotel_ID;
                sqlQuery.Parameters.Add("@numero", SqlDbType.Int).Value = this.textBoxNumeroHabitacionNuevo.Text;
                sqlQuery.Parameters.Add("@piso", SqlDbType.Int).Value = this.comboBoxNuevoPiso.SelectedValue;
                sqlQuery.Parameters.Add("@habilitado", SqlDbType.Bit).Value = this.checkBoxEstaHabilitado.Checked;
                sqlQuery.Parameters.Add("@frente", SqlDbType.Bit).Value = this.checkBoxTieneVistaExterior.Checked;
                sqlQuery.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = this.textBoxNuevaDescripcion.Text;

                int result = sqlQuery.ExecuteNonQuery();


                if (result.Equals(1))
                {
                    this.labelNotificarError.Visible = false;
                    this.labelExito.Visible = true;
                }
            }
            else 
            {
                this.labelNotificarError.Visible = true;
            }
            
        }

        private void comboBoxNuevoHotel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.comboBoxNuevoHotel.SelectedValue.ToString() != "")
            {
                this.comboBoxNuevoPiso.Enabled = true;
                this.textBoxNumeroHabitacionNuevo.Enabled = true;
                ConexionSQL c = new ConexionSQL();
                DataTable dtpisos = c.cargarTablaSQL("select distinct piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + comboBoxNuevoHotel.SelectedValue);
                comboBoxNuevoPiso.DataSource = dtpisos;
                dtpisos.Rows.InsertAt(dtpisos.NewRow(), 0);
                comboBoxNuevoPiso.DisplayMember = "piso";
                comboBoxNuevoPiso.SelectedIndex = 0;
                comboBoxNuevoPiso.ValueMember = "piso";

                string q = "select habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + comboBoxNuevoHotel.SelectedValue;

               

            }
            else
            {
                this.comboBoxNuevoPiso.DataSource = null;
            }
            
        }
    }
}
