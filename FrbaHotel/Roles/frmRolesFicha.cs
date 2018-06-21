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

namespace FrbaHotel.Roles
{
    public partial class frmRolesFicha : Form
    {
        private Rol rol;

        public frmRolesFicha(Rol rol)
        {
            InitializeComponent();
            this.rol = rol;
            this.cargarFormulario();
        }

        private void cargarFormulario()
        {
            if (this.rol.RolId == 0)
            {
                lblTitulo.Text = "Alta de nuevo rol.";
                btnGuardar.Text = "Crear";
                btnLimpiar.Text = "Limpiar";

                txtNombre.Text = "";
                chkHabilitado.Checked = false;

                lbxConcedidos.Items.Clear();
                lbxDenegados.Items.Clear();

                lbxDenegados.DisplayMember = "Text";
                if (this.rol.PermisosRestringidos != null)
                {
                    foreach (Permiso permiso in this.rol.PermisosRestringidos)
                    {
                        lbxDenegados.Items.Add(new ComboBoxItem(permiso.PermisoId.ToString(), permiso.Nombre));
                    }
                }
                
            }
            else
            {
                lblTitulo.Text = "Modificacion del rol '" + this.rol.Nombre + "'";
                btnGuardar.Text = "Modificar";
                btnLimpiar.Text = "Reiniciar";

                txtNombre.Text = this.rol.Nombre;
                chkHabilitado.Checked = this.rol.Habilitado;

                lbxConcedidos.Items.Clear();
                lbxDenegados.Items.Clear();

                if (this.rol.PermisosDados != null)
                {
                    foreach (Permiso permiso in this.rol.PermisosDados)
                    {
                        lbxConcedidos.Items.Add(new ComboBoxItem(permiso.PermisoId.ToString(), permiso.Nombre));
                    }
                }
                if (this.rol.PermisosRestringidos != null)
                {
                    foreach (Permiso permiso in this.rol.PermisosRestringidos)
                    {
                        lbxDenegados.Items.Add(new ComboBoxItem(permiso.PermisoId.ToString(), permiso.Nombre));
                    }
                }
            }
        }

        private void lbxDenegados_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show( ((ComboBoxItem)lbxDenegados.Items[lbxDenegados.SelectedIndex]).Value);
        }
    }

    public class ComboBoxItem
    {
        public string Value;
        public string Text;

        public ComboBoxItem(string val, string text)
        {
            Value = val;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
