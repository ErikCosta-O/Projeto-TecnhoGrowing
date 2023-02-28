namespace InterfaceONGs
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pgbBarra = new System.Windows.Forms.ProgressBar();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.trmSplash = new System.Windows.Forms.Timer(this.components);
            this.lblPorcentagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(10, 1);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(311, 107);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pgbBarra
            // 
            this.pgbBarra.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pgbBarra.ForeColor = System.Drawing.Color.DimGray;
            this.pgbBarra.Location = new System.Drawing.Point(31, 178);
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(266, 51);
            this.pgbBarra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbBarra.TabIndex = 1;
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblmensagem.Location = new System.Drawing.Point(59, 111);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(217, 20);
            this.lblmensagem.TabIndex = 3;
            this.lblmensagem.Text = "Um Futuro melhor para todos";
            // 
            // trmSplash
            // 
            this.trmSplash.Enabled = true;
            this.trmSplash.Tick += new System.EventHandler(this.trmSplash_Tick);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPorcentagem.Location = new System.Drawing.Point(143, 150);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(41, 25);
            this.lblPorcentagem.TabIndex = 4;
            this.lblPorcentagem.Text = "0%";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 247);
            this.ControlBox = false;
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.pgbBarra);
            this.Controls.Add(this.ptbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TECHNO GROWING";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.ProgressBar pgbBarra;
        private System.Windows.Forms.Label lblmensagem;
        private System.Windows.Forms.Timer trmSplash;
        private System.Windows.Forms.Label lblPorcentagem;
    }
}