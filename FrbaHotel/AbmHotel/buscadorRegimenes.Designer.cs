namespace FrbaHotel.AbmHotel
{
    partial class buscadorRegimenes
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
            this.listBoxRegimenesDisponibles = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxRegimenesElegidos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRegimenesDisponibles
            // 
            this.listBoxRegimenesDisponibles.FormattingEnabled = true;
            this.listBoxRegimenesDisponibles.ItemHeight = 16;
            this.listBoxRegimenesDisponibles.Location = new System.Drawing.Point(31, 38);
            this.listBoxRegimenesDisponibles.Name = "listBoxRegimenesDisponibles";
            this.listBoxRegimenesDisponibles.Size = new System.Drawing.Size(211, 164);
            this.listBoxRegimenesDisponibles.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "(+) Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxRegimenesElegidos
            // 
            this.listBoxRegimenesElegidos.FormattingEnabled = true;
            this.listBoxRegimenesElegidos.ItemHeight = 16;
            this.listBoxRegimenesElegidos.Location = new System.Drawing.Point(423, 38);
            this.listBoxRegimenesElegidos.Name = "listBoxRegimenesElegidos";
            this.listBoxRegimenesElegidos.Size = new System.Drawing.Size(251, 164);
            this.listBoxRegimenesElegidos.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "(-) Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscadorRegimenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 324);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxRegimenesElegidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxRegimenesDisponibles);
            this.Name = "buscadorRegimenes";
            this.Text = "Seleccionar regímenes";
            this.Load += new System.EventHandler(this.buscadorRegimenes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRegimenesDisponibles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxRegimenesElegidos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}