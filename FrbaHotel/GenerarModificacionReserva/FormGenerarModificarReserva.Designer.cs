namespace FrbaHotel.GenerarModificacionReserva
{
    partial class FormGenerarModificarReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtpFechaCheckin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCheckout = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoHab = new System.Windows.Forms.ComboBox();
            this.cmbTipoRegimen = new System.Windows.Forms.ComboBox();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERAR/MODIFICAR RESERVAS";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(16, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(310, 30);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sistema de Gestión Hotelera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Los campos con (*) son obligatorios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro Reserva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "* Fecha checkin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "* Fecha checkout:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo Habitacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hotel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tipo Regimen:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(364, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Resultados del {fechain} al {fechaout} - [Tipo habitacion]";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(503, 260);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 38);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 470);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 470);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(649, 260);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 38);
            this.button4.TabIndex = 15;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dtpFechaCheckin
            // 
            this.dtpFechaCheckin.Location = new System.Drawing.Point(147, 145);
            this.dtpFechaCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCheckin.Name = "dtpFechaCheckin";
            this.dtpFechaCheckin.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaCheckin.TabIndex = 16;
            // 
            // dtpFechaCheckout
            // 
            this.dtpFechaCheckout.Location = new System.Drawing.Point(476, 144);
            this.dtpFechaCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCheckout.Name = "dtpFechaCheckout";
            this.dtpFechaCheckout.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaCheckout.TabIndex = 17;
            // 
            // cmbTipoHab
            // 
            this.cmbTipoHab.FormattingEnabled = true;
            this.cmbTipoHab.Location = new System.Drawing.Point(148, 188);
            this.cmbTipoHab.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoHab.Name = "cmbTipoHab";
            this.cmbTipoHab.Size = new System.Drawing.Size(139, 24);
            this.cmbTipoHab.TabIndex = 18;
            // 
            // cmbTipoRegimen
            // 
            this.cmbTipoRegimen.FormattingEnabled = true;
            this.cmbTipoRegimen.Location = new System.Drawing.Point(148, 224);
            this.cmbTipoRegimen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoRegimen.Name = "cmbTipoRegimen";
            this.cmbTipoRegimen.Size = new System.Drawing.Size(139, 24);
            this.cmbTipoRegimen.TabIndex = 19;
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(479, 187);
            this.cmbHotel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(139, 24);
            this.cmbHotel.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSeleccion});
            this.dataGridView1.Location = new System.Drawing.Point(20, 334);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1798, 137);
            this.dataGridView1.TabIndex = 11;
            // 
            // clnSeleccion
            // 
            this.clnSeleccion.HeaderText = "Seleccionar";
            this.clnSeleccion.Name = "clnSeleccion";
            this.clnSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormGenerarModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 523);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.cmbTipoRegimen);
            this.Controls.Add(this.cmbTipoHab);
            this.Controls.Add(this.dtpFechaCheckout);
            this.Controls.Add(this.dtpFechaCheckin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGenerarModificarReserva";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGenerarModificarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtpFechaCheckin;
        private System.Windows.Forms.DateTimePicker dtpFechaCheckout;
        private System.Windows.Forms.ComboBox cmbTipoHab;
        private System.Windows.Forms.ComboBox cmbTipoRegimen;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnSeleccion;
    }
}