﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class modificarDatosHotel : Form
    {
        int idhotel;
        public modificarDatosHotel()
        {
            InitializeComponent();
        }

        internal void RecibirHotel(HotelElegido hotel)
        {
            this.labelCiudad.Text = hotel.GetCiudad();
            this.labelDireccion.Text = hotel.GetDireccion();
            this.labelHotel.Text = hotel.GetNombre();
            this.labelMail.Text = hotel.GetMail();
            this.labelPais.Text = hotel.GetPais();
            this.labelTelefono.Text = hotel.GetTelefono().ToString();
            this.idhotel = hotel.GetID();

            //if (labelTelefono.Text.Equals("")) { this.labelTelefono.Text = "(vacío)"; }
            //if (labelPais.Text.Equals("")) { this.labelPais.Text = "(vacío)"; }
            //if (labelMail.Text.Equals("")) { this.labelMail.Text = "(vacío)"; }
            //if (labelDireccion.Text.Equals("")) { this.labelDireccion.Text = "(vacío)"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.CamposValidados()) {
                SqlConnection sql = ConexionSQL.obtenerConexion();
                string update = "update WHERE_EN_EL_DELETE_FROM.hoteles set nombre=@nombre, direccion=@direccion, telefono=@telefono, ciudad=@ciudad, pais=@pais, mail=@mail where";
                update += " hotel_id=" + this.idhotel;
                SqlCommand com = new SqlCommand(update);
                com.Connection = sql;
                if (this.textBoxHotel.Enabled.Equals(true) && textBoxHotel.Text != "")
                {
                    com.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = this.textBoxHotel.Text;
                }
                else
                {
                    com.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = this.labelHotel.Text;
                }

                if (this.textBoxDireccion.Enabled.Equals(true) && textBoxDireccion.Text != "")
                {
                    com.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = this.textBoxDireccion.Text;
                }
                else
                {
                    com.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = this.labelDireccion.Text;
                }
                if (this.textBoxTelefono.Enabled.Equals(true) && textBoxTelefono.Text != "")
                {
                    com.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = this.textBoxTelefono.Text;
                }
                else
                {
                    com.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = this.labelTelefono.Text;
                }

                if (this.textBoxCiudad.Enabled.Equals(true) && textBoxCiudad.Text != "")
                {
                    com.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = this.textBoxCiudad.Text;
                }
                else
                {
                    com.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = this.labelCiudad.Text;
                }
                if (this.textBoxPais.Enabled.Equals(true) && textBoxPais.Text != "")
                {
                    com.Parameters.Add("@pais", SqlDbType.NVarChar).Value = this.textBoxPais.Text;
                }
                else
                {
                    com.Parameters.Add("@pais", SqlDbType.NVarChar).Value = this.labelPais.Text;
                }
                if (this.textBoxMail.Enabled.Equals(true) && textBoxMail.Text != "")
                {
                    com.Parameters.Add("@mail", SqlDbType.NVarChar).Value = this.textBoxMail.Text;
                }
                else
                {
                    com.Parameters.Add("@mail", SqlDbType.NVarChar).Value = this.labelMail.Text;
                }

                int result = com.ExecuteNonQuery();
                if (result.Equals(1)) { System.Windows.Forms.MessageBox.Show("¡Hotel modificado con éxito!"); this.Hide(); } else { System.Windows.Forms.MessageBox.Show("ERROR!"); }
            
            }
            


        }

        private bool CamposValidados()
        {
            if (this.textBoxMail.Enabled.Equals(true))
            {
                if(this.textBoxMail.Text.IndexOf('@') >= 0)
                { return true; }
                else { System.Windows.Forms.MessageBox.Show("Debe ingresar un mail válido"); return false;}
            }   
            else 
            {
                return true;
            }

        }

        private void checkBoxHotel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxHotel.Checked) { this.textBoxHotel.Enabled = true; } else { this.textBoxHotel.Text = ""; this.textBoxHotel.Enabled = false; } 
        }

        private void checkBoxDir_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDir.Checked) { this.textBoxDireccion.Enabled = true; } else { this.textBoxDireccion.Text = ""; this.textBoxDireccion.Enabled = false; }
        }

        private void checkBoxCiudad_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxCiudad.Checked) { this.textBoxCiudad.Enabled = true; } else { this.textBoxCiudad.Text = ""; this.textBoxCiudad.Enabled = false; }
        }

        private void checkBoxPais_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxPais.Checked) { this.textBoxPais.Enabled = true; } else { this.textBoxPais.Text = ""; this.textBoxPais.Enabled = false; }
        }

        private void checkBoxTelefon_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTelefon.Checked) { this.textBoxTelefono.Enabled = true; } else { this.textBoxTelefono.Text = ""; this.textBoxTelefono.Enabled = false; }
        }

        private void checkBoxMail_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxMail.Checked) { this.textBoxMail.Enabled = true; } else { this.textBoxMail.Text = ""; this.textBoxMail.Enabled = false; }
        }

        private void modificarDatosHotel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxCiudad.Text = "";
            this.textBoxCiudad.Enabled = false;
            this.textBoxDireccion.Text = "";
            this.textBoxDireccion.Enabled = false;
            this.textBoxHotel.Text = "";
            this.textBoxHotel.Enabled = false;
            this.textBoxMail.Text = "";
            this.textBoxMail.Enabled = false;
            this.textBoxPais.Text = "";
            this.textBoxPais.Enabled = false;
            this.textBoxTelefono.Text = "";
            this.textBoxTelefono.Enabled = false;
            this.checkBoxCiudad.Checked = false;
            this.checkBoxDir.Checked = false;
            this.checkBoxHotel.Checked = false;
            this.checkBoxMail.Checked = false;
            this.checkBoxPais.Checked = false;
            this.checkBoxTelefon.Checked = false;
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modificarHotel m = new modificarHotel();
            m.Show();
        }
    }
}
