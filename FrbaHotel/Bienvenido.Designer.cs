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
            this.lblBienvenido.Location = new System.Drawing.Point(199, 19);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(399, 24);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido al sistema de gestion hotelera";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(8, 6);
            this.lblHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(35, 13);
            this.lblHotel.TabIndex = 1;
            this.lblHotel.Text = "Hotel:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(8, 19);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(688, 21);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(707, 5);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(427, 75);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(139, 37);
            this.btnCancelarReserva.TabIndex = 17;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnGenerarModificarReserva
            // 
            this.btnGenerarModificarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarModificarReserva.Location = new System.Drawing.Point(222, 75);
            this.btnGenerarModificarReserva.Name = "btnGenerarModificarReserva";
            this.btnGenerarModificarReserva.Size = new System.Drawing.Size(200, 37);
            this.btnGenerarModificarReserva.TabIndex = 16;
            this.btnGenerarModificarReserva.Text = "Generar o modificar Reserva";
            this.btnGenerarModificarReserva.UseVisualStyleBackColor = true;
            this.btnGenerarModificarReserva.Click += new System.EventHandler(this.btnGenerarModificarReserva_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(126, 118);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(130, 37);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Location = new System.Drawing.Point(589, 162);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(123, 37);
            this.btnRoles.TabIndex = 19;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(205, 162);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(123, 37);
            this.btnUsuarios.TabIndex = 20;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHoteles
            // 
            this.btnHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoteles.Location = new System.Drawing.Point(77, 162);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.Size = new System.Drawing.Size(123, 37);
            this.btnHoteles.TabIndex = 21;
            this.btnHoteles.Text = "Hoteles";
            this.btnHoteles.UseVisualStyleBackColor = true;
            this.btnHoteles.Click += new System.EventHandler(this.btnHoteles_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.Location = new System.Drawing.Point(333, 162);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(123, 37);
            this.btnHabitaciones.TabIndex = 22;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.UseVisualStyleBackColor = true;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnEstadias
            // 
            this.btnEstadias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadias.Location = new System.Drawing.Point(532, 118);
            this.btnEstadias.Name = "btnEstadias";
            this.btnEstadias.Size = new System.Drawing.Size(130, 37);
            this.btnEstadias.TabIndex = 23;
            this.btnEstadias.Text = "Estadias";
            this.btnEstadias.UseVisualStyleBackColor = true;
            this.btnEstadias.Click += new System.EventHandler(this.btnEstadias_Click);
            // 
            // btnConsumibles
            // 
            this.btnConsumibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumibles.Location = new System.Drawing.Point(261, 118);
            this.btnConsumibles.Name = "btnConsumibles";
            this.btnConsumibles.Size = new System.Drawing.Size(130, 37);
            this.btnConsumibles.TabIndex = 24;
            this.btnConsumibles.Text = "Consumibles";
            this.btnConsumibles.UseVisualStyleBackColor = true;
            this.btnConsumibles.Click += new System.EventHandler(this.btnConsumibles_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Location = new System.Drawing.Point(397, 118);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(130, 37);
            this.btnFacturacion.TabIndex = 25;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(461, 162);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(123, 37);
            this.btnEstadisticas.TabIndex = 26;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 246);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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