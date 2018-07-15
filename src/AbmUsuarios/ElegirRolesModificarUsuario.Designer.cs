namespace FrbaHotel.AbmUsuarios
{
    partial class ElegirRolesModificarUsuario
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
            this.listBoxRolesIncluidos = new System.Windows.Forms.ListBox();
            this.listBoxRolesExcluidos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.buttonExcluirRol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRolesIncluidos
            // 
            this.listBoxRolesIncluidos.FormattingEnabled = true;
            this.listBoxRolesIncluidos.ItemHeight = 16;
            this.listBoxRolesIncluidos.Location = new System.Drawing.Point(43, 82);
            this.listBoxRolesIncluidos.Name = "listBoxRolesIncluidos";
            this.listBoxRolesIncluidos.Size = new System.Drawing.Size(348, 132);
            this.listBoxRolesIncluidos.TabIndex = 0;
            // 
            // listBoxRolesExcluidos
            // 
            this.listBoxRolesExcluidos.FormattingEnabled = true;
            this.listBoxRolesExcluidos.ItemHeight = 16;
            this.listBoxRolesExcluidos.Location = new System.Drawing.Point(652, 82);
            this.listBoxRolesExcluidos.Name = "listBoxRolesExcluidos";
            this.listBoxRolesExcluidos.Size = new System.Drawing.Size(311, 132);
            this.listBoxRolesExcluidos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roles que quedarán INCLUIDOS para el usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Roles que quedarán EXCLUIDOS para el usuario";
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Location = new System.Drawing.Point(466, 82);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(113, 44);
            this.buttonAddRole.TabIndex = 4;
            this.buttonAddRole.Text = "Incluir rol";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // buttonExcluirRol
            // 
            this.buttonExcluirRol.Location = new System.Drawing.Point(466, 159);
            this.buttonExcluirRol.Name = "buttonExcluirRol";
            this.buttonExcluirRol.Size = new System.Drawing.Size(113, 44);
            this.buttonExcluirRol.TabIndex = 5;
            this.buttonExcluirRol.Text = "Excluir rol";
            this.buttonExcluirRol.UseVisualStyleBackColor = true;
            this.buttonExcluirRol.Click += new System.EventHandler(this.buttonExcluirRol_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(988, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElegirRolesModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExcluirRol);
            this.Controls.Add(this.buttonAddRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRolesExcluidos);
            this.Controls.Add(this.listBoxRolesIncluidos);
            this.Name = "ElegirRolesModificarUsuario";
            this.Text = "ElegirRolesModificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRolesIncluidos;
        private System.Windows.Forms.ListBox listBoxRolesExcluidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddRole;
        private System.Windows.Forms.Button buttonExcluirRol;
        private System.Windows.Forms.Button button1;
    }
}