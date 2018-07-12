using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuarios
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            BuscarUsuarios b = new BuscarUsuarios();
            DataTable resultados = b.BusquedaInicial(c);
           //
            DataTable hoteles = b.GetHoteles();
            comboBoxHoteles.DataSource = hoteles;
            comboBoxHoteles.DisplayMember = "nombre";
            comboBoxHoteles.ValueMember = "hotel_id";
           dataGridView1.DataSource = resultados;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            BuscarUsuarios b = new BuscarUsuarios();
            DataTable resultados = b.Buscar(c, this.textBoxApellido.Text, this.textBoxDireccion.Text, this.textBoxMail.Text, this.textBoxNombre.Text, this.textBoxNumeroDOC.Text, this.textBoxTelefono.Text, this.textBoxTipoDOC.Text, this.textBoxUsuario.Text, this.dateTimePickerFechaNacimiento.Value, this.comboBoxHoteles.SelectedValue.ToString());
            dataGridView1.DataSource = resultados;
        }
    }
}
