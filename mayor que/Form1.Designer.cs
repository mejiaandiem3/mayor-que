namespace mayor_que
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trcnumero1 = new System.Windows.Forms.TrackBar();
            this.trcnumero2 = new System.Windows.Forms.TrackBar();
            this.lblmostrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcnumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcnumero2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trcnumero1
            // 
            this.trcnumero1.Location = new System.Drawing.Point(12, 30);
            this.trcnumero1.Name = "trcnumero1";
            this.trcnumero1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcnumero1.Size = new System.Drawing.Size(45, 350);
            this.trcnumero1.TabIndex = 1;
            this.trcnumero1.Scroll += new System.EventHandler(this.trcnumero1_Scroll);
            // 
            // trcnumero2
            // 
            this.trcnumero2.Location = new System.Drawing.Point(884, 30);
            this.trcnumero2.Name = "trcnumero2";
            this.trcnumero2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcnumero2.Size = new System.Drawing.Size(45, 350);
            this.trcnumero2.TabIndex = 2;
            this.trcnumero2.Scroll += new System.EventHandler(this.trcnumero2_Scroll);
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Location = new System.Drawing.Point(480, 417);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(16, 13);
            this.lblmostrar.TabIndex = 3;
            this.lblmostrar.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 548);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.trcnumero2);
            this.Controls.Add(this.trcnumero1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcnumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcnumero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trcnumero1;
        private System.Windows.Forms.TrackBar trcnumero2;
        private System.Windows.Forms.Label lblmostrar;
    }
}

