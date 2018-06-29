using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Modelo;
using System.Data.SqlClient;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class FormGenerarModificarReserva : Form
    {
        Reserva _res = null;
        int _idTipoHabitacion;
        int _usuarioLogueado = 1;

        public FormGenerarModificarReserva()
        {
            InitializeComponent();
        }

        public FormGenerarModificarReserva(Reserva r, int idTipoHabitacion)
        {
            _res = r;
            _idTipoHabitacion = idTipoHabitacion;
            InitializeComponent();
        }


       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            Form form1 = new Form();
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if ((dtpFechaCheckout.Value <= dtpFechaCheckin.Value) ||
                ((dtpFechaCheckout.Value - dtpFechaCheckin.Value).Days < 1))
                {
                    System.Windows.Forms.MessageBox.Show("La fecha de checkout debe ser posterior a la fecha de check-in.");
                }
                else {
                    //TODO: Si es recepcionista, mandar hotel_id en el que está logueada.
                    SqlCommand command = new SqlCommand(@"DECLARE @FechaDesde datetime
	                                DECLARE @FechaHasta datetime
	
	                                SELECT @FechaDesde = convert(datetime, SUBSTRING(@fdesde, 0, 11), 103)
	                                SELECT @FechaHasta = convert(datetime, SUBSTRING(@fhasta, 0, 11) + ' 23:59:59', 103)

	                                SET NOCOUNT ON;

	                                SELECT distinct
		                                hab.numero AS [Nro Habitacion],
		                                hot.direccion AS Hotel,
		                                hot.hotel_id,
		                                hab.habitacion_id,
		                                habTipos.max_huespedes AS [Cant Huespedes],
		                                reg.precio * habTipos.max_huespedes * hot.estrellas_recargo AS precio,
		                                reg.descripcion AS TipoRegimen,
		                                reg.codigo AS CodigoRegimen
	                                FROM
		                                WHERE_EN_EL_DELETE_FROM.habitaciones hab
	                                INNER JOIN
		                                WHERE_EN_EL_DELETE_FROM.hoteles hot on
		                                hot.hotel_id = hab.hotel_id
		                                and (hab.hotel_id = @hotel_id or @hotel_id is null)
		                                and (hab.tipos_id = @tipoHabitacion_id or @tipoHabitacion_id is null)
	                                INNER JOIN
		                                WHERE_EN_EL_DELETE_FROM.regimenes_hoteles regHot on
		                                regHot.hotel_id = hot.hotel_id
		                                and (regHot.regimen_id = @regimen_id or @regimen_id is null)
	                                INNER JOIN
		                                WHERE_EN_EL_DELETE_FROM.regimenes reg on
		                                reg.regimen_id = regHot.regimen_id
	                                INNER JOIN
		                                WHERE_EN_EL_DELETE_FROM.habitaciones_tipos habTipos on
		                                habTipos.tipo_id = hab.tipos_id
	                                LEFT JOIN(
		                                SELECT
			                                res.reserva_id,
			                                resHab.habitacion_id
		                                FROM
			                                WHERE_EN_EL_DELETE_FROM.reservas_habitaciones resHab
		                                INNER JOIN
			                                WHERE_EN_EL_DELETE_FROM.reservas res on
			                                res.reserva_id = resHab.reserva_id
			                                and res.estado not in ('cancelada_recepcion', 'cancelada_cliente', 'cancelada_noshow', 'efectivizada')
			                                and (
					                                @FechaDesde is null 
					                                OR 
					                                @FechaHasta is null
					                                OR
					                                @FechaDesde between res.fecha_desde and res.fecha_hasta
					                                OR
					                                @FechaDesde between res.fecha_desde and res.fecha_hasta
					                                OR
					                                (@FechaDesde < res.fecha_desde and @FechaHasta > res.fecha_hasta)
				                                )
		                                ) res on res.habitacion_id = hab.habitacion_id
		
	                                WHERE
		                                res.reserva_id is null
                                        AND @FechaDesde >= getdate() ");

                    command.Connection = ConexionSQL.obtenerConexion();
                    command.Parameters.Add("@fdesde", SqlDbType.VarChar).Value = dtpFechaCheckin.Value;
                    command.Parameters.Add("@fhasta", SqlDbType.VarChar).Value = dtpFechaCheckout.Value;
                    command.Parameters.Add("@regimen_id", SqlDbType.Int).Value = cmbTipoRegimen.SelectedValue;
                    command.Parameters.Add("@hotel_id", SqlDbType.Int).Value = cmbHotel.SelectedValue;
                    command.Parameters.Add("@tipoHabitacion_id", SqlDbType.Int).Value = (cmbTipoHab.SelectedIndex == 0 ? "null" : cmbTipoHab.SelectedValue);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;

                    //Se muestra por pantalla la tabla con los resultados del SELECT
                    //dataGridView1.DataSource = dt;
                    dataGridView1.Columns[3].Visible = dataGridView1.Columns[4].Visible = false;
                    this.Cursor = Cursors.Default;
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
            dt = conexion.cargarTablaSQL("select tipo_id, descripcion from WHERE_EN_EL_DELETE_FROM.habitaciones_tipos");
            dt.Rows.InsertAt(dt.NewRow(), 0); //DESCOMENTAR PARA QUE AGREGUE UNA ROW VACIA EN COMBO
            cmbTipoHab.DataSource = dt;
            //cmbTipoHab.SelectedIndex = 0; //DESCOMENTAR PARA QUE AGREGUE UNA ROW VACIA EN COMBO

            cmbTipoHab.DisplayMember = "descripcion";
            cmbTipoHab.ValueMember = "tipo_id";

            dt = conexion.cargarTablaSQL("select regimen_id, descripcion FROM WHERE_EN_EL_DELETE_FROM.regimenes WHERE habilitado = 1");
            cmbTipoRegimen.DataSource = dt;
            cmbTipoRegimen.DisplayMember = "descripcion";
            cmbTipoRegimen.ValueMember = "regimen_id";

            dt = conexion.cargarTablaSQL("select hotel_id, 'Hotel ' + direccion AS nombre FROM WHERE_EN_EL_DELETE_FROM.hoteles");
            cmbHotel.DataSource = dt;
            cmbHotel.DisplayMember = "nombre";
            cmbHotel.ValueMember = "hotel_id";


            //TODO: Ocultar combo hotel si el usuario es recepcionista. 
            //Si es admin o guest, mostrar combo hotel.
            if (_res.codigo != 0)
            {
                dtpFechaCheckin.Value = _res.fecha_desde;
                dtpFechaCheckout.Value = _res.fecha_hasta;
                cmbTipoRegimen.SelectedValue = _res.regimen_id;
                cmbHotel.SelectedValue = _res.hotel_id;
                cmbTipoHab.SelectedValue = _idTipoHabitacion;


                dataGridView1.DataSource = _res.getHabitacionesByReserva();
                this.Cursor = Cursors.Default;
            }
            else
            {
                dtpFechaCheckin.MinDate = DateTime.Today;
                dtpFechaCheckout.MinDate = DateTime.Today.AddDays(1);
            }
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            List <Habitacion> habs = new List<Habitacion>();
            decimal precioTotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    habs.Add(new Habitacion(Convert.ToInt32(row.Cells[4].Value), Convert.ToInt32(row.Cells[3].Value),
                                                Convert.ToInt32(row.Cells[1].Value), 
                                                Convert.ToDecimal(row.Cells[6].Value)));
                    precioTotal += Convert.ToDecimal(row.Cells[6].Value);
                }

            }

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
                                                                    precioTotal, // Completar total de todas las habs
                                                                    Convert.ToInt32(cmbTipoRegimen.SelectedValue),
                                                                    Convert.ToInt32(cmbHotel.SelectedValue),
                                                                    habs));

                ((GenerarReservaPrincipal)this.Owner).GenerarReservaPrincipal_Load(sender, e);
                this.Close();
                f2.Show();
            }
            else {
              
                _res.usuario_modificacion_id = _usuarioLogueado;
                Cliente c = (new Cliente()).getClienteById(_res.cliente_id);
                //insertar nuevos registros habitaciones_reservas:
                frmConfirmarReserva frm = new frmConfirmarReserva(c, _res, habs);
                frm.Show();

            }
            
        }
    }
}
