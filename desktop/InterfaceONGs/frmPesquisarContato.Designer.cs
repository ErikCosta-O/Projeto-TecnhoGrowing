
namespace InterfaceONGs
{
    partial class frmPesquisarContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarContato));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.cbocodContato = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbEmail = new System.Windows.Forms.RadioButton();
            this.dgvFaleConosco = new System.Windows.Forms.DataGridView();
            this.tdpCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdpMensagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFaleConsco = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.gpbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaleConosco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.rdbCodigo);
            this.gpbPesquisar.Controls.Add(this.cbocodContato);
            this.gpbPesquisar.Controls.Add(this.btnPesquisar);
            this.gpbPesquisar.Controls.Add(this.txtDescricao);
            this.gpbPesquisar.Controls.Add(this.label1);
            this.gpbPesquisar.Controls.Add(this.rdbNome);
            this.gpbPesquisar.Controls.Add(this.rdbEmail);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(9, 143);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(599, 123);
            this.gpbPesquisar.TabIndex = 11;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar por";
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbCodigo.Location = new System.Drawing.Point(235, 27);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigo.TabIndex = 6;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // cbocodContato
            // 
            this.cbocodContato.FormattingEnabled = true;
            this.cbocodContato.Location = new System.Drawing.Point(318, 26);
            this.cbocodContato.Name = "cbocodContato";
            this.cbocodContato.Size = new System.Drawing.Size(84, 28);
            this.cbocodContato.TabIndex = 5;
            this.cbocodContato.Visible = false;
            this.cbocodContato.SelectedIndexChanged += new System.EventHandler(this.cbocodContato_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.txtDescricao.Location = new System.Drawing.Point(109, 74);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(321, 26);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbNome.Location = new System.Drawing.Point(136, 27);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbEmail
            // 
            this.rdbEmail.AutoSize = true;
            this.rdbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEmail.Location = new System.Drawing.Point(34, 27);
            this.rdbEmail.Name = "rdbEmail";
            this.rdbEmail.Size = new System.Drawing.Size(66, 24);
            this.rdbEmail.TabIndex = 1;
            this.rdbEmail.Text = "Email";
            this.rdbEmail.UseVisualStyleBackColor = true;
            this.rdbEmail.CheckedChanged += new System.EventHandler(this.rdbEmail_CheckedChanged);
            // 
            // dgvFaleConosco
            // 
            this.dgvFaleConosco.AllowUserToAddRows = false;
            this.dgvFaleConosco.AllowUserToDeleteRows = false;
            this.dgvFaleConosco.AllowUserToResizeColumns = false;
            this.dgvFaleConosco.AllowUserToResizeRows = false;
            this.dgvFaleConosco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvFaleConosco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFaleConosco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvFaleConosco.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvFaleConosco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaleConosco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdpCodigo,
            this.tdpNome,
            this.tdpEmail,
            this.tdpMensagem});
            this.dgvFaleConosco.Location = new System.Drawing.Point(12, 272);
            this.dgvFaleConosco.Name = "dgvFaleConosco";
            this.dgvFaleConosco.ReadOnly = true;
            this.dgvFaleConosco.Size = new System.Drawing.Size(596, 139);
            this.dgvFaleConosco.StandardTab = true;
            this.dgvFaleConosco.TabIndex = 184;
            this.dgvFaleConosco.TabStop = false;
            // 
            // tdpCodigo
            // 
            this.tdpCodigo.FillWeight = 56.27266F;
            this.tdpCodigo.HeaderText = "Código";
            this.tdpCodigo.Name = "tdpCodigo";
            this.tdpCodigo.ReadOnly = true;
            this.tdpCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tdpCodigo.Width = 65;
            // 
            // tdpNome
            // 
            this.tdpNome.HeaderText = "Nome";
            this.tdpNome.Name = "tdpNome";
            this.tdpNome.ReadOnly = true;
            this.tdpNome.Width = 60;
            // 
            // tdpEmail
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.tdpEmail.DefaultCellStyle = dataGridViewCellStyle1;
            this.tdpEmail.FillWeight = 56.27266F;
            this.tdpEmail.HeaderText = "E-mail";
            this.tdpEmail.Name = "tdpEmail";
            this.tdpEmail.ReadOnly = true;
            this.tdpEmail.Width = 60;
            // 
            // tdpMensagem
            // 
            this.tdpMensagem.HeaderText = "Mensagem";
            this.tdpMensagem.Name = "tdpMensagem";
            this.tdpMensagem.ReadOnly = true;
            this.tdpMensagem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tdpMensagem.Width = 84;
            // 
            // lblFaleConsco
            // 
            this.lblFaleConsco.AutoSize = true;
            this.lblFaleConsco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFaleConsco.Location = new System.Drawing.Point(149, 82);
            this.lblFaleConsco.Name = "lblFaleConsco";
            this.lblFaleConsco.Size = new System.Drawing.Size(338, 31);
            this.lblFaleConsco.TabIndex = 186;
            this.lblFaleConsco.Text = "Pesquisa do Fale Conosco";
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(103, -16);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(384, 111);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 185;
            this.pctLogo.TabStop = false;
            // 
            // frmPesquisarContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 421);
            this.Controls.Add(this.lblFaleConsco);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.dgvFaleConosco);
            this.Controls.Add(this.gpbPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisarContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Fale Conosco";
            this.Load += new System.EventHandler(this.frmPesquisarContato_Load);
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaleConosco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbEmail;
        private System.Windows.Forms.ComboBox cbocodContato;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.DataGridView dgvFaleConosco;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdpMensagem;
        private System.Windows.Forms.Label lblFaleConsco;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}