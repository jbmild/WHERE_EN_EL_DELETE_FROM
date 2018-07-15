namespace FrbaHotel.Roles
{
    partial class frmRolesFicha
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.lblDenegados = new System.Windows.Forms.Label();
            this.lblConcedidos = new System.Windows.Forms.Label();
            this.gbxPermisos = new System.Windows.Forms.GroupBox();
            this.lbxConcedidos = new System.Windows.Forms.ListBox();
            this.lbxDenegados = new System.Windows.Forms.ListBox();
            this.btnDenegar = new System.Windows.Forms.Button();
            this.btnConceder = new System.Windows.Forms.Button();
            this.gbxGeneral = new System.Windows.Forms.GroupBox();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblErrorGeneral = new System.Windows.Forms.Label();
            this.gbxPermisos.SuspendLayout();
            this.gbxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(10, 80);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(106, 24);
            this.chkHabilitado.TabIndex = 2;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblDenegados
            // 
            this.lblDenegados.AutoSize = true;
            this.lblDenegados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenegados.Location = new System.Drawing.Point(6, 33);
            this.lblDenegados.Name = "lblDenegados";
            this.lblDenegados.Size = new System.Drawing.Size(92, 20);
            this.lblDenegados.TabIndex = 8;
            this.lblDenegados.Text = "Denegados";
            // 
            // lblConcedidos
            // 
            this.lblConcedidos.AutoSize = true;
            this.lblConcedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcedidos.Location = new System.Drawing.Point(485, 33);
            this.lblConcedidos.Name = "lblConcedidos";
            this.lblConcedidos.Size = new System.Drawing.Size(93, 20);
            this.lblConcedidos.TabIndex = 9;
            this.lblConcedidos.Text = "Concedidos";
            // 
            // gbxPermisos
            // 
            this.gbxPermisos.Controls.Add(this.lbxConcedidos);
            this.gbxPermisos.Controls.Add(this.lbxDenegados);
            this.gbxPermisos.Controls.Add(this.btnDenegar);
            this.gbxPermisos.Controls.Add(this.btnConceder);
            this.gbxPermisos.Controls.Add(this.lblDenegados);
            this.gbxPermisos.Controls.Add(this.lblConcedidos);
            this.gbxPermisos.Location = new System.Drawing.Point(12, 199);
            this.gbxPermisos.Name = "gbxPermisos";
            this.gbxPermisos.Size = new System.Drawing.Size(797, 419);
            this.gbxPermisos.TabIndex = 10;
            this.gbxPermisos.TabStop = false;
            this.gbxPermisos.Text = "Permisos";
            // 
            // lbxConcedidos
            // 
            this.lbxConcedidos.FormattingEnabled = true;
            this.lbxConcedidos.ItemHeight = 20;
            this.lbxConcedidos.Location = new System.Drawing.Point(489, 56);
            this.lbxConcedidos.Name = "lbxConcedidos";
            this.lbxConcedidos.Size = new System.Drawing.Size(302, 344);
            this.lbxConcedidos.TabIndex = 12;
            // 
            // lbxDenegados
            // 
            this.lbxDenegados.FormattingEnabled = true;
            this.lbxDenegados.ItemHeight = 20;
            this.lbxDenegados.Location = new System.Drawing.Point(6, 56);
            this.lbxDenegados.Name = "lbxDenegados";
            this.lbxDenegados.Size = new System.Drawing.Size(306, 344);
            this.lbxDenegados.TabIndex = 11;
            // 
            // btnDenegar
            // 
            this.btnDenegar.Location = new System.Drawing.Point(318, 217);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.Size = new System.Drawing.Size(165, 57);
            this.btnDenegar.TabIndex = 3;
            this.btnDenegar.Text = "<- Denegar ";
            this.btnDenegar.UseVisualStyleBackColor = true;
            this.btnDenegar.Click += new System.EventHandler(this.btnDenegar_Click);
            // 
            // btnConceder
            // 
            this.btnConceder.Location = new System.Drawing.Point(318, 154);
            this.btnConceder.Name = "btnConceder";
            this.btnConceder.Size = new System.Drawing.Size(165, 57);
            this.btnConceder.TabIndex = 10;
            this.btnConceder.Text = "Conceder ->";
            this.btnConceder.UseVisualStyleBackColor = true;
            this.btnConceder.Click += new System.EventHandler(this.btnConceder_Click);
            // 
            // gbxGeneral
            // 
            this.gbxGeneral.Controls.Add(this.lblErrorNombre);
            this.gbxGeneral.Controls.Add(this.lblNombre);
            this.gbxGeneral.Controls.Add(this.txtNombre);
            this.gbxGeneral.Controls.Add(this.chkHabilitado);
            this.gbxGeneral.Location = new System.Drawing.Point(12, 75);
            this.gbxGeneral.Name = "gbxGeneral";
            this.gbxGeneral.Size = new System.Drawing.Size(797, 118);
            this.gbxGeneral.TabIndex = 11;
            this.gbxGeneral.TabStop = false;
            this.gbxGeneral.Text = "Datos generales";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(333, 38);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(0, 25);
            this.lblErrorNombre.TabIndex = 19;
            this.lblErrorNombre.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 29);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Alta de nuevo rol";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(682, 624);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 42);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 624);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 42);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblErrorGeneral
            // 
            this.lblErrorGeneral.AutoSize = true;
            this.lblErrorGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGeneral.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGeneral.Location = new System.Drawing.Point(17, 47);
            this.lblErrorGeneral.Name = "lblErrorGeneral";
            this.lblErrorGeneral.Size = new System.Drawing.Size(0, 25);
            this.lblErrorGeneral.TabIndex = 20;
            this.lblErrorGeneral.Visible = false;
            // 
            // frmRolesFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 681);
            this.Controls.Add(this.lblErrorGeneral);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxGeneral);
            this.Controls.Add(this.gbxPermisos);
            this.Name = "frmRolesFicha";
            this.Text = "Ficha del rol";
            this.gbxPermisos.ResumeLayout(false);
            this.gbxPermisos.PerformLayout();
            this.gbxGeneral.ResumeLayout(false);
            this.gbxGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Label lblDenegados;
        private System.Windows.Forms.Label lblConcedidos;
        private System.Windows.Forms.GroupBox gbxPermisos;
        private System.Windows.Forms.GroupBox gbxGeneral;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDenegar;
        private System.Windows.Forms.Button btnConceder;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lbxConcedidos;
        private System.Windows.Forms.ListBox lbxDenegados;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorGeneral;
    }
}