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

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class IdentificarUsuario : Form
    {

        private Reserva reserva;

        public IdentificarUsuario() {
            InitializeComponent();
        }

        public IdentificarUsuario(Reserva res)
        {
            InitializeComponent();
            this.reserva = res;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IdentificarUsuario_Load(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            DataTable dt;
            dt = conexion.cargarTablaSQL("select id, descripcion from WHERE_EN_EL_DELETE_FROM.TiposDocumentos");
            //dt.Rows.InsertAt(dt.NewRow(), 0); DESCOMENTAR PARA QUE AGREGUE UNA ROW VACIA EN COMBO
            cmbTiposDocumentos.DataSource = dt;
            //cmbTipoHab.SelectedIndex = 0; DESCOMENTAR PARA QUE AGREGUE UNA ROW VACIA EN COMBO

            cmbTiposDocumentos.DisplayMember = "descripcion";
            cmbTiposDocumentos.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            cli.getClienteByTipoNroDocEmail(Convert.ToInt32(cmbTiposDocumentos.SelectedValue),
                                            txtNroDocumento.Text,
                                            txtMail.Text);


            IdentificarUsuarioExtendido frmUsuExtendido = new IdentificarUsuarioExtendido(reserva);
            frmUsuExtendido.Show();
        }

  
    }
}
