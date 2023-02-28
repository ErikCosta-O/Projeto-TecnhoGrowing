namespace InterfaceONGs
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCarteira = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.mkdCPF = new System.Windows.Forms.MaskedTextBox();
            this.mkdCel = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.mkdCPTS = new System.Windows.Forms.MaskedTextBox();
            this.mkdNum = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mkdCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.mkdSerie = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovoFunc = new System.Windows.Forms.Button();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnUserSystem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNome.Location = new System.Drawing.Point(7, 136);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(95, 142);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(343, 19);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCPF.Location = new System.Drawing.Point(7, 176);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(52, 25);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCelular.Location = new System.Drawing.Point(428, 265);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(74, 25);
            this.lblCelular.TabIndex = 7;
            this.lblCelular.Text = "Celular";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(113, 305);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(5);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(343, 19);
            this.txtEndereco.TabIndex = 7;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEndereco.Location = new System.Drawing.Point(7, 303);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(96, 25);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNumero.Location = new System.Drawing.Point(494, 303);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(33, 25);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Nº";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(151, 342);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(5);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(109, 19);
            this.txtComplemento.TabIndex = 9;
            this.txtComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComplemento_KeyDown);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblComplemento.Location = new System.Drawing.Point(7, 339);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(134, 25);
            this.lblComplemento.TabIndex = 13;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblCargo.Location = new System.Drawing.Point(222, 424);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(70, 25);
            this.lblCargo.TabIndex = 15;
            this.lblCargo.Text = "Cargo";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(154, 84);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(361, 34);
            this.lblInfo.TabIndex = 23;
            this.lblInfo.Text = "Cadastro de Funcionário";
            // 
            // lblCarteira
            // 
            this.lblCarteira.AutoSize = true;
            this.lblCarteira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCarteira.Location = new System.Drawing.Point(7, 220);
            this.lblCarteira.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCarteira.Name = "lblCarteira";
            this.lblCarteira.Size = new System.Drawing.Size(67, 25);
            this.lblCarteira.TabIndex = 24;
            this.lblCarteira.Text = "CPTS";
            // 
            // cboCargo
            // 
            this.cboCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCargo.Enabled = false;
            this.cboCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.ItemHeight = 20;
            this.cboCargo.Location = new System.Drawing.Point(292, 425);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(152, 28);
            this.cboCargo.TabIndex = 14;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterar.Location = new System.Drawing.Point(187, 474);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 35);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCriar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriar.Enabled = false;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCriar.Location = new System.Drawing.Point(96, 474);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(85, 35);
            this.btnCriar.TabIndex = 16;
            this.btnCriar.Text = "Cadastrar";
            this.btnCriar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // mkdCPF
            // 
            this.mkdCPF.Enabled = false;
            this.mkdCPF.Location = new System.Drawing.Point(95, 177);
            this.mkdCPF.Mask = "000,000,000-00";
            this.mkdCPF.Name = "mkdCPF";
            this.mkdCPF.Size = new System.Drawing.Size(122, 26);
            this.mkdCPF.TabIndex = 1;
            this.mkdCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdCPF_KeyDown);
            // 
            // mkdCel
            // 
            this.mkdCel.Enabled = false;
            this.mkdCel.Location = new System.Drawing.Point(510, 264);
            this.mkdCel.Mask = "(00)00000-0000";
            this.mkdCel.Name = "mkdCel";
            this.mkdCel.Size = new System.Drawing.Size(124, 26);
            this.mkdCel.TabIndex = 6;
            this.mkdCel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdCel_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(366, 474);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNascimento.Location = new System.Drawing.Point(231, 176);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(188, 25);
            this.lblNascimento.TabIndex = 25;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // dtpNasc
            // 
            this.dtpNasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtpNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNasc.Enabled = false;
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(427, 177);
            this.dtpNasc.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpNasc.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(118, 26);
            this.dtpNasc.TabIndex = 2;
            this.dtpNasc.Value = new System.DateTime(2023, 2, 27, 0, 0, 0, 0);
            this.dtpNasc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpNasc_KeyDown);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(111, -21);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(433, 124);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 26;
            this.ptbLogo.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.Location = new System.Drawing.Point(12, 514);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 35);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmail.Location = new System.Drawing.Point(7, 265);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEMail
            // 
            this.txtEMail.Enabled = false;
            this.txtEMail.Location = new System.Drawing.Point(95, 264);
            this.txtEMail.MaxLength = 50;
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(306, 26);
            this.txtEMail.TabIndex = 5;
            this.txtEMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEMail_KeyDown);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSerie.Location = new System.Drawing.Point(229, 218);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(58, 25);
            this.lblSerie.TabIndex = 29;
            this.lblSerie.Text = "Série";
            // 
            // mkdCPTS
            // 
            this.mkdCPTS.Enabled = false;
            this.mkdCPTS.Location = new System.Drawing.Point(95, 219);
            this.mkdCPTS.Mask = "000,00000,00-0";
            this.mkdCPTS.Name = "mkdCPTS";
            this.mkdCPTS.Size = new System.Drawing.Size(122, 26);
            this.mkdCPTS.TabIndex = 3;
            this.mkdCPTS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdCPTS_KeyDown_1);
            // 
            // mkdNum
            // 
            this.mkdNum.Enabled = false;
            this.mkdNum.Location = new System.Drawing.Point(535, 302);
            this.mkdNum.Mask = "00000";
            this.mkdNum.Name = "mkdNum";
            this.mkdNum.Size = new System.Drawing.Size(55, 26);
            this.mkdNum.TabIndex = 8;
            this.mkdNum.ValidatingType = typeof(int);
            this.mkdNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdNum_KeyDown_1);
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(74, 383);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(5);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(201, 19);
            this.txtBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBairro.Location = new System.Drawing.Point(14, 379);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(63, 25);
            this.lblBairro.TabIndex = 33;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCEP.Location = new System.Drawing.Point(270, 341);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(53, 25);
            this.lblCEP.TabIndex = 34;
            this.lblCEP.Text = "CEP";
            // 
            // mkdCEP
            // 
            this.mkdCEP.Enabled = false;
            this.mkdCEP.Location = new System.Drawing.Point(331, 340);
            this.mkdCEP.Mask = "00000-000";
            this.mkdCEP.Name = "mkdCEP";
            this.mkdCEP.Size = new System.Drawing.Size(88, 26);
            this.mkdCEP.TabIndex = 10;
            this.mkdCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mkdCEP_KeyDown);
            this.mkdCEP.Leave += new System.EventHandler(this.mkdCEP_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(357, 387);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(5);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(201, 19);
            this.txtCidade.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(285, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cidade";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(460, 474);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 35);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // mkdSerie
            // 
            this.mkdSerie.Enabled = false;
            this.mkdSerie.Location = new System.Drawing.Point(292, 217);
            this.mkdSerie.Mask = "0000";
            this.mkdSerie.Name = "mkdSerie";
            this.mkdSerie.Size = new System.Drawing.Size(49, 26);
            this.mkdSerie.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisar.Location = new System.Drawing.Point(275, 474);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 35);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovoFunc
            // 
            this.btnNovoFunc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNovoFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoFunc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovoFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNovoFunc.Location = new System.Drawing.Point(5, 474);
            this.btnNovoFunc.Name = "btnNovoFunc";
            this.btnNovoFunc.Size = new System.Drawing.Size(85, 35);
            this.btnNovoFunc.TabIndex = 15;
            this.btnNovoFunc.Text = "Novo";
            this.btnNovoFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovoFunc.UseVisualStyleBackColor = false;
            this.btnNovoFunc.Click += new System.EventHandler(this.btnNovoFunc_Click);
            // 
            // cbbEstado
            // 
            this.cbbEstado.Enabled = false;
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(571, 384);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(63, 28);
            this.cbbEstado.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEstado.Location = new System.Drawing.Point(566, 361);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 25);
            this.lblEstado.TabIndex = 94;
            this.lblEstado.Text = "Estado";
            // 
            // btnUserSystem
            // 
            this.btnUserSystem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUserSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserSystem.Enabled = false;
            this.btnUserSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUserSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUserSystem.Location = new System.Drawing.Point(551, 474);
            this.btnUserSystem.Name = "btnUserSystem";
            this.btnUserSystem.Size = new System.Drawing.Size(103, 35);
            this.btnUserSystem.TabIndex = 95;
            this.btnUserSystem.Text = "Criar Usuário";
            this.btnUserSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserSystem.UseVisualStyleBackColor = false;
            this.btnUserSystem.Click += new System.EventHandler(this.btnUserSystem_Click);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 551);
            this.ControlBox = false;
            this.Controls.Add(this.btnUserSystem);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnNovoFunc);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.mkdSerie);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mkdCEP);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.mkdNum);
            this.Controls.Add(this.mkdCPTS);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mkdCel);
            this.Controls.Add(this.mkdCPF);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.lblCarteira);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro-Funcionário";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCarteira;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.MaskedTextBox mkdCPF;
        private System.Windows.Forms.MaskedTextBox mkdCel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblSerie;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mkdCPTS;
        private System.Windows.Forms.MaskedTextBox mkdNum;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mkdCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mkdSerie;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovoFunc;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnUserSystem;
    }
}