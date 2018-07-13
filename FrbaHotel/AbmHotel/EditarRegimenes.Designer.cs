namespace FrbaHotel.AbmHotel
{
    partial class EditarRegimenes
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
            this.listBoxRegimenesActuales = new System.Windows.Forms.ListBox();
            this.listBoxRegimenesPost = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRegimenesActuales
            // 
            this.listBoxRegimenesActuales.FormattingEnabled = true;
            this.listBoxRegimenesActuales.ItemHeight = 16;
            this.listBoxRegimenesActuales.Location = new System.Drawing.Point(83, 84);
            this.listBoxRegimenesActuales.Name = "listBoxRegimenesActuales";
            this.listBoxRegimenesActuales.Size = new System.Drawing.Size(298, 196);
            this.listBoxRegimenesActuales.TabIndex = 0;
            // 
            // listBoxRegimenesPost
            // 
            this.listBoxRegimenesPost.FormattingEnabled = true;
            this.listBoxRegimenesPost.ItemHeight = 16;
            this.listBoxRegimenesPost.Location = new System.Drawing.Point(657, 84);
            this.listBoxRegimenesPost.Name = "listBoxRegimenesPost";
            this.listBoxRegimenesPost.Size = new System.Drawing.Size(298, 196);
            this.listBoxRegimenesPost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Los regímenes actuales del hotel son:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quitar régimen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Volver a añadir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditarRegimenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRegimenesPost);
            this.Controls.Add(this.listBoxRegimenesActuales);
            this.Name = "EditarRegimenes";
            this.Text = "Editar Regimenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRegimenesActuales;
        private System.Windows.Forms.ListBox listBoxRegimenesPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}