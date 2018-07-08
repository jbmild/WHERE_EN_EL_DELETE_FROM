namespace FrbaHotel
{
    partial class FuncionesRecepcionista
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnRegistrarEstadia = new System.Windows.Forms.Button();
            this.labelhotel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarEstadia);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(114, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(284, 359);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones con clientes";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(31, 159);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 68);
            this.button6.TabIndex = 7;
            this.button6.Text = "Registrar Consumibles";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(31, 85);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(192, 68);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "Ver Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEstadia
            // 
            this.btnRegistrarEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEstadia.Location = new System.Drawing.Point(31, 235);
            this.btnRegistrarEstadia.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarEstadia.Name = "btnRegistrarEstadia";
            this.btnRegistrarEstadia.Size = new System.Drawing.Size(188, 68);
            this.btnRegistrarEstadia.TabIndex = 12;
            this.btnRegistrarEstadia.Text = "Check-in";
            this.btnRegistrarEstadia.UseVisualStyleBackColor = true;
            this.btnRegistrarEstadia.Visible = false;
            // 
            // labelhotel
            // 
            this.labelhotel.AutoSize = true;
            this.labelhotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhotel.Location = new System.Drawing.Point(73, 25);
            this.labelhotel.Name = "labelhotel";
            this.labelhotel.Size = new System.Drawing.Size(91, 29);
            this.labelhotel.TabIndex = 12;
            this.labelhotel.Text = "{hotel}";
            // 
            // FuncionesRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 487);
            this.Controls.Add(this.labelhotel);
            this.Controls.Add(this.groupBox1);
            this.Name = "FuncionesRecepcionista";
            this.Text = "FuncionesRecepcionista";
            this.Load += new System.EventHandler(this.FuncionesRecepcionista_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnRegistrarEstadia;
        private System.Windows.Forms.Label labelhotel;
    }
}