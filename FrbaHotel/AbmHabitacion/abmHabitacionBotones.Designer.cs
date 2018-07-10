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
            this.btnAltaHabitacion.Location = new System.Drawing.Point(35, 125);
            this.btnAltaHabitacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltaHabitacion.Name = "btnAltaHabitacion";
            this.btnAltaHabitacion.Size = new System.Drawing.Size(86, 43);
            this.btnAltaHabitacion.TabIndex = 0;
            this.btnAltaHabitacion.Text = "Dar alta habitación";
            this.btnAltaHabitacion.UseVisualStyleBackColor = true;
            this.btnAltaHabitacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBajaHabitacion
            // 
            this.btnBajaHabitacion.Location = new System.Drawing.Point(136, 125);
            this.btnBajaHabitacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBajaHabitacion.Name = "btnBajaHabitacion";
            this.btnBajaHabitacion.Size = new System.Drawing.Size(86, 43);
            this.btnBajaHabitacion.TabIndex = 1;
            this.btnBajaHabitacion.Text = "Dar baja habitación";
            this.btnBajaHabitacion.UseVisualStyleBackColor = true;
            this.btnBajaHabitacion.Click += new System.EventHandler(this.btnBajaHabitacion_Click);
            // 
            // btnEditarHabitacion
            // 
            this.btnEditarHabitacion.Location = new System.Drawing.Point(238, 125);
            this.btnEditarHabitacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarHabitacion.Name = "btnEditarHabitacion";
            this.btnEditarHabitacion.Size = new System.Drawing.Size(86, 43);
            this.btnEditarHabitacion.TabIndex = 2;
            this.btnEditarHabitacion.Text = "Editar habitación";
            this.btnEditarHabitacion.UseVisualStyleBackColor = true;
            this.btnEditarHabitacion.Click += new System.EventHandler(this.btnEditarHabitacion_Click);
            // 
            // abmHabitacionBotones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 206);
            this.Controls.Add(this.btnEditarHabitacion);
            this.Controls.Add(this.btnBajaHabitacion);
            this.Controls.Add(this.btnAltaHabitacion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "abmHabitacionBotones";
            this.Text = "Selección acción Habitación";
            this.Load += new System.EventHandler(this.abmHabitacionBotones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaHabitacion;
        private System.Windows.Forms.Button btnBajaHabitacion;
        private System.Windows.Forms.Button btnEditarHabitacion;
    }
}