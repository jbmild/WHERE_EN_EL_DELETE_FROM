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
    public partial class ElegirRoles : Form
    {
        AgregarUsuario pantallaActual;
        public ElegirRoles()
        {
            InitializeComponent();
        }

        internal void RecibirRolesActuales(ListBox listBox, AgregarUsuario pantalla)
        {
            pantallaActual = pantalla;
            foreach(var item in listBox.Items)
            {
                this.listBoxRolesSeleccionados.Items.Add(item);
            }
            BuscarRolesParaNuevoUsuario buscar = new BuscarRolesParaNuevoUsuario();
            buscar.Buscar(this.listBoxRolesSeleccionados, this.listBoxRolesDisponibles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxRolesDisponibles.Items.Count.Equals(0)) { MessageBox.Show("No hay más roles disponibles para agregarle al usuario"); }
            else
            {
                if (listBoxRolesDisponibles.SelectedIndex == -1) { System.Windows.Forms.MessageBox.Show("No ha seleccionado ningún rol aún"); }
                else
                {
                    listBoxRolesSeleccionados.Items.Add(listBoxRolesDisponibles.SelectedItem.ToString());
                    listBoxRolesDisponibles.Items.Remove(listBoxRolesDisponibles.SelectedItem.ToString());
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxRolesSeleccionados.SelectedIndex == -1) { MessageBox.Show("No ha seleccionado ningún rol"); }
            else
            {
                if (listBoxRolesSeleccionados.Items.Count.Equals(0)) { MessageBox.Show("Todos los roles fueron quitados al usuario"); }
                else
                {
                    listBoxRolesDisponibles.Items.Add(listBoxRolesSeleccionados.SelectedItem.ToString());
                    listBoxRolesSeleccionados.Items.Remove(listBoxRolesSeleccionados.SelectedItem.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pantallaActual.EnviarRolesElegidos(this.listBoxRolesSeleccionados);
            this.Hide();
        }

        private void ElegirRoles_Load(object sender, EventArgs e)
        {

        }
    }
}
