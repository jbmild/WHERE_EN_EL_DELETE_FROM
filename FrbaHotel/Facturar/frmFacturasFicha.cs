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
using FrbaHotel.Tools;

namespace FrbaHotel.Facturar
{
    public partial class frmFacturasFicha : Form
    {
        private Reserva _res;
        private int _estadia_id;
        private string _nombreCliente;
        private string _domicilioCliente;
        private string _localidadCliente;
        private int _cliente_id;
        
        private string _nroDocumento;
        private string _email;
        private bool _returnToCheckInFunctionality = false;

        public frmFacturasFicha(bool returnToCheckInFunctionality) {
            _returnToCheckInFunctionality = returnToCheckInFunctionality;
            InitializeComponent();
        }


        public frmFacturasFicha()
        {
            InitializeComponent();

        }

        public frmFacturasFicha(int estadia_id)
        {
            _estadia_id = estadia_id;
            DataTable dt = Estadias.getEstadiasAFacturar("", "", "", "", "", 0, estadia_id, 0);
            _nombreCliente = dt.Rows[0].ItemArray[4].ToString();
            _domicilioCliente = dt.Rows[0].ItemArray[5].ToString();
            _localidadCliente = dt.Rows[0].ItemArray[6].ToString();
            _cliente_id = Convert.ToInt32(dt.Rows[0].ItemArray[7]);
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = FormasPago.getFormasPago();
            cmbFormaPago.DisplayMember = "nombre";
            cmbFormaPago.ValueMember = "formapago_id";
            dt.Rows.InsertAt(dt.NewRow(), 0); //AGREGA UNA ROW VACIA EN COMBO
            cmbFormaPago.DataSource = dt;

            txtNombreCliente.Text = _nombreCliente;
            txtDomicilioCliente.Text = _domicilioCliente;
            txtLocalidadCliente.Text = _localidadCliente;

            lblTotalFactura.Text = this.loadItemsFactura().ToString();

            cmbTipoIva.Items.Add("Consumidor final");
            cmbTipoIva.Items.Add("Iva inscripto");
            cmbTipoIva.Items.Add("Exento");

        }

        private decimal loadItemsFactura() {
            DataTable dt = Facturas.getItemsFacturables(_estadia_id);
            dtgItemsFactura.DataSource = dt;
            dtgItemsFactura.Columns["consumo_id"].Visible = false;
            dtgItemsFactura.Columns["codigo"].Visible = false;

            decimal totalFactura = 0;

            foreach (DataRow dr in dt.Rows) {
                totalFactura += Convert.ToDecimal(dr["total"]);
            }

            return totalFactura;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombreCliente.Text.Length == 0 || txtDomicilioCliente.Text.Length == 0 || 
                txtLocalidadCliente.Text.Length == 0 || txtCuit.Text.Length == 0 || cmbTipoIva.SelectedIndex <= 0){

                System.Windows.Forms.MessageBox.Show("Debe completar todos los campos de la cabecera de la factura");
            }
            else{

                System.Windows.Forms.MessageBox.Show("Debe completar todos los campos de la cabecera de la factura");

                List <Item_factura> items = new List<Item_factura>();
                Factura fact = new Factura(_estadia_id, _cliente_id, Convert.ToInt32(lblNumeroFactura.Text),
                    Sesion.obtenerFechaSistema(), Convert.ToDecimal(lblTotalFactura.Text), txtCuit.Text,
                    true, txtNombreCliente.Text, Convert.ToInt32(cmbFormaPago.SelectedValue), items);

                
                try
                {
                    //TODO: Pedir confirmacion
                    var confirmResult = MessageBox.Show(String.Concat("¿Confirma que desea crear la factura?", MessageBoxButtons.YesNo));
                    int nroFactura;
                    if (confirmResult == DialogResult.Yes)
                    {
                        nroFactura = fact.guardarFactura();
                        System.Windows.Forms.MessageBox.Show("Se ha creado con éxito la factura nro " + nroFactura.ToString());
                    }
                }
                catch(Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkRehabilitar_CheckedChanged(object sender, EventArgs e)
        {
        

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblMensajeLoginORegister_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
