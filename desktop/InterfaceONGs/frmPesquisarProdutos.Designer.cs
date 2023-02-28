namespace InterfaceONGs
{
    partial class frmPesquisarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarProdutos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricaoProdutos = new System.Windows.Forms.TextBox();
            this.rdbNomeProdutos = new System.Windows.Forms.RadioButton();
            this.rdbQuantidade = new System.Windows.Forms.RadioButton();
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.cbocodProduto = new System.Windows.Forms.ComboBox();
            this.rdbcodProduto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pctCamiseta = new System.Windows.Forms.PictureBox();
            this.pctCase = new System.Windows.Forms.PictureBox();
            this.pctChaveiro = new System.Windows.Forms.PictureBox();
            this.pctExclusivo = new System.Windows.Forms.PictureBox();
            this.pctVIP = new System.Windows.Forms.PictureBox();
            this.pctBolsa = new System.Windows.Forms.PictureBox();
            this.pctOculos = new System.Windows.Forms.PictureBox();
            this.pctCaderno = new System.Windows.Forms.PictureBox();
            this.dgvPesquisarProduto = new System.Windows.Forms.DataGridView();
            this.tdpCodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpQuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpDescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpCodigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisarProdutos = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.gpbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCamiseta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctChaveiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExclusivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBolsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCaderno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(253, 105);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 38);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDescricaoProdutos
            // 
            this.txtDescricaoProdutos.Location = new System.Drawing.Point(253, 68);
            this.txtDescricaoProdutos.MaxLength = 50;
            this.txtDescricaoProdutos.Name = "txtDescricaoProdutos";
            this.txtDescricaoProdutos.Size = new System.Drawing.Size(136, 26);
            this.txtDescricaoProdutos.TabIndex = 3;
            this.txtDescricaoProdutos.TabStop = false;
            this.txtDescricaoProdutos.Validated += new System.EventHandler(this.txtDescricaoProdutos_Validated);
            // 
            // rdbNomeProdutos
            // 
            this.rdbNomeProdutos.AutoSize = true;
            this.rdbNomeProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbNomeProdutos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbNomeProdutos.Location = new System.Drawing.Point(212, 27);
            this.rdbNomeProdutos.Name = "rdbNomeProdutos";
            this.rdbNomeProdutos.Size = new System.Drawing.Size(75, 25);
            this.rdbNomeProdutos.TabIndex = 2;
            this.rdbNomeProdutos.Text = "Nome";
            this.rdbNomeProdutos.UseVisualStyleBackColor = true;
            this.rdbNomeProdutos.CheckedChanged += new System.EventHandler(this.rdbNomeProdutos_CheckedChanged);
            // 
            // rdbQuantidade
            // 
            this.rdbQuantidade.AutoSize = true;
            this.rdbQuantidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbQuantidade.Location = new System.Drawing.Point(84, 27);
            this.rdbQuantidade.Name = "rdbQuantidade";
            this.rdbQuantidade.Size = new System.Drawing.Size(116, 25);
            this.rdbQuantidade.TabIndex = 1;
            this.rdbQuantidade.Text = "Quantidade";
            this.rdbQuantidade.UseVisualStyleBackColor = true;
            this.rdbQuantidade.CheckedChanged += new System.EventHandler(this.rdbQuantidade_CheckedChanged);
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.cbocodProduto);
            this.gpbPesquisar.Controls.Add(this.rdbcodProduto);
            this.gpbPesquisar.Controls.Add(this.btnPesquisar);
            this.gpbPesquisar.Controls.Add(this.txtDescricaoProdutos);
            this.gpbPesquisar.Controls.Add(this.label1);
            this.gpbPesquisar.Controls.Add(this.rdbNomeProdutos);
            this.gpbPesquisar.Controls.Add(this.rdbQuantidade);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(12, 96);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(599, 149);
            this.gpbPesquisar.TabIndex = 7;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar por";
            // 
            // cbocodProduto
            // 
            this.cbocodProduto.FormattingEnabled = true;
            this.cbocodProduto.Location = new System.Drawing.Point(446, 25);
            this.cbocodProduto.Name = "cbocodProduto";
            this.cbocodProduto.Size = new System.Drawing.Size(66, 28);
            this.cbocodProduto.TabIndex = 6;
            this.cbocodProduto.Visible = false;
            this.cbocodProduto.SelectedIndexChanged += new System.EventHandler(this.cbocodProduto_SelectedIndexChanged);
            this.cbocodProduto.TextChanged += new System.EventHandler(this.cbocodProduto_TextChanged);
            // 
            // rdbcodProduto
            // 
            this.rdbcodProduto.AutoSize = true;
            this.rdbcodProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbcodProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbcodProduto.Location = new System.Drawing.Point(293, 27);
            this.rdbcodProduto.Name = "rdbcodProduto";
            this.rdbcodProduto.Size = new System.Drawing.Size(165, 25);
            this.rdbcodProduto.TabIndex = 5;
            this.rdbcodProduto.Text = "Código do Produto";
            this.rdbcodProduto.UseVisualStyleBackColor = true;
            this.rdbcodProduto.CheckedChanged += new System.EventHandler(this.rdbcodProduto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // pctCamiseta
            // 
            this.pctCamiseta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCamiseta.Image = ((System.Drawing.Image)(resources.GetObject("pctCamiseta.Image")));
            this.pctCamiseta.Location = new System.Drawing.Point(695, 34);
            this.pctCamiseta.Name = "pctCamiseta";
            this.pctCamiseta.Size = new System.Drawing.Size(33, 16);
            this.pctCamiseta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCamiseta.TabIndex = 113;
            this.pctCamiseta.TabStop = false;
            this.pctCamiseta.Visible = false;
            // 
            // pctCase
            // 
            this.pctCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCase.Image = ((System.Drawing.Image)(resources.GetObject("pctCase.Image")));
            this.pctCase.Location = new System.Drawing.Point(695, 56);
            this.pctCase.Name = "pctCase";
            this.pctCase.Size = new System.Drawing.Size(33, 16);
            this.pctCase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCase.TabIndex = 112;
            this.pctCase.TabStop = false;
            this.pctCase.Visible = false;
            // 
            // pctChaveiro
            // 
            this.pctChaveiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctChaveiro.Image = ((System.Drawing.Image)(resources.GetObject("pctChaveiro.Image")));
            this.pctChaveiro.Location = new System.Drawing.Point(695, 86);
            this.pctChaveiro.Name = "pctChaveiro";
            this.pctChaveiro.Size = new System.Drawing.Size(33, 16);
            this.pctChaveiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctChaveiro.TabIndex = 111;
            this.pctChaveiro.TabStop = false;
            this.pctChaveiro.Visible = false;
            // 
            // pctExclusivo
            // 
            this.pctExclusivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExclusivo.Image = ((System.Drawing.Image)(resources.GetObject("pctExclusivo.Image")));
            this.pctExclusivo.Location = new System.Drawing.Point(656, 81);
            this.pctExclusivo.Name = "pctExclusivo";
            this.pctExclusivo.Size = new System.Drawing.Size(33, 16);
            this.pctExclusivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExclusivo.TabIndex = 110;
            this.pctExclusivo.TabStop = false;
            this.pctExclusivo.Visible = false;
            // 
            // pctVIP
            // 
            this.pctVIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctVIP.Image = ((System.Drawing.Image)(resources.GetObject("pctVIP.Image")));
            this.pctVIP.Location = new System.Drawing.Point(656, 12);
            this.pctVIP.Name = "pctVIP";
            this.pctVIP.Size = new System.Drawing.Size(33, 16);
            this.pctVIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVIP.TabIndex = 109;
            this.pctVIP.TabStop = false;
            this.pctVIP.Visible = false;
            // 
            // pctBolsa
            // 
            this.pctBolsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBolsa.Image = ((System.Drawing.Image)(resources.GetObject("pctBolsa.Image")));
            this.pctBolsa.Location = new System.Drawing.Point(656, 37);
            this.pctBolsa.Name = "pctBolsa";
            this.pctBolsa.Size = new System.Drawing.Size(33, 16);
            this.pctBolsa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBolsa.TabIndex = 108;
            this.pctBolsa.TabStop = false;
            this.pctBolsa.Visible = false;
            // 
            // pctOculos
            // 
            this.pctOculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctOculos.Image = ((System.Drawing.Image)(resources.GetObject("pctOculos.Image")));
            this.pctOculos.Location = new System.Drawing.Point(656, 59);
            this.pctOculos.Name = "pctOculos";
            this.pctOculos.Size = new System.Drawing.Size(33, 16);
            this.pctOculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOculos.TabIndex = 107;
            this.pctOculos.TabStop = false;
            this.pctOculos.Visible = false;
            // 
            // pctCaderno
            // 
            this.pctCaderno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCaderno.Image = ((System.Drawing.Image)(resources.GetObject("pctCaderno.Image")));
            this.pctCaderno.Location = new System.Drawing.Point(695, 12);
            this.pctCaderno.Name = "pctCaderno";
            this.pctCaderno.Size = new System.Drawing.Size(33, 16);
            this.pctCaderno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCaderno.TabIndex = 106;
            this.pctCaderno.TabStop = false;
            this.pctCaderno.Visible = false;
            // 
            // dgvPesquisarProduto
            // 
            this.dgvPesquisarProduto.AllowUserToAddRows = false;
            this.dgvPesquisarProduto.AllowUserToDeleteRows = false;
            this.dgvPesquisarProduto.AllowUserToResizeColumns = false;
            this.dgvPesquisarProduto.AllowUserToResizeRows = false;
            this.dgvPesquisarProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPesquisarProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPesquisarProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPesquisarProduto.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPesquisarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisarProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdpCodigoProduto,
            this.tdpNomeProduto,
            this.tdpValorProduto,
            this.tdpQuantidadeProduto,
            this.tdpDescricaoProduto,
            this.tdpCodigoFuncionario});
            this.dgvPesquisarProduto.Location = new System.Drawing.Point(12, 260);
            this.dgvPesquisarProduto.Name = "dgvPesquisarProduto";
            this.dgvPesquisarProduto.ReadOnly = true;
            this.dgvPesquisarProduto.Size = new System.Drawing.Size(627, 139);
            this.dgvPesquisarProduto.StandardTab = true;
            this.dgvPesquisarProduto.TabIndex = 185;
            this.dgvPesquisarProduto.TabStop = false;
            this.dgvPesquisarProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisarProduto_CellContentClick);
            this.dgvPesquisarProduto.Validated += new System.EventHandler(this.dgvPesquisarProduto_Validated);
            // 
            // tdpCodigoProduto
            // 
            this.tdpCodigoProduto.FillWeight = 56.27266F;
            this.tdpCodigoProduto.HeaderText = "Código do Produto";
            this.tdpCodigoProduto.Name = "tdpCodigoProduto";
            this.tdpCodigoProduto.ReadOnly = true;
            this.tdpCodigoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tdpCodigoProduto.Width = 110;
            // 
            // tdpNomeProduto
            // 
            this.tdpNomeProduto.HeaderText = "Nome do Produto";
            this.tdpNomeProduto.Name = "tdpNomeProduto";
            this.tdpNomeProduto.ReadOnly = true;
            this.tdpNomeProduto.Width = 106;
            // 
            // tdpValorProduto
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.tdpValorProduto.DefaultCellStyle = dataGridViewCellStyle1;
            this.tdpValorProduto.FillWeight = 56.27266F;
            this.tdpValorProduto.HeaderText = "Valor R$";
            this.tdpValorProduto.Name = "tdpValorProduto";
            this.tdpValorProduto.ReadOnly = true;
            this.tdpValorProduto.Width = 68;
            // 
            // tdpQuantidadeProduto
            // 
            this.tdpQuantidadeProduto.HeaderText = "Quantidade";
            this.tdpQuantidadeProduto.Name = "tdpQuantidadeProduto";
            this.tdpQuantidadeProduto.ReadOnly = true;
            this.tdpQuantidadeProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tdpQuantidadeProduto.Width = 87;
            // 
            // tdpDescricaoProduto
            // 
            this.tdpDescricaoProduto.HeaderText = "Descricão";
            this.tdpDescricaoProduto.Name = "tdpDescricaoProduto";
            this.tdpDescricaoProduto.ReadOnly = true;
            this.tdpDescricaoProduto.Width = 80;
            // 
            // tdpCodigoFuncionario
            // 
            this.tdpCodigoFuncionario.HeaderText = "CodFunc que cadastrou";
            this.tdpCodigoFuncionario.Name = "tdpCodigoFuncionario";
            this.tdpCodigoFuncionario.ReadOnly = true;
            this.tdpCodigoFuncionario.Width = 133;
            // 
            // lblPesquisarProdutos
            // 
            this.lblPesquisarProdutos.AutoSize = true;
            this.lblPesquisarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPesquisarProdutos.Location = new System.Drawing.Point(227, 60);
            this.lblPesquisarProdutos.Name = "lblPesquisarProdutos";
            this.lblPesquisarProdutos.Size = new System.Drawing.Size(251, 31);
            this.lblPesquisarProdutos.TabIndex = 189;
            this.lblPesquisarProdutos.Text = "Pesquisar Produtos";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(128, -10);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(396, 111);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 190;
            this.pctLogo.TabStop = false;
            // 
            // frmPesquisarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 405);
            this.Controls.Add(this.lblPesquisarProdutos);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.dgvPesquisarProduto);
            this.Controls.Add(this.pctCamiseta);
            this.Controls.Add(this.pctCase);
            this.Controls.Add(this.pctChaveiro);
            this.Controls.Add(this.pctExclusivo);
            this.Controls.Add(this.pctVIP);
            this.Controls.Add(this.pctBolsa);
            this.Controls.Add(this.pctOculos);
            this.Controls.Add(this.pctCaderno);
            this.Controls.Add(this.gpbPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Produtos";
            this.Load += new System.EventHandler(this.frmPesquisarProdutos_Load);
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCamiseta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctChaveiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExclusivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBolsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCaderno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricaoProdutos;
        private System.Windows.Forms.RadioButton rdbNomeProdutos;
        private System.Windows.Forms.RadioButton rdbQuantidade;
        private System.Windows.Forms.GroupBox gpbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctCamiseta;
        private System.Windows.Forms.PictureBox pctCase;
        private System.Windows.Forms.PictureBox pctChaveiro;
        private System.Windows.Forms.PictureBox pctExclusivo;
        private System.Windows.Forms.PictureBox pctVIP;
        private System.Windows.Forms.PictureBox pctBolsa;
        private System.Windows.Forms.PictureBox pctOculos;
        private System.Windows.Forms.PictureBox pctCaderno;
        private System.Windows.Forms.RadioButton rdbcodProduto;
        private System.Windows.Forms.ComboBox cbocodProduto;
        private System.Windows.Forms.DataGridView dgvPesquisarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpQuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpDescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCodigoFuncionario;
        private System.Windows.Forms.Label lblPesquisarProdutos;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}