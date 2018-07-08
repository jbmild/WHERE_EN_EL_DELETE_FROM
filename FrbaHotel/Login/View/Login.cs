using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class SeleccionUsuario : Form
    {
        private FrbaHotel.Modelo.Usuario usuario;
        private FrbaHotel.Modelo.Hotel hotel;
        private Roles.Modelo.Rol rol;
        public SeleccionUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.View.AccesoUsuarioHotel accesoUsuarioHotel = new Login.View.AccesoUsuarioHotel();
            accesoUsuarioHotel.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClienteLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
