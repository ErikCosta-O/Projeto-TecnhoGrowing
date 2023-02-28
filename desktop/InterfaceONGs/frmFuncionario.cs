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
using Correios.Net;
using System.Runtime.ConstrainedExecution;

namespace InterfaceONGs
{
    public partial class frmFuncionario : Form
    {

        public string NomeFunc = "";
        public frmFuncionario()

        {
            InitializeComponent();

        }

        public frmFuncionario(string NomeFunc)
        {
            InitializeComponent();
            this.NomeFunc = NomeFunc;
            txtNome.Text = NomeFunc;


            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnUserSystem.Enabled = true;

            if (btnAlterar.Enabled = true)
            {
                flag = false;

                txtNome.Enabled = true;
                mkdCPF.Enabled = true;
                dtpNasc.Enabled = true;
                mkdCPTS.Enabled = true;
                mkdSerie.Enabled = true;
                mkdCel.Enabled = true;
                txtEMail.Enabled = true;
                txtEndereco.Enabled = true;
                mkdNum.Enabled = true;
                txtComplemento.Enabled = true;
                mkdCEP.Enabled = true;
                txtBairro.Enabled = true;
                txtCidade.Enabled = true;
                cbbEstado.Enabled = true;
                cboCargo.Enabled = true;
            }
        }


        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            btnNovoFunc.Focus();

            carregaCombo();
            caregaEstado();
        }


        public void carregaCombo()
        {
            cboCargo.Items.Add("Administrador");
            cboCargo.Items.Add("SAC");
            cboCargo.Items.Add("Venda");

        }


