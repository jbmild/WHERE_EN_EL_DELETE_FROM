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
        Busqueda busqueda = new Busqueda();
           
        string habitacion_numero;
        MostrarHoteles mHoteles=new MostrarHoteles();
        MostrarHabitaciones mHabitaciones = new MostrarHabitaciones();
        public modificarHabitacion()
        {
            InitializeComponent();
        }


        private void comboBoxNuevoHotel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //this.BuscarPisoParaHotelSeleccionado();
            
        }

        //private void BuscarPisoParaHotelSeleccionado()
        //{
          //  ConexionSQL c = new ConexionSQL();
         //   DataTable dtpisosNuevos = c.cargarTablaSQL("select distinct piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" +
            //  this.comboBoxNuevoHotel.SelectedValue + " order by piso asc");
            //comboBoxNuevoPiso.DataSource = dtpisosNuevos;
            //comboBoxNuevoPiso.DisplayMember = "piso";
            //comboBoxNuevoPiso.ValueMember = "piso";
        //}
        private void modificarHabitacion_Load(object sender, EventArgs e)
        {
            mHoteles.CargarHoteles(this.comboBoxHoteles);
            //this.CargarHoteles();
         //   mHabitaciones.CargarHabitacionesParaHotelElegido(this.comboBoxNumeroHabitacion, this.comboBoxHoteles);
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

        
            /*Guardo el numero de habitacion conocido por el empleado*/
            habitacion_numero = comboBoxNumeroHabitacion.Text;

            //textBoxNuevaDescripcion.Text = Convert.ToString(habitacion_numero);
            ConexionSQL con2 = new ConexionSQL();
            Consulta consulta = new Consulta();
              consulta.ConcatToQuery("select ha.numero as 'Numero_Habitacion', ha.piso as 'Piso', ha.descripcion as 'Descripcion'," +
            "t.descripcion 'Tipo_Habitacion', convert(bit,ha.frente) as 'Tiene_vista_al_exterior', convert(bit,habilitado) as 'Esta_habilitada' from" +
                " WHERE_EN_EL_DELETE_FROM.habitaciones ha join WHERE_EN_EL_DELETE_FROM.habitaciones_tipos t on ha.tipos_id=t.tipo_id");

            BuscarHotel bHotel = new BuscarHotel();
            BuscarPiso bPiso=new BuscarPiso();
            BuscarHabitacion bHabi = new BuscarHabitacion();
            
            bHotel.ejecutar( consulta, this.comboBoxHoteles.SelectedValue.ToString(),busqueda);
            bPiso.ejecutar(consulta, this.comboBoxPiso.SelectedValue.ToString(),busqueda);
            bHabi.ejecutar(consulta, this.comboBoxNumeroHabitacion.Text, busqueda);
            this.ChequearCheckboxes(consulta, busqueda.GetHotel(), busqueda.GetPiso(), busqueda.GetHabitacion());
            
            System.Diagnostics.Debug.WriteLine(consulta);
            
            DataTable resultados = con2.cargarTablaSQL(consulta.GetQuery());
            dataGridView1.DataSource = resultados;

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[4].Width = 130;
       
        }

        private void ChequearCheckboxes(Consulta consulta, bool hayHotel, bool hayPiso, bool hayHabitacion)
        {
            if (checkBoxHabilitado.Checked)
            {
                if (hayPiso.Equals(1) || hayHabitacion.Equals(1) || hayHotel.Equals(1))
                {
                    consulta.ConcatToQuery(" and habilitado= 1");
                    if (checkBoxVistaExterior.Checked)
                    {
                        consulta.ConcatToQuery(" and vista=1");
                    }
                }
                else
                {
                    consulta.ConcatToQuery(" where ");
                    consulta.ConcatToQuery(" habilitado= 1");
                    if (checkBoxVistaExterior.Checked)
                    {
                        consulta.ConcatToQuery(" and vista=1");
                    }
                }
            }
            if (checkBoxVistaExterior.Checked) 
            {
                if (hayPiso.Equals(1) || hayHabitacion.Equals(1) || hayHotel.Equals(1))
                {
                    consulta.ConcatToQuery(" and vista=1");
                }
                else 
                {
                    consulta.ConcatToQuery(" where ");
                    consulta.ConcatToQuery(" vista=1");
                }
            }
            
        }



        private void comboBoxHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable dtpisos = c.cargarTablaSQL("select distinct piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + comboBoxHoteles.SelectedValue);
            comboBoxPiso.DataSource = dtpisos;
            dtpisos.Rows.InsertAt(dtpisos.NewRow(), 0);
            comboBoxPiso.DisplayMember = "piso";
            comboBoxPiso.SelectedIndex = 0;
            comboBoxPiso.ValueMember = "piso";

            string q = "select habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + comboBoxHoteles.SelectedValue;

            ConexionSQL c2 = new ConexionSQL();
            DataTable dthabitaciones = c2.cargarTablaSQL("select habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + comboBoxHoteles.SelectedValue + " order by numero asc");
            comboBoxNumeroHabitacion.DataSource = dthabitaciones;
            dthabitaciones.Rows.InsertAt(dthabitaciones.NewRow(), 0);
            comboBoxNumeroHabitacion.DisplayMember = "numero";
            comboBoxNumeroHabitacion.SelectedIndex = 0;
            comboBoxNumeroHabitacion.ValueMember = "habitacion_id";
        }

       

        private void NotificarHabitacionExistente()
        {
            
            this.UseWaitCursor = false;
        }

      
      

        private void labelDescripcionNueva_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            string q = "select habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + comboBoxHoteles.SelectedValue +
                " and piso=" + comboBoxPiso.SelectedValue + " order by numero asc";

            DataTable dthabitaciones = c.cargarTablaSQL(q);
            comboBoxNumeroHabitacion.DataSource = dthabitaciones;
            dthabitaciones.Rows.InsertAt(dthabitaciones.NewRow(), 0);
            comboBoxNumeroHabitacion.DisplayMember = "numero";
            comboBoxNumeroHabitacion.SelectedIndex = 0;
            comboBoxNumeroHabitacion.ValueMember = "habitacion_id";
        }



    
    }
}
