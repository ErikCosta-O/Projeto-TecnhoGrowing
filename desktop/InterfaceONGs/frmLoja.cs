using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using InterfaceONGs.WSCorreios;
using MySql.Data.MySqlClient;
using Exception = System.Exception;

namespace InterfaceONGs
{
    public partial class frmLoja : Form
    {

        public string Loja = "";


        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmLoja()
        {
            InitializeComponent();
        }

        public frmLoja(string Loja)
        {
            InitializeComponent();
            this.Loja = Loja;
            txtnomeProd.Text = Loja;

        }
        private void frmLoja_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            pesquisaFuncionarios();
        }


        private void limparCampos()
        {
            txtnomeProd.Clear();
            mkdQuantidade.ResetText();
            cbbCodigoFunc.Text = "";
            txtnomeProd.Text = "";
            txtNome.Clear();
            mkdQuantidade.ResetText();
            mkdValorLoja.ResetText();
            rdbAcessoVIP.Checked = false;
            rdbBolsa.Checked = false;
            rdbChaveiro.Checked = false;
            rdbConteudoExcluiso.Checked = false;
            rdbOculos.Checked = false;
            rdbCaderno.Checked = false;
            rdbCamiseta.Checked = false;
            rdbConteudoExcluiso.Checked = false;
        }



        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtdescProd.Text == string.Empty && txtnomeProd.Text == string.Empty && mkdQuantidade.Text == string.Empty && mkdValorLoja.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos para cadastrar um produto","Mensagem do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    MySqlCommand comm = new MySqlCommand();

                    comm.CommandText = "insert into tbLoja (nomeProduto,Valor,Quantidade,Descricao,codFunc)" + "values(@nomeProduto,@Valor,@Quantidade,@Descricao,@codFunc)";
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.Clear();

