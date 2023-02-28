namespace InterfaceONGs
{
    partial class frmPesquisarVagasONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarVagasONG));
            this.lstInformacoesVagaONG = new System.Windows.Forms.ListBox();
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbVaga = new System.Windows.Forms.RadioButton();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.lblPesquisarFuncionario = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.gpbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstInformacoesVagaONG
            // 
            this.lstInformacoesVagaONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInformacoesVagaONG.FormattingEnabled = true;
            this.lstInformacoesVagaONG.ItemHeight = 20;
            this.lstInformacoesVagaONG.Location = new System.Drawing.Point(9, 241);
            this.lstInformacoesVagaONG.Name = "lstInformacoesVagaONG";
            this.lstInformacoesVagaONG.Size = new System.Drawing.Size(599, 124);
            this.lstInformacoesVagaONG.TabIndex = 7;
            this.lstInformacoesVagaONG.SelectedIndexChanged += new System.EventHandler(this.lstInformacoesVagaONG_SelectedIndexChanged);
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.btnPesquisar);
            this.gpbPesquisar.Controls.Add(this.txtDescricao);
            this.gpbPesquisar.Controls.Add(this.label1);
            this.gpbPesquisar.Controls.Add(this.rdbVaga);
            this.gpbPesquisar.Controls.Add(this.rdbID);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(9, 114);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(599, 121);
            this.gpbPesquisar.TabIndex = 6;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar por";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(463, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 75);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(108, 74);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(321, 26);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // rdbVaga
            // 
            this.rdbVaga.AutoSize = true;
            this.rdbVaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbVaga.Location = new System.Drawing.Point(208, 25);
            this.rdbVaga.Name = "rdbVaga";
            this.rdbVaga.Size = new System.Drawing.Size(64, 24);
            this.rdbVaga.TabIndex = 2;
            this.rdbVaga.Text = "Vaga";
            this.rdbVaga.UseVisualStyleBackColor = true;
            this.rdbVaga.CheckedChanged += new System.EventHandler(this.rdbVaga_CheckedChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbID.Location = new System.Drawing.Point(80, 25);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(43, 24);
            this.rdbID.TabIndex = 1;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // lblPesquisarFuncionario
            // 
            this.lblPesquisarFuncionario.AutoSize = true;
            this.lblPesquisarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPesquisarFuncionario.Location = new System.Drawing.Point(200, 67);
            this.lblPesquisarFuncionario.Name = "lblPesquisarFuncionario";
            this.lblPesquisarFuncionario.Size = new System.Drawing.Size(288, 31);
            this.lblPesquisarFuncionario.TabIndex = 189;
            this.lblPesquisarFuncionario.Text = "Pesquisar Vagas ONG";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(104, -13);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(396, 111);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 190;
            this.pctLogo.TabStop = false;
            // 
            // frmPesquisarVagasONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 378);
            this.Controls.Add(this.lblPesquisarFuncionario);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lstInformacoesVagaONG);
            this.Controls.Add(this.gpbPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisarVagasONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Vagas ONG";
            this.Load += new System.EventHandler(this.frmPesquisarVagasONG_Load);
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbVaga;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.Label lblPesquisarFuncionario;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.ListBox lstInformacoesVagaONG;
    }
}