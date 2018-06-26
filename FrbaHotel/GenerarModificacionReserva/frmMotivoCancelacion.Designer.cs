namespace FrbaHotel.GenerarModificacionReserva
{
    partial class frmMotivoCancelacion
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
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(100, 75);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(160, 77);
            this.txtMotivo.TabIndex = 1;
            this.txtMotivo.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el motivo de cancelación: ";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(154, 202);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(106, 24);
            this.btnCancelarReserva.TabIndex = 3;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // frmMotivoCancelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 290);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivo);
            this.Name = "frmMotivoCancelacion";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarReserva;

    }
}