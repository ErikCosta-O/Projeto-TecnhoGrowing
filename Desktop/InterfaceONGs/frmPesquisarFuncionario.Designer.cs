
namespace InterfaceONGs
{
    partial class frmPesquisarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionario));
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbRegistroFuncionario = new System.Windows.Forms.RadioButton();
            this.lstInformacoesFunc = new System.Windows.Forms.ListBox();
            this.lblPesquisarFuncionario = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.gpbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.btnPesquisar);
            this.gpbPesquisar.Controls.Add(this.txtDescricao);
            this.gpbPesquisar.Controls.Add(this.label1);
            this.gpbPesquisar.Controls.Add(this.rdbNome);
            this.gpbPesquisar.Controls.Add(this.rdbRegistroFuncionario);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(21, 116);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(599, 121);
            this.gpbPesquisar.TabIndex = 0;
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
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(208, 25);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbRegistroFuncionario
            // 
            this.rdbRegistroFuncionario.AutoSize = true;
            this.rdbRegistroFuncionario.Location = new System.Drawing.Point(80, 25);
            this.rdbRegistroFuncionario.Name = "rdbRegistroFuncionario";
            this.rdbRegistroFuncionario.Size = new System.Drawing.Size(44, 24);
            this.rdbRegistroFuncionario.TabIndex = 1;
            this.rdbRegistroFuncionario.Text = "ID";
            this.rdbRegistroFuncionario.UseVisualStyleBackColor = true;
            this.rdbRegistroFuncionario.CheckedChanged += new System.EventHandler(this.rdbRegistroFuncionario_CheckedChanged);
            // 
            // lstInformacoesFunc
            // 
            this.lstInformacoesFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInformacoesFunc.FormattingEnabled = true;
            this.lstInformacoesFunc.ItemHeight = 20;
            this.lstInformacoesFunc.Location = new System.Drawing.Point(21, 250);
            this.lstInformacoesFunc.Name = "lstInformacoesFunc";
            this.lstInformacoesFunc.Size = new System.Drawing.Size(599, 144);
            this.lstInformacoesFunc.TabIndex = 5;
            this.lstInformacoesFunc.SelectedIndexChanged += new System.EventHandler(this.lstInformacoes_SelectedIndexChanged);
            // 
            // lblPesquisarFuncionario
            // 
            this.lblPesquisarFuncionario.AutoSize = true;
            this.lblPesquisarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPesquisarFuncionario.Location = new System.Drawing.Point(203, 61);
            this.lblPesquisarFuncionario.Name = "lblPesquisarFuncionario";
            this.lblPesquisarFuncionario.Size = new System.Drawing.Size(284, 31);
            this.lblPesquisarFuncionario.TabIndex = 187;
            this.lblPesquisarFuncionario.Text = "Pesquisar Funcionario";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(101, -19);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(396, 111);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 188;
            this.pctLogo.TabStop = false;
            // 
            // frmPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 402);
            this.Controls.Add(this.lstInformacoesFunc);
            this.Controls.Add(this.gpbPesquisar);
            this.Controls.Add(this.lblPesquisarFuncionario);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar dados Funcionários";
            this.Load += new System.EventHandler(this.frmPesquisar_Load);
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
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbRegistroFuncionario;
        private System.Windows.Forms.Label lblPesquisarFuncionario;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.ListBox lstInformacoesFunc;
    }
}