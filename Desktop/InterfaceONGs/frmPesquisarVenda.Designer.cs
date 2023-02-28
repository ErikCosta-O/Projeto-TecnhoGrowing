namespace InterfaceONGs
{
    partial class frmPesquisarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarVenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.cbocodVenda = new System.Windows.Forms.ComboBox();
            this.rdbcodVenda = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricaoVenda = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rdbPagamento = new System.Windows.Forms.RadioButton();
            this.rdbQuantidadeVenda = new System.Windows.Forms.RadioButton();
            this.dgvPesquisarProduto = new System.Windows.Forms.DataGridView();
            this.lblPesquisadeVenda = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.tdpCodigodaVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpCodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpQuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpCPFCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpDataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpCodigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.cbocodVenda);
            this.gpbPesquisar.Controls.Add(this.rdbcodVenda);
            this.gpbPesquisar.Controls.Add(this.btnPesquisar);
            this.gpbPesquisar.Controls.Add(this.txtDescricaoVenda);
            this.gpbPesquisar.Controls.Add(this.lblDescricao);
            this.gpbPesquisar.Controls.Add(this.rdbPagamento);
            this.gpbPesquisar.Controls.Add(this.rdbQuantidadeVenda);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(27, 131);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(599, 190);
            this.gpbPesquisar.TabIndex = 8;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar por";
            // 
            // cbocodVenda
            // 
            this.cbocodVenda.FormattingEnabled = true;
            this.cbocodVenda.Location = new System.Drawing.Point(451, 52);
            this.cbocodVenda.Name = "cbocodVenda";
            this.cbocodVenda.Size = new System.Drawing.Size(66, 28);
            this.cbocodVenda.TabIndex = 6;
            this.cbocodVenda.Visible = false;
            this.cbocodVenda.SelectedIndexChanged += new System.EventHandler(this.cbocodVenda_SelectedIndexChanged);
            // 
            // rdbcodVenda
            // 
            this.rdbcodVenda.AutoSize = true;
            this.rdbcodVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbcodVenda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbcodVenda.Location = new System.Drawing.Point(413, 21);
            this.rdbcodVenda.Name = "rdbcodVenda";
            this.rdbcodVenda.Size = new System.Drawing.Size(156, 25);
            this.rdbcodVenda.TabIndex = 5;
            this.rdbcodVenda.Text = "Código da Venda";
            this.rdbcodVenda.UseVisualStyleBackColor = true;
            this.rdbcodVenda.CheckedChanged += new System.EventHandler(this.rdbcodVenda_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(253, 132);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 38);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDescricaoVenda
            // 
            this.txtDescricaoVenda.Location = new System.Drawing.Point(222, 64);
            this.txtDescricaoVenda.MaxLength = 50;
            this.txtDescricaoVenda.Name = "txtDescricaoVenda";
            this.txtDescricaoVenda.Size = new System.Drawing.Size(105, 26);
            this.txtDescricaoVenda.TabIndex = 3;
            this.txtDescricaoVenda.TabStop = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(136, 70);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // rdbPagamento
            // 
            this.rdbPagamento.AutoSize = true;
            this.rdbPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbPagamento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbPagamento.Location = new System.Drawing.Point(253, 21);
            this.rdbPagamento.Name = "rdbPagamento";
            this.rdbPagamento.Size = new System.Drawing.Size(115, 25);
            this.rdbPagamento.TabIndex = 2;
            this.rdbPagamento.Text = "Pagamento";
            this.rdbPagamento.UseVisualStyleBackColor = true;
            this.rdbPagamento.CheckedChanged += new System.EventHandler(this.rdbPagamento_CheckedChanged);
            // 
            // rdbQuantidadeVenda
            // 
            this.rdbQuantidadeVenda.AutoSize = true;
            this.rdbQuantidadeVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbQuantidadeVenda.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbQuantidadeVenda.Location = new System.Drawing.Point(107, 21);
            this.rdbQuantidadeVenda.Name = "rdbQuantidadeVenda";
            this.rdbQuantidadeVenda.Size = new System.Drawing.Size(116, 25);
            this.rdbQuantidadeVenda.TabIndex = 1;
            this.rdbQuantidadeVenda.Text = "Quantidade";
            this.rdbQuantidadeVenda.UseVisualStyleBackColor = true;
            this.rdbQuantidadeVenda.CheckedChanged += new System.EventHandler(this.rdbQuantidadeVenda_CheckedChanged);
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
            this.tdpCodigodaVenda,
            this.tdpCodigoProduto,
            this.tdpNomeProduto,
            this.tdpValorProduto,
            this.tdpQuantidadeProduto,
            this.tdpCPFCliente,
            this.tdpDataVenda,
            this.tdpCodigoFuncionario});
            this.dgvPesquisarProduto.Location = new System.Drawing.Point(12, 327);
            this.dgvPesquisarProduto.Name = "dgvPesquisarProduto";
            this.dgvPesquisarProduto.ReadOnly = true;
            this.dgvPesquisarProduto.Size = new System.Drawing.Size(627, 139);
            this.dgvPesquisarProduto.StandardTab = true;
            this.dgvPesquisarProduto.TabIndex = 187;
            this.dgvPesquisarProduto.TabStop = false;
            // 
            // lblPesquisadeVenda
            // 
            this.lblPesquisadeVenda.AutoSize = true;
            this.lblPesquisadeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblPesquisadeVenda.Location = new System.Drawing.Point(191, 78);
            this.lblPesquisadeVenda.Name = "lblPesquisadeVenda";
            this.lblPesquisadeVenda.Size = new System.Drawing.Size(294, 37);
            this.lblPesquisadeVenda.TabIndex = 189;
            this.lblPesquisadeVenda.Text = "Pesquisa de Venda";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(74, -17);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(442, 132);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 188;
            this.pctLogo.TabStop = false;
            // 
            // tdpCodigodaVenda
            // 
            this.tdpCodigodaVenda.HeaderText = "Código da Venda";
            this.tdpCodigodaVenda.Name = "tdpCodigodaVenda";
            this.tdpCodigodaVenda.ReadOnly = true;
            this.tdpCodigodaVenda.Width = 105;
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
            this.tdpNomeProduto.Width = 105;
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
            // tdpCPFCliente
            // 
            this.tdpCPFCliente.HeaderText = "CPF Cliente";
            this.tdpCPFCliente.Name = "tdpCPFCliente";
            this.tdpCPFCliente.ReadOnly = true;
            this.tdpCPFCliente.Width = 80;
            // 
            // tdpDataVenda
            // 
            this.tdpDataVenda.HeaderText = "Data Venda";
            this.tdpDataVenda.Name = "tdpDataVenda";
            this.tdpDataVenda.ReadOnly = true;
            this.tdpDataVenda.Width = 82;
            // 
            // tdpCodigoFuncionario
            // 
            this.tdpCodigoFuncionario.HeaderText = "Responsável pela baixa";
            this.tdpCodigoFuncionario.Name = "tdpCodigoFuncionario";
            this.tdpCodigoFuncionario.ReadOnly = true;
            this.tdpCodigoFuncionario.Width = 110;
            // 
            // frmPesquisarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 478);
            this.Controls.Add(this.lblPesquisadeVenda);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.dgvPesquisarProduto);
            this.Controls.Add(this.gpbPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Venda";
            this.Load += new System.EventHandler(this.frmPesquisarVenda_Load);
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisar;
        private System.Windows.Forms.ComboBox cbocodVenda;
        private System.Windows.Forms.RadioButton rdbcodVenda;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricaoVenda;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rdbPagamento;
        private System.Windows.Forms.RadioButton rdbQuantidadeVenda;
        private System.Windows.Forms.DataGridView dgvPesquisarProduto;
        private System.Windows.Forms.Label lblPesquisadeVenda;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCodigodaVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpQuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCPFCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpDataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCodigoFuncionario;
    }
}