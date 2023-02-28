using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;
using Correios.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;
using Org.BouncyCastle.Utilities.Collections;
using System.ServiceModel.Channels;

namespace InterfaceONGs
{
    public partial class frmONG : Form
    {
        public string NomeONG = "";

        public frmONG()
        {
            InitializeComponent();
        }

        public frmONG(string NomeONG)
        {
            InitializeComponent();
            this.NomeONG = NomeONG;
            txtNomeONG.Text = NomeONG;


            if (btnAlterarONG.Enabled = true)
            {
                txtNomeONG.Enabled = true;
                txtEmailONG.Enabled = true;
                txtSenhaONG.Enabled = true;
                mkdTelONG.Enabled = true;
                mkdCNPJONG.Enabled = true;
                txtEnderecoONG.Enabled = true;
                mkdNumONG.Enabled = true;
                txtComplementoONG.Enabled = true;
                mkdCEPONG.Enabled = true;
                txtBairroONG.Enabled = true;
                txtCidadeONG.Enabled = true;
                cboCategoriaONG.Enabled = true;
                txtsobreONG.Enabled = true;
                txtSiteONG.Enabled = true;
                cbbRedeSocial.Enabled = true;
                cbbEstado.Enabled = true;
                txtUrl.Enabled = true;

                btnDeletar.Enabled = true;
                btnVaga.Enabled = true;

                flag = false;
            }


        }





        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        private void frmONG_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            caregaEstado();
        }




        private void limparCampos()
        {
            txtNomeONG.Clear();
            txtEmailONG.Clear();
            txtEnderecoONG.Clear();
            txtComplementoONG.Clear();
            txtsobreONG.Clear();
            txtSiteONG.Clear();
            txtBairroONG.Clear();
            txtCidadeONG.Clear();
            txtUrl.Clear();
            mkdTelONG.Clear();
            mkdNumONG.Clear();
            mkdCNPJONG.Clear();
            mkdCEPONG.Clear();
            txtSenhaONG.Clear();
            cbbRedeSocial.ResetText();
            cbbEstado.ResetText();
            cboCategoriaONG.ResetText();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtNomeONG.Text != string.Empty && txtEmailONG.Text != string.Empty && txtSenhaONG.Text != string.Empty && mkdTelONG.Text != string.Empty && txtEnderecoONG.Text != string.Empty && mkdNumONG.Text != string.Empty && txtComplementoONG.Text != string.Empty && mkdCEPONG.Text != string.Empty && txtBairroONG.Text != string.Empty && txtCidadeONG.Text != string.Empty && cbbEstado.Text != string.Empty && cboCategoriaONG.Text != string.Empty && txtsobreONG.Text != string.Empty)
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbONG (Nome,Email,password,Tel,CNPJ,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Estado,Categoria,Descricao,WebSite,RedeSocial,Url)" + "values (@Nome,@Email,SHA2(@password,256),@Tel,@CNPJ,@Endereco,@Numero,@Complemento,@CEP,@Bairro,@Cidade,@Estado,@Categoria,@Descricao,@WebSite,@RedeSocial,@Url)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();

                comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = txtNomeONG.Text;
                comm.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = txtEmailONG.Text;
                comm.Parameters.Add("@password", MySqlDbType.VarChar, 100).Value = txtSenhaONG.Text;
                comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 18).Value = mkdTelONG.Text;
                comm.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 25).Value = mkdCNPJONG.Text;
                comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 100).Value = txtEnderecoONG.Text;
                comm.Parameters.Add("@Numero", MySqlDbType.VarChar, 10).Value = mkdNumONG.Text;
                comm.Parameters.Add("@Complemento", MySqlDbType.VarChar, 40).Value = txtComplementoONG.Text;
                comm.Parameters.Add("@CEP", MySqlDbType.VarChar, 10).Value = mkdCEPONG.Text;
                comm.Parameters.Add("@Bairro", MySqlDbType.VarChar, 45).Value = txtBairroONG.Text;
                comm.Parameters.Add("@Cidade", MySqlDbType.VarChar, 45).Value = txtCidadeONG.Text;
                comm.Parameters.Add("@Estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
                comm.Parameters.Add("@Categoria", MySqlDbType.VarChar, 15).Value = cboCategoriaONG.Text;
                comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 150).Value = txtsobreONG.Text;
                comm.Parameters.Add("@WebSite", MySqlDbType.VarChar, 75).Value = txtSiteONG.Text;
                comm.Parameters.Add("@RedeSocial", MySqlDbType.VarChar, 35).Value = cbbRedeSocial.Text;
                comm.Parameters.Add("@Url", MySqlDbType.VarChar, 100).Value = txtUrl.Text;

                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();

                comm.ExecuteNonQuery();

                MessageBox.Show("A ONG " + txtNomeONG.Text + "foi cadastrada com sucesso", "Cadastro de ONG", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                Conexao.fecharConexao();
                limparCampos();

                btnVaga.Enabled = true;
            }

            else
            {
                MessageBox.Show("Campos obrigatórios para o cadastrado estão em branco", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void alterarONG()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbONG set Nome = @Nome, Email = @Email, password = SHA2(@password,256) ,Tel = @Tel,CNPJ= @CNPJ,Endereco= @Endereco,Numero = @Numero,Complemento = @Complemento,CEP = @CEP ,Bairro = @Bairro,Cidade = @Cidade,Estado = @Estado ,Categoria = @Categoria,Descricao = @Descricao,WebSite =@WebSite, RedeSocial =@RedeSocial, Url = @Url where codONG =" + codONG + ";";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();

            comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 100).Value = txtNomeONG.Text;
            comm.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = txtEmailONG.Text;
            comm.Parameters.Add("@password", MySqlDbType.VarChar, 100).Value = txtSenhaONG.Text;
            comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 18).Value = mkdTelONG.Text;
            comm.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 25).Value = mkdCNPJONG.Text;
            comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 100).Value = txtEnderecoONG.Text;
            comm.Parameters.Add("@Numero", MySqlDbType.VarChar, 10).Value = mkdNumONG.Text;
            comm.Parameters.Add("@Complemento", MySqlDbType.VarChar, 40).Value = txtComplementoONG.Text;
            comm.Parameters.Add("@CEP", MySqlDbType.VarChar, 10).Value = mkdCEPONG.Text;
            comm.Parameters.Add("@Bairro", MySqlDbType.VarChar, 45).Value = txtBairroONG.Text;
            comm.Parameters.Add("@Cidade", MySqlDbType.VarChar, 45).Value = txtCidadeONG.Text;
            comm.Parameters.Add("@Estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
            comm.Parameters.Add("@Categoria", MySqlDbType.VarChar, 15).Value = cboCategoriaONG.Text;
            comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 150).Value = txtsobreONG.Text;
            comm.Parameters.Add("@WebSite", MySqlDbType.VarChar, 75).Value = txtSiteONG.Text;
            comm.Parameters.Add("@RedeSocial", MySqlDbType.VarChar, 35).Value = cbbRedeSocial.Text;
            comm.Parameters.Add("@Url", MySqlDbType.VarChar, 100).Value = txtUrl.Text;

            comm.ExecuteNonQuery();

            if (MessageBox.Show("Confirma a alteração dos dados da ONG "+txtNomeONG.Text+" ?", "Messangem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("As informações da "+txtNomeONG.Text+" foram alteradas com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            else
            {
                MessageBox.Show("As alteração das informações da "+txtNomeONG.Text+ "foi cancelada", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            Conexao.fecharConexao();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarONG();

            flag = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (txtNomeONG.Enabled == false)
            {
                MessageBox.Show("Impossivel limpar campos vazio", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (MessageBox.Show("Confirmar a limpeza dos campos de cadastramento da ONG?", "Cadastro de ONG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {


                limparCampos();

                MessageBox.Show("Limpeza Concluída", "Mensagem Sistema");
            }
            else
            {
                MessageBox.Show("Limpeza Cancelada", "Mensagem Sistema");
            }
        }




        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmailONG.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenhaONG.Focus();
            }
        }
        private void txtSenhaONG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdTelONG.Focus();
            }

        }



        private void mkdTelFixo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCNPJONG.Focus();
            }
        }

        private void mkdCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEnderecoONG.Focus();
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdNumONG.Focus();
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComplementoONG.Focus();
            }
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cboCategoriaONG.Focus();
            }

        }

        private void cboCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsobreONG.Focus();
            }
        }

        private void txtsobreONG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSiteONG.Focus();
            }

        }

        private void txtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUrl.Focus();
            }
        }


        public bool CEP = true;


        public void carregaCEP(string cep)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            try
            {
                WSCorreios.enderecoERP endereco = ws.consultaCEP(cep);
                txtEnderecoONG.Text = endereco.end;
                txtBairroONG.Text = endereco.bairro;
                txtCidadeONG.Text = endereco.cidade;
                cbbEstado.Text = endereco.uf;

                mkdNumONG.Focus();
            }

            catch (Exception)
            {

                MessageBox.Show("CEP não encontrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                mkdCEPONG.Text = "";
                mkdCEPONG.Focus();
            }
        }


        private void mkdCEP_Leave(object sender, EventArgs e)
        {

            if (txtEnderecoONG.Text != string.Empty)
            {

                CEP = false;

                txtBairroONG.Focus();

            }
            if (txtEnderecoONG.Text == string.Empty)
            {
                carregaCEP(mkdCEPONG.Text);
            }

        }

        private void mkdCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                carregaCEP(mkdCEPONG.Text);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbONG where codONG = " + codONG + ";";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();


            comm.Parameters.Clear();
            comm.Parameters.Add("@codONG", MySqlDbType.VarChar, 10).Value = codONG;

            comm.ExecuteNonQuery();


            if (MessageBox.Show("Confirma a exclusão da ONG do Banco de dados ?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Dados da ONG Excluído com Sucesso !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                limparCampos();
            }
            else
            {
                MessageBox.Show("Dados da ONG para Exclusão Cancelada !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            btnLimparONG.Enabled = true;

            Conexao.fecharConexao();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarONG abrirPesquisa = new frmPesquisarONG();
            this.Hide();
            abrirPesquisa.Show();


            flag = true;

            btnLimparONG.Enabled = true;
            btnDeletar.Enabled = true;
        }

        public bool flag = true;

        private void txtNomeONG_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                carregarONG();
            }


        }

        public string codONG = "";

        private void carregarONG()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbONG where nome like '%" + txtNomeONG.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            dr.Read();
            codONG = dr.GetString(0);
            txtNomeONG.Text = dr.GetString(1);
            txtEmailONG.Text = dr.GetString(2);
            txtSenhaONG.Text = dr.GetString(3);
            mkdTelONG.Text = dr.GetString(4);
            mkdCNPJONG.Text = dr.GetString(5);
            txtEnderecoONG.Text = dr.GetString(6);
            mkdNumONG.Text = dr.GetString(7);
            txtComplementoONG.Text = dr.GetString(8);
            mkdCEPONG.Text = dr.GetString(9);
            txtBairroONG.Text = dr.GetString(10);
            txtCidadeONG.Text = dr.GetString(11);
            cbbEstado.Text = dr.GetString(12);
            cboCategoriaONG.Text = dr.GetString(13);
            txtsobreONG.Text = dr.GetString(14);
            txtSiteONG.Text = dr.GetString(15);
            cbbRedeSocial.Text = dr.GetString(16);
            txtUrl.Text = dr.GetString(17);

            Conexao.fecharConexao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();

            flag = false;

            txtNomeONG.Enabled = true;
            txtEmailONG.Enabled = true;
            txtSenhaONG.Enabled = true;
            mkdTelONG.Enabled = true;
            mkdCNPJONG.Enabled = true;
            txtEnderecoONG.Enabled = true;
            mkdNumONG.Enabled = true;
            txtComplementoONG.Enabled = true;
            mkdCEPONG.Enabled = true;
            txtBairroONG.Enabled = true;
            txtCidadeONG.Enabled = true;
            cboCategoriaONG.Enabled = true;
            txtsobreONG.Enabled = true;
            txtSiteONG.Enabled = true;
            cbbRedeSocial.Enabled = true;
            txtUrl.Enabled = true;
            cbbEstado.Enabled = true;

            btnCriarONG.Enabled = true;

            txtNomeONG.Focus();
        }

        private void btnVoltarONG_Click(object sender, EventArgs e)
        {
            frmAdministrador administrador = new frmAdministrador();
            administrador.Show();
            this.Hide();
        }

        public void caregaEstado()
        {
            cbbEstado.Items.Add("");
            cbbEstado.Items.Add("AC");
            cbbEstado.Items.Add("AL");
            cbbEstado.Items.Add("AP");
            cbbEstado.Items.Add("AM");
            cbbEstado.Items.Add("BA");
            cbbEstado.Items.Add("CE");
            cbbEstado.Items.Add("DF");
            cbbEstado.Items.Add("ES");
            cbbEstado.Items.Add("GO");
            cbbEstado.Items.Add("MA");
            cbbEstado.Items.Add("MT");
            cbbEstado.Items.Add("MS");
            cbbEstado.Items.Add("MG");
            cbbEstado.Items.Add("PA");
            cbbEstado.Items.Add("PB");
            cbbEstado.Items.Add("PR");
            cbbEstado.Items.Add("PE");
            cbbEstado.Items.Add("PI");
            cbbEstado.Items.Add("RJ");
            cbbEstado.Items.Add("RN");
            cbbEstado.Items.Add("RS");
            cbbEstado.Items.Add("RO");
            cbbEstado.Items.Add("RR");
            cbbEstado.Items.Add("SC");
            cbbEstado.Items.Add("SP");
            cbbEstado.Items.Add("SE");
            cbbEstado.Items.Add("TO");
        }

        public void carregarCategoria()
        {

            cboCategoriaONG.Items.Add("Meio Ambiente");
            cboCategoriaONG.Items.Add("Animais");
            cboCategoriaONG.Items.Add("Seres Humanos");
            cboCategoriaONG.Items.Add("Genêro");
            cboCategoriaONG.Items.Add("Escolar");
            cboCategoriaONG.Items.Add(" Reabilitação");
        }

        private void btnVaga_Click(object sender, EventArgs e)
        {
            frmVagaONG Vaga = new frmVagaONG();
            Vaga.Show();
            this.Hide();
        }
    }
}
