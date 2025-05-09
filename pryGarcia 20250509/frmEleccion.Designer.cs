namespace pryGarcia_20250509
{
    partial class frmEleccion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbHeroe = new System.Windows.Forms.ComboBox();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.lblHeroe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHeroe
            // 
            this.cmbHeroe.FormattingEnabled = true;
            this.cmbHeroe.Location = new System.Drawing.Point(30, 51);
            this.cmbHeroe.Name = "cmbHeroe";
            this.cmbHeroe.Size = new System.Drawing.Size(121, 21);
            this.cmbHeroe.TabIndex = 0;
            this.cmbHeroe.SelectedIndexChanged += new System.EventHandler(this.cmbHeroe_SelectedIndexChanged);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Location = new System.Drawing.Point(30, 103);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(100, 50);
            this.pcbImagen.TabIndex = 1;
            this.pcbImagen.TabStop = false;
            // 
            // lblHeroe
            // 
            this.lblHeroe.AutoSize = true;
            this.lblHeroe.Location = new System.Drawing.Point(27, 24);
            this.lblHeroe.Name = "lblHeroe";
            this.lblHeroe.Size = new System.Drawing.Size(45, 13);
            this.lblHeroe.TabIndex = 2;
            this.lblHeroe.Text = "HEROE";
            // 
            // frmEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 224);
            this.Controls.Add(this.lblHeroe);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.cmbHeroe);
            this.Name = "frmEleccion";
            this.Text = "ELECCION";
            this.Load += new System.EventHandler(this.frmEleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHeroe;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lblHeroe;
    }
}

