namespace FrbaHotel.Reservas
{
    partial class GenerarReservaPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTipoRegimen = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.btnBuscarHabitaciones = new System.Windows.Forms.Button();
            this.txtNrosHabitaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.cmbTiposDocumentos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblHotel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Los campos con (*) son obligatorios";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(32, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(244, 24);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sistema de Gestión Hotelera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "GENERAR NUEVA RESERVA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHotel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPrecioTotal);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.lblTipoRegimen);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.btnBuscarHabitaciones);
            this.groupBox1.Controls.Add(this.txtNrosHabitaciones);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 169);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total: USD";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.Location = new System.Drawing.Point(82, 135);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(64, 18);
            this.lblPrecioTotal.TabIndex = 11;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(14, 102);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(45, 13);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Hotel: ";
            // 
            // lblTipoRegimen
            // 
            this.lblTipoRegimen.AutoSize = true;
            this.lblTipoRegimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRegimen.Location = new System.Drawing.Point(308, 102);
            this.lblTipoRegimen.Name = "lblTipoRegimen";
            this.lblTipoRegimen.Size = new System.Drawing.Size(106, 13);
            this.lblTipoRegimen.TabIndex = 7;
            this.lblTipoRegimen.Text = "Tipo de regimen: ";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(191, 70);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(87, 13);
            this.lblFechaHasta.TabIndex = 5;
            this.lblFechaHasta.Text = "Fecha Hasta: ";
            this.lblFechaHasta.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(14, 70);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(90, 13);
            this.lblFechaDesde.TabIndex = 3;
            this.lblFechaDesde.Text = "Fecha Desde: ";
            // 
            // btnBuscarHabitaciones
            // 
            this.btnBuscarHabitaciones.Location = new System.Drawing.Point(246, 25);
            this.btnBuscarHabitaciones.Name = "btnBuscarHabitaciones";
            this.btnBuscarHabitaciones.Size = new System.Drawing.Size(80, 38);
            this.btnBuscarHabitaciones.TabIndex = 2;
            this.btnBuscarHabitaciones.Text = "Buscar habitaciones";
            this.btnBuscarHabitaciones.UseVisualStyleBackColor = true;
            this.btnBuscarHabitaciones.Click += new System.EventHandler(this.btnBuscarHabitaciones_Click);
            // 
            // txtNrosHabitaciones
            // 
            this.txtNrosHabitaciones.Enabled = false;
            this.txtNrosHabitaciones.Location = new System.Drawing.Point(133, 30);
            this.txtNrosHabitaciones.Name = "txtNrosHabitaciones";
            this.txtNrosHabitaciones.Size = new System.Drawing.Size(91, 20);
            this.txtNrosHabitaciones.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Habitaciones: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.txtNroDocumento);
            this.groupBox2.Controls.Add(this.cmbTiposDocumentos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbEmail);
            this.groupBox2.Controls.Add(this.lblNroDoc);
            this.groupBox2.Location = new System.Drawing.Point(11, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 155);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(127, 116);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(112, 20);
            this.txtMail.TabIndex = 14;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(127, 71);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(112, 20);
            this.txtNroDocumento.TabIndex = 13;
            // 
            // cmbTiposDocumentos
            // 
            this.cmbTiposDocumentos.FormattingEnabled = true;
            this.cmbTiposDocumentos.Location = new System.Drawing.Point(127, 23);
            this.cmbTiposDocumentos.Name = "cmbTiposDocumentos";
            this.cmbTiposDocumentos.Size = new System.Drawing.Size(93, 21);
            this.cmbTiposDocumentos.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email (*)";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(10, 74);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(88, 13);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "Nro Documento: ";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(10, 31);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(86, 13);
            this.lblNroDoc.TabIndex = 9;
            this.lblNroDoc.Text = "Tipo Documento";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(334, 450);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(104, 29);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(444, 450);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 29);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar (-)";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(554, 450);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 29);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar ( x )";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(65, 102);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(213, 22);
            this.lblHotel.TabIndex = 13;
            // 
            // GenerarReservaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 492);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "GenerarReservaPrincipal";
            this.Text = "Generar Reserva";
            this.Load += new System.EventHandler(this.GenerarReservaPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipoRegimen;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnBuscarHabitaciones;
        private System.Windows.Forms.TextBox txtNrosHabitaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.ComboBox cmbTiposDocumentos;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHotel;
    }
}