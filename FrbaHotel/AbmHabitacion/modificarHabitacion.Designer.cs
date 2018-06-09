namespace FrbaHotel.AbmHabitacion
{
    partial class modificarHabitacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNumeroHabitacion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHotelNuevo = new System.Windows.Forms.Label();
            this.comboBoxNuevoHotel = new System.Windows.Forms.ComboBox();
            this.labelPisoNuevo = new System.Windows.Forms.Label();
            this.comboBoxNuevoPiso = new System.Windows.Forms.ComboBox();
            this.labelDescripcionNueva = new System.Windows.Forms.Label();
            this.textBoxNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxHoteles = new System.Windows.Forms.ComboBox();
            this.checkBoxTieneVistaExterior = new System.Windows.Forms.CheckBox();
            this.checkBoxEstaHabilitado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNuevosCambios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de habitación";
            // 
            // comboBoxNumeroHabitacion
            // 
            this.comboBoxNumeroHabitacion.FormattingEnabled = true;
            this.comboBoxNumeroHabitacion.Location = new System.Drawing.Point(251, 53);
            this.comboBoxNumeroHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNumeroHabitacion.Name = "comboBoxNumeroHabitacion";
            this.comboBoxNumeroHabitacion.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNumeroHabitacion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHotelNuevo
            // 
            this.labelHotelNuevo.AutoSize = true;
            this.labelHotelNuevo.Location = new System.Drawing.Point(478, 211);
            this.labelHotelNuevo.Name = "labelHotelNuevo";
            this.labelHotelNuevo.Size = new System.Drawing.Size(41, 17);
            this.labelHotelNuevo.TabIndex = 5;
            this.labelHotelNuevo.Text = "Hotel";
            this.labelHotelNuevo.Visible = false;
            // 
            // comboBoxNuevoHotel
            // 
            this.comboBoxNuevoHotel.FormattingEnabled = true;
            this.comboBoxNuevoHotel.Location = new System.Drawing.Point(560, 209);
            this.comboBoxNuevoHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNuevoHotel.Name = "comboBoxNuevoHotel";
            this.comboBoxNuevoHotel.Size = new System.Drawing.Size(232, 24);
            this.comboBoxNuevoHotel.TabIndex = 6;
            this.comboBoxNuevoHotel.Visible = false;
            this.comboBoxNuevoHotel.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNuevoHotel_SelectedIndexChanged);
            // 
            // labelPisoNuevo
            // 
            this.labelPisoNuevo.AutoSize = true;
            this.labelPisoNuevo.Location = new System.Drawing.Point(478, 257);
            this.labelPisoNuevo.Name = "labelPisoNuevo";
            this.labelPisoNuevo.Size = new System.Drawing.Size(105, 17);
            this.labelPisoNuevo.TabIndex = 7;
            this.labelPisoNuevo.Text = "Piso en el hotel";
            this.labelPisoNuevo.Visible = false;
            // 
            // comboBoxNuevoPiso
            // 
            this.comboBoxNuevoPiso.FormattingEnabled = true;
            this.comboBoxNuevoPiso.Location = new System.Drawing.Point(672, 257);
            this.comboBoxNuevoPiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNuevoPiso.Name = "comboBoxNuevoPiso";
            this.comboBoxNuevoPiso.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNuevoPiso.TabIndex = 8;
            this.comboBoxNuevoPiso.Visible = false;
            // 
            // labelDescripcionNueva
            // 
            this.labelDescripcionNueva.AutoSize = true;
            this.labelDescripcionNueva.Location = new System.Drawing.Point(480, 312);
            this.labelDescripcionNueva.Name = "labelDescripcionNueva";
            this.labelDescripcionNueva.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcionNueva.TabIndex = 9;
            this.labelDescripcionNueva.Text = "Descripcion";
            this.labelDescripcionNueva.Visible = false;
            // 
            // textBoxNuevaDescripcion
            // 
            this.textBoxNuevaDescripcion.Location = new System.Drawing.Point(593, 312);
            this.textBoxNuevaDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNuevaDescripcion.Multiline = true;
            this.textBoxNuevaDescripcion.Name = "textBoxNuevaDescripcion";
            this.textBoxNuevaDescripcion.Size = new System.Drawing.Size(199, 90);
            this.textBoxNuevaDescripcion.TabIndex = 10;
            this.textBoxNuevaDescripcion.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 80);
            this.dataGridView1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 448);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Guardar cambios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxHoteles
            // 
            this.comboBoxHoteles.FormattingEnabled = true;
            this.comboBoxHoteles.Location = new System.Drawing.Point(144, 23);
            this.comboBoxHoteles.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHoteles.Name = "comboBoxHoteles";
            this.comboBoxHoteles.Size = new System.Drawing.Size(228, 24);
            this.comboBoxHoteles.TabIndex = 13;
            this.comboBoxHoteles.SelectionChangeCommitted += new System.EventHandler(this.comboBoxHoteles_SelectedIndexChanged);
            // 
            // checkBoxTieneVistaExterior
            // 
            this.checkBoxTieneVistaExterior.AutoSize = true;
            this.checkBoxTieneVistaExterior.Location = new System.Drawing.Point(483, 427);
            this.checkBoxTieneVistaExterior.Name = "checkBoxTieneVistaExterior";
            this.checkBoxTieneVistaExterior.Size = new System.Drawing.Size(165, 21);
            this.checkBoxTieneVistaExterior.TabIndex = 14;
            this.checkBoxTieneVistaExterior.Text = "Tiene vista al exterior";
            this.checkBoxTieneVistaExterior.UseVisualStyleBackColor = true;
            this.checkBoxTieneVistaExterior.Visible = false;
            // 
            // checkBoxEstaHabilitado
            // 
            this.checkBoxEstaHabilitado.AutoSize = true;
            this.checkBoxEstaHabilitado.Location = new System.Drawing.Point(483, 463);
            this.checkBoxEstaHabilitado.Name = "checkBoxEstaHabilitado";
            this.checkBoxEstaHabilitado.Size = new System.Drawing.Size(123, 21);
            this.checkBoxEstaHabilitado.TabIndex = 15;
            this.checkBoxEstaHabilitado.Text = "Está habilitado";
            this.checkBoxEstaHabilitado.UseVisualStyleBackColor = true;
            this.checkBoxEstaHabilitado.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Aquí se mostrará la habitación correspondiente a su búsqueda";
            // 
            // labelNuevosCambios
            // 
            this.labelNuevosCambios.AutoSize = true;
            this.labelNuevosCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevosCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNuevosCambios.Location = new System.Drawing.Point(371, 155);
            this.labelNuevosCambios.Name = "labelNuevosCambios";
            this.labelNuevosCambios.Size = new System.Drawing.Size(726, 25);
            this.labelNuevosCambios.TabIndex = 17;
            this.labelNuevosCambios.Text = "A continuación, puede modificar los siguientes datos de la habitación seleccionad" +
    "a";
            this.labelNuevosCambios.Visible = false;
            // 
            // modificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 514);
            this.Controls.Add(this.labelNuevosCambios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxEstaHabilitado);
            this.Controls.Add(this.checkBoxTieneVistaExterior);
            this.Controls.Add(this.comboBoxHoteles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxNuevaDescripcion);
            this.Controls.Add(this.labelDescripcionNueva);
            this.Controls.Add(this.comboBoxNuevoPiso);
            this.Controls.Add(this.labelPisoNuevo);
            this.Controls.Add(this.comboBoxNuevoHotel);
            this.Controls.Add(this.labelHotelNuevo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxNumeroHabitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "modificarHabitacion";
            this.Text = "Modificar habitación";
            this.Load += new System.EventHandler(this.modificarHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNumeroHabitacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHotelNuevo;
        private System.Windows.Forms.ComboBox comboBoxNuevoHotel;
        private System.Windows.Forms.Label labelPisoNuevo;
        private System.Windows.Forms.ComboBox comboBoxNuevoPiso;
        private System.Windows.Forms.Label labelDescripcionNueva;
        private System.Windows.Forms.TextBox textBoxNuevaDescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxHoteles;
        private System.Windows.Forms.CheckBox checkBoxTieneVistaExterior;
        private System.Windows.Forms.CheckBox checkBoxEstaHabilitado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNuevosCambios;
    }
}