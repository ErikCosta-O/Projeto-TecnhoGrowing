namespace InterfaceONGs
{
    partial class frmVagaONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVagaONG));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.txtNomeONG = new System.Windows.Forms.TextBox();
            this.lblCadVagasONG = new System.Windows.Forms.Label();
            this.lblNomeONG = new System.Windows.Forms.Label();
            this.lblVaga = new System.Windows.Forms.Label();
            this.lblCategoriaVagaONG = new System.Windows.Forms.Label();
            this.cbbCategoriaVagaONG = new System.Windows.Forms.ComboBox();
            this.lblDescricaoVaga = new System.Windows.Forms.Label();
            this.txtDescricaoVagaONG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnderecoONG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovoVaga = new System.Windows.Forms.Button();
            this.btnExcluirVaga = new System.Windows.Forms.Button();
            this.btnLimparVaga = new System.Windows.Forms.Button();
            this.btnAlterarVaga = new System.Windows.Forms.Button();
            this.btnCriarVaga = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.mkdVaga = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(117, -15);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(400, 117);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 23;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);
            // 
            // txtNomeONG
            // 
            this.txtNomeONG.Enabled = false;
            this.txtNomeONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeONG.Location = new System.Drawing.Point(159, 166);
            this.txtNomeONG.Name = "txtNomeONG";
            this.txtNomeONG.Size = new System.Drawing.Size(185, 26);
            this.txtNomeONG.TabIndex = 0;
            this.txtNomeONG.Leave += new System.EventHandler(this.txtNomeONG_Leave);
            // 
            // lblCadVagasONG
            // 
            this.lblCadVagasONG.AutoSize = true;
            this.lblCadVagasONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCadVagasONG.Location = new System.Drawing.Point(160, 82);
            this.lblCadVagasONG.Name = "lblCadVagasONG";
            this.lblCadVagasONG.Size = new System.Drawing.Size(315, 31);
            this.lblCadVagasONG.TabIndex = 25;
            this.lblCadVagasONG.Text = "Cadastro de Vagas ONG";
            // 
            // lblNomeONG
            // 
            this.lblNomeONG.AutoSize = true;
            this.lblNomeONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNomeONG.Location = new System.Drawing.Point(12, 165);
            this.lblNomeONG.Name = "lblNomeONG";
            this.lblNomeONG.Size = new System.Drawing.Size(141, 25);
            this.lblNomeONG.TabIndex = 26;
            this.lblNomeONG.Text = "Nome da ONG";
            // 
            // lblVaga
            // 
            this.lblVaga.AutoSize = true;
            this.lblVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVaga.Location = new System.Drawing.Point(350, 165);
            this.lblVaga.Name = "lblVaga";
            this.lblVaga.Size = new System.Drawing.Size(59, 25);
            this.lblVaga.TabIndex = 28;
            this.lblVaga.Text = "Vaga";
            // 
            // lblCategoriaVagaONG
            // 
            this.lblCategoriaVagaONG.AutoSize = true;
            this.lblCategoriaVagaONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCategoriaVagaONG.Location = new System.Drawing.Point(149, 215);
            this.lblCategoriaVagaONG.Name = "lblCategoriaVagaONG";
            this.lblCategoriaVagaONG.Size = new System.Drawing.Size(97, 25);
            this.lblCategoriaVagaONG.TabIndex = 29;
            this.lblCategoriaVagaONG.Text = "Categoria";
            // 
            // cbbCategoriaVagaONG
            // 
            this.cbbCategoriaVagaONG.Enabled = false;
            this.cbbCategoriaVagaONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbCategoriaVagaONG.FormattingEnabled = true;
            this.cbbCategoriaVagaONG.Location = new System.Drawing.Point(262, 216);
            this.cbbCategoriaVagaONG.Name = "cbbCategoriaVagaONG";
            this.cbbCategoriaVagaONG.Size = new System.Drawing.Size(147, 28);
            this.cbbCategoriaVagaONG.TabIndex = 2;
            // 
            // lblDescricaoVaga
            // 
            this.lblDescricaoVaga.AutoSize = true;
            this.lblDescricaoVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescricaoVaga.Location = new System.Drawing.Point(12, 257);
            this.lblDescricaoVaga.Name = "lblDescricaoVaga";
            this.lblDescricaoVaga.Size = new System.Drawing.Size(99, 25);
            this.lblDescricaoVaga.TabIndex = 31;
            this.lblDescricaoVaga.Text = "Descrição";
            // 
            // txtDescricaoVagaONG
            // 
            this.txtDescricaoVagaONG.Enabled = false;
            this.txtDescricaoVagaONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescricaoVagaONG.Location = new System.Drawing.Point(117, 257);
            this.txtDescricaoVagaONG.Name = "txtDescricaoVagaONG";
            this.txtDescricaoVagaONG.Size = new System.Drawing.Size(515, 26);
            this.txtDescricaoVagaONG.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Período";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPeriodo.Location = new System.Drawing.Point(117, 303);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(185, 26);
            this.txtPeriodo.TabIndex = 4;
            // 
            // txtHorario
            // 
            this.txtHorario.Enabled = false;
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHorario.Location = new System.Drawing.Point(391, 303);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(179, 26);
            this.txtHorario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(310, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Horário";
            // 
            // txtEnderecoONG
            // 
            this.txtEnderecoONG.Enabled = false;
            this.txtEnderecoONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEnderecoONG.Location = new System.Drawing.Point(117, 351);
            this.txtEnderecoONG.Name = "txtEnderecoONG";
            this.txtEnderecoONG.Size = new System.Drawing.Size(502, 26);
            this.txtEnderecoONG.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Endereço";
            // 
            // btnNovoVaga
            // 
            this.btnNovoVaga.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNovoVaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoVaga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovoVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNovoVaga.Location = new System.Drawing.Point(88, 397);
            this.btnNovoVaga.Name = "btnNovoVaga";
            this.btnNovoVaga.Size = new System.Drawing.Size(85, 35);
            this.btnNovoVaga.TabIndex = 40;
            this.btnNovoVaga.Text = "Novo";
            this.btnNovoVaga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovoVaga.UseVisualStyleBackColor = false;
            this.btnNovoVaga.Click += new System.EventHandler(this.btnNovoVaga_Click);
            // 
            // btnExcluirVaga
            // 
            this.btnExcluirVaga.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExcluirVaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirVaga.Enabled = false;
            this.btnExcluirVaga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluirVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluirVaga.Location = new System.Drawing.Point(544, 397);
            this.btnExcluirVaga.Name = "btnExcluirVaga";
            this.btnExcluirVaga.Size = new System.Drawing.Size(85, 35);
            this.btnExcluirVaga.TabIndex = 45;
            this.btnExcluirVaga.Text = "Excluir";
            this.btnExcluirVaga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirVaga.UseVisualStyleBackColor = false;
            this.btnExcluirVaga.Click += new System.EventHandler(this.btnExcluirVaga_Click);
            // 
            // btnLimparVaga
            // 
            this.btnLimparVaga.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimparVaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparVaga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimparVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimparVaga.Location = new System.Drawing.Point(453, 397);
            this.btnLimparVaga.Name = "btnLimparVaga";
            this.btnLimparVaga.Size = new System.Drawing.Size(85, 35);
            this.btnLimparVaga.TabIndex = 44;
            this.btnLimparVaga.Text = "Limpar";
            this.btnLimparVaga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimparVaga.UseVisualStyleBackColor = false;
            this.btnLimparVaga.Click += new System.EventHandler(this.btnLimparVaga_Click);
            // 
            // btnAlterarVaga
            // 
            this.btnAlterarVaga.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAlterarVaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarVaga.Enabled = false;
            this.btnAlterarVaga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlterarVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterarVaga.Location = new System.Drawing.Point(270, 397);
            this.btnAlterarVaga.Name = "btnAlterarVaga";
            this.btnAlterarVaga.Size = new System.Drawing.Size(85, 35);
            this.btnAlterarVaga.TabIndex = 42;
            this.btnAlterarVaga.Text = "Alterar";
            this.btnAlterarVaga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterarVaga.UseVisualStyleBackColor = false;
            this.btnAlterarVaga.Click += new System.EventHandler(this.btnAlterarVaga_Click);
            // 
            // btnCriarVaga
            // 
            this.btnCriarVaga.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCriarVaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarVaga.Enabled = false;
            this.btnCriarVaga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCriarVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCriarVaga.Location = new System.Drawing.Point(179, 397);
            this.btnCriarVaga.Name = "btnCriarVaga";
            this.btnCriarVaga.Size = new System.Drawing.Size(85, 35);
            this.btnCriarVaga.TabIndex = 41;
            this.btnCriarVaga.Text = "Cadastrar";
            this.btnCriarVaga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCriarVaga.UseVisualStyleBackColor = false;
            this.btnCriarVaga.Click += new System.EventHandler(this.btnCriarVaga_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(3, 434);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(76, 35);
            this.btnVoltar.TabIndex = 46;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(361, 397);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 35);
            this.btnPesquisar.TabIndex = 47;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // mkdVaga
            // 
            this.mkdVaga.Enabled = false;
            this.mkdVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdVaga.Location = new System.Drawing.Point(415, 166);
            this.mkdVaga.Mask = "00000";
            this.mkdVaga.Name = "mkdVaga";
            this.mkdVaga.Size = new System.Drawing.Size(60, 26);
            this.mkdVaga.TabIndex = 1;
            this.mkdVaga.ValidatingType = typeof(int);
            // 
            // frmVagaONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 471);
            this.Controls.Add(this.mkdVaga);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnNovoVaga);
            this.Controls.Add(this.btnExcluirVaga);
            this.Controls.Add(this.btnLimparVaga);
            this.Controls.Add(this.btnAlterarVaga);
            this.Controls.Add(this.btnCriarVaga);
            this.Controls.Add(this.txtEnderecoONG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricaoVagaONG);
            this.Controls.Add(this.lblDescricaoVaga);
            this.Controls.Add(this.cbbCategoriaVagaONG);
            this.Controls.Add(this.lblCategoriaVagaONG);
            this.Controls.Add(this.lblVaga);
            this.Controls.Add(this.lblNomeONG);
            this.Controls.Add(this.lblCadVagasONG);
            this.Controls.Add(this.txtNomeONG);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVagaONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vaga ONG";
            this.Load += new System.EventHandler(this.frmVagaONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblCadVagasONG;
        private System.Windows.Forms.Label lblNomeONG;
        private System.Windows.Forms.Label lblVaga;
        private System.Windows.Forms.Label lblCategoriaVagaONG;
        private System.Windows.Forms.ComboBox cbbCategoriaVagaONG;
        private System.Windows.Forms.Label lblDescricaoVaga;
        private System.Windows.Forms.TextBox txtDescricaoVagaONG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnderecoONG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoVaga;
        private System.Windows.Forms.Button btnExcluirVaga;
        private System.Windows.Forms.Button btnLimparVaga;
        private System.Windows.Forms.Button btnAlterarVaga;
        private System.Windows.Forms.Button btnCriarVaga;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.TextBox txtNomeONG;
        private System.Windows.Forms.MaskedTextBox mkdVaga;
    }
}