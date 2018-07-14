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
        int hotelid;
        
        Busqueda busqueda;
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
        private void modificarHabitacion_Load(object sender, EventArgs e)
        {
            //mHoteles.CargarHoteles(hotelid);
            this.CargarHabitaciones();
            this.CargarPiso();
            this.comboBoxPiso.Enabled = true;
            this.comboBoxNumeroHabitacion.Enabled = true;
         }

        private void CargarPiso()
        {
            ConexionSQL c = new ConexionSQL();
            BuscarPiso p = new BuscarPiso();
            p.Cargar(c, this.comboBoxPiso, hotelid);
        }

        private void CargarHabitaciones()
        {
            ConexionSQL con = new ConexionSQL();
            BuscarHabitacion b = new BuscarHabitacion();
            b.Cargar(con, this.comboBoxNumeroHabitacion, hotelid);
        }

        private void CargarHabitacionesParaHotelElegido()
        {
            
        }

        private void CargarHoteles()
        {
            //ConexionSQL c = new ConexionSQL();
            //DataTable dt = c.cargarTablaSQL("select direccion, hotel_id from WHERE_EN_EL_DELETE_FROM.hoteles ");
            //comboBoxHoteles.DataSource = dt;
            //comboBoxHoteles.DisplayMember = "direccion";
            //comboBoxHoteles.ValueMember = "hotel_id";
        }

        
        public void button1_Click(object sender, EventArgs e)
        {
            
                labelHabilitadoError.Visible = false;
                labelExteriorError.Visible = false;
                /*Guardo el numero de habitacion conocido por el empleado*/
                habitacion_numero = comboBoxNumeroHabitacion.Text;
                ConexionSQL con2 = new ConexionSQL();
                Consulta consulta = new Consulta();
                consulta.ConcatToQuery("select ha.numero as 'Numero_Habitacion', ha.piso as 'Piso', ha.descripcion as 'Descripcion'," +
                "t.descripcion 'Tipo_Habitacion', convert(bit,ha.frente) as 'Tiene_vista_al_exterior', convert(bit,habilitado) as 'Esta_habilitada', ho.direccion as 'Direccion',  ha.habitacion_id as 'ID' from" +
                  " WHERE_EN_EL_DELETE_FROM.habitaciones ha join WHERE_EN_EL_DELETE_FROM.habitaciones_tipos t on ha.tipos_id=t.tipo_id join WHERE_EN_EL_DELETE_FROM.hoteles ho" +
                  " on ho.hotel_id=ha.hotel_id ");

                BuscarHotel bHotel = new BuscarHotel();
                BuscarPiso bPiso = new BuscarPiso();
                BuscarHabitacion bHabi = new BuscarHabitacion();
                busqueda = new Busqueda();

                bHotel.ejecutar(consulta, hotelid.ToString(), busqueda);
                if (this.comboBoxPiso.Enabled)
                {
                    bPiso.ejecutar(consulta, this.comboBoxPiso.SelectedValue.ToString(), busqueda);
                }
                if (this.comboBoxNumeroHabitacion.Enabled)
                {
                    bHabi.ejecutar(consulta, this.comboBoxNumeroHabitacion.Text, busqueda);
                }

                this.ChequearRadioButtons(consulta, busqueda);

                System.Diagnostics.Debug.WriteLine(consulta);
                consulta.ConcatToQuery("order by ha.numero asc");
                DataTable resultados = con2.cargarTablaSQL(consulta.GetQuery());
                dataGridView1.DataSource = resultados;

                dataGridView1.Columns[0].Width = 120;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[4].Width = 130;
                dataGridView1.Columns[2].Width = 130;
                dataGridView1.Columns[6].Width = 130;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Enabled = true;
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[6].ReadOnly = true;

            
            
        }

        private bool vista_o_no_elegido()
        {
            return radioButtonExteriorNO.Checked.Equals(true) || radioButtonExteriorSI.Checked.Equals(true);
        }

        private bool habilitado_o_no_elegido()
        {
            return radioButtonHabilitadoNO.Checked.Equals(true) || radioButtonHabilitadoSI.Checked.Equals(true);
        }

       
        private void ChequearRadioButtons(Consulta consulta, Busqueda busqueda)
        {


            if (busqueda.GetPiso().Equals(false) && busqueda.GetHabitacion().Equals(false) && busqueda.GetHotel().Equals(false))
            {
                
                this.VerificarCheckBoxes_(consulta);
            }
            else {
                
                this.VerificarCheckBoxes(consulta);
            }
}

        private void VerificarCheckBoxes_(Consulta consulta)
        {
            //1 es SI, 2 es NO, 3 es NA
            int habilitado = 3;
            if (radioButtonHabilitadoSI.Checked)
            {
                consulta.ConcatToQuery(" where habilitado=1 ");
                habilitado = 1;
            }
            if (radioButtonHabilitadoNO.Checked)
            {
                consulta.ConcatToQuery(" where habilitado=0 ");
                habilitado = 2;
            }
            
            if (radioButtonExteriorSI.Checked)
            {
                if (habilitado.Equals(1) || habilitado.Equals(2))
                {
                    consulta.ConcatToQuery(" and frente=1");
                }
                else 
                {
                    consulta.ConcatToQuery(" where frente=1");
                }
                
            }
            if(radioButtonExteriorNO.Checked)
            {
                if (habilitado.Equals(1) || habilitado.Equals(2))
                {
                    consulta.ConcatToQuery(" and frente=0");
                }
                else
                {
                    consulta.ConcatToQuery(" where frente=0");
                }
            }
        }

        private void VerificarCheckBoxes(Consulta consulta)
        {
            if (radioButtonHabilitadoSI.Checked)
            {
                consulta.ConcatToQuery(" and habilitado=1 ");
            }
            if (radioButtonHabilitadoNO.Checked) 
            {
                consulta.ConcatToQuery(" and habilitado=0 ");
            }
            if (radioButtonExteriorSI.Checked)
            {
                consulta.ConcatToQuery(" and frente=1");
            }
            if (radioButtonExteriorNO.Checked) {
                consulta.ConcatToQuery(" and frente=0");
            }
            
        }



        private void comboBoxHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                this.comboBoxPiso.Enabled = true;
                this.comboBoxNumeroHabitacion.Enabled = true;
                ConexionSQL c = new ConexionSQL();
                DataTable dtpisos = c.cargarTablaSQL("select distinct piso from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + hotelid);
                comboBoxPiso.DataSource = dtpisos;
                dtpisos.Rows.InsertAt(dtpisos.NewRow(), 0);
                comboBoxPiso.DisplayMember = "piso";
                comboBoxPiso.SelectedIndex = 0;
                comboBoxPiso.ValueMember = "piso";

                string q = "select habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + hotelid;

                ConexionSQL c2 = new ConexionSQL();
                DataTable dthabitaciones = c2.cargarTablaSQL("select habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + hotelid + " order by numero asc");
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
            if(this.comboBoxPiso.SelectedValue.ToString().Equals("")){
            }else{
            string q = "select habitacion_id, numero from WHERE_EN_EL_DELETE_FROM.habitaciones where hotel_id=" + hotelid +
                " and piso=" + comboBoxPiso.SelectedValue + " order by numero asc";

            DataTable dthabitaciones = c.cargarTablaSQL(q);
            comboBoxNumeroHabitacion.DataSource = dthabitaciones;
            dthabitaciones.Rows.InsertAt(dthabitaciones.NewRow(), 0);
            comboBoxNumeroHabitacion.DisplayMember = "numero";
            comboBoxNumeroHabitacion.SelectedIndex = 0;
            comboBoxNumeroHabitacion.ValueMember = "habitacion_id";}
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(1)) {
                int row = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[row];
                darBajaHabitacion baja = new darBajaHabitacion();
                HabitacionElegida habitacion = new HabitacionElegida();
                habitacion.SetHabiID(Int32.Parse(selectedRow.Cells[9].Value.ToString()));
                habitacion.SetNumero(Int32.Parse(selectedRow.Cells[2].Value.ToString()));
                baja.EnviarNumeroHabitacion(habitacion.GetHabiID(),habitacion.GetNumero(), this);
                baja.ShowDialog();

            }
            if (e.ColumnIndex.Equals(0)) {
                this.Hide();
                int row = e.RowIndex;
                int tieneVista = 0;
                int estaHabilitado = 0;

                DataGridViewRow selectedRow = dataGridView1.Rows[row];
                int piso = this.mapearPiso(selectedRow);
                HabitacionElegida habitacion = new HabitacionElegida();
                //System.Windows.Forms.MessageBox.Show(dataGridView1.Columns.Count.ToString());


                habitacion.SetNumero(Int32.Parse(selectedRow.Cells[2].Value.ToString()));
                if (piso.Equals(0))
                {
                    habitacion.SetPiso(Int32.Parse(selectedRow.Cells[3].Value.ToString()));
                }
                else
                {
                    habitacion.SetPiso(piso);
                }

                habitacion.SetDescripcion(selectedRow.Cells[4].Value.ToString());
                habitacion.SetTipo(selectedRow.Cells[5].Value.ToString());
                habitacion.SetDireccion(selectedRow.Cells[6].Value.ToString());
                habitacion.SetHabiID(Int32.Parse(selectedRow.Cells[9].Value.ToString()));
                habitacion.SetHotelID(this.ObtenerHotelID(habitacion));


                if (selectedRow.Cells[6].Value.Equals(true))
                {
                    tieneVista = 1;
                }
                if (selectedRow.Cells[7].Value.Equals(true))
                {
                    estaHabilitado = 1;
                }
                habitacion.SetVista(tieneVista);
                habitacion.SetHabilitado(estaHabilitado);
                modificarDatosHabitacioncs modifDatos = new modificarDatosHabitacioncs();
                modifDatos.RecibirHabitacion(habitacion);
                modifDatos.ShowDialog();
            }
            
            
            
        }

        private int mapearPiso(DataGridViewRow d)
        {
            
           if(d.Cells[3].Value.ToString().Equals(""))
           {
               return -1;
           }
            
            else { return Int32.Parse(d.Cells[3].Value.ToString()); }
            
        }

        private int ObtenerHotelID(HabitacionElegida habi)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable hotelID = c.cargarTablaSQL("select hotel_id from WHERE_EN_EL_DELETE_FROM.Habitaciones where habitacion_id=" + habi.GetHabiID());
            ComboBox hotelIDValue= new ComboBox();
            hotelIDValue.Visible=false;
            hotelIDValue.DataSource=hotelID;
            hotelIDValue.ValueMember="hotel_id";
            return Int32.Parse(hotelID.Rows[0].ItemArray[0].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.comboBoxNumeroHabitacion.SelectedIndex = comboBoxNumeroHabitacion.FindStringExact("");
            this.comboBoxPiso.SelectedIndex=comboBoxPiso.FindStringExact("");
            this.radioButtonExteriorNA.Checked = false;
            this.radioButtonExteriorNO.Checked = false;
            this.radioButtonExteriorSI.Checked = false;
            this.radioButtonHabilitadoNA.Checked = false;
            this.radioButtonHabilitadoNO.Checked = false;
            this.radioButtonHabilitadoSI.Checked = false;
            this.dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            altaHabitacion alta = new altaHabitacion();
            alta.Show();

        }

        private void comboBoxHoteles_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        internal void EnviarHotel(string p1, int p2)
        {
            hotelid = p2;
            this.labelhotelnombre.Text = p1;
        }
    }
}

 