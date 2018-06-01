namespace FrbaHotel.AbmHabitacion
{
    partial class abmHabitacion
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
            this.btnAltaHabitacion = new System.Windows.Forms.Button();
            this.btnBajaHabitacion = new System.Windows.Forms.Button();
            this.btnModificacionHabitacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaHabitacion
            // 
            this.btnAltaHabitacion.Location = new System.Drawing.Point(61, 197);
            this.btnAltaHabitacion.Name = "btnAltaHabitacion";
            this.btnAltaHabitacion.Size = new System.Drawing.Size(131, 63);
            this.btnAltaHabitacion.TabIndex = 0;
            this.btnAltaHabitacion.Text = "Alta Habitación";
            this.btnAltaHabitacion.UseVisualStyleBackColor = true;
            this.btnAltaHabitacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBajaHabitacion
            // 
            this.btnBajaHabitacion.Location = new System.Drawing.Point(232, 197);
            this.btnBajaHabitacion.Name = "btnBajaHabitacion";
            this.btnBajaHabitacion.Size = new System.Drawing.Size(127, 63);
            this.btnBajaHabitacion.TabIndex = 1;
            this.btnBajaHabitacion.Text = "Baja Habitación";
            this.btnBajaHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnModificacionHabitacion
            // 
            this.btnModificacionHabitacion.Location = new System.Drawing.Point(410, 197);
            this.btnModificacionHabitacion.Name = "btnModificacionHabitacion";
            this.btnModificacionHabitacion.Size = new System.Drawing.Size(133, 63);
            this.btnModificacionHabitacion.TabIndex = 2;
            this.btnModificacionHabitacion.Text = "Modificación Habitación";
            this.btnModificacionHabitacion.UseVisualStyleBackColor = true;
            this.btnModificacionHabitacion.Click += new System.EventHandler(this.btnModificacionHabitacion_Click);
            // 
            // abmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 339);
            this.Controls.Add(this.btnModificacionHabitacion);
            this.Controls.Add(this.btnBajaHabitacion);
            this.Controls.Add(this.btnAltaHabitacion);
            this.Name = "abmHabitacion";
            this.Text = "ABM Habitacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaHabitacion;
        private System.Windows.Forms.Button btnBajaHabitacion;
        private System.Windows.Forms.Button btnModificacionHabitacion;

    }
}