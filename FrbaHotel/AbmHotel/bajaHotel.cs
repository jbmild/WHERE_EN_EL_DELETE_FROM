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
using System.Globalization;

namespace FrbaHotel.AbmHotel
{
    public partial class bajaHotel : Form
    {
        private int _hotel_id;

        public bajaHotel(int hotel_id)
        {
            _hotel_id = hotel_id;
            InitializeComponent();
        }

        private void bajaHotel_Load(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable hoteles = c.cargarTablaSQL("select hotel_id, isNull(nombre, 'hotel ' + direccion) as 'nombre' from WHERE_EN_EL_DELETE_FROM.hoteles");
            
            comboBoxHoteles.DataSource = hoteles;
            
            comboBoxHoteles.DisplayMember = "nombre";
            comboBoxHoteles.ValueMember = "hotel_id";
            comboBoxHoteles.SelectedValue = _hotel_id;

            DataTable estrellas = c.cargarTablaSQL("select distinct estrellas_cant from WHERE_EN_EL_DELETE_FROM.hoteles");
            estrellas.Rows.InsertAt(estrellas.NewRow(), 0);
            comboBoxEstrellas.DataSource = estrellas;
            comboBoxEstrellas.SelectedIndex = 0;
            comboBoxEstrellas.DisplayMember = "estrellas_cant";
            comboBoxEstrellas.ValueMember = "estrellas_cant";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.labelFechaInicio.Text = monthCalendar1.SelectionEnd.Day.ToString() + "/" + monthCalendar1.SelectionEnd.Month.ToString() + "/" + monthCalendar1.SelectionEnd.Year.ToString();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.labelFechaFin.Text = monthCalendar2.SelectionEnd.Day.ToString() + "/" + monthCalendar2.SelectionEnd.Month.ToString() + "/" + monthCalendar2.SelectionEnd.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelFechaFin.Text.Equals("") || labelFechaInicio.Text.Equals(""))
            {
                this.labelErrorFechas.Visible = true;
            }
            else
            {
                this.labelErrorFechas.Visible = false;
                if (monthCalendar1.SelectionEnd.Date > monthCalendar2.SelectionEnd.Date)
                {

                    System.Windows.Forms.MessageBox.Show("La fecha de inicio debe ser menor o igual que la fecha de fin");

                }
                else
                {
                    this.labelErrorFechas.Visible = false;
                    if (this.NoHayAlojamientosEnEsePeriodo(this.monthCalendar1.SelectionEnd, this.monthCalendar2.SelectionEnd) &&
                        this.NoHayReservasEnEsePeriodo(this.monthCalendar1.SelectionEnd, this.monthCalendar2.SelectionEnd))
                    {
                        this.Hide();
                        this.DarDeBajaHotel(this.monthCalendar1.SelectionEnd, this.monthCalendar2.SelectionEnd);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No puede dar de baja hotel en esta fecha por reservas o alojamientos efectuados en la misma");
                    }


                }

            }
        }

        private void DarDeBajaHotel(DateTime dateTime1, DateTime dateTime2)
        {
            AbmHotel.motivoBajaHotel motivo = new AbmHotel.motivoBajaHotel();
            motivo.RecibirDatosBaja(dateTime1, dateTime2, comboBoxHoteles.SelectedValue.ToString());
            motivo.Show();
            

            
        }

        private bool NoHayAlojamientosEnEsePeriodo(DateTime dateTime1, DateTime dateTime2)
        {
            string strDatetime1 = dateTime1.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            string strDatetime2 = dateTime2.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);

