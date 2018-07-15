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
    public partial class BajaUsuarios : Form
    {
        private string usuario_nombre;
        public BajaUsuarios()
        {
            InitializeComponent();
        }

        private void BajaUsuarios_Load(object sender, EventArgs e)
        {
            this.labelBajaUsuario.Text = "¿Desea inhabilitar al usuario '" + this.usuario_nombre + "'?";
        }

        internal void EnviarUsuario(string usuario)
        {
            this.usuario_nombre = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarUsuarioBaja b = new BuscarUsuarioBaja();
            b.BuscarUsuario(this.usuario_nombre, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
