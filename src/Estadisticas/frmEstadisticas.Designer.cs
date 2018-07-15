namespace FrbaHotel.Estadisticas
{
    partial class frmEstadisticas
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
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.dgvEstadistica = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.numAnio);
            this.gpbFiltros.Controls.Add(this.cmbTrimestre);
            this.gpbFiltros.Controls.Add(this.cmbTipo);
            this.gpbFiltros.Controls.Add(this.lblTipo);
            this.gpbFiltros.Controls.Add(this.lblTrimestre);
            this.gpbFiltros.Controls.Add(this.lblAnio);
            this.gpbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(791, 152);
            this.gpbFiltros.TabIndex = 0;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Filtros";
            // 
            // numAnio
            // 
            this.numAnio.Location = new System.Drawing.Point(140, 33);
            this.numAnio.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numAnio.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numAnio.Name = "numAnio";
            this.numAnio.Size = new System.Drawing.Size(616, 26);
            this.numAnio.TabIndex = 7;
            this.numAnio.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Location = new System.Drawing.Point(140, 71);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(616, 28);
            this.cmbTrimestre.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(140, 110);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(616, 28);
            this.cmbTipo.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(19, 113);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(115, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de listado:";
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(19, 74);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(79, 20);
            this.lblTrimestre.TabIndex = 1;
            this.lblTrimestre.Text = "Trimestre:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(19, 35);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(42, 20);
            this.lblAnio.TabIndex = 0;
            this.lblAnio.Text = "Año:";
            // 
            // dgvEstadistica
            // 
            this.dgvEstadistica.AllowUserToAddRows = false;
            this.dgvEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadistica.Location = new System.Drawing.Point(12, 214);
            this.dgvEstadistica.Name = "dgvEstadistica";
            this.dgvEstadistica.RowTemplate.Height = 28;
            this.dgvEstadistica.Size = new System.Drawing.Size(791, 399);
            this.dgvEstadistica.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(681, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 170);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 38);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 625);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvEstadistica);
            this.Controls.Add(this.gpbFiltros);
            this.Name = "frmEstadisticas";
            this.Text = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.DataGridView dgvEstadistica;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NumericUpDown numAnio;
    }
}