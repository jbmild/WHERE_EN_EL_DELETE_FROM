﻿namespace FrbaHotel.Clientes
{
    partial class frmClientesFicha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblMensajeLoginORegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccionCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTiposDocumentos = new System.Windows.Forms.ComboBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtPaisVivienda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccionNro = new System.Windows.Forms.TextBox();
            this.txtDireccionDepto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccionPiso = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(167, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(244, 24);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sistema de Gestión Hotelera";
            // 
            // lblMensajeLoginORegister
            // 
            this.lblMensajeLoginORegister.AutoSize = true;
            this.lblMensajeLoginORegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeLoginORegister.Location = new System.Drawing.Point(241, 42);
            this.lblMensajeLoginORegister.Name = "lblMensajeLoginORegister";
            this.lblMensajeLoginORegister.Size = new System.Drawing.Size(153, 18);
            this.lblMensajeLoginORegister.TabIndex = 3;
            this.lblMensajeLoginORegister.Text = "{texto modificar/crear}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo Documento*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre*:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(147, 221);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(129, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(149, 263);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(129, 20);
            this.txtMail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calle*:";
            // 
            // txtDireccionCalle
            // 
            this.txtDireccionCalle.Location = new System.Drawing.Point(147, 305);
            this.txtDireccionCalle.Name = "txtDireccionCalle";
            this.txtDireccionCalle.Size = new System.Drawing.Size(129, 20);
            this.txtDireccionCalle.TabIndex = 7;
            this.txtDireccionCalle.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(147, 349);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(105, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mail*: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pais: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Localidad: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(206, 439);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 31);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Siguiente >";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(324, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 31);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar ( x )";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nro Documento*: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Apellido*: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 177);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(164, 140);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(129, 20);
            this.txtNroDocumento.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nacionalidad*: ";
            // 
            // cmbTiposDocumentos
            // 
            this.cmbTiposDocumentos.FormattingEnabled = true;
            this.cmbTiposDocumentos.Location = new System.Drawing.Point(164, 99);
            this.cmbTiposDocumentos.Name = "cmbTiposDocumentos";
            this.cmbTiposDocumentos.Size = new System.Drawing.Size(92, 21);
            this.cmbTiposDocumentos.TabIndex = 1;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(437, 177);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(129, 20);
            this.txtNacionalidad.TabIndex = 4;
            // 
            // txtPaisVivienda
            // 
            this.txtPaisVivienda.Location = new System.Drawing.Point(147, 396);
            this.txtPaisVivienda.Name = "txtPaisVivienda";
            this.txtPaisVivienda.Size = new System.Drawing.Size(118, 20);
            this.txtPaisVivienda.TabIndex = 13;
            this.txtPaisVivienda.TextChanged += new System.EventHandler(this.txtPaisVivienda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Número*:";
            // 
            // txtDireccionNro
            // 
            this.txtDireccionNro.Location = new System.Drawing.Point(354, 302);
            this.txtDireccionNro.Name = "txtDireccionNro";
            this.txtDireccionNro.Size = new System.Drawing.Size(54, 20);
            this.txtDireccionNro.TabIndex = 8;
            this.txtDireccionNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionNro_KeyPress);
            // 
            // txtDireccionDepto
            // 
            this.txtDireccionDepto.Location = new System.Drawing.Point(612, 302);
            this.txtDireccionDepto.Name = "txtDireccionDepto";
            this.txtDireccionDepto.Size = new System.Drawing.Size(54, 20);
            this.txtDireccionDepto.TabIndex = 10;
            this.txtDireccionDepto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(560, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Depto:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtDireccionPiso
            // 
            this.txtDireccionPiso.Location = new System.Drawing.Point(486, 302);
            this.txtDireccionPiso.Name = "txtDireccionPiso";
            this.txtDireccionPiso.Size = new System.Drawing.Size(54, 20);
            this.txtDireccionPiso.TabIndex = 9;
            this.txtDireccionPiso.TextChanged += new System.EventHandler(this.txtDireccionPiso_TextChanged);
            this.txtDireccionPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionPiso_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Piso:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(377, 348);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(122, 20);
            this.txtLocalidad.TabIndex = 12;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.chkHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilitado.Location = new System.Drawing.Point(51, 65);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 34;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            this.chkHabilitado.Visible = false;
            this.chkHabilitado.CheckedChanged += new System.EventHandler(this.chkRehabilitar_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(437, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmClientesFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 487);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtDireccionPiso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDireccionDepto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDireccionNro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPaisVivienda);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.cmbTiposDocumentos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccionCalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMensajeLoginORegister);
            this.Name = "frmClientesFicha";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblMensajeLoginORegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccionCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTiposDocumentos;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtPaisVivienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccionNro;
        private System.Windows.Forms.TextBox txtDireccionDepto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccionPiso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}