            ConexionSQL c = new ConexionSQL();
            DataTable estadias= c.cargarTablaSQL(@"select e.estadia_id from WHERE_EN_EL_DELETE_FROM.estadias e" + 
                " join WHERE_EN_EL_DELETE_FROM.reservas r on r.reserva_id=e.reserva_id " + 
                " join WHERE_EN_EL_DELETE_FROM.reservas_habitaciones rh on rh.reserva_id=r.reserva_id " + 
                " join WHERE_EN_EL_DELETE_FROM.habitaciones h on rh.habitacion_id=h.habitacion_id" + 
                " where h.hotel_id=" + comboBoxHoteles.SelectedValue.ToString() +
                " and (e.ingreso_fecha between convert(date, '" + strDatetime1 + "', 110) and convert(date,'" + strDatetime2 + "', 110) " +
                " OR e.egreso_fecha between convert(date, '" + strDatetime1 + "', 110) and convert(date,'" + strDatetime2 + "', 110) " +
                " OR (e.ingreso_fecha < convert(date, '" + strDatetime1 + "', 110) and e.egreso_fecha > convert(date, '" + strDatetime2 + "', 110)))");
                
                
                //+ " and e.ingreso_fecha >='" + dateTime1.ToString() +
                //"' and e.egreso_fecha<='" + dateTime2.ToString() + "'");
            return estadias.Rows.Count.Equals(0);
        }

        private bool NoHayReservasEnEsePeriodo(DateTime dateTime1, DateTime dateTime2)
        {
            ConexionSQL c = new ConexionSQL();

            string strDatetime1 = dateTime1.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            string strDatetime2 = dateTime2.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);

            string query = "select r.reserva_id from WHERE_EN_EL_DELETE_FROM.reservas r";
            query += @" join WHERE_EN_EL_DELETE_FROM.reservas_habitaciones rh on r.reserva_id=rh.reserva_id " +
                " join WHERE_EN_EL_DELETE_FROM.habitaciones h on h.habitacion_id= rh.habitacion_id" + " where " +
                " h.hotel_id=" + comboBoxHoteles.SelectedValue.ToString()+
                " and (r.fecha_desde between convert(date, '" + strDatetime1 + "', 110) and convert(date,'" + strDatetime2 + "', 110) " +
                " OR r.fecha_hasta between convert(date, '" + strDatetime1 + "', 110) and convert(date,'" + strDatetime2 + "', 110) " +
                " OR (r.fecha_desde < convert(date, '" + strDatetime1 + "', 110) and r.fecha_hasta > convert(date, '" + strDatetime2 + "', 110)))" + 
                " AND r.estado in ('correcta', 'modificada')";
            
            DataTable reservas=c.cargarTablaSQL(query);
                
            return reservas.Rows.Count.Equals(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable hotelesFiltrados;
            int hayCiudad = 0; int hayPais = 0; 
            string queryHotelesFiltrados = "select hotel_id, isNull(nombre, 'hotel ' + direccion) as 'nombre' from WHERE_EN_EL_DELETE_FROM.hoteles";
            if (textBoxCiudad.Text.Equals("")) { } else { hayCiudad = 1;
            queryHotelesFiltrados += " where ciudad like '%" + this.textBoxCiudad.Text + "%'";
            }
            if (textBoxPais.Text.Equals("")) {}else{
            
                if (hayCiudad.Equals(1))
                {
                    hayCiudad = 1;
                    queryHotelesFiltrados += " and pais='%" + this.textBoxPais.Text + "%'";
                }
                else {
                    hayCiudad = 1;
                    queryHotelesFiltrados += " where pais='%" + this.textBoxPais.Text + "%'";
                }
            
            
            }
            if (comboBoxEstrellas.SelectedValue.ToString().Equals("")) { }else
            {
                if (hayCiudad.Equals(1) || hayPais.Equals(1))
                {
                    queryHotelesFiltrados += " and estrellas_cant=" + comboBoxEstrellas.SelectedValue.ToString();
                }
                else 
                {
                    queryHotelesFiltrados += "where estrellas_cant=" + comboBoxEstrellas.SelectedValue.ToString();
                }
            }
            hotelesFiltrados = c.cargarTablaSQL(queryHotelesFiltrados);
            
            comboBoxHoteles.DataSource = hotelesFiltrados;
            comboBoxHoteles.ValueMember = "hotel_id";
            comboBoxHoteles.DisplayMember = "nombre";

        }

        private void comboBoxHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
