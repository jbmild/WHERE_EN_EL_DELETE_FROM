namespace FrbaHotel.AbmHabitacion
{
    partial class altaHabitacion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPisoEnHotel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBoxDescripcionHabitacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.labelNroVacio = new System.Windows.Forms.Label();
            this.labelDescVacia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAgregado = new System.Windows.Forms.Label();
            this.labelNoSePuede = new System.Windows.Forms.Label();
            this.labelHotelPendiente = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelVistaPendiente = new System.Windows.Forms.Label();
            this.radioButtonVistaExteriorSI = new System.Windows.Forms.RadioButton();
            this.radioButtonVistaExteriorNO = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(218, 32);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(288, 24);
            this.comboBoxHotel.TabIndex = 1;
            this.comboBoxHotel.SelectionChangeCommitted += new System.EventHandler(this.comboBoxHotel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Piso dentro  del hotel";
            // 
            // comboBoxPisoEnHotel
            // 
            this.comboBoxPisoEnHotel.FormattingEnabled = true;
            this.comboBoxPisoEnHotel.Location = new System.Drawing.Point(218, 72);
            this.comboBoxPisoEnHotel.Name = "comboBoxPisoEnHotel";
            this.comboBoxPisoEnHotel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPisoEnHotel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de habitación";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // textBoxDescripcionHabitacion
            // 
            this.textBoxDescripcionHabitacion.Location = new System.Drawing.Point(82, 247);
            this.textBoxDescripcionHabitacion.Name = "textBoxDescripcionHabitacion";
            this.textBoxDescripcionHabitacion.Size = new System.Drawing.Size(315, 22);
            this.textBoxDescripcionHabitacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dar de alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxNumeroHabitacion
            // 
            this.textBoxNumeroHabitacion.Location = new System.Drawing.Point(227, 111);
            this.textBoxNumeroHabitacion.Name = "textBoxNumeroHabitacion";
            this.textBoxNumeroHabitacion.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumeroHabitacion.TabIndex = 10;
            // 
            // labelNroVacio
            // 
            this.labelNroVacio.AutoSize = true;
            this.labelNroVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroVacio.ForeColor = System.Drawing.Color.Red;
            this.labelNroVacio.Location = new System.Drawing.Point(333, 111);
            this.labelNroVacio.Name = "labelNroVacio";
            this.labelNroVacio.Size = new System.Drawing.Size(409, 25);
            this.labelNroVacio.TabIndex = 11;
            this.labelNroVacio.Text = "Debe ingresar un número de habitación válido";
            this.labelNroVacio.Visible = false;
            // 
            // labelDescVacia
            // 
            this.labelDescVacia.AutoSize = true;
            this.labelDescVacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescVacia.ForeColor = System.Drawing.Color.Red;
            this.labelDescVacia.Location = new System.Drawing.Point(404, 247);
            this.labelDescVacia.Name = "labelDescVacia";
            this.labelDescVacia.Size = new System.Drawing.Size(276, 25);
            this.labelDescVacia.TabIndex = 12;
            this.labelDescVacia.Text = "Debe ingresar una descripción";
            this.labelDescVacia.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 13;
            // 
            // labelAgregado
            // 
            this.labelAgregado.AutoSize = true;
            this.labelAgregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelAgregado.Location = new System.Drawing.Point(104, 303);
            this.labelAgregado.Name = "labelAgregado";
            this.labelAgregado.Size = new System.Drawing.Size(281, 25);
            this.labelAgregado.TabIndex = 16;
            this.labelAgregado.Text = "Habitación agregada con éxito!";
            this.labelAgregado.Visible = false;
            // 
            // labelNoSePuede
            // 
            this.labelNoSePuede.AutoSize = true;
            this.labelNoSePuede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoSePuede.ForeColor = System.Drawing.Color.Red;
            this.labelNoSePuede.Location = new System.Drawing.Point(86, 334);
            this.labelNoSePuede.Name = "labelNoSePuede";
            this.labelNoSePuede.Size = new System.Drawing.Size(311, 25);
            this.labelNoSePuede.TabIndex = 17;
            this.labelNoSePuede.Text = "Número de habitación ya existente";
            this.labelNoSePuede.Visible = false;
            // 
            // labelHotelPendiente
            // 
            this.labelHotelPendiente.AutoSize = true;
            this.labelHotelPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelPendiente.ForeColor = System.Drawing.Color.Red;
            this.labelHotelPendiente.Location = new System.Drawing.Point(519, 34);
            this.labelHotelPendiente.Name = "labelHotelPendiente";
            this.labelHotelPendiente.Size = new System.Drawing.Size(185, 25);
            this.labelHotelPendiente.TabIndex = 18;
            this.labelHotelPendiente.Text = "Debe elegir un hotel";
            this.labelHotelPendiente.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 56);
            this.button2.TabIndex = 19;
            this.button2.Text = "Limpiar campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "¿Tiene vista al exterior?";
            // 
            // labelVistaPendiente
            // 
            this.labelVistaPendiente.AutoSize = true;
            this.labelVistaPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVistaPendiente.ForeColor = System.Drawing.Color.Red;
            this.labelVistaPendiente.Location = new System.Drawing.Point(389, 185);
            this.labelVistaPendiente.Name = "labelVistaPendiente";
            this.labelVistaPendiente.Size = new System.Drawing.Size(212, 25);
            this.labelVistaPendiente.TabIndex = 22;
            this.labelVistaPendiente.Text = "Debe elegir una opción";
            this.labelVistaPendiente.Visible = false;
            // 
            // radioButtonVistaExteriorSI
            // 
            this.radioButtonVistaExteriorSI.AutoSize = true;
            this.radioButtonVistaExteriorSI.Location = new System.Drawing.Point(269, 185);
            this.radioButtonVistaExteriorSI.Name = "radioButtonVistaExteriorSI";
            this.radioButtonVistaExteriorSI.Size = new System.Drawing.Size(41, 21);
            this.radioButtonVistaExteriorSI.TabIndex = 23;
            this.radioButtonVistaExteriorSI.TabStop = true;
            this.radioButtonVistaExteriorSI.Text = "Sí";
            this.radioButtonVistaExteriorSI.UseVisualStyleBackColor = true;
            // 
            // radioButtonVistaExteriorNO
            // 
            this.radioButtonVistaExteriorNO.AutoSize = true;
            this.radioButtonVistaExteriorNO.Location = new System.Drawing.Point(316, 185);
            this.radioButtonVistaExteriorNO.Name = "radioButtonVistaExteriorNO";
            this.radioButtonVistaExteriorNO.Size = new System.Drawing.Size(47, 21);
            this.radioButtonVistaExteriorNO.TabIndex = 24;
            this.radioButtonVistaExteriorNO.TabStop = true;
            this.radioButtonVistaExteriorNO.Text = "No";
            this.radioButtonVistaExteriorNO.UseVisualStyleBackColor = true;
            // 
            // altaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 423);
            this.Controls.Add(this.radioButtonVistaExteriorNO);
            this.Controls.Add(this.radioButtonVistaExteriorSI);
            this.Controls.Add(this.labelVistaPendiente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelHotelPendiente);
            this.Controls.Add(this.labelNoSePuede);
            this.Controls.Add(this.labelAgregado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDescVacia);
            this.Controls.Add(this.labelNroVacio);
            this.Controls.Add(this.textBoxNumeroHabitacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescripcionHabitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPisoEnHotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.label1);
            this.Name = "altaHabitacion";
            this.Text = "Dar de alta habitación";
            this.Load += new System.EventHandler(this.altaHabitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPisoEnHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBoxDescripcionHabitacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNumeroHabitacion;
        private System.Windows.Forms.Label labelNroVacio;
        private System.Windows.Forms.Label labelDescVacia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAgregado;
        private System.Windows.Forms.Label labelNoSePuede;
        private System.Windows.Forms.Label labelHotelPendiente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVistaPendiente;
        private System.Windows.Forms.RadioButton radioButtonVistaExteriorSI;
        private System.Windows.Forms.RadioButton radioButtonVistaExteriorNO;
    }
}