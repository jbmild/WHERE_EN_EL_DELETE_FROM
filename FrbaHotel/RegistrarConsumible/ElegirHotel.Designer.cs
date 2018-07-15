namespace FrbaHotel.RegistrarConsumible
{
    partial class ElegirHotel
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
            this.labelHabitacion = new System.Windows.Forms.Label();
            this.comboBoxHabitaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHabitacion
            // 
            this.labelHabitacion.AutoSize = true;
            this.labelHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHabitacion.ForeColor = System.Drawing.Color.Red;
            this.labelHabitacion.Location = new System.Drawing.Point(424, 51);
            this.labelHabitacion.Name = "labelHabitacion";
            this.labelHabitacion.Size = new System.Drawing.Size(253, 20);
            this.labelHabitacion.TabIndex = 14;
            this.labelHabitacion.Text = "Debe seleccionar una habitación";
            this.labelHabitacion.Visible = false;
            // 
            // comboBoxHabitaciones
            // 
            this.comboBoxHabitaciones.FormattingEnabled = true;
            this.comboBoxHabitaciones.Location = new System.Drawing.Point(285, 48);
            this.comboBoxHabitaciones.Name = "comboBoxHabitaciones";
            this.comboBoxHabitaciones.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHabitaciones.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Habitación:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Elegir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElegirHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelHabitacion);
            this.Controls.Add(this.comboBoxHabitaciones);
            this.Controls.Add(this.label1);
            this.Name = "ElegirHotel";
            this.Text = "ElegirHotel";
            this.Load += new System.EventHandler(this.ElegirHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHabitacion;
        private System.Windows.Forms.ComboBox comboBoxHabitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}