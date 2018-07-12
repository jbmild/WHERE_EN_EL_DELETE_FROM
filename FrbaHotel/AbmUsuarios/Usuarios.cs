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
        private int hotelid;
        private string hotelnombre;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            BuscarUsuarios b = new BuscarUsuarios();
            DataTable resultados = b.BusquedaInicial(c, hotelid);
           //
            this.labelHotel.Text = hotelnombre;
            
           dataGridView1.DataSource = resultados;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            BuscarUsuarios b = new BuscarUsuarios();
            DataTable resultados = b.Buscar(c, this.textBoxApellido.Text, this.textBoxDireccion.Text, this.textBoxLocalidad.Text, this.textBoxNumero.Text, this.textBoxPais.Text, this.textBoxPiso.Text, this.textBoxMail.Text, this.textBoxNombre.Text, this.textBoxNumeroDOC.Text, this.textBoxTelefono.Text, this.textBoxTipoDOC.Text, this.textBoxUsuario.Text, this.dateTimePickerFechaNacimiento.Value, this.hotelid);
            dataGridView1.DataSource = resultados;
        }

        internal void RecibirHotel(int _hotelid, string _hotelnombre)
        {
            this.hotelid = _hotelid;
            this.hotelnombre = _hotelnombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarUsuario newUser = new AgregarUsuario();
            newUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBoxPiso.Text = "";
            this.textBoxTelefono.Text = "";
            this.textBoxPais.Text = "";
            this.textBoxMail.Text = "";
            this.textBoxDepto.Text = "";
            this.textBoxApellido.Text = "";
            this.textBoxDireccion.Text = "";
            this.textBoxLocalidad.Text = "";
            this.textBoxDepto.Text = "";
            this.textBoxNombre.Text = "";
            this.textBoxTipoDOC.Text = "";
            this.textBoxUsuario.Text = "";
            this.textBoxNumeroDOC.Text = "";
        }
    }
}
