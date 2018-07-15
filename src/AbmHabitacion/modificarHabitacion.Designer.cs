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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonExteriorSI = new System.Windows.Forms.RadioButton();
            this.radioButtonExteriorNO = new System.Windows.Forms.RadioButton();
            this.radioButtonExteriorNA = new System.Windows.Forms.RadioButton();
            this.radioButtonHabilitadoNA = new System.Windows.Forms.RadioButton();
            this.radioButtonHabilitadoNO = new System.Windows.Forms.RadioButton();
            this.radioButtonHabilitadoSI = new System.Windows.Forms.RadioButton();
            this.labelHabilitadoError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelhotelnombre = new System.Windows.Forms.Label();
            this.labelExteriorError = new System.Windows.Forms.Label();
            this.numPiso = new System.Windows.Forms.NumericUpDown();
            this.numNumHabitacion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de habitación";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1311, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(50, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1476, 422);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Modificar";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "Seleccionar";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Dar de baja";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Piso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "¿Vista al exterior?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "¿Habilitado?";
            // 
            // radioButtonExteriorSI
            // 
            this.radioButtonExteriorSI.AutoSize = true;
            this.radioButtonExteriorSI.Location = new System.Drawing.Point(165, 20);
            this.radioButtonExteriorSI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonExteriorSI.Name = "radioButtonExteriorSI";
            this.radioButtonExteriorSI.Size = new System.Drawing.Size(48, 24);
            this.radioButtonExteriorSI.TabIndex = 30;
            this.radioButtonExteriorSI.TabStop = true;
            this.radioButtonExteriorSI.Text = "Sí";
            this.radioButtonExteriorSI.UseVisualStyleBackColor = true;
            // 
            // radioButtonExteriorNO
            // 
            this.radioButtonExteriorNO.AutoSize = true;
            this.radioButtonExteriorNO.Location = new System.Drawing.Point(217, 20);
            this.radioButtonExteriorNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonExteriorNO.Name = "radioButtonExteriorNO";
            this.radioButtonExteriorNO.Size = new System.Drawing.Size(54, 24);
            this.radioButtonExteriorNO.TabIndex = 31;
            this.radioButtonExteriorNO.TabStop = true;
            this.radioButtonExteriorNO.Text = "No";
            this.radioButtonExteriorNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonExteriorNA
            // 
            this.radioButtonExteriorNA.AutoSize = true;
            this.radioButtonExteriorNA.Location = new System.Drawing.Point(287, 20);
            this.radioButtonExteriorNA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonExteriorNA.Name = "radioButtonExteriorNA";
            this.radioButtonExteriorNA.Size = new System.Drawing.Size(56, 24);
            this.radioButtonExteriorNA.TabIndex = 32;
            this.radioButtonExteriorNA.TabStop = true;
            this.radioButtonExteriorNA.Text = "NA";
            this.radioButtonExteriorNA.UseVisualStyleBackColor = true;
            // 
            // radioButtonHabilitadoNA
            // 
            this.radioButtonHabilitadoNA.AutoSize = true;
            this.radioButtonHabilitadoNA.Location = new System.Drawing.Point(287, 20);
            this.radioButtonHabilitadoNA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHabilitadoNA.Name = "radioButtonHabilitadoNA";
            this.radioButtonHabilitadoNA.Size = new System.Drawing.Size(56, 24);
            this.radioButtonHabilitadoNA.TabIndex = 35;
            this.radioButtonHabilitadoNA.TabStop = true;
            this.radioButtonHabilitadoNA.Text = "NA";
            this.radioButtonHabilitadoNA.UseVisualStyleBackColor = true;
            // 
            // radioButtonHabilitadoNO
            // 
            this.radioButtonHabilitadoNO.AutoSize = true;
            this.radioButtonHabilitadoNO.Location = new System.Drawing.Point(222, 21);
            this.radioButtonHabilitadoNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHabilitadoNO.Name = "radioButtonHabilitadoNO";
            this.radioButtonHabilitadoNO.Size = new System.Drawing.Size(54, 24);
            this.radioButtonHabilitadoNO.TabIndex = 34;
            this.radioButtonHabilitadoNO.TabStop = true;
            this.radioButtonHabilitadoNO.Text = "No";
            this.radioButtonHabilitadoNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonHabilitadoSI
            // 
            this.radioButtonHabilitadoSI.AutoSize = true;
            this.radioButtonHabilitadoSI.Location = new System.Drawing.Point(163, 20);
            this.radioButtonHabilitadoSI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHabilitadoSI.Name = "radioButtonHabilitadoSI";
            this.radioButtonHabilitadoSI.Size = new System.Drawing.Size(48, 24);
            this.radioButtonHabilitadoSI.TabIndex = 33;
            this.radioButtonHabilitadoSI.TabStop = true;
            this.radioButtonHabilitadoSI.Text = "Sí";
            this.radioButtonHabilitadoSI.UseVisualStyleBackColor = true;
            // 
            // labelHabilitadoError
            // 
            this.labelHabilitadoError.AutoSize = true;
            this.labelHabilitadoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHabilitadoError.ForeColor = System.Drawing.Color.Red;
            this.labelHabilitadoError.Location = new System.Drawing.Point(1104, 24);
            this.labelHabilitadoError.Name = "labelHabilitadoError";
            this.labelHabilitadoError.Size = new System.Drawing.Size(212, 22);
            this.labelHabilitadoError.TabIndex = 37;
            this.labelHabilitadoError.Text = "Seleccione una opción";
            this.labelHabilitadoError.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.radioButtonExteriorNA);
            this.groupBox1.Controls.Add(this.radioButtonExteriorNO);
            this.groupBox1.Controls.Add(this.radioButtonExteriorSI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(667, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(348, 54);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonHabilitadoSI);
            this.groupBox2.Controls.Add(this.radioButtonHabilitadoNO);
            this.groupBox2.Controls.Add(this.radioButtonHabilitadoNA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(668, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(348, 61);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1167, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 46);
            this.button2.TabIndex = 40;
            this.button2.Text = "Limpiar campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1491, 62);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 48);
            this.button3.TabIndex = 42;
            this.button3.Text = "Dar de alta habitación";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelhotelnombre
            // 
            this.labelhotelnombre.AutoSize = true;
            this.labelhotelnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhotelnombre.Location = new System.Drawing.Point(173, 26);
            this.labelhotelnombre.Name = "labelhotelnombre";
            this.labelhotelnombre.Size = new System.Drawing.Size(80, 25);
            this.labelhotelnombre.TabIndex = 43;
            this.labelhotelnombre.Text = "{hotel}";
            // 
            // labelExteriorError
            // 
            this.labelExteriorError.AutoSize = true;
            this.labelExteriorError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExteriorError.ForeColor = System.Drawing.Color.Red;
            this.labelExteriorError.Location = new System.Drawing.Point(1094, 24);
            this.labelExteriorError.Name = "labelExteriorError";
            this.labelExteriorError.Size = new System.Drawing.Size(212, 22);
            this.labelExteriorError.TabIndex = 36;
            this.labelExteriorError.Text = "Seleccione una opción";
            this.labelExteriorError.Visible = false;
            // 
            // numPiso
            // 
            this.numPiso.Location = new System.Drawing.Point(259, 76);
            this.numPiso.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numPiso.Name = "numPiso";
            this.numPiso.Size = new System.Drawing.Size(120, 26);
            this.numPiso.TabIndex = 44;
            // 
            // numNumHabitacion
            // 
            this.numNumHabitacion.Location = new System.Drawing.Point(259, 120);
            this.numNumHabitacion.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numNumHabitacion.Name = "numNumHabitacion";
            this.numNumHabitacion.Size = new System.Drawing.Size(120, 26);
            this.numNumHabitacion.TabIndex = 45;
            // 
            // modificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1542, 642);
            this.Controls.Add(this.numNumHabitacion);
            this.Controls.Add(this.numPiso);
            this.Controls.Add(this.labelhotelnombre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHabilitadoError);
            this.Controls.Add(this.labelExteriorError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonHabilitadoNA;
        private System.Windows.Forms.RadioButton radioButtonHabilitadoNO;
        private System.Windows.Forms.RadioButton radioButtonHabilitadoSI;
        private System.Windows.Forms.RadioButton radioButtonExteriorNA;
        private System.Windows.Forms.RadioButton radioButtonExteriorNO;
        private System.Windows.Forms.RadioButton radioButtonExteriorSI;
        private System.Windows.Forms.Label labelHabilitadoError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelhotelnombre;
        private System.Windows.Forms.Label labelExteriorError;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.NumericUpDown numPiso;
        private System.Windows.Forms.NumericUpDown numNumHabitacion;
    }
}