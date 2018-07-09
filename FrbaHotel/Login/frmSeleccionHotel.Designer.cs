namespace FrbaHotel.Login
{
    partial class frmSeleccionHotel
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
            this.lblSeleccionHotel = new System.Windows.Forms.Label();
            this.cmbHoteles = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionHotel
            // 
            this.lblSeleccionHotel.AutoSize = true;
            this.lblSeleccionHotel.Location = new System.Drawing.Point(25, 23);
            this.lblSeleccionHotel.Name = "lblSeleccionHotel";
            this.lblSeleccionHotel.Size = new System.Drawing.Size(230, 20);
            this.lblSeleccionHotel.TabIndex = 0;
            this.lblSeleccionHotel.Text = "Seleccion el hotel para ingresar";
            // 
            // cmbHoteles
            // 
            this.cmbHoteles.FormattingEnabled = true;
            this.cmbHoteles.Location = new System.Drawing.Point(261, 20);
            this.cmbHoteles.Name = "cmbHoteles";
            this.cmbHoteles.Size = new System.Drawing.Size(251, 28);
            this.cmbHoteles.TabIndex = 1;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(29, 60);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(483, 43);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmSeleccionHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 131);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.cmbHoteles);
            this.Controls.Add(this.lblSeleccionHotel);
            this.Name = "frmSeleccionHotel";
            this.Text = "Seleccion de hotel";
            this.Load += new System.EventHandler(this.frmSeleccionHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionHotel;
        private System.Windows.Forms.ComboBox cmbHoteles;
        private System.Windows.Forms.Button btnContinuar;
    }
}