using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace InterfaceONGs
{

    public partial class frmVoluntariosONG : Form
    {
        public string NomeVoluntario = "";
        public frmVoluntariosONG()
        {
            InitializeComponent();
        }

        public frmVoluntariosONG(string NomeVoluntario)
        {
            InitializeComponent();
            this.NomeVoluntario = NomeVoluntario;
            txtNome.Text = NomeVoluntario;

            btnAlterar.Enabled = true;
            btnDeletar.Enabled = true;


            txtNome.Enabled = true;
            dtpNasc.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            mkdCPF.Enabled = true;
            mkdCelular.Enabled = true;
            cboEXP.Enabled = true;
            cboSocias.Enabled = true;
            txtURL.Enabled = true;


            flag = false;


        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAdministrador abrirAdmin = new frmAdministrador();
            abrirAdmin.Show();
            this.Hide();
        }



        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);



        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            carregarEXP();
            Redesocial();

            btnNovo.Focus();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtEmail.Text != string.Empty && txtSenha.Text != string.Empty && mkdCPF.Text != string.Empty && mkdCelular.Text != string.Empty && cboEXP.Text != string.Empty && cboSocias.Text != string.Empty && txtURL.Text != string.Empty)
            {
                MySqlCommand comm = new MySqlCommand();

                comm.CommandText = "insert into tbVoluntario (Nome,dataNascimento,Email,password,CPF,Tel,Experiencia,RedeSocial,Url)" + "values (@Nome,@dataNascimento,@Email,SHA2(@password,256),@CPF,@Tel,@Experiencia,@RedeSocial,@Url)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();


                comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                comm.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dtpNasc.Value;
                comm.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
                comm.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = txtSenha.Text;
                comm.Parameters.Add("@CPF", MySqlDbType.VarChar, 16).Value = mkdCPF.Text;
                comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 45).Value = mkdCelular.Text;
                comm.Parameters.Add("@Experiencia", MySqlDbType.VarChar, 12).Value = cboEXP.Text;
                comm.Parameters.Add("@RedeSocial", MySqlDbType.VarChar, 20).Value = cboSocias.Text;
                comm.Parameters.Add("@Url", MySqlDbType.VarChar, 100).Value = txtURL.Text;


                comm.Connection = Conexao.obterConexao();

                comm.ExecuteNonQuery();

                MessageBox.Show(" O Voluntário " + (txtNome.Text) + " cadastrado com sucesso", "Mensagem do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Conexao.fecharConexao();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para cadastrar o voluntário", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            



            
        }
   

        public string codVoluntario = "";

        private void buscainfs()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario  where  nome like '%" + txtNome.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            comm.Parameters.Clear();
            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            dr.Read();
           
                codVoluntario = dr.GetString(0);
                dtpNasc.Text = dr.GetString(2);
                txtEmail.Text = dr.GetString(3);
                txtSenha.Text = dr.GetString(4);
                mkdCPF.Text = dr.GetString(5);
                mkdCelular.Text = dr.GetString(6);
                cboEXP.Text= dr.GetString(7);
                cboEXP.Text = dr.GetString(7);
                cboSocias.Text = dr.GetString(8);
                txtURL.Text = dr.GetString(9);

            Conexao.fecharConexao();

        }


        public void alterarUsuario()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE `tbVoluntario` SET Nome= @Nome,Email = @Email,password = SHA2(@password, 256),CPF =@CPF,Tel = @tel,Experiencia = @Experiencia,Url = @Url WHERE codVoluntario = " + codVoluntario + ";";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = txtSenha.Text;
            comm.Parameters.Add("@CPF", MySqlDbType.VarChar, 45).Value = mkdCPF.Text;
            comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 45).Value = mkdCelular.Text;
            comm.Parameters.Add("@Experiencia", MySqlDbType.VarChar, 12).Value = cboEXP.Text;
            comm.Parameters.Add("@RedeSocial", MySqlDbType.VarChar, 20).Value = cboSocias.Text;
            comm.Parameters.Add("@Url", MySqlDbType.VarChar, 100).Value = txtURL.Text;

            comm.ExecuteNonQuery();


            if (MessageBox.Show("Confirma as alterações de Informações do Voluntário "+txtNome.Text+ " ? ", "Mensagem do sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("As informações do Voluntário "+txtNome.Text+ " foram alteradas ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                LimparCampos();
            }

            Conexao.fecharConexao();
        }
        string pegainfs;
        string pegaVoluntario;


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarUsuario();
        }


        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpNasc.Focus();
            }
        }

        private void dtpNasc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCPF.Focus();
            }
        }

        private void mkdCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCelular.Focus();
            }
        }

        private void mkdCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboEXP.Focus();
            }

        }

        private void cboEXP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboSocias.Focus();
            }
        }

        private void cboSocias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtURL.Focus();
        }



        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult vresp;

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbVoluntario where CPF = @CPF";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@CPF", MySqlDbType.VarChar, 45).Value = mkdCPF.Text;
            comm.ExecuteNonQuery();
            vresp = MessageBox.Show("Deseja apagar o Cadastro do Usuário ?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (vresp == DialogResult.Yes)
            {

                MessageBox.Show("Voluntário excluído com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                LimparCampos();

            }
            else
            {
                MessageBox.Show("Impossível excluir Voluntário. Pois, ele possui vínculo de dados com outros dados no Banco de Dados!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            Conexao.fecharConexao();

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            mkdCPF.ResetText();
            dtpNasc.ResetText();
            txtEmail.Clear();
            txtSenha.Clear();
            mkdCPF.ResetText();
            mkdCelular.ResetText();
            cboEXP.ResetText();
            cboSocias.Text = "";
            txtURL.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarVoluntarios PesquisarVoluntario = new frmPesquisarVoluntarios();
            this.Hide();
            PesquisarVoluntario.Show();
   
        }

        public bool flag = true;

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                buscainfs();
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            dtpNasc.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            mkdCPF.Enabled = true;
            mkdCelular.Enabled = true;
            cboEXP.Enabled = true;
            cboSocias.Enabled = true;
            txtURL.Enabled = true;


            flag = false;

            btnCriar.Enabled = true;
        }


        private void carregarEXP()
        {
            cboEXP.Items.Add("Iniciante");
            cboEXP.Items.Add("Intermediário");
            cboEXP.Items.Add("Avançado");
            cboEXP.Items.Add("Não Possuí");
        }

        private void Redesocial()
        {
            cboSocias.Items.Add("Facebook");
            cboSocias.Items.Add("Instagram");
            cboSocias.Items.Add("Linkdlin");
            cboSocias.Items.Add("Twiter");
            cboSocias.Items.Add("Github");
        }
    }
}
