namespace FrbaHotel.Facturar
{
    partial class frmFacturasFicha
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
            this.txtDomicilioCliente = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtLocalidadCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgItemsFactura = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItemsFactura)).BeginInit();
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
            this.lblMensajeLoginORegister.Location = new System.Drawing.Point(220, 42);
            this.lblMensajeLoginORegister.Name = "lblMensajeLoginORegister";
            this.lblMensajeLoginORegister.Size = new System.Drawing.Size(98, 18);
            this.lblMensajeLoginORegister.TabIndex = 3;
            this.lblMensajeLoginORegister.Text = "FACTURA N°";
            this.lblMensajeLoginORegister.Click += new System.EventHandler(this.lblMensajeLoginORegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localidad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha: ";
            // 
            // txtDomicilioCliente
            // 
            this.txtDomicilioCliente.Location = new System.Drawing.Point(64, 47);
            this.txtDomicilioCliente.Name = "txtDomicilioCliente";
            this.txtDomicilioCliente.Size = new System.Drawing.Size(129, 20);
            this.txtDomicilioCliente.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(388, 69);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(129, 20);
            this.txtMail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Domicilio: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "IVA: ";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(206, 439);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(102, 31);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear Factura";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Señor/a: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Location = new System.Drawing.Point(452, 47);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(0, 13);
            this.lblFechaFactura.TabIndex = 21;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(64, 17);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(129, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // txtLocalidadCliente
            // 
            this.txtLocalidadCliente.Location = new System.Drawing.Point(388, 13);
            this.txtLocalidadCliente.Name = "txtLocalidadCliente";
            this.txtLocalidadCliente.Size = new System.Drawing.Size(129, 20);
            this.txtLocalidadCliente.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "CUIT: ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(324, 42);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(70, 18);
            this.lblNumeroFactura.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtDomicilioCliente);
            this.groupBox1.Controls.Add(this.txtLocalidadCliente);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Location = new System.Drawing.Point(55, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 97);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(181, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 17);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Responsable no inscripto";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 70);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 17);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Responsable inscripto";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(272, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 64);
            this.label10.TabIndex = 36;
            this.label10.Text = "Cuit nro: XXXXXXX. Ingresos brutos: 111111. Fecha inicio actividades: 1/3/2010";
            // 
            // dtgItemsFactura
            // 
            this.dtgItemsFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItemsFactura.Location = new System.Drawing.Point(58, 262);
            this.dtgItemsFactura.Name = "dtgItemsFactura";
            this.dtgItemsFactura.Size = new System.Drawing.Size(519, 162);
            this.dtgItemsFactura.TabIndex = 37;
            // 
            // frmFacturasFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 487);
            this.Controls.Add(this.dtgItemsFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblFechaFactura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMensajeLoginORegister);
            this.Name = "frmFacturasFicha";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItemsFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblMensajeLoginORegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomicilioCliente;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtLocalidadCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgItemsFactura;
    }
}