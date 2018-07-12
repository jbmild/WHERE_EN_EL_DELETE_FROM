using System;
using System.Globalization;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Modelo;
using FrbaHotel.Tools;
using System.Data.SqlClient;

namespace FrbaHotel.Reservas
{
    public partial class FormSeleccionarHabitaciones : Form
    {
        Reserva _res = null;
        int _idTipoHabitacion;
        int _usuarioLogueado = 1;
        DateTime _fechaSistema = Convert.ToDateTime(ConfigurationManager.AppSettings["fechaSistema"], new CultureInfo(ConfigurationManager.AppSettings["formatoFechaSistema"]));
        decimal subTotalReserva = 0;

        public FormSeleccionarHabitaciones()
        {
            InitializeComponent();
        }

        public FormSeleccionarHabitaciones(Reserva r, int idTipoHabitacion)
        {
            _res = r;
            _idTipoHabitacion = idTipoHabitacion;
            InitializeComponent();
        }


       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form form1 = new Form();
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (cmbHotel.SelectedIndex == 0 || cmbTipoHab.SelectedIndex == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Debe seleccionar un hotel y un tipo de habitación");
                }
                else {
                    if ((dtpFechaCheckout.Value <= dtpFechaCheckin.Value) ||
                    ((dtpFechaCheckout.Value - dtpFechaCheckin.Value).Days < 1))
                    {
                        System.Windows.Forms.MessageBox.Show("La fecha de checkout debe ser posterior a la fecha de check-in.");
                    }
                    else
                    {
                        //TODO: Si es recepcionista, mandar hotel_id en el que está logueada.
                        Habitacion hab = new Habitacion();
                        dataGridView1.DataSource = hab.obtenerHabitacionesDisponibles(dtpFechaCheckin.Value, dtpFechaCheckout.Value,
                                                        (lblRegimenId.Text == "" ? -1 : Convert.ToInt32(lblRegimenId.Text)),
                                                        Convert.ToInt32(cmbHotel.SelectedValue),
                                                        (cmbTipoHab.SelectedIndex == 0 || cmbTipoHab.SelectedIndex == -1) ? -1 : Convert.ToInt32(cmbTipoHab.SelectedValue));


                        //Se muestra por pantalla la tabla con los resultados del SELECT
                        dataGridView1.Columns[3].Visible = dataGridView1.Columns[4].Visible =
                            dataGridView1.Columns[7].Visible = false;
                        this.Cursor = Cursors.Default;
                    }
                }
                this.Cursor = Cursors.Default;
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGenerarModificarReserva_Load(object sender, EventArgs e)
        {

            ConexionSQL conexion = new ConexionSQL();

            DataTable dt;
            dt = conexion.cargarTablaSQL("select tipo_id, descripcion from WHERE_EN_EL_DELETE_FROM.habitaciones_tipos ORDER BY max_huespedes");
            dt.Rows.InsertAt(dt.NewRow(), 0); //AGREGA UNA ROW VACIA EN COMBO
            cmbTipoHab.DataSource = dt;
            //cmbTipoHab.SelectedIndex = 0; 

            cmbTipoHab.DisplayMember = "descripcion";
            cmbTipoHab.ValueMember = "tipo_id";

            
            
            dt = conexion.cargarTablaSQL("select hotel_id, 'Hotel ' + direccion AS nombre FROM WHERE_EN_EL_DELETE_FROM.hoteles");
            dt.Rows.InsertAt(dt.NewRow(), 0); //AGREGA UNA ROW VACIA EN COMBO
            cmbHotel.DataSource = dt;
            cmbHotel.DisplayMember = "nombre";
            cmbHotel.ValueMember = "hotel_id";

            if (Sesion.hotel != null)
            {
                // Si es un usuario logueado (administrador o recepcionista), el hotel de la reserva se preselecciona
                cmbHotel.SelectedValue = Sesion.hotel.HotelId;
                cmbHotel.Enabled = false;

                dtgRegimenesHoteles.DataSource = (new Modelo.TipoRegimen()).getRegimenesByHotel(Convert.ToInt32(cmbHotel.SelectedValue));
            }


            if (_res != null)
            {

                if (_res.codigo != 0)
                {
                    dtpFechaCheckin.Value = _res.fecha_desde;
                    dtpFechaCheckout.Value = _res.fecha_hasta;
                    lblRegimenId.Text = _res.regimen_id.ToString();
                    lblPrecioRegimen.Text = (new TipoRegimen()).getPrecioById(_res.regimen_id).ToString();
                    cmbHotel.SelectedValue = _res.hotel_id;
                    cmbTipoHab.SelectedValue = _idTipoHabitacion;


                    dataGridView1.DataSource = _res.getHabitacionesByReserva();
                    this.Cursor = Cursors.Default;

                    dtgRegimenesHoteles.DataSource = (new Modelo.TipoRegimen()).getRegimenesByHotel(Convert.ToInt32(cmbHotel.SelectedValue));
                }

            }
            else {
                CultureInfo culture = new CultureInfo(ConfigurationManager.AppSettings["formatoFechaSistema"]);

                dtpFechaCheckin.Value = dtpFechaCheckin.MinDate = dtpFechaCheckout.MinDate
                            = Convert.ToDateTime(ConfigurationManager.AppSettings["fechaSistema"], culture);
                
                dtpFechaCheckout.Value = dtpFechaCheckin.Value.AddDays(1);
            }
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (lblRegimenId.Text == "") {
                System.Windows.Forms.MessageBox.Show("Debe seleccionar un regimen para continuar con la reserva.");
            }
            else{
                List <Habitacion> habs = new List<Habitacion>();
                decimal precioTotal = 0, maxHuespedes, recargoEstrellas;
                decimal precioBase =  Convert.ToDecimal(lblPrecioRegimen.Text);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        habs.Add(new Habitacion(Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[3].Value),
                                                    Convert.ToInt32(row.Cells[1].Value)));
                        
                        maxHuespedes = (Convert.ToDecimal(row.Cells[5].Value));
                        recargoEstrellas = Convert.ToDecimal(row.Cells[6].Value) * (decimal)0.01;
                        precioTotal += maxHuespedes * (1 + recargoEstrellas) * precioBase;
                    }

                }
                precioTotal = decimal.Round(precioTotal, 2);

