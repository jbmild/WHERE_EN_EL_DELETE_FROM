﻿namespace FrbaHotel.AbmHabitacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonExteriorSI = new System.Windows.Forms.RadioButton();
            this.radioButtonExteriorNO = new System.Windows.Forms.RadioButton();
            this.radioButtonExteriorNA = new System.Windows.Forms.RadioButton();
            this.radioButtonHabilitadoNA = new System.Windows.Forms.RadioButton();
            this.radioButtonHabilitadoNO = new System.Windows.Forms.RadioButton();
            this.radioButtonHabilitadoSI = new System.Windows.Forms.RadioButton();
            this.labelExteriorError = new System.Windows.Forms.Label();
            this.labelHabilitadoError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.comboBoxNumeroHabitacion.Enabled = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(561, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 338);
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
            this.label6.Location = new System.Drawing.Point(842, 9);
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
            this.comboBoxPiso.Enabled = false;
            this.comboBoxPiso.FormattingEnabled = true;
            this.comboBoxPiso.Location = new System.Drawing.Point(252, 60);
            this.comboBoxPiso.Name = "comboBoxPiso";
            this.comboBoxPiso.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPiso.TabIndex = 21;
            this.comboBoxPiso.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPiso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "¿Vista al exterior?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "¿Habilitado?";
            // 
            // radioButtonExteriorSI
            // 
            this.radioButtonExteriorSI.AutoSize = true;
            this.radioButtonExteriorSI.Location = new System.Drawing.Point(9, 19);
            this.radioButtonExteriorSI.Name = "radioButtonExteriorSI";
            this.radioButtonExteriorSI.Size = new System.Drawing.Size(41, 21);
            this.radioButtonExteriorSI.TabIndex = 30;
            this.radioButtonExteriorSI.TabStop = true;
            this.radioButtonExteriorSI.Text = "Sí";
            this.radioButtonExteriorSI.UseVisualStyleBackColor = true;
            // 
            // radioButtonExteriorNO
            // 
            this.radioButtonExteriorNO.AutoSize = true;
            this.radioButtonExteriorNO.Location = new System.Drawing.Point(57, 19);
            this.radioButtonExteriorNO.Name = "radioButtonExteriorNO";
            this.radioButtonExteriorNO.Size = new System.Drawing.Size(47, 21);
            this.radioButtonExteriorNO.TabIndex = 31;
            this.radioButtonExteriorNO.TabStop = true;
            this.radioButtonExteriorNO.Text = "No";
            this.radioButtonExteriorNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonExteriorNA
            // 
            this.radioButtonExteriorNA.AutoSize = true;
            this.radioButtonExteriorNA.Location = new System.Drawing.Point(111, 19);
            this.radioButtonExteriorNA.Name = "radioButtonExteriorNA";
            this.radioButtonExteriorNA.Size = new System.Drawing.Size(48, 21);
            this.radioButtonExteriorNA.TabIndex = 32;
            this.radioButtonExteriorNA.TabStop = true;
            this.radioButtonExteriorNA.Text = "NA";
            this.radioButtonExteriorNA.UseVisualStyleBackColor = true;
            // 
            // radioButtonHabilitadoNA
            // 
            this.radioButtonHabilitadoNA.AutoSize = true;
            this.radioButtonHabilitadoNA.Location = new System.Drawing.Point(99, 21);
            this.radioButtonHabilitadoNA.Name = "radioButtonHabilitadoNA";
            this.radioButtonHabilitadoNA.Size = new System.Drawing.Size(48, 21);
            this.radioButtonHabilitadoNA.TabIndex = 35;
            this.radioButtonHabilitadoNA.TabStop = true;
            this.radioButtonHabilitadoNA.Text = "NA";
            this.radioButtonHabilitadoNA.UseVisualStyleBackColor = true;
            // 
            // radioButtonHabilitadoNO
            // 
            this.radioButtonHabilitadoNO.AutoSize = true;
            this.radioButtonHabilitadoNO.Location = new System.Drawing.Point(49, 21);
            this.radioButtonHabilitadoNO.Name = "radioButtonHabilitadoNO";
            this.radioButtonHabilitadoNO.Size = new System.Drawing.Size(47, 21);
            this.radioButtonHabilitadoNO.TabIndex = 34;
            this.radioButtonHabilitadoNO.TabStop = true;
            this.radioButtonHabilitadoNO.Text = "No";
            this.radioButtonHabilitadoNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonHabilitadoSI
            // 
            this.radioButtonHabilitadoSI.AutoSize = true;
            this.radioButtonHabilitadoSI.Location = new System.Drawing.Point(2, 21);
            this.radioButtonHabilitadoSI.Name = "radioButtonHabilitadoSI";
            this.radioButtonHabilitadoSI.Size = new System.Drawing.Size(41, 21);
            this.radioButtonHabilitadoSI.TabIndex = 33;
            this.radioButtonHabilitadoSI.TabStop = true;
            this.radioButtonHabilitadoSI.Text = "Sí";
            this.radioButtonHabilitadoSI.UseVisualStyleBackColor = true;
            // 
            // labelExteriorError
            // 
            this.labelExteriorError.AutoSize = true;
            this.labelExteriorError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExteriorError.ForeColor = System.Drawing.Color.Red;
            this.labelExteriorError.Location = new System.Drawing.Point(327, 181);
            this.labelExteriorError.Name = "labelExteriorError";
            this.labelExteriorError.Size = new System.Drawing.Size(210, 25);
            this.labelExteriorError.TabIndex = 36;
            this.labelExteriorError.Text = "Seleccione una opción";
            this.labelExteriorError.Visible = false;
            // 
            // labelHabilitadoError
            // 
            this.labelHabilitadoError.AutoSize = true;
            this.labelHabilitadoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHabilitadoError.ForeColor = System.Drawing.Color.Red;
            this.labelHabilitadoError.Location = new System.Drawing.Point(327, 212);
            this.labelHabilitadoError.Name = "labelHabilitadoError";
            this.labelHabilitadoError.Size = new System.Drawing.Size(210, 25);
            this.labelHabilitadoError.TabIndex = 37;
            this.labelHabilitadoError.Text = "Seleccione una opción";
            this.labelHabilitadoError.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonExteriorNA);
            this.groupBox1.Controls.Add(this.radioButtonExteriorNO);
            this.groupBox1.Controls.Add(this.radioButtonExteriorSI);
            this.groupBox1.Location = new System.Drawing.Point(140, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 43);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonHabilitadoSI);
            this.groupBox2.Controls.Add(this.radioButtonHabilitadoNO);
            this.groupBox2.Controls.Add(this.radioButtonHabilitadoNA);
            this.groupBox2.Location = new System.Drawing.Point(149, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 48);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // modificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHabilitadoError);
            this.Controls.Add(this.labelExteriorError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonHabilitadoNA;
        private System.Windows.Forms.RadioButton radioButtonHabilitadoNO;
        private System.Windows.Forms.RadioButton radioButtonHabilitadoSI;
        private System.Windows.Forms.RadioButton radioButtonExteriorNA;
        private System.Windows.Forms.RadioButton radioButtonExteriorNO;
        private System.Windows.Forms.RadioButton radioButtonExteriorSI;
        private System.Windows.Forms.Label labelExteriorError;
        private System.Windows.Forms.Label labelHabilitadoError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}