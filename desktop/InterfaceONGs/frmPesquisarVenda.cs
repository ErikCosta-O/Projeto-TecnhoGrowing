using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfaceONGs
{
    public partial class frmPesquisarVenda : Form
    {
        public frmPesquisarVenda()
        {
            InitializeComponent();
        }

        private void frmPesquisarVenda_Load(object sender, EventArgs e)
        {
            pegaCodVenda();

        }


        private void buscainfs()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVenda where codVenda like '%" + cbocodVenda.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            dr = comm.ExecuteReader();

            dgvPesquisarProduto.Rows.Clear();
            while (dr.Read())
            {

                dgvPesquisarProduto.Rows.Add(dr.GetString(0), dr.GetString(8), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(1), dr.GetString(5), dr.GetString(7));
            }


            Conexao.fecharConexao();
        }


        private void BuscaQuantidadeVenda()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVenda where  codVenda like '%" + txtDescricaoVenda.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dgvPesquisarProduto.Rows.Clear();

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                dgvPesquisarProduto.Rows.Add(dr.GetString(0), dr.GetString(8), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(1), dr.GetString(5), dr.GetString(7));
            }

            Conexao.fecharConexao();
        }





        private void pegaPagamento()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVenda where  Pagamento like '%" + txtDescricaoVenda.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dgvPesquisarProduto.Rows.Clear();

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                dgvPesquisarProduto.Rows.Add(dr.GetString(0), dr.GetString(8), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(1), dr.GetString(5), dr.GetString(7));
            }

            Conexao.fecharConexao();
        }




        private void pegaCodVenda()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codVenda` FROM `tbVenda` order by codVenda";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader dr;

            dr = comm.ExecuteReader();
            cbocodVenda.Text = "";
            while (dr.Read())
            {
                cbocodVenda.Items.Add(dr.GetInt32(0));

            }
            Conexao.fecharConexao();
        }

        public string pegacodVenda = "";
        private void cbocodVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cbocodVenda.SelectedItem.ToString();

            pegacodVenda = indice;
        }



        private void rdbcodVenda_CheckedChanged(object sender, EventArgs e)
        {
            cbocodVenda.Visible = true;
            txtDescricaoVenda.ReadOnly = true;
            txtDescricaoVenda.Text = "";
            dgvPesquisarProduto.Rows.Clear();
        }

        private void rdbQuantidadeVenda_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricaoVenda.ReadOnly = false;
            cbocodVenda.Visible = false;
            dgvPesquisarProduto.Rows.Clear();

        }


        private void rdbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricaoVenda.ReadOnly = false;
            dgvPesquisarProduto.Rows.Clear();
            cbocodVenda.Visible=false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (rdbcodVenda.Checked == false && rdbPagamento.Checked == false && rdbQuantidadeVenda.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item, para pesquisar ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {

                if (rdbQuantidadeVenda.Checked && txtDescricaoVenda.Text != string.Empty)
                {
                    BuscaQuantidadeVenda();
                }



                if (rdbcodVenda.Checked && cbocodVenda.Text != string.Empty)
                {
                    buscainfs();
                }


                if (rdbPagamento.Checked && txtDescricaoVenda.Text != string.Empty)
                {
                    pegaPagamento();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}