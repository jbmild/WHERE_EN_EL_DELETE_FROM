using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Modelo;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class frmMotivoCancelacion : Form
    {

        Reserva res; 

        public frmMotivoCancelacion(Reserva r)
        {
            res = r;
            InitializeComponent();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            DialogResult resultado = System.Windows.Forms.MessageBox.Show("Confirma que desea cancelar la reserva? ", "Confirme", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) {
                res.motivoCancelacion = txtMotivo.Text;

                try
                {
                    int exito = res.cancelarReserva();

                    if (exito == 1)
                    {
                        System.Windows.Forms.MessageBox.Show("La reserva ha sido cancelada con éxito!");
                        ((ModificarCancelarReserva)this.Owner).Close();
                        this.Close();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No se pudo cancelar la reserva. Intentelo nuevamene. ");
                    }
                }
                catch (Exception ex) {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                
            }
            
        }
    }
}
