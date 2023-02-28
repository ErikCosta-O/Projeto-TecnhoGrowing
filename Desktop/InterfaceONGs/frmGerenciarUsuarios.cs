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

namespace InterfaceONGs
{
    public partial class frmGerenciarUsuarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAdministrador abrir = new frmAdministrador();
            abrir.Show();
            this.Visible = false;
        }

        private void frmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            pesquisaFuncionarios();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionario pesquisarFunc = new frmPesquisarFuncionario();
            pesquisarFunc.Show();

            pesquisaFuncionarios();
        }

        //pesquisar funcionarios
        public void pesquisaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbFuncionario order by codFunc";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();

                cbbCodigo.Items.Clear();
                while (dr.Read())
                {
                    cbbCodigo.Items.Add(dr.GetInt32(0));
                }

                Conexao.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Por Favor inserir o registro do funcionário!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar o Banco de dados!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        public string pegaCodFunc = "";
        private void cbbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cbbCodigo.SelectedItem.ToString();
            carregaFuncionario(indice);
            carregaUsuario(indice);
            pegaCodFunc = indice;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty && txtNomeUsu.Text == String.Empty && txtSenhaUsu.Text == string.Empty && txtConfirmaSenha.Text == string.Empty)
            {
                MessageBox.Show("Atenção é necessário possuir dados nos campos para fazer a limpeza dos registros!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                limparCampos();

                pesquisaFuncionarios();

                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }

          
        }

        public void carregaUsuario(string i)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.nome, usu.password from tbUsuario as usu inner join tbFuncionario as funcon usu.codFunc = func.codFunc where codUsu =" + i + "";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            try
            {
                dr = comm.ExecuteReader();
                dr.Read();

                txtNomeUsu.Text = dr.GetString(0);
                txtSenhaUsu.Text = dr.GetString(1);


                Conexao.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Funcionário não possui usuário criado!!!", "Mensagem do sistema");
                txtNomeUsu.Clear(); txtSenhaUsu.Clear(); txtNomeUsu.Focus();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar o Banco de dados", "Mensagem do sistema");

            }
        }

        public void limparCampos()
        {
            cbbCodigo.Items.Clear();
            txtNome.Clear();
            txtNomeUsu.Clear();
            txtSenhaUsu.Clear();
            txtConfirmaSenha.Clear();
            cbbCodigo.Text = "";
            btnVoltar.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            txtNomeUsu.Enabled= true;
            txtSenhaUsu.Enabled= true;
            txtConfirmaSenha.Enabled= true;

            if ((txtNomeUsu.Text == String.Empty) && (txtSenhaUsu.Text == String.Empty) && (txtConfirmaSenha.Text == String.Empty))
            {
                MessageBox.Show("Para cadastrar um usuário no sistema, é necessário possuir registros nos campos", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparUsuario();
            }
            else if (!txtSenhaUsu.Text.Equals(txtConfirmaSenha.Text))
            {
                MessageBox.Show("Senha e contrasenha são diferentes!!!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtSenhaUsu.Clear();
                txtConfirmaSenha.Clear();
                txtSenhaUsu.Focus();
            }
            else
            {
                pegaCodFunc = cbbCodigo.Text;
                cadastrarUsuario(pegaCodFunc);
            }

        }

        public void cadastrarUsuario(string codfunc)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbUsuarios(nome,password,codFunc)values(@nome,SHA2(@senha,256)," + codfunc + ");";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNomeUsu.Text;
            comm.Parameters.Add("@password", MySqlDbType.VarChar, 50).Value = txtSenhaUsu.Text;


            comm.Connection = Conexao.obterConexao();

            try
            {
                comm.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            catch (Exception)
            {

                MessageBox.Show("Usuário já existe no banco de dados!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            Conexao.fecharConexao();
        }

        private void cbbCodigo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string recebe = cbbCodigo.SelectedItem.ToString();
            carregaFuncionario(recebe);
            carregaUsuarioSenha(recebe);


        }
        public void carregaUsuarioSenha(string codfunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.codUsuario,usu.Login,usu.password from tbUsuario as usu inner join " + "tbFuncionario as func on usu.codFunc = func.codFunc " + "where func.codFunc = " + codfunc + ";";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            dr.Read();
            try
            {
                codigoUsuario = Convert.ToString(dr.GetInt32(0));
                txtNomeUsu.Text = dr.GetString(1);
                txtSenhaUsu.Text = dr.GetString(2);
            }
            catch (Exception)
            {
                MessageBox.Show("O Funcionário não possui usuário criado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limparUsuario();
            }
            Conexao.fecharConexao();

        }
        public void limparUsuario()
        {
            txtNomeUsu.Clear();
            txtSenhaUsu.Clear();
            txtConfirmaSenha.Clear();
            txtNomeUsu.Focus();

        }

        public void carregaFuncionario(string codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select Nome from tbFuncionario where codFunc = " + codFunc + ";";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            dr.Read();

            txtNome.Text = dr.GetString(0);

            Conexao.fecharConexao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            alterarUsuario(codigoUsuario);
        }

        public string codigoUsuario = null;

        public void alterarUsuario(string codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuario set password = SHA2(@password,256) where codUsuario = " + codUsu + "; ";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();

            comm.Parameters.Add("@password", MySqlDbType.VarChar, 50).Value = txtSenhaUsu.Text;

            comm.ExecuteNonQuery();
            if (MessageBox.Show("Confirma a alteração da senha ?","Mensagem do Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Alteração Cancelada!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            Conexao.fecharConexao();

        }

        public void deletarUsuario(string codUsuario)
        {
            DialogResult vresp;

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbUsuario where codUsuario= @codUsuario";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsuario", MySqlDbType.VarChar, 7).Value = codUsuario;

            vresp = MessageBox.Show("Deseja apagar o Usuario?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (vresp == DialogResult.Yes)
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("O Usuário foi excluído com sucesso!!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                limparCampos();
            }
            else
            {

                MessageBox.Show("Erro ao deletar o  Usuário foi deletado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty && txtNomeUsu.Text == String.Empty && txtSenhaUsu.Text == string.Empty && txtConfirmaSenha.Text == string.Empty)
            {
                MessageBox.Show("Atenção é necessário possuir dados nos campos para fazer a exclusão do usuário do sistema!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
            else if(MessageBox.Show("Confirma exclusão do usuário ao sistema ?+","Após a exclusão não será possivel acessar o sistema utlizando os dados apagados.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)==DialogResult.OK)
            {
                MessageBox.Show("O usuário foi removido, lembre-se as informações agora não serão mais validas para o acesso", "Mensagem do Sistema");
                deletarUsuario(codigoUsuario);
            }


            
        }

        private void cbbCodigo_SelectedValueChanged(object sender, EventArgs e)
        {

            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;

            txtNomeUsu.Enabled = true;
            txtSenhaUsu.Enabled = true;
            txtConfirmaSenha.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbbCodigo.Focus();
            txtNomeUsu.Enabled= true;
            txtSenhaUsu.Enabled= true;
            txtConfirmaSenha.Enabled= true;


            btnCadastrar.Enabled = true;
        }
    }
}
