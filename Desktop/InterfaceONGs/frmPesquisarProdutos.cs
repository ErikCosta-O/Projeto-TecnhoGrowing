using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceONGs.WSCorreios;
using MySql.Data.MySqlClient;

namespace InterfaceONGs
{
    public partial class frmPesquisarProdutos : Form
    {
        public frmPesquisarProdutos()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (rdbNomeProdutos.Checked == false && rdbQuantidade.Checked == false && rdbcodProduto.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item, para pesquisar ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (rdbQuantidade.Checked && txtDescricaoProdutos.Text != string.Empty)
            {
                pesquisaQuantidade();
            }
            if (rdbNomeProdutos.Checked && txtDescricaoProdutos.Text != string.Empty)
            {

                pesquisaPorNome();
            }


            if (rdbcodProduto.Checked && cbocodProduto.Text != string.Empty)
            {
                buscaCodigo();
            }

        }


        public void pesquisaQuantidade()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tbloja where Quantidade like '%" + txtDescricaoProdutos.Text + "%' order by codLoja";
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();

                MySqlDataReader dr;
                dr = comm.ExecuteReader();

                dgvPesquisarProduto.Rows.Clear();
                while (dr.Read())
                {

                    dgvPesquisarProduto.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
                }

                Conexao.fecharConexao();
            }
            catch (System.Exception)
            {

                MessageBox.Show("Essa quantidade não existe");
            }


            
        }

        public void pesquisaPorNome()
        {
            //MySqlCommand comm = new MySqlCommand();
            //comm.CommandText = "SELECT * FROM `tbloja` WHERE `nomeProduto` LIKE '%" +txtDescricaoProdutos+ "%'";
            //comm.CommandType = CommandType.Text;
            //comm.Connection = Conexao.obterConexao();

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbloja where nomeProduto  = '" + txtDescricaoProdutos.Text + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();

                dgvPesquisarProduto.Rows.Clear();

                while (dr.Read())
                {
                    dgvPesquisarProduto.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
                }


            }

            catch (SystemException)
            {
                MessageBox.Show("Insira o Nome do Produto", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            Conexao.fecharConexao();

            //MessageBox.Show("O Nome do Produto não existe no Banco de Dados", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //limparCampos();


        }

        public void limparCampos()
        {
            rdbNomeProdutos.Checked = false;
            rdbQuantidade.Checked = false;
            dgvPesquisarProduto.Rows.Clear();
            txtDescricaoProdutos.Clear();
            btnPesquisar.Focus();
            //pctPesquisarProdutos.Visible = false;
        }

        string Produto = "";

        public static string valor = "";


        private void txtDescricaoProdutos_Validated(object sender, EventArgs e)
        {

            if (txtDescricaoProdutos.Text == "Bolsa")
            {
                Produto = "Bolsa";
                //pctPesquisarProdutos.Image = pctBolsa.Image;


            }
            if (txtDescricaoProdutos.Text == "Oculos")
            {
                Produto = "Armação de Ocúlos";
                //pctPesquisarProdutos.Image  pctOculos.Image;

            }

            if (txtDescricaoProdutos.Text == "Caderno")
            {
                Produto = "Caderno";
                //pctPesquisarProdutos.Image  pctCaderno.Image;
            }

            if (txtDescricaoProdutos.Text == "Case de Celular")
            {
                Produto = "Case de Celular";
                //pctPesquisarProdutos.Image pctCase.Image;
            }

            if (txtDescricaoProdutos.Text == "Camiseta")
            {
                Produto = "Camiseta";
                //pctPesquisarProdutos.Image  pctCamiseta.Image;
            }

            if (txtDescricaoProdutos.Text == "Cartão VIP")
            {
                Produto = "Cartão VIP";
                //pctPesquisarProdutos.Image  pctVIP.Image;
            }

            if (txtDescricaoProdutos.Text == "Conteúdo Exclusivo")
            {
                Produto = "Conteúdo Exclusivo";
                //pctPesquisarProdutos.Image  pctExclusivo.Image;
            }

            if (txtDescricaoProdutos.Text == "Chaveiro")
            {
                Produto = "Chaveiro";
                //pctPesquisarProdutos.Image pctChaveiro.Image;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLoja abir = new frmLoja();
            abir.Show();
            this.Hide();
        }


        private void CodigoProduto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codLoja` FROM `tbLoja` order by codLoja";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader dr;

            dr = comm.ExecuteReader();
            cbocodProduto.Text = "";
            dgvPesquisarProduto.Rows.Clear();
            while (dr.Read())
            {
                cbocodProduto.Items.Add(dr.GetInt32(0));
            }
            Conexao.fecharConexao();
        }


        private void buscaCodigo()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbLoja where  codloja like '%" + cbocodProduto.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dgvPesquisarProduto.Rows.Clear();

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                dgvPesquisarProduto.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
            }

            Conexao.fecharConexao();
        }

        public string pegacodLoja = "";
        public string pega = "";

        private void cbocodProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cbocodProduto.SelectedItem.ToString();
            string indic = cbocodProduto.Text.ToString();

            pegacodLoja = indice;
            pega = indic;
        }

        private void cbocodProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPesquisarProdutos_Load(object sender, EventArgs e)
        {
            CodigoProduto();
        }

        private void rdbcodProduto_CheckedChanged(object sender, EventArgs e)
        {
            cbocodProduto.Visible = true;
            txtDescricaoProdutos.ReadOnly = true;
            txtDescricaoProdutos.Text = "";
            dgvPesquisarProduto.Rows.Clear();
            cbocodProduto.Focus();
        }


        private void rdbQuantidade_CheckedChanged(object sender, EventArgs e)
        {
            cbocodProduto.Visible = false;
            txtDescricaoProdutos.ReadOnly = false;
            dgvPesquisarProduto.Rows.Clear();
            txtDescricaoProdutos.Focus();
        }

        private void rdbNomeProdutos_CheckedChanged(object sender, EventArgs e)
        {
            cbocodProduto.Visible = false;
            txtDescricaoProdutos.ReadOnly = false;
            dgvPesquisarProduto.Rows.Clear();
            txtDescricaoProdutos.Focus();
        }

        private void dgvPesquisarProduto_Validated(object sender, EventArgs e)
        {
            if (txtDescricaoProdutos.Text == "Bolsa")
            {
                Produto = "Bolsa";
                //pctPesquisarProdutos.Image = pctBolsa.Image;


            }
            if (txtDescricaoProdutos.Text == "Oculos")
            {
                Produto = "Armação de Ocúlos";
                //pctPesquisarProdutos.Image = pctOculos.Image;

            }

            if (txtDescricaoProdutos.Text == "Caderno")
            {
                Produto = "Caderno";
                //pctPesquisarProdutos.Image = pctCaderno.Image;
            }

            if (txtDescricaoProdutos.Text == "Case de Celular")
            {
                Produto = "Case de Celular";
                //pctPesquisarProdutos.Image = pctCase.Image;
            }

            if (txtDescricaoProdutos.Text == "Camiseta")
            {
                Produto = "Camiseta";
                //pctPesquisarProdutos.Image = pctCamiseta.Image;
            }

            if (txtDescricaoProdutos.Text == "Cartão VIP")
            {
                Produto = "Cartão VIP";
                //pctPesquisarProdutos.Image = pctVIP.Image;
            }

            if (txtDescricaoProdutos.Text == "Conteúdo Exclusivo")
            {
                Produto = "Conteúdo Exclusivo";
                //pctPesquisarProdutos.Image = pctExclusivo.Image;
            }

            if (txtDescricaoProdutos.Text == "Chaveiro")
            {
                Produto = "Chaveiro";
                //pctPesquisarProdutos.Image = pctChaveiro.Image;
            }
        }

        public static string Loja = "";

        private void dgvPesquisarProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loja = dgvPesquisarProduto.CurrentRow.Index.ToString();
            frmLoja enviar = new frmLoja(Loja);
            enviar.Show();
            this.Hide();

        }
    }
}
