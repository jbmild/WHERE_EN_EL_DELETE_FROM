﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class modificarHotel : Form
    {
        public modificarHotel()
        {
            InitializeComponent();
        }

        private void modificarHotel_Load(object sender, EventArgs e)
        {
            ConexionSQL c = new ConexionSQL();
            DataTable estrellas = c.cargarTablaSQL("select distinct estrellas_cant from WHERE_EN_EL_DELETE_FROM.hoteles");
            estrellas.Rows.InsertAt(estrellas.NewRow(),0);
            comboBoxEstrellas.DataSource=estrellas;    
            comboBoxEstrellas.SelectedIndex=0;
            comboBoxEstrellas.DisplayMember="estrellas_cant";
            comboBoxEstrellas.ValueMember="estrellas_cant";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombreNoVacio=0;
            int estrellasNoVacio=0;
            int ciudadNoVacio=0;
            
            ConexionSQL c = new ConexionSQL();
            string consulta="select * from WHERE_EN_EL_DELETE_FROM.hoteles";
            if(textBoxHotelNombre.Text.Equals("")){}else{nombreNoVacio=1; consulta+=" where nombre like '%" + textBoxHotelNombre.Text + "%'";}
            if(comboBoxEstrellas.Text.Equals("")){}else
            {
                estrellasNoVacio=1;
                if(nombreNoVacio.Equals(1))
                {
                    consulta+=" and estrellas_cant=" + comboBoxEstrellas.SelectedValue;
                }else
                {
                    consulta+=" where estrellas_cant=" + comboBoxEstrellas.SelectedValue;
                }
            }
            if(textBoxCiudad.Text.Equals("")){}else
            {
                ciudadNoVacio=1;
                if (estrellasNoVacio.Equals(1) || nombreNoVacio.Equals(1))
                {
                    consulta+=" and ciudad like '%" + textBoxCiudad.Text + "%'";
                }
                else
                {
                    consulta+=" where ciudad like '%" + textBoxCiudad.Text + "%'";
                }
            }
            if (textBoxPais.Text.Equals("")){}else
            {
                if (estrellasNoVacio.Equals(1) || nombreNoVacio.Equals(1) || ciudadNoVacio.Equals(1))
                {
                    consulta+=" and pais like '%" + textBoxPais.Text + "%'";
                }
                else
                {
                    consulta+= " where pais like '%" + textBoxPais.Text + "%'";
                }
            }
            DataTable resultados = c.cargarTablaSQL(consulta);
            dataGridView1.DataSource = resultados;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPais.Text = "";
            textBoxHotelNombre.Text = "";
            textBoxCiudad.Text = "";
            comboBoxEstrellas.SelectedIndex = 0;
        }

       
    }
}