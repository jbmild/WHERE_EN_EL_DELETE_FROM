namespace FrbaHotel.AbmRegimen
{
    partial class bajaRegimen
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxBajaRegimen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxBajaRegimen
            // 
            this.comboBoxBajaRegimen.FormattingEnabled = true;
            this.comboBoxBajaRegimen.Location = new System.Drawing.Point(320, 131);
            this.comboBoxBajaRegimen.Name = "comboBoxBajaRegimen";
            this.comboBoxBajaRegimen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBajaRegimen.TabIndex = 1;
            this.comboBoxBajaRegimen.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Regimen";
            // 
            // bajaRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBajaRegimen);
            this.Controls.Add(this.button1);
            this.Name = "bajaRegimen";
            this.Text = "bajaRegimen";
            this.Load += new System.EventHandler(this.bajaRegimen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxBajaRegimen;
        private System.Windows.Forms.Label label1;
    }
}