                    comm.Parameters.Add("@nomeProduto", MySqlDbType.VarChar, 45).Value = txtnomeProd.Text;
                    comm.Parameters.Add("@Valor", MySqlDbType.VarChar, 10).Value = mkdValorLoja.Text;
                    comm.Parameters.Add("@Quantidade", MySqlDbType.VarChar, 5).Value = mkdQuantidade.Text;
                    comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 45).Value = txtdescProd.Text;
                    comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 2).Value = cbbCodigoFunc.Text;
                    comm.Connection = Conexao.obterConexao();

                    comm.ExecuteNonQuery();

                    if (MessageBox.Show("Confirma o cadastro do " + txtnomeProd.Text + "  na loja ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        MessageBox.Show("O " + txtnomeProd.Text + " foi cadastrado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCampos();
                    }

                    Conexao.fecharConexao();

                }
                catch (Exception)
                {
                    MessageBox.Show("Preencha todos os campos para cadastrar um produto", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirmar a limpeza dos campos de cadastramento da Loja ?", "Cadastro de Produtos da loja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {

                limparCampos();

                MessageBox.Show("Limpeza Conclúida", "Mensagem do Sistema");

            }
            else
            {
                MessageBox.Show("Limpeza Cancelada", "Mensagem do Sistema");
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            frmAdministrador abrirAdmin = new frmAdministrador();
            abrirAdmin.Show();
            this.Hide();
        }

        //Editei
        public void pesquisaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codFunc` FROM `tbfuncionario` where `codFunc` order by codFunc";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            cbbCodigoFunc.Items.Clear();
            while (dr.Read())
            {
                cbbCodigoFunc.Items.Add(dr.GetInt32(0));
            }
            Conexao.fecharConexao();
        }

        private void buscanomeFunc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionario  where  codFunc like '%" + cbbCodigoFunc.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            cbbCodigoFunc.Text = "";
            txtNome.Text = "";

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                txtNome.Text = dr.GetString(1);

            }
            Conexao.fecharConexao();

        }

        string pegaCodFunc;
        string pegaNomeFunc;

        private void cbbCodigoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cbbCodigoFunc.SelectedItem.ToString();
            string indic = cbbCodigoFunc.Text.ToString();

            string pegaNomeFunc = indic;
            string pegaCodFunc = indice;
        }

        // Problema de carregar o Código do Func, pois está carregando o codFunc(Se comentar ele funciona)

        private void cbbCodigoFunc_TextChanged(object sender, EventArgs e)
        {
            buscanomeFunc();

        }

        public string codLoja = "";
        private void buscainfs()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbLoja where  nomeProduto like '%" + txtnomeProd.Text + "%' order by codLoja";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            txtNome.Text = "";
            txtnomeProd.Text = "";
            rdbAcessoVIP.Checked = false;
            rdbBolsa.Checked = false;
            rdbChaveiro.Checked = false;
            rdbConteudoExcluiso.Checked = false;
            rdbOculos.Checked = false;
            rdbCaderno.Checked = false;
            rdbCamiseta.Checked = false;
            rdbConteudoExcluiso.Checked = false;
            mkdValorLoja.Text = "";
            mkdQuantidade.Text = "";
            txtdescProd.Text = "";
            cbbCodigoFunc.Text = "";


            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                txtnomeProd.Text = dr.GetString(1);
                mkdValorLoja.Text = dr.GetString(2);
                mkdQuantidade.Text = dr.GetString(3);
                txtdescProd.Text = dr.GetString(4);
                cbbCodigoFunc.Text = dr.GetString(5);
                codLoja = dr.GetString(0);

            }
            Conexao.fecharConexao();

        }

        string pegainfs;
        string pegacodProd;



        private void cbbcodLoja_TextChanged(object sender, EventArgs e)
        {
            buscainfs();

        }


        string Produto = "";

        private void rdbOculos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOculos.Checked)
            {
                Produto = "Armação de Óculos";
                pctLoja.Image = pctOculos.Image;
                mkdValorLoja.Text = (" 15.00");
                txtnomeProd.Text = ("Armação de Óculos");
            }
        }
        private void rdbCaderno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCaderno.Checked)
            {
                Produto = "Caderno";
                pctLoja.Image = pctCaderno.Image;
                mkdValorLoja.Text = (" 15.00");
                txtnomeProd.Text = ("Caderno");
            }
        }

        private void rdbBolsa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBolsa.Checked)
            {
                Produto = "Bolsa";
                pctLoja.Image = pctBolsa.Image;
                mkdValorLoja.Text = (" 30.00");
                txtnomeProd.Text = ("Bolsa");
            }

        }

        private void rdbCase_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCase.Checked)
            {
                Produto = "Case";
                pctLoja.Image = pctCase.Image;
                mkdValorLoja.Text = (" 10.00");
                txtnomeProd.Text = ("Case");
            }
            else
            {

            }
        }

        private void rdbCamiseta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCamiseta.Checked)
            {
                Produto = "Camiseta";
                pctLoja.Image = pctCamiseta.Image;
                mkdValorLoja.Text = (" 30.00");
                txtnomeProd.Text = ("Camiseta");
            }
        }

        private void rdbAcessoVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAcessoVIP.Checked)
            {
                Produto = "Cartão VIP";
                pctLoja.Image = pctVIP.Image;
                mkdValorLoja.Text = (" 25.00");
                txtnomeProd.Text = ("Cartão VIP");
            }
        }

        private void rdbConteudoExcluiso_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConteudoExcluiso.Checked)
            {
                Produto = "Conteúdo Exclusivo";
                pctLoja.Image = pctExclusivo.Image;
                mkdValorLoja.Text = (" 30.00");
                txtnomeProd.Text = ("Conteúdo Exclusivo");
            }
        }

        private void rdbChaveiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbChaveiro.Checked)
            {
                Produto = "Chaveiro";
                pctLoja.Image = pctChaveiro.Image;
                mkdValorLoja.Text = (" 10.00");
                txtnomeProd.Text = ("Chaveiro");
            }

        }

        private void alterarProduto()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "update tbLoja set nomeProduto = @nomeProduto,Valor = @Valor,Quantidade = @Quantidade,Descricao =@Descricao,codFunc = @codFunc  where codLoja = " + codLoja + ";";

            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Add("@nomeProduto", MySqlDbType.VarChar, 10).Value = txtnomeProd.Text;
            comm.Parameters.Add("@Valor", MySqlDbType.VarChar, 10).Value = mkdValorLoja.Text;
            comm.Parameters.Add("@Quantidade", MySqlDbType.VarChar, 5).Value = mkdQuantidade.Text;
            comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 15).Value = txtdescProd.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 2).Value = cbbCodigoFunc.Text;

            comm.ExecuteNonQuery();


            Conexao.fecharConexao();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirma a alteração dos dados ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK))
            {
                alterarProduto();
                MessageBox.Show("Alterado com sucesso!!!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        //private void txtnomeProd_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (txtnomeProd.Enabled)
        //    {
        //        rdbAcessoVIP.Checked = false;
        //        rdbBolsa.Checked = false;
        //        rdbChaveiro.Checked = false;
        //        rdbConteudoExcluiso.Checked = false;
        //        rdbOculos.Checked = false;
        //        rdbCaderno.Checked = false;
        //        rdbCamiseta.Checked = false;
        //        rdbConteudoExcluiso.Checked = false;
        //    }
        //}

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbLoja where codLoja = codLoja";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 15).Value = txtdescProd.Text;
            comm.ExecuteNonQuery();
            if ((MessageBox.Show("Deseja deletar o Produto ?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
            {

                MessageBox.Show("Produto excluído com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Você cancelou a exclusão o produto", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarProdutos pesquisarProdutos = new frmPesquisarProdutos();
            pesquisarProdutos.ShowDialog();
            this.Hide();

        }

        private void cbbCodigoFunc_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtnomeProd.Text = "";
            rdbAcessoVIP.Enabled = true;
            rdbBolsa.Enabled = true;
            rdbChaveiro.Enabled = true;
            rdbConteudoExcluiso.Enabled = true;
            rdbCase.Enabled = true;
            rdbOculos.Enabled = true;
            rdbCaderno.Enabled = true;
            rdbCamiseta.Enabled = true;
            rdbConteudoExcluiso.Enabled = true;
            mkdValorLoja.Enabled = true;
            mkdQuantidade.Enabled = true;
            txtdescProd.Enabled = true;
            cbbCodigoFunc.Enabled = true;

            btnCriar.Enabled = true;
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmVenda abrirVenda = new frmVenda();
            abrirVenda.Show();
            this.Hide();
        }
    }
}


