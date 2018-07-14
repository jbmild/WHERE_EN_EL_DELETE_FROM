using FrbaHotel.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class EditarRegimenes : Form
    {
        Hoteles.modificarDatosHotel pantalla;
        public EditarRegimenes()
        {
            InitializeComponent();
        }

        internal void EnviarRegimenes(ListBox listBox, Hoteles.modificarDatosHotel pantallita)
        {
            this.pantalla = pantallita;
            foreach (var item in listBox.Items) 
            {
                this.listBoxRegimenesActuales.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxRegimenesPost.SelectedIndex == -1)
            {
                MessageBox.Show("No se seleccionó ningún régimen");
            }
            else
            {
                listBoxRegimenesActuales.Items.Add(listBoxRegimenesPost.SelectedItem);
                listBoxRegimenesPost.Items.Remove(listBoxRegimenesPost.SelectedItem);
            }
        }
        

        private bool ChequearRegimenEstadias(string regimen)
        {
            ConexionSQL c = new ConexionSQL();
            string query = "select e.estadia_id from WHERE_EN_EL_DELETE_FROM.estadias e" +
                " join WHERE_EN_EL_DELETE_FROM.reservas r on e.reserva_id=r.reserva_id " +
                " join WHERE_EN_EL_DELETE_FROM.regimenes reg on reg.regimen_id=r.regimen_id " +
                " where reg.descripcion like '" + regimen + "' and e.ingreso_fecha>=convert(Date, " + "'" + Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy") + "', 110)" + " and e.egreso_fecha<=convert(Date, '" + Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy") + "', 110)" +
                " and r.hotel_id=" + Sesion.hotel.HotelId;
            DataTable estadias=c.cargarTablaSQL(query);
            return estadias.Rows.Count.Equals(0);
        }
        private bool ChequearRegimenReservas(string regimen)
        {
            ConexionSQL c = new ConexionSQL();
            string query = "select res.reserva_id from WHERE_EN_EL_DELETE_FROM.reservas res join WHERE_EN_EL_DELETE_FROM.regimenes regi on res.regimen_id=regi.regimen_id "
                + " where regi.descripcion like '" + regimen + "' and res.fecha_desde>=convert(Date, " + "'" + Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy") + 
                "', 110)" + " and res.fecha_hasta<=convert(Date, '" + Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy") + "', 110)" +
                " and res.hotel_id=" + Sesion.hotel.HotelId;
            DataTable estadias = c.cargarTablaSQL(query);
            return estadias.Rows.Count.Equals(0);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxRegimenesActuales.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado ningún régimen actual");
            }
            else
            {
                bool puedeSerQuitadoPorEstadias = this.ChequearRegimenEstadias(listBoxRegimenesActuales.SelectedItem.ToString());
                bool puedeSerQuitadoPorReservas = this.ChequearRegimenReservas(listBoxRegimenesActuales.SelectedItem.ToString());
                if (puedeSerQuitadoPorEstadias && puedeSerQuitadoPorReservas)
                {
                    listBoxRegimenesPost.Items.Add(listBoxRegimenesActuales.SelectedItem);
                    listBoxRegimenesActuales.Items.Remove(listBoxRegimenesActuales.SelectedItem);
                }
                else 
                {
                    MessageBox.Show("No se puede eliminar el régimen porque existen estadías o reservas con dicho régimen");
                }
                
            }
        }

        

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            this.pantalla.RecibirRegimenesActualizados(this.listBoxRegimenesActuales);
            this.Hide();
            pantalla.Show();
        }

        private void EditarRegimenes_Load(object sender, EventArgs e)
        {
            BuscarRegimenes buscar = new BuscarRegimenes();
            DataTable regimenes = buscar.Buscar(this.listBoxRegimenesActuales);
            int i;
            for (i = 0; i < regimenes.Rows.Count;i++ )
            {
                listBoxRegimenesPost.Items.Add(regimenes.Rows[i].ItemArray[0]);
            }
        }
    }
}
