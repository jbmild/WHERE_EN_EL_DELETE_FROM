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
    public partial class AgregarUsuario : Form
    {
        private string hotel_nom;
        private int hotel_ID;
        private Usuarios pantallaUsu;
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CrearUsuario crear = new CrearUsuario();
            ConexionSQL c = new ConexionSQL();

            DataTable data = c.cargarTablaSQL("SELECT * FROM WHERE_EN_EL_DELETE_FROM.usuarios where usuario='"+textBoxUsuario.Text+"'");

            string fecha_nacimiento;
            if (this.textBoxUsuario.Text.Equals("") || this.textBoxTipoDOC.Text.Equals("") || this.textBoxTelefono.Text.Equals("") ||
                this.textBoxPiso.Text.Equals("") || this.textBoxPais.Text.Equals("") || this.textBoxNumeroDOC.Text.Equals("") ||
                this.textBoxNumero.Text.Equals("") || this.textBoxNombre.Text.Equals("") || this.textBoxMail.Text.Equals("") ||
                this.textBoxLocalidad.Text.Equals("") || this.textBoxDireccion.Text.Equals("") || this.textBoxDepto.Text.Equals("") ||
                this.textBoxApellido.Text.Equals("") || this.dateTimePickerFechaNacimiento.Value.Equals(null) || this.listBoxRolesElegidos.Items.Count.Equals(0) || data.Rows.Count>0)
            {
                MessageBox.Show("Debe completar todos los campos y el usuario debe ser unico");
            }
            else
            {
                crear.Crear(c, this.textBoxApellido.Text, this.textBoxDepto.Text, this.textBoxDireccion.Text, this.textBoxMail.Text, this.textBoxNombre.Text, this.textBoxNumero.Text, this.textBoxNumeroDOC.Text, this.textBoxPais.Text, this.textBoxPiso.Text, this.textBoxTelefono.Text, this.textBoxTipoDOC.Text, this.textBoxUsuario.Text, this.dateTimePickerFechaNacimiento.Value, this.textBoxLocalidad.Text, this.textBoxPassword.Text, this.listBoxRolesElegidos, this.hotel_ID, this, pantallaUsu);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElegirRoles pantallaRoles = new ElegirRoles();
            pantallaRoles.RecibirRolesActuales(this.listBoxRolesElegidos, this);
            pantallaRoles.Show();
        }

        internal void EnviarRolesElegidos(ListBox listBox)
        {
            listBoxRolesElegidos.Items.Clear();
            foreach (var item in listBox.Items) 
            {
                this.listBoxRolesElegidos.Items.Add(item);
            }
        }

        internal void RecibirHotel(string hotName, int hotID, Usuarios pUsu)
        {
            this.pantallaUsu = pUsu;
            this.hotel_ID = hotID;
            this.hotel_nom = hotName;
            this.labelHotel.Text = hotel_nom;
        }
    }
}
