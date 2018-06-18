namespace FrbaHotel.Roles
{
    partial class frmRolesListado
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
            this.dgwRoles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRoles
            // 
            this.dgwRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRoles.Location = new System.Drawing.Point(132, 97);
            this.dgwRoles.Name = "dgwRoles";
            this.dgwRoles.RowTemplate.Height = 28;
            this.dgwRoles.Size = new System.Drawing.Size(757, 348);
            this.dgwRoles.TabIndex = 0;
            // 
            // frmRolesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 676);
            this.Controls.Add(this.dgwRoles);
            this.Name = "frmRolesListado";
            this.Text = "Administracion de Roles";
            this.Load += new System.EventHandler(this.frmRolesGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRoles;
    }
}