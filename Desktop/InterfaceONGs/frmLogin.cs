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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System.Threading;

namespace InterfaceONGs
{
    public partial class frmLogin : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmLoguin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        void PausaComEntrar()
        {
            Thread.Sleep(5000);
        }

        //criando variavel para acesso ao sistema
        private bool logado = false;
        public int erros = 0;



        // manando infs para a frmHome
        public bool flag = true;

        public static string l0gin = "";


        private void btnEntrar_Click(object sender, EventArgs e)
        {

            logado = acessaSistema();

            if (logado)
            {
                    //frmHome abrir = new frmHome();
                    //this.Hide();

                l0gin = txtUsuario.Text.ToString();
                frmHome enviar = new frmHome(l0gin);
                enviar.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                while (erros == 6)
                {
                    
                }
                erros++;
                if (erros == 1)
                {
                    MessageBox.Show("Você errou o seu usuário ou senha. Você tem 4 tentativas, ao persistir com dados incorretos terá que aguarda 1 minuto para tentar novamente.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                MessageBox.Show("Atenção, você fez " + erros + " tentativa", " Você tem 4 tentativas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

             if (erros >=5)
             {
                MessageBox.Show("Você fez muitas tentativas de acesso ao Banco de Dados com dados incorretos,aguarde 1 minuto para tentar novamente", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btnEntrar.Enabled = false;
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                btnLimpar.Enabled = false;
                erros = 5;
                Thread.Sleep(36000);
                limparTela();
                erros= 0;
                txtUsuario.Enabled = true;
                btnLimpar.Enabled = true;
                txtUsuario.Focus();

             }

        }

        public void limparTela()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
            ckbMostrarSenha.Checked = false;
        }



        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtUsuario.Text != string.Empty)
            {

                txtSenha.Enabled = true;
                txtSenha.Focus();
                ckbMostrarSenha.Enabled = true;
            }
            if (e.KeyCode == Keys.Enter && txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Informe um login para obter acesso ao campo de senha", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_TabStopChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty)
            {

                txtSenha.Enabled = true;
                txtSenha.Focus();
                ckbMostrarSenha.Enabled = true;
            }
            else
            {
                MessageBox.Show("Informe um login para obter acesso ao campo de senha", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtSenha.Text != string.Empty)
            {
                ckbMostrarSenha.Enabled = true;
                btnEntrar.Enabled = true;
                btnEntrar.Focus();
            }
            if (e.KeyCode == Keys.Enter && txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Informe um senha para obter acesso ao Mostrar a senha e ao botão entrar", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtSenha_TabStopChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != string.Empty)
            {
                ckbMostrarSenha.Enabled = true;
                btnEntrar.Enabled = true;
                btnEntrar.Focus();
            }
            else
            {
                MessageBox.Show("Informe uma senha para obter acesso ao Mostrar a senha e ao botão entrar", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ckbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = (char)0;
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        public bool acessaSistema()
        {

            bool resultado = false;

            //Instanciando a classe MySqlCommand para executar comando de SQL no C#
            MySqlCommand comm = new MySqlCommand();


            //Executando comandos de sql no C#
            comm.CommandText = "select * from tbUsuario where Login='" + txtUsuario.Text + "' and password='" + txtSenha.Text + "'";
            comm.CommandType = CommandType.Text;

            //Abrir a conexão com o banco de dados
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader dr;

            try
            {
                //carregando no DataReader os dados
                dr = comm.ExecuteReader();

                //verificando se existe valor na pesquisa do SQL no BD.
                resultado = dr.HasRows;

                //fecha a conexão do BD
                Conexao.fecharConexao();


            }

            catch (Exception)
            {

                MessageBox.Show("Banco de dados desconectado, verifique se a conexão está ligada", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); ;
            }
            //Retorna o valor
            return resultado;
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == string.Empty && txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Não é possivel limpar campos em branco", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                limparTela();
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o encerramento do programa ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Application.Exit();
            }

        }



        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
