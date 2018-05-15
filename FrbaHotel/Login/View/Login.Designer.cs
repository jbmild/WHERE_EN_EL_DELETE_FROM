namespace FrbaHotel.Login
{
    partial class SeleccionUsuario
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
            this.btnPersonalHotelLogin = new System.Windows.Forms.Button();
            this.btnClienteLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonalHotelLogin
            // 
            this.btnPersonalHotelLogin.Location = new System.Drawing.Point(148, 106);
            this.btnPersonalHotelLogin.Name = "btnPersonalHotelLogin";
            this.btnPersonalHotelLogin.Size = new System.Drawing.Size(164, 46);
            this.btnPersonalHotelLogin.TabIndex = 0;
            this.btnPersonalHotelLogin.Text = "Personal del hotel";
            this.btnPersonalHotelLogin.UseVisualStyleBackColor = true;
            this.btnPersonalHotelLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClienteLogin
            // 
            this.btnClienteLogin.Location = new System.Drawing.Point(148, 174);
            this.btnClienteLogin.Name = "btnClienteLogin";
            this.btnClienteLogin.Size = new System.Drawing.Size(164, 47);
            this.btnClienteLogin.TabIndex = 1;
            this.btnClienteLogin.Text = "Cliente";
            this.btnClienteLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para continuar, elija su tipo de usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SeleccionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClienteLogin);
            this.Controls.Add(this.btnPersonalHotelLogin);
            this.Name = "SeleccionUsuario";
            this.Text = "Selección de usuario";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonalHotelLogin;
        private System.Windows.Forms.Button btnClienteLogin;
        private System.Windows.Forms.Label label1;
    }
}