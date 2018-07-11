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
            
            int  habilitado = 0;
            int  vista = 0;
            if (this.CamposCompletos())

            {
                if (radioButtonHabilitadoNO.Checked.Equals(true)) { habilitado = 2; }
                if (radioButtonHabilitadoSI.Checked.Equals(true)) { habilitado = 1; }
                if (radioButtonVistaNO.Checked.Equals(true)) { vista = 2; }
                if (radioButtonVistaSI.Checked.Equals(true)) { vista = 1; }
                this.labelPisoPendiente.Visible = false;
                this.labelHotelPendiente.Visible = false;
                this.labelNumeroHabiPendiente.Visible = false;

                if (labelHotelActual.Text.Equals(comboBoxNuevoHotel.Text.ToString()) && labelNumeroHabitacionActual.Text.Equals(textBoxNumeroHabitacionNuevo.Text))
                {   /* Edición de una misma habitación en ese hotel*/
                    // this.EditarHabitacion(  habilitado,  vista);
                    this.EditarHabitacionDentroDelHotel(habilitado, vista);
                }
                else 
                {
                    this.EditarHabitacion(habilitado, vista);
                }    
            }
            else 
            {
                if (this.comboBoxNuevoHotel.Text.Equals("")) { this.labelHotelPendiente.Visible = true; } else { this.labelHotelPendiente.Visible = false; }
                if (this.comboBoxNuevoPiso.Text.Equals("")) { this.labelPisoPendiente.Visible = true; } else { this.labelPisoPendiente.Visible = false; }
                if (this.textBoxNumeroHabitacionNuevo.Text.Equals("")) { this.labelNumeroHabiPendiente.Visible = true; } else { this.labelNumeroHabiPendiente.Visible = false; }
                
            }

            
        }

        private void EditarHabitacionDentroDelHotel(int habilitado, int vista)
        {
            SqlConnection con1 = new SqlConnection("Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gdhotel2018");
            con1.Open();
            string update = "update WHERE_EN_EL_DELETE_FROM.Habitaciones set piso=@piso, descripcion=@descripcion";// where hotel_id=@hotel_id and " +
                //"numero=" + Int32.Parse(textBoxNumeroHabitacionNuevo.Text.ToString());
            if (habilitado.Equals(0)) { } else { update += ", habilitado=@habilitado "; }
            if (vista.Equals(0)) { } else { update += ", frente=@frente"; }
            update += " where hotel_id=@hotel_id and numero=" + Int32.Parse(textBoxNumeroHabitacionNuevo.Text.ToString());
            SqlCommand sqlQuery = new SqlCommand(update);
            sqlQuery.Connection = con1;
            sqlQuery.Parameters.Add("@hotel_id", SqlDbType.Int).Value = this.comboBoxNuevoHotel.SelectedValue;
            sqlQuery.Parameters.Add("@numero", SqlDbType.Int).Value = this.textBoxNumeroHabitacionNuevo.Text;
            sqlQuery.Parameters.Add("@piso", SqlDbType.Int).Value = this.comboBoxNuevoPiso.SelectedValue;
            sqlQuery.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value =this.textBoxNuevaDescripcion.Text;
            if (habilitado.Equals(1))
            {
                sqlQuery.Parameters.Add("@habilitado", SqlDbType.Bit).Value = 1;
            }
            else if (habilitado.Equals(2))
            {
                sqlQuery.Parameters.Add("@habilitado", SqlDbType.Bit).Value = 0;
            }
            if (vista.Equals(1))
            {
                sqlQuery.Parameters.Add("@frente", SqlDbType.Bit).Value = 1;
            }
            else if (vista.Equals(2))
            {
                sqlQuery.Parameters.Add("@frente", SqlDbType.Bit).Value = 0;
            }
            

            int result = sqlQuery.ExecuteNonQuery();


            if (result.Equals(1))
            {
                this.labelNotificarError.Visible = false;
                System.Windows.Forms.MessageBox.Show("¡Habitación modificada con éxito!");
                this.Hide();
                //this.labelExito.Visible = true;
            }
            else 
            {
                System.Windows.Forms.MessageBox.Show("ERROR al intentar modificar la habitación. Revise los datos ingresados");
            }
        }

        private void EditarHabitacion( int habilitado,  int vista)
        {
         
            ConexionSQL conexion = new ConexionSQL();
            DataTable resultadoDeBuscar = conexion.cargarTablaSQL("select ho.hotel_id from WHERE_EN_EL_DELETE_FROM.Hoteles ho join WHERE_EN_EL_DELETE_FROM.Habitaciones ha"
                + " on ha.hotel_id=ho.hotel_id " + " where ho.direccion='" + this.labelHotelActual.Text + "' and ha.numero=" + this.textBoxNumeroHabitacionNuevo.Text);
            if (resultadoDeBuscar.Rows.Count.Equals(0))
            {

                SqlConnection con1 = new SqlConnection("Data Source=LOCALHOST\\SQLSERVER2012;Initial Catalog=GD1C2018;Persist Security Info=True;User ID=gdHotel2018;Password=gdhotel2018");
                con1.Open();
                string update = "update WHERE_EN_EL_DELETE_FROM.Habitaciones set hotel_id=@hotel_id, numero=@numero, piso=@piso, descripcion=@descripcion";// where habitacion_id=" + this.habitacionID;
                if (habilitado.Equals(0)) { } else { update+=", habilitado=@habilitado"; }
                if (vista.Equals(0)) { } else { update += ", frente=@frente"; }
                update+= " where habitacion_id=" + this.habitacionID;
                SqlCommand sqlQuery = new SqlCommand(update);
                sqlQuery.Connection = con1;
                sqlQuery.Parameters.Add("@hotel_id", SqlDbType.Int).Value = this.comboBoxNuevoHotel.SelectedValue;
                sqlQuery.Parameters.Add("@numero", SqlDbType.Int).Value = this.textBoxNumeroHabitacionNuevo.Text;
                sqlQuery.Parameters.Add("@piso", SqlDbType.Int).Value = this.comboBoxNuevoPiso.SelectedValue;
                if (habilitado.Equals(1))
                {
                    
                    sqlQuery.Parameters.Add("@habilitado", SqlDbType.Bit).Value = 1;

                }
                else if (habilitado.Equals(2))
                {
                    sqlQuery.Parameters.Add("@habilitado", SqlDbType.Bit).Value = 0;
                }
                if (vista.Equals(1))
                {
                    sqlQuery.Parameters.Add("@frente", SqlDbType.Bit).Value = 1;
                }
                else if (vista.Equals(2))
                {
                    sqlQuery.Parameters.Add("@frente", SqlDbType.Bit).Value = 0;
                }
                sqlQuery.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = this.textBoxNuevaDescripcion.Text;

                int result = sqlQuery.ExecuteNonQuery();


                if (result.Equals(1))
                {
                    this.labelNotificarError.Visible = false;
                    System.Windows.Forms.MessageBox.Show("¡Habitación modificada con éxito!");
                    this.Hide();
                    //this.labelExito.Visible = true;
                }
            }
            else
            {
                this.labelNotificarError.Visible = true;
                
            }
        }

        private bool CamposCompletos()
        {
            return this.NuevoHotelCompleto() && this.NuevoNumeroHabitacionCompleto() && this.NuevoPisoCompleto();
            
        }

        private bool NuevoPisoCompleto()
        {
            if (this.comboBoxNuevoPiso.SelectedIndex.Equals(0))
            {
                this.labelPisoPendiente.Visible = true;
                return false;
            }
            else 
            {
                this.labelPisoPendiente.Visible = false;
                return true;
            }
        }

        private bool NuevoNumeroHabitacionCompleto()
        {
            int r;
            if (!Int32.TryParse(textBoxNumeroHabitacionNuevo.Text, out r))
            {
                this.labelNumeroHabiPendiente.Visible = true;
                return false;
            }
            else 
            {
                this.labelNumeroHabiPendiente.Visible = false;
                return true;
            }
        }

        private bool NuevoHotelCompleto()
        {
            if (this.comboBoxNuevoHotel.Text.Equals(""))
            {
                this.labelHotelPendiente.Visible = true;
                return false;
            }
            else {
                this.labelHotelPendiente.Visible = false;
                return true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBoxNuevoHotel.SelectedIndex = comboBoxNuevoHotel.FindStringExact("");
            this.textBoxNumeroHabitacionNuevo.Text = "";
            this.comboBoxNuevoPiso.SelectedIndex=comboBoxNuevoPiso.FindStringExact("");
            this.textBoxNuevaDescripcion.Text = "";
            this.radioButtonVistaSI.Checked = false;
            this.radioButtonVistaNO.Checked = false;
            this.radioButtonHabilitadoSI.Checked = false;
            this.radioButtonHabilitadoNO.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificarHabitacion m = new modificarHabitacion();
            this.Hide();
            m.Show();
        }

      
    }
}
