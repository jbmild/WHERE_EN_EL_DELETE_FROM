using FrbaHotel.Roles.Modelo;
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
    public partial class FuncionesAdmin : Form
    {
        private int hotelID;
        private string nombrehotel;
        public FuncionesAdmin()
        {
            InitializeComponent();
        }

        internal void RecibirHotel(int hotelid, string hotel)
        {
            this.hotelID = hotelid;
            this.nombrehotel = hotel;
        }

        private void FuncionesAdmin_Load(object sender, EventArgs e)
        {
            this.labelhotel.Text = nombrehotel;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbmHabitacion.modificarHabitacion habitaciones = new AbmHabitacion.modificarHabitacion();
            habitaciones.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AbmCliente.frmClientesListado listadoClientes = new AbmCliente.frmClientesListado();
            listadoClientes.Show();
        }

        internal void HabilitarBotones(string rol)
        {
            ConexionSQL c = new ConexionSQL();
           List<Permiso> permisos= Roles.Modelo.RolesPermisos.obtenerPermisosDadosPorRol(Int32.Parse(rol));
            //DataTable permisos = c.cargarTablaSQL("select rp.permiso_id from WHERE_EN_EL_DELETE_FROM.roles r join WHERE_EN_EL_DELETE_FROM.roles_permisos rp" + 
            //    " on r.rol_id=rp.rol_id where r.rol_ '" + rol + "' order by rp.permiso_id asc");
            foreach (Permiso p in permisos) 
            {
                switch ( p.PermisoId) {

                    case 1: btn1.Visible = true;
                        break;
                    case 2: btn2.Visible = true;
                        break;
                    case 3: btn3.Visible = true;
                        break;
                    case 4: btn4.Visible = true;
                        break;
                    case 5: btn5.Visible = true;
                        break;
                    case 6: btn6.Visible = true; 
                        break;
                    case 7: btn7.Visible = true;
                        break;
                    case 8: btn8.Visible = true;
                        break;
                    case 9: btn9.Visible = true;
                        break;
                    case 10: btn10.Visible = true;
                        break;
                    case 11: btn11.Visible = true;
                        break;
                    case 12: btn12.Visible = true;
                        break;
                }
            }
               
        }
    }
}
