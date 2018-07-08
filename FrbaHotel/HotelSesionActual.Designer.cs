namespace FrbaHotel
{
    partial class HotelSesionActual
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
            this.comboBoxHoteles = new System.Windows.Forms.ComboBox();
            this.buttonElegirHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el hotel para seguir operando:";
            // 
            // comboBoxHoteles
            // 
            this.comboBoxHoteles.FormattingEnabled = true;
            this.comboBoxHoteles.Location = new System.Drawing.Point(303, 28);
            this.comboBoxHoteles.Name = "comboBoxHoteles";
            this.comboBoxHoteles.Size = new System.Drawing.Size(334, 24);
            this.comboBoxHoteles.TabIndex = 1;
            // 
            // buttonElegirHotel
            // 
            this.buttonElegirHotel.Location = new System.Drawing.Point(459, 202);
            this.buttonElegirHotel.Name = "buttonElegirHotel";
            this.buttonElegirHotel.Size = new System.Drawing.Size(166, 52);
            this.buttonElegirHotel.TabIndex = 2;
            this.buttonElegirHotel.Text = "Elegir hotel";
            this.buttonElegirHotel.UseVisualStyleBackColor = true;
            this.buttonElegirHotel.Click += new System.EventHandler(this.buttonElegirHotel_Click);
            // 
            // HotelSesionActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 416);
            this.Controls.Add(this.buttonElegirHotel);
            this.Controls.Add(this.comboBoxHoteles);
            this.Controls.Add(this.label1);
            this.Name = "HotelSesionActual";
            this.Text = "Hotel sesión actual";
            this.Load += new System.EventHandler(this.HotelSesionActual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHoteles;
        private System.Windows.Forms.Button buttonElegirHotel;
    }
}