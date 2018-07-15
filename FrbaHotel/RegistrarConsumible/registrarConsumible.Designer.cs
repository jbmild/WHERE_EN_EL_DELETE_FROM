namespace FrbaHotel.RegistrarConsumible
{
    partial class registrarConsumible
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxConsumible = new System.Windows.Forms.ComboBox();
            this.labelPrecioSugerido = new System.Windows.Forms.Label();
            this.textBoxPrecioSugerido = new System.Windows.Forms.TextBox();
            this.checkBoxMantenerPrecioSugerido = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelConsumible = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio sugerido: USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio final: USD";
            // 
            // comboBoxConsumible
            // 
            this.comboBoxConsumible.FormattingEnabled = true;
            this.comboBoxConsumible.Location = new System.Drawing.Point(123, 60);
            this.comboBoxConsumible.Name = "comboBoxConsumible";
            this.comboBoxConsumible.Size = new System.Drawing.Size(121, 24);
            this.comboBoxConsumible.TabIndex = 5;
            this.comboBoxConsumible.SelectionChangeCommitted += new System.EventHandler(this.comboBoxConsumible_SelectionChangeCommitted);
            // 
            // labelPrecioSugerido
            // 
            this.labelPrecioSugerido.AutoSize = true;
            this.labelPrecioSugerido.Location = new System.Drawing.Point(178, 107);
            this.labelPrecioSugerido.Name = "labelPrecioSugerido";
            this.labelPrecioSugerido.Size = new System.Drawing.Size(114, 17);
            this.labelPrecioSugerido.TabIndex = 6;
            this.labelPrecioSugerido.Text = "{precioSugerido}";
            // 
            // textBoxPrecioSugerido
            // 
            this.textBoxPrecioSugerido.Location = new System.Drawing.Point(149, 184);
            this.textBoxPrecioSugerido.Name = "textBoxPrecioSugerido";
            this.textBoxPrecioSugerido.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecioSugerido.TabIndex = 7;
            // 
            // checkBoxMantenerPrecioSugerido
            // 
            this.checkBoxMantenerPrecioSugerido.AutoSize = true;
            this.checkBoxMantenerPrecioSugerido.Location = new System.Drawing.Point(72, 145);
            this.checkBoxMantenerPrecioSugerido.Name = "checkBoxMantenerPrecioSugerido";
            this.checkBoxMantenerPrecioSugerido.Size = new System.Drawing.Size(192, 21);
            this.checkBoxMantenerPrecioSugerido.TabIndex = 8;
            this.checkBoxMantenerPrecioSugerido.Text = "Mantener precio sugerido";
            this.checkBoxMantenerPrecioSugerido.UseVisualStyleBackColor = true;
            this.checkBoxMantenerPrecioSugerido.CheckedChanged += new System.EventHandler(this.checkBoxMantenerPrecioSugerido_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(808, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(960, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpiar campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelConsumible
            // 
            this.labelConsumible.AutoSize = true;
            this.labelConsumible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsumible.ForeColor = System.Drawing.Color.Red;
            this.labelConsumible.Location = new System.Drawing.Point(262, 60);
            this.labelConsumible.Name = "labelConsumible";
            this.labelConsumible.Size = new System.Drawing.Size(253, 20);
            this.labelConsumible.TabIndex = 12;
            this.labelConsumible.Text = "Debe seleccionar un consumible";
            this.labelConsumible.Visible = false;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.Red;
            this.labelPrecio.Location = new System.Drawing.Point(279, 166);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(170, 20);
            this.labelPrecio.TabIndex = 13;
            this.labelPrecio.Text = "Precio final pendiente";
            this.labelPrecio.Visible = false;
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotel.Location = new System.Drawing.Point(496, 9);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(75, 25);
            this.labelHotel.TabIndex = 14;
            this.labelHotel.Text = "{hotel}";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(149, 221);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 22);
            this.textBoxCantidad.TabIndex = 16;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.Red;
            this.labelCantidad.Location = new System.Drawing.Point(279, 221);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(152, 20);
            this.labelCantidad.TabIndex = 17;
            this.labelCantidad.Text = "Cantidad pendiente";
            this.labelCantidad.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 55);
            this.button3.TabIndex = 18;
            this.button3.Text = "Agregar consumible";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(560, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(441, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 20;
            // 
            // registrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelConsumible);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxMantenerPrecioSugerido);
            this.Controls.Add(this.textBoxPrecioSugerido);
            this.Controls.Add(this.labelPrecioSugerido);
            this.Controls.Add(this.comboBoxConsumible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "registrarConsumible";
            this.Text = "Registrar consumible";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxConsumible;
        private System.Windows.Forms.Label labelPrecioSugerido;
        private System.Windows.Forms.TextBox textBoxPrecioSugerido;
        private System.Windows.Forms.CheckBox checkBoxMantenerPrecioSugerido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelConsumible;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}