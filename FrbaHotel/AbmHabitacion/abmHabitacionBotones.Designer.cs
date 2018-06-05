namespace FrbaHotel.AbmHabitacion
{
    partial class abmHabitacionBotones
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
            this.btnEditarHabitacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaHabitacion
            // 
            this.btnAltaHabitacion.Location = new System.Drawing.Point(47, 154);
            this.btnAltaHabitacion.Name = "btnAltaHabitacion";
            this.btnAltaHabitacion.Size = new System.Drawing.Size(115, 53);
            this.btnAltaHabitacion.TabIndex = 0;
            this.btnAltaHabitacion.Text = "Dar alta habitación";
            this.btnAltaHabitacion.UseVisualStyleBackColor = true;
            this.btnAltaHabitacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBajaHabitacion
            // 
            this.btnBajaHabitacion.Location = new System.Drawing.Point(181, 154);
            this.btnBajaHabitacion.Name = "btnBajaHabitacion";
            this.btnBajaHabitacion.Size = new System.Drawing.Size(115, 53);
            this.btnBajaHabitacion.TabIndex = 1;
            this.btnBajaHabitacion.Text = "Dar baja habitación";
            this.btnBajaHabitacion.UseVisualStyleBackColor = true;
            this.btnBajaHabitacion.Click += new System.EventHandler(this.btnBajaHabitacion_Click);
            // 
            // btnEditarHabitacion
            // 
            this.btnEditarHabitacion.Location = new System.Drawing.Point(317, 154);
            this.btnEditarHabitacion.Name = "btnEditarHabitacion";
            this.btnEditarHabitacion.Size = new System.Drawing.Size(115, 53);
            this.btnEditarHabitacion.TabIndex = 2;
            this.btnEditarHabitacion.Text = "Editar habitación";
            this.btnEditarHabitacion.UseVisualStyleBackColor = true;
            this.btnEditarHabitacion.Click += new System.EventHandler(this.btnEditarHabitacion_Click);
            // 
            // abmHabitacionBotones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 253);
            this.Controls.Add(this.btnEditarHabitacion);
            this.Controls.Add(this.btnBajaHabitacion);
            this.Controls.Add(this.btnAltaHabitacion);
            this.Name = "abmHabitacionBotones";
            this.Text = "Selección acción Habitación";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaHabitacion;
        private System.Windows.Forms.Button btnBajaHabitacion;
        private System.Windows.Forms.Button btnEditarHabitacion;
    }
}