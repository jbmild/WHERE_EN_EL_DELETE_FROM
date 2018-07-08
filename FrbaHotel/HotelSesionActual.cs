using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class HotelSesionActual : Form
    {
        private Modelo.Usuario usuarioActual;

        public HotelSesionActual()
        {
            InitializeComponent();
        }

        private void HotelSesionActual_Load(object sender, EventArgs e)
        {
            ConexionSQL con = new ConexionSQL();
            BuscarHotelesInicioSesion buscarHotelesInicioSesion = new BuscarHotelesInicioSesion();
           DataTable hotelesComboBox= buscarHotelesInicioSesion.Buscar(this.usuarioActual);
           this.comboBoxHoteles.DataSource = hotelesComboBox;
           this.comboBoxHoteles.ValueMember = "hotel_id";
           this.comboBoxHoteles.DisplayMember = "nombre";
        }

        internal void RecibirDatosUsuario(Modelo.Usuario usuario)
        {
            usuarioActual = new Modelo.Usuario();
            usuarioActual = usuario;
            
        }

        private void buttonElegirHotel_Click(object sender, EventArgs e)
        {
            if (usuarioActual.GetRol().Equals("Administrador General"))
            {
                FuncionesAdmin funcionAdmin = new FuncionesAdmin();
                funcionAdmin.RecibirHotel(Int32.Parse(comboBoxHoteles.SelectedValue.ToString()), comboBoxHoteles.Text);
                funcionAdmin.Show();
            }
            else {
                FuncionesRecepcionista funcRecepcion = new FuncionesRecepcionista();
                funcRecepcion.RecibirHotel(Int32.Parse(comboBoxHoteles.SelectedValue.ToString()), comboBoxHoteles.Text);

                funcRecepcion.Show();
            }
        }
    }
}
