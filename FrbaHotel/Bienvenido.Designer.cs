namespace FrbaHotel
{
    partial class Bienvenido
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnGenerarModificarReserva = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnHoteles = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.btnEstadias = new System.Windows.Forms.Button();
            this.btnConsumibles = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(265, 23);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(502, 29);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido al sistema de gestion hotelera";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(11, 7);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(45, 17);
            this.lblHotel.TabIndex = 1;
            this.lblHotel.Text = "Hotel:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(11, 23);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 17);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(917, 26);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(943, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(569, 92);
            this.btnCancelarReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(185, 46);
            this.btnCancelarReserva.TabIndex = 17;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnGenerarModificarReserva
            // 
            this.btnGenerarModificarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarModificarReserva.Location = new System.Drawing.Point(296, 92);
            this.btnGenerarModificarReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarModificarReserva.Name = "btnGenerarModificarReserva";
            this.btnGenerarModificarReserva.Size = new System.Drawing.Size(267, 46);
            this.btnGenerarModificarReserva.TabIndex = 16;
            this.btnGenerarModificarReserva.Text = "Generar o modificar Reserva";
            this.btnGenerarModificarReserva.UseVisualStyleBackColor = true;
            this.btnGenerarModificarReserva.Click += new System.EventHandler(this.btnGenerarModificarReserva_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(168, 145);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(173, 46);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Location = new System.Drawing.Point(785, 199);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(164, 46);
            this.btnRoles.TabIndex = 19;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(273, 199);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(164, 46);
            this.btnUsuarios.TabIndex = 20;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHoteles
            // 
            this.btnHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoteles.Location = new System.Drawing.Point(103, 199);
            this.btnHoteles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.Size = new System.Drawing.Size(164, 46);
            this.btnHoteles.TabIndex = 21;
            this.btnHoteles.Text = "Hoteles";
            this.btnHoteles.UseVisualStyleBackColor = true;
            this.btnHoteles.Click += new System.EventHandler(this.btnHoteles_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.Location = new System.Drawing.Point(444, 199);
            this.btnHabitaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(164, 46);
            this.btnHabitaciones.TabIndex = 22;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.UseVisualStyleBackColor = true;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnEstadias
            // 
            this.btnEstadias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadias.Location = new System.Drawing.Point(709, 145);
            this.btnEstadias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEstadias.Name = "btnEstadias";
            this.btnEstadias.Size = new System.Drawing.Size(173, 46);
            this.btnEstadias.TabIndex = 23;
            this.btnEstadias.Text = "Estadias";
            this.btnEstadias.UseVisualStyleBackColor = true;
            this.btnEstadias.Click += new System.EventHandler(this.btnEstadias_Click);
            // 
            // btnConsumibles
            // 
            this.btnConsumibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumibles.Location = new System.Drawing.Point(348, 145);
            this.btnConsumibles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsumibles.Name = "btnConsumibles";
            this.btnConsumibles.Size = new System.Drawing.Size(173, 46);
            this.btnConsumibles.TabIndex = 24;
            this.btnConsumibles.Text = "Consumibles";
            this.btnConsumibles.UseVisualStyleBackColor = true;
            this.btnConsumibles.Click += new System.EventHandler(this.btnConsumibles_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Location = new System.Drawing.Point(529, 145);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(173, 46);
            this.btnFacturacion.TabIndex = 25;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(615, 199);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(164, 46);
            this.btnEstadisticas.TabIndex = 26;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 303);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnConsumibles);
            this.Controls.Add(this.btnEstadias);
            this.Controls.Add(this.btnHabitaciones);
            this.Controls.Add(this.btnHoteles);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnGenerarModificarReserva);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.lblBienvenido);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bienvenido";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.Bienvenido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnGenerarModificarReserva;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnHoteles;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnEstadias;
        private System.Windows.Forms.Button btnConsumibles;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}