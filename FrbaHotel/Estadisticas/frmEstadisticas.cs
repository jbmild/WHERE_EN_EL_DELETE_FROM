using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Estadisticas.Modelo;
using FrbaHotel.Tools;

namespace FrbaHotel.Estadisticas
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            cmbTrimestre.Items.Add(new Option("1", "1er Trimestre"));
            cmbTrimestre.Items.Add(new Option("2", "2do Trimestre"));
            cmbTrimestre.Items.Add(new Option("3", "3ro Trimestre"));
            cmbTrimestre.Items.Add(new Option("4", "4to Trimestre"));

            cmbTipo.Items.Add(new Option("cantReservasCanceladas", "Hoteles con mayor cantidad de reservas canceladas"));
            cmbTipo.Items.Add(new Option("cantConsumiblesFacturados", "Hoteles con mayor cantidad de consumibles facturados"));
            cmbTipo.Items.Add(new Option("cantDiasFueraServicio", "Hoteles con mayor cantidad de dias fuera de servicio"));
            cmbTipo.Items.Add(new Option("habitacionMayorOcupacion", "Habitaciones con mayor cantidad de dias y veces que fueron ocupadas"));
            cmbTipo.Items.Add(new Option("clienteMasPuntos", "Cliente con mayor cantidad de puntos"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numAnio.Value = 1970;
            cmbTrimestre.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbTrimestre.SelectedIndex != -1 && cmbTipo.SelectedIndex != -1)
            {
                int anio = Convert.ToInt32(numAnio.Value);
                int trimestre = Convert.ToInt32(((Option)cmbTrimestre.Items[cmbTrimestre.SelectedIndex]).Value);
                string tipo = ((Option)cmbTipo.Items[cmbTipo.SelectedIndex]).Value;
                try
                {
                    Estadistica estadistica = Estadisticas.Modelo.Estadisticas.obtener(anio, trimestre, tipo);

                    this.dgvEstadistica.AutoGenerateColumns = false;
                    this.dgvEstadistica.Columns.Clear();

                    if (estadistica != null)
                    {
                        if (estadistica.columnas != null && estadistica.columnas.Count > 0)
                        {
                            foreach (DataGridViewTextBoxColumn columna in estadistica.columnas)
                            {
                                this.dgvEstadistica.Columns.Add(columna);
                            }

                            this.dgvEstadistica.DataSource = estadistica.data;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al procesar su solicitud.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al procesar su solicitud.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cmbTrimestre.SelectedIndex == -1 && cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un trimestre y un tipo de estadistica.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbTrimestre.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un trimestre.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de estadistica.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
