namespace FrbaHotel.Hoteles
{
    partial class frmHotelesListado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwHoteles = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEstrellas = new System.Windows.Forms.ComboBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoteles)).BeginInit();
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estrellas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "País:";
            // 
            // dgwHoteles
            // 
            this.dgwHoteles.AllowUserToAddRows = false;
            this.dgwHoteles.AllowUserToDeleteRows = false;
            this.dgwHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Eliminar});
            this.dgwHoteles.Location = new System.Drawing.Point(11, 206);
            this.dgwHoteles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwHoteles.Name = "dgwHoteles";
            this.dgwHoteles.RowTemplate.Height = 24;
            this.dgwHoteles.Size = new System.Drawing.Size(1529, 290);
            this.dgwHoteles.TabIndex = 8;
            this.dgwHoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modificar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Modificar";
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modificar.Text = "Modificar";
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Baja";
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Baja";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(776, 168);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 33);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(11, 168);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 33);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 26);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // cmbEstrellas
            // 
            this.cmbEstrellas.FormattingEnabled = true;
            this.cmbEstrellas.Location = new System.Drawing.Point(89, 56);
            this.cmbEstrellas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstrellas.Name = "cmbEstrellas";
            this.cmbEstrellas.Size = new System.Drawing.Size(272, 24);
            this.cmbEstrellas.TabIndex = 12;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(89, 87);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(272, 22);
            this.txtCiudad.TabIndex = 13;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(89, 117);
            this.txtPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(272, 22);
            this.txtPais.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(776, 501);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 16;
            this.button3.Text = "Alta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.label1);
            this.gpbFiltros.Controls.Add(this.label2);
            this.gpbFiltros.Controls.Add(this.txtPais);
            this.gpbFiltros.Controls.Add(this.label3);
            this.gpbFiltros.Controls.Add(this.txtCiudad);
            this.gpbFiltros.Controls.Add(this.label4);
            this.gpbFiltros.Controls.Add(this.cmbEstrellas);
            this.gpbFiltros.Controls.Add(this.txtNombre);
            this.gpbFiltros.Location = new System.Drawing.Point(11, 10);
            this.gpbFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFiltros.Size = new System.Drawing.Size(865, 154);
            this.gpbFiltros.TabIndex = 17;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Filtros";
            // 
            // frmHotelesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1552, 546);
            this.Controls.Add(this.gpbFiltros);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgwHoteles);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHotelesListado";
            this.Text = "Administracion de hoteles";
            this.Load += new System.EventHandler(this.frmHotelesListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHoteles)).EndInit();
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwHoteles;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbEstrellas;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.GroupBox gpbFiltros;
    }
}