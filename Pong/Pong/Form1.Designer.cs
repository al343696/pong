namespace Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.marcadorPB = new System.Windows.Forms.Label();
            this.pelotaImg = new System.Windows.Forms.PictureBox();
            this.raqueta1 = new System.Windows.Forms.PictureBox();
            this.raqueta2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pelotaImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raqueta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raqueta2)).BeginInit();
            this.SuspendLayout();
            // 
            // marcadorPB
            // 
            this.marcadorPB.AutoSize = true;
            this.marcadorPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcadorPB.Location = new System.Drawing.Point(240, 0);
            this.marcadorPB.Name = "marcadorPB";
            this.marcadorPB.Size = new System.Drawing.Size(324, 153);
            this.marcadorPB.TabIndex = 0;
            this.marcadorPB.Text = "0 : 0";
            // 
            // pelotaImg
            // 
            this.pelotaImg.Image = ((System.Drawing.Image)(resources.GetObject("pelotaImg.Image")));
            this.pelotaImg.Location = new System.Drawing.Point(383, 265);
            this.pelotaImg.Name = "pelotaImg";
            this.pelotaImg.Size = new System.Drawing.Size(25, 25);
            this.pelotaImg.TabIndex = 1;
            this.pelotaImg.TabStop = false;
            // 
            // raqueta1
            // 
            this.raqueta1.BackColor = System.Drawing.Color.Black;
            this.raqueta1.Location = new System.Drawing.Point(12, 197);
            this.raqueta1.Name = "raqueta1";
            this.raqueta1.Size = new System.Drawing.Size(24, 155);
            this.raqueta1.TabIndex = 2;
            this.raqueta1.TabStop = false;
            // 
            // raqueta2
            // 
            this.raqueta2.BackColor = System.Drawing.Color.Black;
            this.raqueta2.Location = new System.Drawing.Point(748, 197);
            this.raqueta2.Name = "raqueta2";
            this.raqueta2.Size = new System.Drawing.Size(24, 155);
            this.raqueta2.TabIndex = 3;
            this.raqueta2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.raqueta2);
            this.Controls.Add(this.raqueta1);
            this.Controls.Add(this.pelotaImg);
            this.Controls.Add(this.marcadorPB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pelotaImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raqueta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raqueta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label marcadorPB;
        private System.Windows.Forms.PictureBox pelotaImg;
        private System.Windows.Forms.PictureBox raqueta1;
        private System.Windows.Forms.PictureBox raqueta2;
    }
}

