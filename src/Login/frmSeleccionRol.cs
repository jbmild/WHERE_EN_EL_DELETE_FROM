using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Roles.Modelo;
using FrbaHotel.Tools;

namespace FrbaHotel.Login
{
    public partial class frmSeleccionRoles : Form
    {
        public frmSeleccionRoles()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex >= 0)
            {
                Option opcion = (Option)cmbRoles.Items[cmbRoles.SelectedIndex];
                int rolId = Convert.ToInt32(opcion.Value);
                Sesion.rol = new Rol(rolId);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol valido con el que desea continuar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmSeleccionRol_Load(object sender, EventArgs e)
        {
            List<Rol> roles = Sesion.usuario.obtenerRolesHabilitados();
            if (roles.Count == 1)
            {
                Sesion.rol = roles[0];
                this.Close();
            }
            else if (roles.Count > 1)
            {
                foreach (Rol rol in roles)
                {
                    cmbRoles.Items.Add(new Option(rol.RolId.ToString(), rol.Nombre));
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
