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
using System.Data.SqlClient;


namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class ModificarCancelarReserva : Form
    {
        int usuario = 1; 

        public ModificarCancelarReserva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL conn = new ConexionSQL();

            string sqlQuery = @"select codigo, fecha_desde, fecha_hasta, isNull(h.nombre, 'Hotel ' + h.direccion) AS Hotel, datediff(dd, getdate(), fecha_desde) AS DiasHastaLaReserva from WHERE_EN_EL_DELETE_FROM.Reservas r
                    INNER JOIN WHERE_EN_EL_DELETE_FROM.Hoteles h on h.hotel_id = r.hotel_id WHERE ";

            if (txtCodigo.Text.Length > 0)
            {
                sqlQuery += "codigo = " + txtCodigo.Text.ToString();
                sqlQuery += " AND estado in ('correcta', 'modificada') ";
                DataTable dt = conn.cargarTablaSQL(sqlQuery);
                dgvReservas.DataSource = dt;
                this.Cursor = Cursors.Default;

                dgvReservas.Columns["DiasHastaLaReserva"].Visible = false;

           
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (Convert.ToInt32(row.Cells[0].Value) >= 1)
                    {
                        //TODO: MUESTRO FORM PARA MODIFICAR RESERVA
                        Convert.ToInt32(row.Cells[1].Value); // codigo reserva
                    }
                    else {
                        System.Windows.Forms.MessageBox.Show("No es posible modificar su reserva a menos de un día de que comience. ");
                    }
                            
                }
            }    
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (Convert.ToInt32(row.Cells[0].Value) >= 1)
                    {
                        Reserva res = new Reserva();
                        res.codigo = Convert.ToInt32(row.Cells[1].Value);
                        res.usuarioCancelacion = usuario;
                        frmMotivoCancelacion form = new frmMotivoCancelacion(res);
                        form.Owner = this;
                        form.Show();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("No es posible modificar su reserva a menos de un día de que comience. ");
                    }
                }
            }
        }

        private void ModificarCancelarReserva_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            dgvReservas.Rows.Clear();
        }
    }

    
}
