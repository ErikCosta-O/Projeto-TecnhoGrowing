namespace InterfaceONGs
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tbcVenda = new System.Windows.Forms.TabControl();
            this.tbpVenda = new System.Windows.Forms.TabPage();
            this.mkdvalorVenda = new System.Windows.Forms.MaskedTextBox();
            this.cboCodProd = new System.Windows.Forms.ComboBox();
            this.cboNomeProd = new System.Windows.Forms.ComboBox();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.lblnomeProduto = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblcodProd = new System.Windows.Forms.Label();
            this.txtquantidadeVenda = new System.Windows.Forms.TextBox();
            this.lblquantidadeVenda = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.dtpdataVenda = new System.Windows.Forms.DateTimePicker();
            this.txtNFunc = new System.Windows.Forms.TextBox();
            this.cboCodFunc = new System.Windows.Forms.ComboBox();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.lblclienteCPF = new System.Windows.Forms.Label();
            this.mkdclienteCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbldateVenda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPaineldeVendas = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.tdpCPFCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpcodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpCodFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResumoVenda = new System.Windows.Forms.Label();
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.tbcVenda.SuspendLayout();
            this.tbpVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(121, -21);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(442, 132);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 37;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirmar.Location = new System.Drawing.Point(280, 425);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 35);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(378, 425);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.Location = new System.Drawing.Point(12, 880);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 35);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tbcVenda
            // 
            this.tbcVenda.Controls.Add(this.tbpVenda);
            this.tbcVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbcVenda.Location = new System.Drawing.Point(12, 127);
            this.tbcVenda.Multiline = true;
            this.tbcVenda.Name = "tbcVenda";
            this.tbcVenda.SelectedIndex = 0;
            this.tbcVenda.Size = new System.Drawing.Size(707, 292);
            this.tbcVenda.TabIndex = 159;
            // 
            // tbpVenda
            // 
            this.tbpVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpVenda.Controls.Add(this.mkdvalorVenda);
            this.tbpVenda.Controls.Add(this.cboCodProd);
            this.tbpVenda.Controls.Add(this.cboNomeProd);
            this.tbpVenda.Controls.Add(this.rdbDebito);
            this.tbpVenda.Controls.Add(this.rdbCredito);
            this.tbpVenda.Controls.Add(this.lblnomeProduto);
            this.tbpVenda.Controls.Add(this.lblPagamento);
            this.tbpVenda.Controls.Add(this.lblcodProd);
            this.tbpVenda.Controls.Add(this.txtquantidadeVenda);
            this.tbpVenda.Controls.Add(this.lblquantidadeVenda);
            this.tbpVenda.Controls.Add(this.lblValor);
            this.tbpVenda.Controls.Add(this.dtpdataVenda);
            this.tbpVenda.Controls.Add(this.txtNFunc);
            this.tbpVenda.Controls.Add(this.cboCodFunc);
            this.tbpVenda.Controls.Add(this.lblCodFunc);
            this.tbpVenda.Controls.Add(this.lblclienteCPF);
            this.tbpVenda.Controls.Add(this.mkdclienteCPF);
            this.tbpVenda.Controls.Add(this.lbldateVenda);
            this.tbpVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbpVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpVenda.Location = new System.Drawing.Point(4, 22);
            this.tbpVenda.Name = "tbpVenda";
            this.tbpVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVenda.Size = new System.Drawing.Size(699, 266);
            this.tbpVenda.TabIndex = 0;
            this.tbpVenda.Text = "Venda";
            this.tbpVenda.UseVisualStyleBackColor = true;
            // 
            // mkdvalorVenda
            // 
            this.mkdvalorVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mkdvalorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdvalorVenda.Location = new System.Drawing.Point(577, 188);
            this.mkdvalorVenda.Mask = "$000.00";
            this.mkdvalorVenda.Name = "mkdvalorVenda";
            this.mkdvalorVenda.Size = new System.Drawing.Size(82, 26);
            this.mkdvalorVenda.TabIndex = 185;
            // 
            // cboCodProd
            // 
            this.cboCodProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCodProd.FormattingEnabled = true;
            this.cboCodProd.Location = new System.Drawing.Point(582, 154);
            this.cboCodProd.Name = "cboCodProd";
            this.cboCodProd.Size = new System.Drawing.Size(69, 28);
            this.cboCodProd.TabIndex = 183;
            this.cboCodProd.SelectedIndexChanged += new System.EventHandler(this.cboCodProd_SelectedIndexChanged);
            this.cboCodProd.TextChanged += new System.EventHandler(this.cboCodProd_TextChanged);
            // 
            // cboNomeProd
            // 
            this.cboNomeProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNomeProd.Enabled = false;
            this.cboNomeProd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboNomeProd.FormatString = "abc";
            this.cboNomeProd.FormattingEnabled = true;
            this.cboNomeProd.ItemHeight = 20;
            this.cboNomeProd.Location = new System.Drawing.Point(223, 154);
            this.cboNomeProd.Name = "cboNomeProd";
            this.cboNomeProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboNomeProd.Size = new System.Drawing.Size(160, 28);
            this.cboNomeProd.TabIndex = 182;
            this.cboNomeProd.SelectedIndexChanged += new System.EventHandler(this.cboNomeProd_SelectedIndexChanged);
            this.cboNomeProd.TextChanged += new System.EventHandler(this.cboNomeProd_TextChanged);
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbDebito.Font = new System.Drawing.Font("Arial", 12F);
            this.rdbDebito.Location = new System.Drawing.Point(310, 228);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(73, 22);
            this.rdbDebito.TabIndex = 187;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbCredito.Font = new System.Drawing.Font("Arial", 12F);
            this.rdbCredito.Location = new System.Drawing.Point(223, 228);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(78, 22);
            this.rdbCredito.TabIndex = 186;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            // 
            // lblnomeProduto
            // 
            this.lblnomeProduto.AutoSize = true;
            this.lblnomeProduto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblnomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblnomeProduto.Location = new System.Drawing.Point(49, 153);
            this.lblnomeProduto.Name = "lblnomeProduto";
            this.lblnomeProduto.Size = new System.Drawing.Size(169, 25);
            this.lblnomeProduto.TabIndex = 188;
            this.lblnomeProduto.Text = "Nome  do Produto";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPagamento.Location = new System.Drawing.Point(49, 225);
            this.lblPagamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(112, 25);
            this.lblPagamento.TabIndex = 192;
            this.lblPagamento.Text = "Pagamento";
            // 
            // lblcodProd
            // 
            this.lblcodProd.AutoSize = true;
            this.lblcodProd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblcodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblcodProd.Location = new System.Drawing.Point(401, 153);
            this.lblcodProd.Name = "lblcodProd";
            this.lblcodProd.Size = new System.Drawing.Size(175, 25);
            this.lblcodProd.TabIndex = 189;
            this.lblcodProd.Text = "Código do Produto";
            // 
            // txtquantidadeVenda
            // 
            this.txtquantidadeVenda.BackColor = System.Drawing.Color.White;
            this.txtquantidadeVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantidadeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtquantidadeVenda.Location = new System.Drawing.Point(223, 195);
            this.txtquantidadeVenda.MaxLength = 5;
            this.txtquantidadeVenda.Name = "txtquantidadeVenda";
            this.txtquantidadeVenda.Size = new System.Drawing.Size(100, 26);
            this.txtquantidadeVenda.TabIndex = 184;
            this.txtquantidadeVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblquantidadeVenda
            // 
            this.lblquantidadeVenda.AutoSize = true;
            this.lblquantidadeVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblquantidadeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblquantidadeVenda.Location = new System.Drawing.Point(49, 187);
            this.lblquantidadeVenda.Name = "lblquantidadeVenda";
            this.lblquantidadeVenda.Size = new System.Drawing.Size(114, 25);
            this.lblquantidadeVenda.TabIndex = 191;
            this.lblquantidadeVenda.Text = "Quantidade";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblValor.Location = new System.Drawing.Point(504, 187);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(58, 25);
            this.lblValor.TabIndex = 190;
            this.lblValor.Text = "Valor";
            // 
            // dtpdataVenda
            // 
            this.dtpdataVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpdataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpdataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdataVenda.Location = new System.Drawing.Point(493, 76);
            this.dtpdataVenda.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpdataVenda.MinDate = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            this.dtpdataVenda.Name = "dtpdataVenda";
            this.dtpdataVenda.Size = new System.Drawing.Size(118, 26);
            this.dtpdataVenda.TabIndex = 4;
            this.dtpdataVenda.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // txtNFunc
            // 
            this.txtNFunc.Location = new System.Drawing.Point(347, 26);
            this.txtNFunc.Name = "txtNFunc";
            this.txtNFunc.ReadOnly = true;
            this.txtNFunc.Size = new System.Drawing.Size(199, 26);
            this.txtNFunc.TabIndex = 130;
            // 
            // cboCodFunc
            // 
            this.cboCodFunc.CausesValidation = false;
            this.cboCodFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCodFunc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCodFunc.FormattingEnabled = true;
            this.cboCodFunc.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboCodFunc.Location = new System.Drawing.Point(272, 25);
            this.cboCodFunc.Name = "cboCodFunc";
            this.cboCodFunc.Size = new System.Drawing.Size(48, 28);
            this.cboCodFunc.TabIndex = 0;
            this.cboCodFunc.SelectedIndexChanged += new System.EventHandler(this.cboCodFunc_SelectedIndexChanged);
            this.cboCodFunc.SelectedValueChanged += new System.EventHandler(this.cboCodFunc_SelectedValueChanged);
            this.cboCodFunc.TextChanged += new System.EventHandler(this.cboCodFunc_TextChanged);
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCodFunc.Location = new System.Drawing.Point(49, 24);
            this.lblCodFunc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(209, 25);
            this.lblCodFunc.TabIndex = 125;
            this.lblCodFunc.Text = "Código do Funcionário";
            // 
            // lblclienteCPF
            // 
            this.lblclienteCPF.AutoSize = true;
            this.lblclienteCPF.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblclienteCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblclienteCPF.Location = new System.Drawing.Point(49, 75);
            this.lblclienteCPF.Name = "lblclienteCPF";
            this.lblclienteCPF.Size = new System.Drawing.Size(118, 25);
            this.lblclienteCPF.TabIndex = 114;
            this.lblclienteCPF.Text = "Cliente CPF";
            // 
            // mkdclienteCPF
            // 
            this.mkdclienteCPF.BackColor = System.Drawing.Color.White;
            this.mkdclienteCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mkdclienteCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mkdclienteCPF.Location = new System.Drawing.Point(180, 75);
            this.mkdclienteCPF.Mask = "000,000,000-00";
            this.mkdclienteCPF.Name = "mkdclienteCPF";
            this.mkdclienteCPF.Size = new System.Drawing.Size(121, 26);
            this.mkdclienteCPF.TabIndex = 3;
            // 
            // lbldateVenda
            // 
            this.lbldateVenda.AutoSize = true;
            this.lbldateVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbldateVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbldateVenda.Location = new System.Drawing.Point(342, 76);
            this.lbldateVenda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldateVenda.Name = "lbldateVenda";
            this.lbldateVenda.Size = new System.Drawing.Size(143, 25);
            this.lbldateVenda.TabIndex = 119;
            this.lbldateVenda.Text = "Data da Venda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 161;
            this.pictureBox1.TabStop = false;
            // 
            // lblPaineldeVendas
            // 
            this.lblPaineldeVendas.AutoSize = true;
            this.lblPaineldeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblPaineldeVendas.Location = new System.Drawing.Point(196, 87);
            this.lblPaineldeVendas.Name = "lblPaineldeVendas";
            this.lblPaineldeVendas.Size = new System.Drawing.Size(267, 37);
            this.lblPaineldeVendas.TabIndex = 160;
            this.lblPaineldeVendas.Text = "Painel de Vendas";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.AllowUserToResizeColumns = false;
            this.dgvVenda.AllowUserToResizeRows = false;
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvVenda.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdpCPFCliente,
            this.tdpcodProduto,
            this.tdpProduto,
            this.tdpQuantidade,
            this.tdpValor,
            this.tdpPagamento,
            this.tdpVenda,
            this.tdpCodFunc});
            this.dgvVenda.Location = new System.Drawing.Point(16, 496);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.Size = new System.Drawing.Size(692, 227);
            this.dgvVenda.StandardTab = true;
            this.dgvVenda.TabIndex = 183;
            this.dgvVenda.TabStop = false;
            // 
            // tdpCPFCliente
            // 
            this.tdpCPFCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tdpCPFCliente.FillWeight = 56.27266F;
            this.tdpCPFCliente.HeaderText = "CPF";
            this.tdpCPFCliente.Name = "tdpCPFCliente";
            this.tdpCPFCliente.ReadOnly = true;
            // 
            // tdpcodProduto
            // 
            this.tdpcodProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tdpcodProduto.FillWeight = 56.27266F;
            this.tdpcodProduto.HeaderText = "Código do Produto";
            this.tdpcodProduto.Name = "tdpcodProduto";
            this.tdpcodProduto.ReadOnly = true;
            this.tdpcodProduto.Width = 110;
            // 
            // tdpProduto
            // 
            this.tdpProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tdpProduto.FillWeight = 56.27266F;
            this.tdpProduto.HeaderText = "Produto";
            this.tdpProduto.Name = "tdpProduto";
            this.tdpProduto.ReadOnly = true;
            // 
            // tdpQuantidade
            // 
            this.tdpQuantidade.FillWeight = 56.27266F;
            this.tdpQuantidade.HeaderText = "Quantidade";
            this.tdpQuantidade.Name = "tdpQuantidade";
            this.tdpQuantidade.ReadOnly = true;
            this.tdpQuantidade.Width = 87;
            // 
            // tdpValor
            // 
            this.tdpValor.FillWeight = 56.27266F;
            this.tdpValor.HeaderText = "Valor";
            this.tdpValor.Name = "tdpValor";
            this.tdpValor.ReadOnly = true;
            this.tdpValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tdpValor.Width = 37;
            // 
            // tdpPagamento
            // 
            this.tdpPagamento.FillWeight = 56.27266F;
            this.tdpPagamento.HeaderText = "Pagamento";
            this.tdpPagamento.Name = "tdpPagamento";
            this.tdpPagamento.ReadOnly = true;
            this.tdpPagamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tdpPagamento.Width = 86;
            // 
            // tdpVenda
            // 
            this.tdpVenda.FillWeight = 56.27266F;
            this.tdpVenda.HeaderText = "Data";
            this.tdpVenda.Name = "tdpVenda";
            this.tdpVenda.ReadOnly = true;
            this.tdpVenda.Width = 55;
            // 
            // tdpCodFunc
            // 
            this.tdpCodFunc.HeaderText = "Cod Func";
            this.tdpCodFunc.Name = "tdpCodFunc";
            this.tdpCodFunc.ReadOnly = true;
            this.tdpCodFunc.Width = 72;
            // 
            // lblResumoVenda
            // 
            this.lblResumoVenda.AutoSize = true;
            this.lblResumoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResumoVenda.Location = new System.Drawing.Point(300, 473);
            this.lblResumoVenda.Name = "lblResumoVenda";
            this.lblResumoVenda.Size = new System.Drawing.Size(142, 20);
            this.lblResumoVenda.TabIndex = 184;
            this.lblResumoVenda.Text = "Resumo da Venda";
            // 
            // btnLoja
            // 
            this.btnLoja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLoja.Location = new System.Drawing.Point(330, 729);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(85, 35);
            this.btnLoja.TabIndex = 185;
            this.btnLoja.Text = "Loja";
            this.btnLoja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoja.UseVisualStyleBackColor = false;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(233, 729);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 35);
            this.btnSair.TabIndex = 186;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 765);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLoja);
            this.Controls.Add(this.lblResumoVenda);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPaineldeVendas);
            this.Controls.Add(this.tbcVenda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pctLogo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.tbcVenda.ResumeLayout(false);
            this.tbpVenda.ResumeLayout(false);
            this.tbpVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tbcVenda;
        private System.Windows.Forms.TabPage tbpVenda;
        private System.Windows.Forms.TextBox txtNFunc;
        private System.Windows.Forms.Label lblCodFunc;
        private System.Windows.Forms.DateTimePicker dtpdataVenda;
        private System.Windows.Forms.Label lbldateVenda;
        private System.Windows.Forms.MaskedTextBox mkdclienteCPF;
        private System.Windows.Forms.Label lblclienteCPF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPaineldeVendas;
        private System.Windows.Forms.MaskedTextBox mkdvalorVenda;
        private System.Windows.Forms.ComboBox cboCodProd;
        private System.Windows.Forms.ComboBox cboNomeProd;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.Label lblnomeProduto;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblcodProd;
        private System.Windows.Forms.TextBox txtquantidadeVenda;
        private System.Windows.Forms.Label lblquantidadeVenda;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Label lblResumoVenda;
        private System.Windows.Forms.ComboBox cboCodFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCPFCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpcodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCodFunc;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnSair;
    }
}