                if (habs.Count > 0)
                {
                    if (_res == null) // es nueva reserva
                    {
                        GenerarReservaPrincipal f2 = null;
                        for (int i = 0; i < Application.OpenForms.Count; i++)
                        {
                            if (Application.OpenForms[i] is GenerarReservaPrincipal)
                            {
                                f2 = (GenerarReservaPrincipal)Application.OpenForms[i];
                                break;
                            }
                        }

                        if (f2 == null)
                            f2 = new GenerarReservaPrincipal();



                        f2.pasarReserva(new Reserva(dtpFechaCheckin.Value, dtpFechaCheckout.Value,
                                                                            0,
                                                                            precioTotal, 
                                                                            Convert.ToInt32(lblRegimenId.Text),
                                                                            Convert.ToInt32(cmbHotel.SelectedValue),
                                                                            habs));

                        ((GenerarReservaPrincipal)this.Owner).GenerarReservaPrincipal_Load(sender, e);
                        this.Close();
                        f2.Show();
                    }
                    else
                    {


                        Cliente c = (new Cliente()).getClienteById(_res.cliente_id);

                        _res.fecha_desde = dtpFechaCheckin.Value;
                        _res.fecha_hasta = dtpFechaCheckout.Value;
                        _res.regimen_id = Convert.ToInt32(lblRegimenId.Text);
                        _res.hotel_id = Convert.ToInt32(cmbHotel.SelectedValue);
                        _res.total = precioTotal;
                        _res.usuario_modificacion_id = _usuarioLogueado;
                        _res.total = precioTotal;


                        frmConfirmarReserva frm = new frmConfirmarReserva(c, _res, habs);
                        frm.Owner = this;
                        frm.Show();

                    }
                }
            }

        }

        private void dtpFechaCheckout_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaCheckin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Focused) {
                dtgRegimenesHoteles.DataSource = (new Modelo.TipoRegimen()).getRegimenesByHotel(Convert.ToInt32(cmbHotel.SelectedValue));
            }
        }

        private void dtgRegimenesHoteles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lblRegimenId.Text = this.dtgRegimenesHoteles.Rows[e.RowIndex].Cells[0].Value.ToString();
                //guarda el precio en un label invisible.
                lblPrecioRegimen.Text = this.dtgRegimenesHoteles.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbHotel.SelectedIndex = 0;
            cmbTipoHab.SelectedIndex = 0;
            DataTable dt = (DataTable)dtgRegimenesHoteles.DataSource;
            dt.Rows.Clear();
            dtpFechaCheckin.Value = _fechaSistema;
            dtpFechaCheckout.Value = _fechaSistema.AddDays(1);
        }
        /*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si clickea el checkbox va totalizando el total de la reserva. 
            if (this.dataGridView1.Rows[e.RowIndex].Cells[0].Selected)
            {
                subTotalReserva += (Convert.ToDecimal(this.dataGridView1.Rows[e.RowIndex].Cells[7].Value) *
                                Convert.ToDecimal(this.dataGridView1.Rows[e.RowIndex].Cells[8].Value) *
                                Convert.ToDecimal(lblPrecioRegimen.Text));
            }
            else {
                subTotalReserva -= (Convert.ToDecimal(this.dataGridView1.Rows[e.RowIndex].Cells[7].Value) *
                                Convert.ToDecimal(this.dataGridView1.Rows[e.RowIndex].Cells[8].Value) *
                                Convert.ToDecimal(lblPrecioRegimen.Text));
            }
            
            lblSubTotalReserva.Text = "USD " + subTotalReserva.ToString();
                                
        }
         * */
    }
}
