namespace InterfaceONGs
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.grpFuncionários = new System.Windows.Forms.GroupBox();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.grpONG = new System.Windows.Forms.GroupBox();
            this.btnCadastrarONG = new System.Windows.Forms.Button();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.lblVoluntarios = new System.Windows.Forms.Label();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.grpLoja = new System.Windows.Forms.GroupBox();
            this.btnWodPress = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSAC = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpFuncionários.SuspendLayout();
            this.grpONG.SuspendLayout();
            this.grpUsuarios.SuspendLayout();
            this.grpLoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFuncionários
            // 
            this.grpFuncionários.Controls.Add(this.btnCadastrarFuncionario);
            this.grpFuncionários.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpFuncionários.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpFuncionários.ForeColor = System.Drawing.Color.Black;
            this.grpFuncionários.Location = new System.Drawing.Point(12, 124);
            this.grpFuncionários.Name = "grpFuncionários";
            this.grpFuncionários.Size = new System.Drawing.Size(137, 126);
            this.grpFuncionários.TabIndex = 0;
            this.grpFuncionários.TabStop = false;
            this.grpFuncionários.Text = "Área Funcionários";
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarFuncionario.Image")));
            this.btnCadastrarFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(10, 22);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(96, 93);
            this.btnCadastrarFuncionario.TabIndex = 0;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadastrarFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // grpONG
            // 
            this.grpONG.Controls.Add(this.btnCadastrarONG);
            this.grpONG.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpONG.ForeColor = System.Drawing.Color.Black;
            this.grpONG.Location = new System.Drawing.Point(167, 128);
            this.grpONG.Name = "grpONG";
            this.grpONG.Size = new System.Drawing.Size(135, 122);
            this.grpONG.TabIndex = 11;
            this.grpONG.TabStop = false;
            this.grpONG.Text = "Área ONG";
            // 
            // btnCadastrarONG
            // 
            this.btnCadastrarONG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadastrarONG.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarONG.Image")));
            this.btnCadastrarONG.Location = new System.Drawing.Point(16, 22);
            this.btnCadastrarONG.Name = "btnCadastrarONG";
            this.btnCadastrarONG.Size = new System.Drawing.Size(96, 90);
            this.btnCadastrarONG.TabIndex = 7;
            this.btnCadastrarONG.Text = "Cadastrar ONG";
            this.btnCadastrarONG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarONG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarONG.UseVisualStyleBackColor = true;
            this.btnCadastrarONG.Click += new System.EventHandler(this.btnCadastrarONG_Click_1);
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.lblVoluntarios);
            this.grpUsuarios.Controls.Add(this.btnCadastrarUsuario);
            this.grpUsuarios.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpUsuarios.ForeColor = System.Drawing.Color.Black;
            this.grpUsuarios.Location = new System.Drawing.Point(341, 137);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(129, 102);
            this.grpUsuarios.TabIndex = 5;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Área Voluntários";
            // 
            // lblVoluntarios
            // 
            this.lblVoluntarios.AutoSize = true;
            this.lblVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoluntarios.Location = new System.Drawing.Point(10, 19);
            this.lblVoluntarios.Name = "lblVoluntarios";
            this.lblVoluntarios.Size = new System.Drawing.Size(0, 24);
            this.lblVoluntarios.TabIndex = 35;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarUsuario.Image")));
            this.btnCadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(14, 19);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(95, 80);
            this.btnCadastrarUsuario.TabIndex = 2;
            this.btnCadastrarUsuario.Text = "Cadastrar Voluntários";
            this.btnCadastrarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // grpLoja
            // 
            this.grpLoja.Controls.Add(this.btnWodPress);
            this.grpLoja.Controls.Add(this.btnLoja);
            this.grpLoja.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grpLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpLoja.Location = new System.Drawing.Point(12, 256);
            this.grpLoja.Name = "grpLoja";
            this.grpLoja.Size = new System.Drawing.Size(228, 109);
            this.grpLoja.TabIndex = 14;
            this.grpLoja.TabStop = false;
            this.grpLoja.Text = "Área Loja";
            // 
            // btnWodPress
            // 
            this.btnWodPress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWodPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWodPress.Image = ((System.Drawing.Image)(resources.GetObject("btnWodPress.Image")));
            this.btnWodPress.Location = new System.Drawing.Point(124, 18);
            this.btnWodPress.Name = "btnWodPress";
            this.btnWodPress.Size = new System.Drawing.Size(93, 83);
            this.btnWodPress.TabIndex = 7;
            this.btnWodPress.Text = "Acessar WordPress";
            this.btnWodPress.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWodPress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWodPress.UseVisualStyleBackColor = true;
            this.btnWodPress.Click += new System.EventHandler(this.btnWodPress_Click);
            // 
            // btnLoja
            // 
            this.btnLoja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoja.Image = ((System.Drawing.Image)(resources.GetObject("btnLoja.Image")));
            this.btnLoja.Location = new System.Drawing.Point(10, 19);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(96, 82);
            this.btnLoja.TabIndex = 5;
            this.btnLoja.Text = "Loja / Venda";
            this.btnLoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(56, -10);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(341, 105);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 22;
            this.pctLogo.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label14.Location = new System.Drawing.Point(130, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 31);
            this.label14.TabIndex = 23;
            this.label14.Text = "Painel Administrativo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSAC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(341, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 102);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de SAC";
            // 
            // btnSAC
            // 
            this.btnSAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSAC.Image = ((System.Drawing.Image)(resources.GetObject("btnSAC.Image")));
            this.btnSAC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSAC.Location = new System.Drawing.Point(11, 22);
            this.btnSAC.Name = "btnSAC";
            this.btnSAC.Size = new System.Drawing.Size(95, 80);
            this.btnSAC.TabIndex = 4;
            this.btnSAC.Text = "SAC";
            this.btnSAC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSAC.UseVisualStyleBackColor = true;
            this.btnSAC.Click += new System.EventHandler(this.btnSAC_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(217, 371);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 35);
            this.btnSair.TabIndex = 34;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 416);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpONG);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.grpLoja);
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.grpFuncionários);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.grpFuncionários.ResumeLayout(false);
            this.grpONG.ResumeLayout(false);
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            this.grpLoja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFuncionários;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.GroupBox grpONG;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.GroupBox grpLoja;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCadastrarONG;
        private System.Windows.Forms.Label lblVoluntarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSAC;
        private System.Windows.Forms.Button btnWodPress;
        private System.Windows.Forms.Button btnSair;
    }
}