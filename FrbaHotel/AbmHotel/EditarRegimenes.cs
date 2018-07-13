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
        public EditarRegimenes()
        {
            InitializeComponent();
        }

        internal void EnviarRegimenes(ListBox listBox)
        {
            foreach (var item in listBox.Items) 
            {
                this.listBoxRegimenesActuales.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxRegimenesActuales.SelectedIndex == -1)
            {
                MessageBox.Show("No se seleccionó ningún régimen");
            }
            else
            {
                bool puedeSerQuitado = this.ChequearRegimen(listBoxRegimenesActuales.SelectedItem.ToString());
            }
        }
        

        private bool ChequearRegimen(string regimen)
        {
            ConexionSQL c = new ConexionSQL();
            string query = "select e.estadia_id from WHERE_EN_EL_DELETE_FROM.estadias e" +
                " join WHERE_EN_EL_DELETE_FROM.reservas r on e.reserva_id=r.reserva_id " +
                " join WHERE_EN_EL_DELETE_FROM.regimenes reg on reg.regimen_id=r.regimen_id " +
                " where reg.descripcion like" + regimen + " and e.ingreso_fecha>=convert(Date, " + Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy") + ", 110)" + "' and e.egreso_fecha<=convert(Date, " + Sesion.obtenerFechaSistema().ToString("MM/dd/yyyy") + ", 110)";
            DataTable estadias=c.cargarTablaSQL(query);
            return estadias.Rows.Count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxRegimenesActuales.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado ningún régimen actual");
            }
            else
            {
                listBoxRegimenesPost.Items.Add(listBoxRegimenesActuales.SelectedItem);
                listBoxRegimenesActuales.Items.Remove(listBoxRegimenesActuales.SelectedItem);
            }
        }
    }
}
