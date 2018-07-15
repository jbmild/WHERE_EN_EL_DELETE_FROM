namespace FrbaHotel.AbmHabitacion
{
    partial class darBajaHabitacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNumeroHabitacion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelInhabilitada = new System.Windows.Forms.Label();
            this.labelErrorInhabilitar = new System.Windows.Forms.Label();
            this.labelNumeroVacio = new System.Windows.Forms.Label();
            this.labelHotelVacio = new System.Windows.Forms.Label();
            this.labelInhabilitar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // comboBoxHoteles
            // 
            this.comboBoxHoteles.Enabled = false;
            this.comboBoxHoteles.FormattingEnabled = true;
            this.comboBoxHoteles.Location = new System.Drawing.Point(466, 357);
            this.comboBoxHoteles.Name = "comboBoxHoteles";
            this.comboBoxHoteles.Size = new System.Drawing.Size(326, 24);
            this.comboBoxHoteles.TabIndex = 1;
            this.comboBoxHoteles.Visible = false;
            this.comboBoxHoteles.SelectionChangeCommitted += new System.EventHandler(this.comboBoxHoteles_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // comboBoxNumeroHabitacion
            // 
            this.comboBoxNumeroHabitacion.Enabled = false;
            this.comboBoxNumeroHabitacion.FormattingEnabled = true;
            this.comboBoxNumeroHabitacion.Location = new System.Drawing.Point(671, 327);
            this.comboBoxNumeroHabitacion.Name = "comboBoxNumeroHabitacion";
            this.comboBoxNumeroHabitacion.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNumeroHabitacion.TabIndex = 3;
            this.comboBoxNumeroHabitacion.Visible = false;
            this.comboBoxNumeroHabitacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumeroHabitacion_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sí";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInhabilitada
            // 
            this.labelInhabilitada.AutoSize = true;
            this.labelInhabilitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInhabilitada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelInhabilitada.Location = new System.Drawing.Point(261, 296);
            this.labelInhabilitada.Name = "labelInhabilitada";
            this.labelInhabilitada.Size = new System.Drawing.Size(250, 20);
            this.labelInhabilitada.TabIndex = 5;
            this.labelInhabilitada.Text = "Habitación inhabilitada con éxito";
            this.labelInhabilitada.Visible = false;
            // 
            // labelErrorInhabilitar
            // 
            this.labelErrorInhabilitar.AutoSize = true;
            this.labelErrorInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorInhabilitar.ForeColor = System.Drawing.Color.Red;
            this.labelErrorInhabilitar.Location = new System.Drawing.Point(265, 341);
            this.labelErrorInhabilitar.Name = "labelErrorInhabilitar";
            this.labelErrorInhabilitar.Size = new System.Drawing.Size(203, 20);
            this.labelErrorInhabilitar.TabIndex = 6;
            this.labelErrorInhabilitar.Text = "Error al intentar inhabilitar";
            this.labelErrorInhabilitar.Visible = false;
            // 
            // labelNumeroVacio
            // 
            this.labelNumeroVacio.AutoSize = true;
            this.labelNumeroVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroVacio.ForeColor = System.Drawing.Color.Red;
            this.labelNumeroVacio.Location = new System.Drawing.Point(578, 93);
            this.labelNumeroVacio.Name = "labelNumeroVacio";
            this.labelNumeroVacio.Size = new System.Drawing.Size(0, 20);
            this.labelNumeroVacio.TabIndex = 7;
            this.labelNumeroVacio.Visible = false;
            // 
            // labelHotelVacio
            // 
            this.labelHotelVacio.AutoSize = true;
            this.labelHotelVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelVacio.ForeColor = System.Drawing.Color.Red;
            this.labelHotelVacio.Location = new System.Drawing.Point(578, 53);
            this.labelHotelVacio.Name = "labelHotelVacio";
            this.labelHotelVacio.Size = new System.Drawing.Size(0, 20);
            this.labelHotelVacio.TabIndex = 8;
            this.labelHotelVacio.Visible = false;
            // 
            // labelInhabilitar
            // 
            this.labelInhabilitar.AutoSize = true;
            this.labelInhabilitar.Location = new System.Drawing.Point(262, 93);
            this.labelInhabilitar.Name = "labelInhabilitar";
            this.labelInhabilitar.Size = new System.Drawing.Size(0, 17);
            this.labelInhabilitar.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // darBajaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelInhabilitar);
            this.Controls.Add(this.labelHotelVacio);
            this.Controls.Add(this.labelNumeroVacio);
            this.Controls.Add(this.labelErrorInhabilitar);
            this.Controls.Add(this.labelInhabilitada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxNumeroHabitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxHoteles);
            this.Controls.Add(this.label1);
            this.Name = "darBajaHabitacion";
            this.Text = "Dar de baja habitación";
            this.Load += new System.EventHandler(this.darBajaHabitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHoteles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNumeroHabitacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelInhabilitada;
        private System.Windows.Forms.Label labelErrorInhabilitar;
        private System.Windows.Forms.Label labelNumeroVacio;
        private System.Windows.Forms.Label labelHotelVacio;
        private System.Windows.Forms.Label labelInhabilitar;
        private System.Windows.Forms.Button button2;
    }
}