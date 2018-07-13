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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxHabitaciones = new System.Windows.Forms.ComboBox();
            this.comboBoxConsumible = new System.Windows.Forms.ComboBox();
            this.labelPrecioSugerido = new System.Windows.Forms.Label();
            this.textBoxPrecioSugerido = new System.Windows.Forms.TextBox();
            this.checkBoxMantenerPrecioSugerido = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelHabitacion = new System.Windows.Forms.Label();
            this.labelConsumible = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Habitación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio sugerido: USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio final: USD";
            // 
            // comboBoxHabitaciones
            // 
            this.comboBoxHabitaciones.FormattingEnabled = true;
            this.comboBoxHabitaciones.Location = new System.Drawing.Point(248, 118);
            this.comboBoxHabitaciones.Name = "comboBoxHabitaciones";
            this.comboBoxHabitaciones.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHabitaciones.TabIndex = 4;
            // 
            // comboBoxConsumible
            // 
            this.comboBoxConsumible.FormattingEnabled = true;
            this.comboBoxConsumible.Location = new System.Drawing.Point(248, 161);
            this.comboBoxConsumible.Name = "comboBoxConsumible";
            this.comboBoxConsumible.Size = new System.Drawing.Size(121, 24);
            this.comboBoxConsumible.TabIndex = 5;
            this.comboBoxConsumible.SelectionChangeCommitted += new System.EventHandler(this.comboBoxConsumible_SelectionChangeCommitted);
            // 
            // labelPrecioSugerido
            // 
            this.labelPrecioSugerido.AutoSize = true;
            this.labelPrecioSugerido.Location = new System.Drawing.Point(303, 208);
            this.labelPrecioSugerido.Name = "labelPrecioSugerido";
            this.labelPrecioSugerido.Size = new System.Drawing.Size(114, 17);
            this.labelPrecioSugerido.TabIndex = 6;
            this.labelPrecioSugerido.Text = "{precioSugerido}";
            // 
            // textBoxPrecioSugerido
            // 
            this.textBoxPrecioSugerido.Location = new System.Drawing.Point(274, 285);
            this.textBoxPrecioSugerido.Name = "textBoxPrecioSugerido";
            this.textBoxPrecioSugerido.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecioSugerido.TabIndex = 7;
            // 
            // checkBoxMantenerPrecioSugerido
            // 
            this.checkBoxMantenerPrecioSugerido.AutoSize = true;
            this.checkBoxMantenerPrecioSugerido.Location = new System.Drawing.Point(197, 246);
            this.checkBoxMantenerPrecioSugerido.Name = "checkBoxMantenerPrecioSugerido";
            this.checkBoxMantenerPrecioSugerido.Size = new System.Drawing.Size(192, 21);
            this.checkBoxMantenerPrecioSugerido.TabIndex = 8;
            this.checkBoxMantenerPrecioSugerido.Text = "Mantener precio sugerido";
            this.checkBoxMantenerPrecioSugerido.UseVisualStyleBackColor = true;
            this.checkBoxMantenerPrecioSugerido.CheckedChanged += new System.EventHandler(this.checkBoxMantenerPrecioSugerido_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(832, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpiar campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelHabitacion
            // 
            this.labelHabitacion.AutoSize = true;
            this.labelHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHabitacion.ForeColor = System.Drawing.Color.Red;
            this.labelHabitacion.Location = new System.Drawing.Point(387, 121);
            this.labelHabitacion.Name = "labelHabitacion";
            this.labelHabitacion.Size = new System.Drawing.Size(253, 20);
            this.labelHabitacion.TabIndex = 11;
            this.labelHabitacion.Text = "Debe seleccionar una habitación";
            this.labelHabitacion.Visible = false;
            // 
            // labelConsumible
            // 
            this.labelConsumible.AutoSize = true;
            this.labelConsumible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsumible.ForeColor = System.Drawing.Color.Red;
            this.labelConsumible.Location = new System.Drawing.Point(387, 161);
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
            this.labelPrecio.Location = new System.Drawing.Point(404, 267);
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
            this.labelHotel.Location = new System.Drawing.Point(375, 40);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(75, 25);
            this.labelHotel.TabIndex = 14;
            this.labelHotel.Text = "{hotel}";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(274, 322);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 22);
            this.textBoxCantidad.TabIndex = 16;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 325);
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
            this.labelCantidad.Location = new System.Drawing.Point(404, 322);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(152, 20);
            this.labelCantidad.TabIndex = 17;
            this.labelCantidad.Text = "Cantidad pendiente";
            this.labelCantidad.Visible = false;
            // 
            // registrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 507);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelConsumible);
            this.Controls.Add(this.labelHabitacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxMantenerPrecioSugerido);
            this.Controls.Add(this.textBoxPrecioSugerido);
            this.Controls.Add(this.labelPrecioSugerido);
            this.Controls.Add(this.comboBoxConsumible);
            this.Controls.Add(this.comboBoxHabitaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registrarConsumible";
            this.Text = "Registrar consumible";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxHabitaciones;
        private System.Windows.Forms.ComboBox comboBoxConsumible;
        private System.Windows.Forms.Label labelPrecioSugerido;
        private System.Windows.Forms.TextBox textBoxPrecioSugerido;
        private System.Windows.Forms.CheckBox checkBoxMantenerPrecioSugerido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelHabitacion;
        private System.Windows.Forms.Label labelConsumible;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCantidad;
    }
}