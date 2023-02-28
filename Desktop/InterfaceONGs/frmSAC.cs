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
using System.Runtime.Versioning;

namespace InterfaceONGs
{
    public partial class frmSAC : Form
    {
        public frmSAC()
        {
            InitializeComponent();
        }
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmSAC_Load(object sender, EventArgs e)
        {


            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            pesquisaFuncionarios();

        }

        public void pesquisaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT  `codFunc` FROM `tbfuncionario` order by codFunc";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            cbocodFunc.Items.Clear();
            while (dr.Read())
            {
                cbocodFunc.Items.Add(dr.GetInt32(0));

            }
            Conexao.fecharConexao();
        }

        private void pesquisanomeFuncionario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "Select * from `tbfuncionario` where codFunc like '%" + cbocodFunc.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            dr = comm.ExecuteReader();

            txtnomeFunc.Text = "";

            while (dr.Read())
            {
                txtnomeFunc.Text = dr.GetString(1);
            }
            Conexao.fecharConexao();
        }

        public string pegaCodFunc = "";
        public string pegaNomeFunc = "";

        private void cbocodFunc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string indic = cbocodFunc.Text;
            string indice = cbocodFunc.SelectedItem.ToString();
            pegaCodFunc = indice;
            pegaNomeFunc = indic;
        }


        private void cbocodFunc_TextChanged(object sender, EventArgs e)
        {
            pesquisanomeFuncionario();
        }

        private void btnselectONG_Click_1(object sender, EventArgs e)
        {
            if (txtnomeONG.Text == string.Empty)
            {
                MessageBox.Show("O nome da ONG está vazio ","Mensagem do Sitema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                mkdCNPJ.Text = "";
            }


            if (txtnomeONG.Text != string.Empty)
            {


                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tbONG where nome like '%" + txtnomeONG.Text + "%'";
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();


                MySqlDataReader dr;
                dr = comm.ExecuteReader();
                dr.Read();

                try
                {
                    mkdCNPJ.Text = dr.GetString(5);

                }
                catch (Exception)
                {
                     MessageBox.Show("O Nome da ONG não existe no Banco de Dados ", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                Conexao.fecharConexao();
            }
        }

        private void btnselectUser_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where CPF = '" + mkdcpfuserONG.Text + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            dr = comm.ExecuteReader();
            dr.Read();
            try
            {
                txtnomeusuarioONG.Text = dr.GetString(1);
                txtemailusuarioONG.Text = dr.GetString(3);
            }
            catch (Exception)
            {

                MessageBox.Show("O CPF informado é invalido", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            Conexao.fecharConexao();

        }

        private void btnselectLoja_Click(object sender, EventArgs e)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVenda where cpfCliente = '" + mkdcpfLoja.Text + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            dr = comm.ExecuteReader();
            dr.Read();

            try
            {
                mkddataLoja.Text = dr.GetString(5);
                txtnomeProd.Text = dr.GetString(2);
            }
            catch (Exception)
            {

                MessageBox.Show("O CPF  informado não possui compra vinculada!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }


            Conexao.fecharConexao();


            //MessageBox.Show("Número de CPF inválido ou incorreto", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            Conexao.fecharConexao();
        }

        private void limparuserONG()
        {
            mkdcpfuserONG.ResetText();
            txtemailusuarioONG.Clear();
            txtnomeusuarioONG.Clear();
            txtSolicitacaoVoluntarioONG.Clear();
            txtSolucaoVoluntarioONG.Clear();

        }
        private void btnconfirmuserONG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar o fechamento da solicitação?", "Solicitação Usuário ONG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Obrigado pelo seu trabalho", "Mensagem do Sistema");
                limparuserONG();
            }
            else
            {
                MessageBox.Show("Fechamento cancelado", "Mensagem do Sistema");
            }
        }

        private void limparONG()
        {
            mkdCNPJ.ResetText();
            txtnomeONG.Clear();
            txtSolicitacoesONG.Clear();
            txtSolucaoONG.Clear();
        }


        private void limparLoja()
        {
            mkddataLoja.ResetText();
            mkdcpfLoja.ResetText();
            txtnomeProd.Clear();
            txtSolicitacaoVenda.Clear();
            txtSolucaoVenda.Clear();
        }

        private void btnconfirmLoja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar o fechamento da solicitação?", "Solicitação Vendas da Loja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Obrigado pelo seu trabalho", "Mensagem do Sistema");
                limparLoja();
            }
            else
            {
                MessageBox.Show("Fechamento cancelado", "Mensagem do Sistema");
            }
        }

        private void mkdcpfuserONG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnselectUser.Focus();
            }
        }

        private void mkdcpfLoja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnselectLoja.Focus();
            }
        }

        private void txtnomeONG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnselectONG.Focus();
            }
        }

        private void btnONG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar o fechamento da solicitação?", "Solicitação ONG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Obrigado pelo seu trabalho", "Mensagem do Sistema");
                limparONG();
            }
            else
            {
                MessageBox.Show("Fechamento cancelado", "Mensagem do Sistema");
            }
        }

        private void mkdcpfuserONG_TextChanged(object sender, EventArgs e)
        {
            if (mkdcpfuserONG.Text == string.Empty)
            {
                MessageBox.Show("Por favor numero de CPF para fazer a pequisa", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnPesquisaVoluntario_Click(object sender, EventArgs e)
        {
            frmPesquisarVoluntarios abrirVoluntario = new frmPesquisarVoluntarios();
            abrirVoluntario.ShowDialog();
        }

        private void btnPesquisarONG_Click(object sender, EventArgs e)
        {
            frmPesquisarONG abrirPesquisar = new frmPesquisarONG();
            abrirPesquisar.ShowDialog();
        }

        private void btnPesquisarVenda_Click(object sender, EventArgs e)
        {
            frmPesquisarVenda abrirPesquisaVenda = new frmPesquisarVenda();
            abrirPesquisaVenda.ShowDialog();
        }

        private void btnFaleConosco_Click(object sender, EventArgs e)
        {
            frmPesquisarContato abrirContato = new frmPesquisarContato();
            abrirContato.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o retorno para Página login ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                frmLogin login= new frmLogin();
                login.Show();
                //esconder a página anterior da página de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("O retorno para Página de login foi cancelado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}