namespace FrbaHotel.Reservas
{
    partial class FormSeleccionarHabitaciones
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtpFechaCheckin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCheckout = new System.Windows.Forms.DateTimePicker();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoHab = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgRegimenesHoteles = new System.Windows.Forms.DataGridView();
            this.lblRegimenId = new System.Windows.Forms.Label();
            this.lblPrecioRegimen = new System.Windows.Forms.Label();
            this.lblSubTotalReserva = new System.Windows.Forms.Label();
            this.labelRegimenPendiente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegimenesHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Habitacion";
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
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Los campos con (*) son obligatorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hotel:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(553, 281);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 38);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(503, 608);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(129, 38);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 608);
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
            this.button4.Location = new System.Drawing.Point(16, 281);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 38);
            this.button4.TabIndex = 15;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtpFechaCheckin
            // 
            this.dtpFechaCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCheckin.Location = new System.Drawing.Point(147, 145);
            this.dtpFechaCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCheckin.MinDate = new System.DateTime(2018, 6, 25, 0, 0, 0, 0);
            this.dtpFechaCheckin.Name = "dtpFechaCheckin";
            this.dtpFechaCheckin.Size = new System.Drawing.Size(131, 22);
            this.dtpFechaCheckin.TabIndex = 16;
            this.dtpFechaCheckin.Value = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this.dtpFechaCheckin.ValueChanged += new System.EventHandler(this.dtpFechaCheckin_ValueChanged);
            // 
            // dtpFechaCheckout
            // 
            this.dtpFechaCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCheckout.Location = new System.Drawing.Point(476, 144);
            this.dtpFechaCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCheckout.Name = "dtpFechaCheckout";
            this.dtpFechaCheckout.Size = new System.Drawing.Size(128, 22);
            this.dtpFechaCheckout.TabIndex = 17;
            this.dtpFechaCheckout.Value = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            this.dtpFechaCheckout.ValueChanged += new System.EventHandler(this.dtpFechaCheckout_ValueChanged);
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(88, 177);
            this.cmbHotel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbHotel.Size = new System.Drawing.Size(203, 24);
            this.cmbHotel.TabIndex = 20;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSeleccion});
            this.dataGridView1.Location = new System.Drawing.Point(16, 326);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1167, 236);
            this.dataGridView1.TabIndex = 11;
            // 
            // clnSeleccion
            // 
            this.clnSeleccion.HeaderText = "Seleccionar";
            this.clnSeleccion.Name = "clnSeleccion";
            this.clnSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnSeleccion.Width = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo Habitacion:";
            // 
            // cmbTipoHab
            // 
            this.cmbTipoHab.FormattingEnabled = true;
            this.cmbTipoHab.Location = new System.Drawing.Point(441, 174);
            this.cmbTipoHab.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoHab.Name = "cmbTipoHab";
            this.cmbTipoHab.Size = new System.Drawing.Size(163, 24);
            this.cmbTipoHab.TabIndex = 18;
            this.cmbTipoHab.SelectedIndexChanged += new System.EventHandler(this.cmbTipoHab_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tipo de Regimen: ";
            // 
            // dtgRegimenesHoteles
            // 
            this.dtgRegimenesHoteles.AllowUserToAddRows = false;
            this.dtgRegimenesHoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgRegimenesHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegimenesHoteles.Location = new System.Drawing.Point(781, 145);
            this.dtgRegimenesHoteles.Margin = new System.Windows.Forms.Padding(4);
            this.dtgRegimenesHoteles.Name = "dtgRegimenesHoteles";
            this.dtgRegimenesHoteles.ReadOnly = true;
            this.dtgRegimenesHoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRegimenesHoteles.Size = new System.Drawing.Size(401, 149);
            this.dtgRegimenesHoteles.TabIndex = 23;
            this.dtgRegimenesHoteles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRegimenesHoteles_CellDoubleClick);
            // 
            // lblRegimenId
            // 
            this.lblRegimenId.AutoSize = true;
            this.lblRegimenId.Location = new System.Drawing.Point(683, 178);
            this.lblRegimenId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegimenId.Name = "lblRegimenId";
            this.lblRegimenId.Size = new System.Drawing.Size(0, 17);
            this.lblRegimenId.TabIndex = 24;
            // 
            // lblPrecioRegimen
            // 
            this.lblPrecioRegimen.AutoSize = true;
            this.lblPrecioRegimen.Location = new System.Drawing.Point(671, 219);
            this.lblPrecioRegimen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioRegimen.Name = "lblPrecioRegimen";
            this.lblPrecioRegimen.Size = new System.Drawing.Size(0, 17);
            this.lblPrecioRegimen.TabIndex = 26;
            this.lblPrecioRegimen.Visible = false;
            // 
            // lblSubTotalReserva
            // 
            this.lblSubTotalReserva.AutoSize = true;
            this.lblSubTotalReserva.Location = new System.Drawing.Point(264, 587);
            this.lblSubTotalReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotalReserva.Name = "lblSubTotalReserva";
            this.lblSubTotalReserva.Size = new System.Drawing.Size(0, 17);
            this.lblSubTotalReserva.TabIndex = 28;
            // 
            // labelRegimenPendiente
            // 
            this.labelRegimenPendiente.AutoSize = true;
            this.labelRegimenPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegimenPendiente.Location = new System.Drawing.Point(839, 123);
            this.labelRegimenPendiente.Name = "labelRegimenPendiente";
            this.labelRegimenPendiente.Size = new System.Drawing.Size(261, 18);
            this.labelRegimenPendiente.TabIndex = 29;
            this.labelRegimenPendiente.Text = "Haga doble click para elegir el régimen";
            // 
            // FormSeleccionarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 661);
            this.Controls.Add(this.labelRegimenPendiente);
            this.Controls.Add(this.lblSubTotalReserva);
            this.Controls.Add(this.lblPrecioRegimen);
            this.Controls.Add(this.lblRegimenId);
            this.Controls.Add(this.dtgRegimenesHoteles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHotel);
            this.Controls.Add(this.cmbTipoHab);
            this.Controls.Add(this.dtpFechaCheckout);
            this.Controls.Add(this.dtpFechaCheckin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSeleccionarHabitaciones";
            this.Text = "Buscar Habitación";
            this.Load += new System.EventHandler(this.FormGenerarModificarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegimenesHoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtpFechaCheckin;
        private System.Windows.Forms.DateTimePicker dtpFechaCheckout;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnSeleccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoHab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgRegimenesHoteles;
        private System.Windows.Forms.Label lblRegimenId;
        private System.Windows.Forms.Label lblPrecioRegimen;
        private System.Windows.Forms.Label lblSubTotalReserva;
        private System.Windows.Forms.Label labelRegimenPendiente;
    }
}