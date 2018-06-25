using System;
using System.Collections;
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
                lblTitulo.Text = "Alta de nuevo rol";
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
                        lbxDenegados.Items.Add(new Option(permiso.PermisoId.ToString(), permiso.Nombre));
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
                        lbxConcedidos.Items.Add(new Option(permiso.PermisoId.ToString(), permiso.Nombre));
                    }
                }
                if (this.rol.PermisosRestringidos != null)
                {
                    foreach (Permiso permiso in this.rol.PermisosRestringidos)
                    {
                        lbxDenegados.Items.Add(new Option(permiso.PermisoId.ToString(), permiso.Nombre));
                    }
                }
            }
        }

        private void btnConceder_Click(object sender, EventArgs e)
        {
            if (this.lbxDenegados.SelectedIndex != -1)
            {
                Option opcion = (Option)this.lbxDenegados.Items[this.lbxDenegados.SelectedIndex];
                lbxConcedidos.Items.Add(opcion);
                this.lbxDenegados.Items.Remove(opcion);

                List<Option> opciones = new List<Option>();
                foreach (Option op in lbxConcedidos.Items)
                {
                    opciones.Add(op);
                }

                opciones = opciones.OrderBy(item => item.Text).ToList();

                lbxConcedidos.Items.Clear();
                foreach (Option op in opciones)
                {
                    lbxConcedidos.Items.Add(op);
                }
            }

        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            if (this.lbxConcedidos.SelectedIndex != -1)
            {
                Option opcion = (Option)this.lbxConcedidos.Items[this.lbxConcedidos.SelectedIndex];
                lbxDenegados.Items.Add(opcion);
                this.lbxConcedidos.Items.Remove(opcion);

                List<Option> opciones = new List<Option>();
                foreach (Option op in lbxDenegados.Items){
                    opciones.Add(op);
                }

                opciones = opciones.OrderBy(item => item.Text).ToList();

                lbxDenegados.Items.Clear();
                foreach (Option op in opciones)
                {
                    lbxDenegados.Items.Add(op);
                }
         
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cargarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.rol.Nombre = txtNombre.Text;
            this.rol.Habilitado = chkHabilitado.Checked;

            List<Permiso> permisos = new List<Permiso>();
            foreach (Option op in lbxConcedidos.Items)
            {
                permisos.Add(new Permiso(Convert.ToInt32(op.Value)));
            }
            this.rol.PermisosDados = permisos;
            this.loadError(this.rol.guardar());
        }

        private void loadError(List<KeyValuePair<string, string>> errores)
        {
            if (errores.Count == 0)
            {
                MessageBox.Show(String.Concat("La operacion se realizo con exito!"), "Exito", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                lblErrorNombre.Text = "";
                lblErrorGeneral.Text = "";

                foreach (KeyValuePair<string, string> error in errores)
                {
                    switch (error.Key)
                    {
                        case "nombre":
                            if (lblErrorNombre.Text == "")
                            {
                                lblErrorNombre.Text = error.Value;
                            }
                            else
                            {
                                lblErrorNombre.Text = lblErrorNombre.Text + " " + error.Value;
                            }
                            lblErrorNombre.Show();
                            break;
                        case "general":
                            if (lblErrorGeneral.Text == "")
                            {
                                lblErrorGeneral.Text = error.Value;
                            }
                            else
                            {
                                lblErrorGeneral.Text = lblErrorGeneral.Text + " " + error.Value;
                            }
                            lblErrorGeneral.Show();
                            break;
                    }
                }
            }
        }

    }
}
