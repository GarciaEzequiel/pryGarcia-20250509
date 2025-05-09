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
            this.nudFuerza = new System.Windows.Forms.NumericUpDown();
            this.NudDestreza = new System.Windows.Forms.NumericUpDown();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDestreza)).BeginInit();
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
            // nudFuerza
            // 
            this.nudFuerza.Location = new System.Drawing.Point(363, 144);
            this.nudFuerza.Name = "nudFuerza";
            this.nudFuerza.Size = new System.Drawing.Size(120, 20);
            this.nudFuerza.TabIndex = 3;
            // 
            // NudDestreza
            // 
            this.NudDestreza.Location = new System.Drawing.Point(363, 202);
            this.NudDestreza.Name = "NudDestreza";
            this.NudDestreza.Size = new System.Drawing.Size(120, 20);
            this.NudDestreza.TabIndex = 4;
            // 
            // lblFuerza
            // 
            this.lblFuerza.Location = new System.Drawing.Point(360, 128);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(52, 13);
            this.lblFuerza.TabIndex = 0;
            this.lblFuerza.Text = "Fuerza";
            // 
            // lblDestreza
            // 
            this.lblDestreza.Location = new System.Drawing.Point(360, 186);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(52, 13);
            this.lblDestreza.TabIndex = 5;
            this.lblDestreza.Text = "Destreza";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(363, 243);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(118, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "STATS";
            // 
            // frmEleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(219, 224);
=======
            this.ClientSize = new System.Drawing.Size(519, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblDestreza);
            this.Controls.Add(this.lblFuerza);
            this.Controls.Add(this.NudDestreza);
            this.Controls.Add(this.nudFuerza);
>>>>>>> Stashed changes
            this.Controls.Add(this.lblHeroe);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.cmbHeroe);
            this.Name = "frmEleccion";
            this.Text = "ELECCION";
            this.Load += new System.EventHandler(this.frmEleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDestreza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHeroe;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lblHeroe;
        private System.Windows.Forms.NumericUpDown nudFuerza;
        private System.Windows.Forms.NumericUpDown NudDestreza;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
    }
}

