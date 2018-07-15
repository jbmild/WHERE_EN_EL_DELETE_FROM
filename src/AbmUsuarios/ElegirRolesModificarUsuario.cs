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
    public partial class ElegirRolesModificarUsuario : Form
    {
        private ModificarUsuario pantallaInicial;
        public ElegirRolesModificarUsuario()
        {
            InitializeComponent();
        }

        internal void RecibirRolesActuales(ListBox listBox, ModificarUsuario modificarUsuario)
        {
            this.pantallaInicial = modificarUsuario;
            foreach (var item in listBox.Items) 
            {
                this.listBoxRolesIncluidos.Items.Add(item);
            }
            TraerRolesFaltantes traerRoles = new TraerRolesFaltantes();
            traerRoles.traer(listBoxRolesIncluidos, this.listBoxRolesExcluidos);
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            if (listBoxRolesExcluidos.Items.Count.Equals(0)) { MessageBox.Show("No hay más roles para incluir"); }
            else
            {
                if (listBoxRolesExcluidos.SelectedIndex == -1) { MessageBox.Show("No hay rol elegido"); }
                else
                {
                    listBoxRolesIncluidos.Items.Add(listBoxRolesExcluidos.SelectedItem);
                    listBoxRolesExcluidos.Items.Remove(listBoxRolesExcluidos.SelectedItem);
                }
            }
        }

        private void buttonExcluirRol_Click(object sender, EventArgs e)
        {
            if (listBoxRolesIncluidos.SelectedIndex == -1) { MessageBox.Show("No hay rol elegido"); }
            else
            {
                    if (listBoxRolesIncluidos.Items.Count.Equals(1)) { MessageBox.Show("No puede dejar a un usuario sin roles"); }
                    else
                    {
                
                    listBoxRolesExcluidos.Items.Add(listBoxRolesIncluidos.SelectedItem);
                    listBoxRolesIncluidos.Items.Remove(listBoxRolesIncluidos.SelectedItem);
                }
            }
        }

        internal void BuscarRolesParaModificar(ListBox listBox, string usuario)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable roles= c.cargarTablaSQL("select r.nombre from WHERE_EN_EL_DELETE_FROM.roles r" + 
                " join WHERE_EN_EL_DELETE_FROM.usuarios_roles ur on r.rol_id=ur.rol_id " +
                " join WHERE_EN_EL_DELETE_FROM.usuarios u on u.usuario_id= ur.usuario_id" +
                " where u.usuario like '" + usuario + "'");
            int i;
            for (i = 0; i < roles.Rows.Count; i++) 
            {
                listBox.Items.Add(roles.Rows[i].ItemArray[0].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pantallaInicial.RecibirRolesActualizados(this.listBoxRolesIncluidos);
            this.Hide();
        }
    }
}