        public void carregaCEP(string cep)
        {
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();
            try
            {
                WSCorreios.enderecoERP endereco = ws.consultaCEP(cep);
                txtEndereco.Text = endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;
                cbbEstado.Text = endereco.uf;

                mkdNum.Focus();
            }

            catch (Exception)
            {

                MessageBox.Show("CEP não encontrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                mkdCEP.Text = "";
                mkdCEP.Focus();
            }


        }

        public bool CEP = false;

        private void mkdCEP_Leave(object sender, EventArgs e)
        {
            if (txtEndereco.Text != string.Empty)
            {
                CEP = true;
            }

            if (txtEndereco.Text == string.Empty)
            {
                carregaCEP(mkdCEP.Text);
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirma a limpeza dos registros de todos os campos", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                limparCampos();

                MessageBox.Show("Limpeza Conclúida", "Mensagem do Sistema");
            }
            else
            {
                MessageBox.Show("Limpeza Cancelada", "Mensagem do Sistema");
            }
        }

        public void limparCampos()
        {

            txtNome.ResetText();
            txtComplemento.ResetText();
            txtEMail.ResetText();
            txtEndereco.ResetText();
            txtCidade.ResetText();
            txtBairro.ResetText();
            mkdCEP.ResetText();
            mkdSerie.ResetText();
            mkdCPF.ResetText();
            mkdCPTS.ResetText();
            mkdCel.ResetText();
            mkdNum.ResetText();
            cboCargo.ResetText();
            dtpNasc.ResetText();
            cbbEstado.ResetText();

        }

        //KeyDown


        private void txtNome_KeyDown(object sender, KeyEventArgs e)

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
                dtpNasc.Focus();
            }


        }

        private void dtpNasc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCPTS.Focus();
            }
        }

        private void mkdregistroFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void mkdCPTS_KeyDown_1(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                mkdSerie.Focus();
            }
        }

        private void mkdSerie_KeyDown_1(object sender, KeyEventArgs e)
        {
            mkdCel.Focus();
        }

        private void mkdCel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEMail.Focus();
            }
        }

        private void txtEMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mkdCEP.Focus();
            }
        }

        private void mkdCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                carregaCEP(mkdCEP.Text);
                mkdNum.Focus();
            }
        }

        private void mkdNum_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComplemento.Focus();
            }
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboCargo.Focus();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != string.Empty && mkdCPF.Text != string.Empty && mkdCPTS.Text != string.Empty && mkdSerie.Text != string.Empty && mkdCel.Text != string.Empty && txtEMail.Text != string.Empty && txtEndereco.Text != string.Empty && mkdNum.Text != string.Empty && txtComplemento.Text != string.Empty && mkdCEP.Text != string.Empty && txtBairro.Text != string.Empty && txtCidade.Text != string.Empty && cbbEstado.Text != string.Empty && cboCargo.Text != string.Empty)
            {
                MySqlCommand comm = new MySqlCommand();


                comm.CommandText = "insert into tbfuncionario (Nome,CPF,dataNascimento,CTPS,Serie,Tel,Email,Endereco,Numero,Complemento,CEP,Bairro,Cidade,Estado,Cargo)" + "values (@Nome,@CPF,@dataNascimento,@CTPS,@Serie,@Tel,@Email,@Endereco,@Numero,@Complemento,@CEP,@Bairro,@Cidade,@Estado,@Cargo)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();

                comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
                comm.Parameters.Add("@CPF", MySqlDbType.VarChar, 16).Value = mkdCPF.Text;
                comm.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dtpNasc.Value;
                comm.Parameters.Add("@CTPS", MySqlDbType.VarChar, 35).Value = mkdCPTS.Text;
                comm.Parameters.Add("@Serie", MySqlDbType.VarChar, 4).Value = mkdSerie.Text;
                comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 15).Value = mkdCPF.Text;
                comm.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = txtEMail.Text;
                comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 80).Value = txtEndereco.Text;
                comm.Parameters.Add("@Numero", MySqlDbType.VarChar, 7).Value = mkdNum.Text;
                comm.Parameters.Add("@Complemento", MySqlDbType.VarChar, 45).Value = txtComplemento.Text;
                comm.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = mkdCEP.Text;
                comm.Parameters.Add("@Bairro", MySqlDbType.VarChar, 45).Value = txtBairro.Text;
                comm.Parameters.Add("@Cidade", MySqlDbType.VarChar, 45).Value = txtCidade.Text;
                comm.Parameters.Add("@Estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
                comm.Parameters.Add("@Cargo", MySqlDbType.VarChar, 15).Value = cboCargo.Text;

                comm.Connection = Conexao.obterConexao();
                comm.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastrado", "Menssagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Conexao.fecharConexao();
                limparCampos();
            }
            else 
            {

                MessageBox.Show("Complete todos os campos para cadastrar o Funcionário", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }




private void btnExcluir_Click(object sender, EventArgs e)
{
    DialogResult vresp;

    MySqlCommand comm = new MySqlCommand();
    comm.CommandText = "delete from tbFuncionario where codFunc = @codFunc";
    comm.CommandType = CommandType.Text;
    comm.Connection = Conexao.obterConexao();

    comm.Parameters.Clear();
    comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 7).Value = codFunc;

    vresp = MessageBox.Show("Deseja apagar o registro dos " + (txtNome.Text) + " ?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
    if (vresp == DialogResult.Yes)
    {
        try
        {
            comm.ExecuteNonQuery();
            MessageBox.Show("Registos excluído com sucesso!!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        catch (Exception)
        {

            MessageBox.Show("Impossível excluir o funcionário, é necessário excluir o usuário de acesso ao sistema primeiro", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

    }
}


//public string = null;

public void AlterarFunc()
{

    MySqlCommand comm = new MySqlCommand();

    comm.CommandText = "update tbfuncionario set Nome = @Nome,CPF = @CPF,dataNascimento = @dataNascimento,CTPS = @CTPS,Serie = @Serie,Tel = @Tel,Email = @Email ,Endereco = @Endereco,Numero = @Numero,Complemento =@Complemento,CEP = @CEP,Bairro = @Bairro,Cidade = @Cidade,Estado = @Estado,Cargo = @Cargo  where codFunc = " + codFunc + ";";

    comm.CommandType = CommandType.Text;
    comm.Connection = Conexao.obterConexao();

    comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 45).Value = txtNome.Text;
    comm.Parameters.Add("@CPF", MySqlDbType.VarChar, 16).Value = mkdCPF.Text;
    comm.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dtpNasc.Value;
    comm.Parameters.Add("@CTPS", MySqlDbType.VarChar, 35).Value = mkdCPTS.Text;
    comm.Parameters.Add("@Serie", MySqlDbType.VarChar, 4).Value = mkdSerie.Text;
    comm.Parameters.Add("@Tel", MySqlDbType.VarChar, 15).Value = mkdCel.Text;
    comm.Parameters.Add("@Email", MySqlDbType.VarChar, 45).Value = txtEMail.Text;
    comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 80).Value = txtEndereco.Text;
    comm.Parameters.Add("@Numero", MySqlDbType.VarChar, 7).Value = mkdNum.Text;
    comm.Parameters.Add("@Complemento", MySqlDbType.VarChar, 45).Value = txtComplemento.Text;
    comm.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = mkdCEP.Text;
    comm.Parameters.Add("@Bairro", MySqlDbType.VarChar, 45).Value = txtBairro.Text;
    comm.Parameters.Add("@Cidade", MySqlDbType.VarChar, 45).Value = txtCidade.Text;
    comm.Parameters.Add("@Estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
    comm.Parameters.Add("@Cargo", MySqlDbType.VarChar, 15).Value = cboCargo.Text;

    try
    {


        comm.ExecuteNonQuery();

        if (MessageBox.Show("Confirma a alteração do Registro do Funcionário " + (txtNome.Text) + " ?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        {
            MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            limparCampos();
        }
        else
        {
            MessageBox.Show("Erro ao alterar os registros", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        Conexao.fecharConexao();
    }
    catch (Exception)
    {

        MessageBox.Show("Existe campos vázios", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }
}

private void btnAlterar_Click(object sender, EventArgs e)
{

    AlterarFunc();

}

private void btnVoltar_Click(object sender, EventArgs e)
{
    frmAdministrador abrirAdmin = new frmAdministrador();
    abrirAdmin.Show();
    this.Hide();
}

private void btnPesquisar_Click(object sender, EventArgs e)
{
    frmPesquisarFuncionario pesquisarFunc = new frmPesquisarFuncionario();
    this.Hide();
    pesquisarFunc.Show();

    flag = true;


    btnAlterar.Enabled = true;
    btnCriar.Enabled = true;
}


public bool flag = true;

private void txtNome_TextChanged(object sender, EventArgs e)
{
    if (flag)
    {
        CarregarDados();
    }


}

private void btnNovoFunc_Click(object sender, EventArgs e)
{
    flag = false;

    limparCampos();

    txtNome.Enabled = true;
    mkdCPF.Enabled = true;
    dtpNasc.Enabled = true;
    mkdCPTS.Enabled = true;
    mkdSerie.Enabled = true;
    mkdCel.Enabled = true;
    txtEMail.Enabled = true;
    txtEndereco.Enabled = true;
    mkdNum.Enabled = true;
    txtComplemento.Enabled = true;
    mkdCEP.Enabled = true;
    txtBairro.Enabled = true;
    txtCidade.Enabled = true;
    cbbEstado.Enabled = true;
    cboCargo.Enabled = true;

    btnExcluir.Enabled = false;
    btnAlterar.Enabled = false;
    btnCriar.Enabled = true;


    txtNome.Focus();

}

public string codFunc = "";

private void CarregarDados()
{
    MySqlCommand comm = new MySqlCommand();
    comm.CommandText = "SELECT * FROM tbfuncionario where nome like '%" + txtNome.Text + "%'";
    comm.CommandType = CommandType.Text;
    comm.Connection = Conexao.obterConexao();

    MySqlDataReader dr;

    dr = comm.ExecuteReader();

    dr.Read();

    codFunc = dr.GetString(0);
    mkdCPF.Text = dr.GetString(2);
    dtpNasc.Text = dr.GetString(3);
    mkdCPTS.Text = dr.GetString(4);
    mkdSerie.Text = dr.GetString(5);
    mkdCel.Text = dr.GetString(6);
    txtEMail.Text = dr.GetString(7);
    txtEndereco.Text = dr.GetString(8);
    mkdNum.Text = dr.GetString(9);
    txtComplemento.Text = dr.GetString(10);
    mkdCEP.Text = dr.GetString(11);
    txtBairro.Text = dr.GetString(12);
    txtCidade.Text = dr.GetString(13);
    cbbEstado.Text = dr.GetString(14);
    cboCargo.Text = dr.GetString(15);

    Conexao.fecharConexao();
}
public void caregaEstado()
{
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

private void btnUserSystem_Click(object sender, EventArgs e)
{
    frmGerenciarUsuarios abrirUser = new frmGerenciarUsuarios();
    abrirUser.Show();
    this.Hide();
}
    }
}
