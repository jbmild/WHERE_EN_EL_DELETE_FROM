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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxHoteles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPiso = new System.Windows.Forms.ComboBox();
            this.checkBoxVistaExterior = new System.Windows.Forms.CheckBox();
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
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
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de habitación";
            // 
            // comboBoxNumeroHabitacion
            // 
            this.comboBoxNumeroHabitacion.FormattingEnabled = true;
            this.comboBoxNumeroHabitacion.Location = new System.Drawing.Point(253, 99);
            this.comboBoxNumeroHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNumeroHabitacion.Name = "comboBoxNumeroHabitacion";
            this.comboBoxNumeroHabitacion.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNumeroHabitacion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 338);
            this.dataGridView1.TabIndex = 11;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Aquí se mostrará la habitación correspondiente a su búsqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Piso";
            // 
            // comboBoxPiso
            // 
            this.comboBoxPiso.FormattingEnabled = true;
            this.comboBoxPiso.Location = new System.Drawing.Point(252, 60);
            this.comboBoxPiso.Name = "comboBoxPiso";
            this.comboBoxPiso.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPiso.TabIndex = 21;

            this.comboBoxPiso.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPiso_SelectedIndexChanged);
            // 
            // checkBoxVistaExterior
            // 
            this.checkBoxVistaExterior.AutoSize = true;
            this.checkBoxVistaExterior.Location = new System.Drawing.Point(44, 185);
            this.checkBoxVistaExterior.Name = "checkBoxVistaExterior";
            this.checkBoxVistaExterior.Size = new System.Drawing.Size(165, 21);
            this.checkBoxVistaExterior.TabIndex = 22;
            this.checkBoxVistaExterior.Text = "Tiene vista al exterior";
            this.checkBoxVistaExterior.UseVisualStyleBackColor = true;
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Location = new System.Drawing.Point(44, 226);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(123, 21);
            this.checkBoxHabilitado.TabIndex = 23;
            this.checkBoxHabilitado.Text = "Está habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // modificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 514);
            this.Controls.Add(this.checkBoxHabilitado);
            this.Controls.Add(this.checkBoxVistaExterior);
            this.Controls.Add(this.comboBoxPiso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxHoteles);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxHoteles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPiso;
        private System.Windows.Forms.CheckBox checkBoxVistaExterior;
        private System.Windows.Forms.CheckBox checkBoxHabilitado;
    }
}