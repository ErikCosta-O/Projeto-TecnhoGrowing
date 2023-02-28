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
    public partial class frmPesquisarContato : Form
    {


        public frmPesquisarContato()
        {
            InitializeComponent();

        }

        private void frmPesquisarContato_Load(object sender, EventArgs e)
        {
            CodigoContato();
        }



        private void buscaNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select `codContato`,`Email`,`Mensagem` from tbContato where nome like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
                dr = comm.ExecuteReader();

                dgvFaleConosco.Rows.Clear();

                while (dr.Read())
                {
                    // dgvFaleConosco.Rows.Add(dr.GetString(0));
                    dgvFaleConosco.Rows.Add(dr.GetString(0),txtDescricao.Text,dr.GetString(1),dr.GetString(2));

                    txtDescricao.Focus();

                }

                Conexao.fecharConexao();
        }

        private void buscaEmail()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbContato where email like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

                dr = comm.ExecuteReader();

                dgvFaleConosco.Rows.Clear();

                while (dr.Read())
                {
                    dgvFaleConosco.Rows.Add(dr.GetString(0), dr.GetString(1),txtDescricao.Text, dr.GetString(3));
                }


        }



        private void CodigoContato()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codContato` FROM `tbContato` order by codContato";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            cbocodContato.ResetText();
            dgvFaleConosco.Rows.Clear();

            while (dr.Read())
            {
                cbocodContato.Items.Add(dr.GetInt32(0));
            }
            Conexao.fecharConexao();
        }




        private void buscaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbContato where  codContato like '%" + cbocodContato.Text + "%' order by codContato";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            dr = comm.ExecuteReader();

            cbocodContato.ResetText();
            dgvFaleConosco.Rows.Clear();

            while (dr.Read())
            {
                cbocodContato.Items.Add(dr.GetInt32(0));
                dgvFaleConosco.Rows.Add(dr.GetString(0),dr.GetString(1),dr.GetString(2),dr.GetString(3));
            }
            Conexao.fecharConexao();

            string codCadastro, Nome, Email, Mensagem;

            codCadastro = cbocodContato.Text;
            Nome = tdpNome.ToString();
            Email = tdpEmail.ToString();
            Mensagem = tdpMensagem.ToString();

            

        }

        public string pegacodContato = "";
        public string pegaInfos = "";
        private void cbocodContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indice = cbocodContato.SelectedItem.ToString();
            string indic = cbocodContato.Text.ToString();
            pegacodContato = indice;
            pegaInfos = indic;


            
        }

        private void lstInformacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
           //string indice1 = lstInformacoes.SelectedItem.ToString();
           // pegaInfos = indice1;
            
        }
        private void LimparCampos()
        {
            rdbNome.Checked = false;
            rdbEmail.Checked = false;
            dgvFaleConosco.Rows.Clear();
            txtDescricao.Clear();
            btnPesquisar.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == false && rdbEmail.Checked == false && rdbCodigo.Checked ==false)
            {
                cbocodContato.Visible = false;
                MessageBox.Show("Favor selecionar um item ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            if (rdbEmail.Checked && txtDescricao.Text != string.Empty)
            {

                buscaEmail();

            }

            if (rdbNome.Checked && txtDescricao.Text != string.Empty)
            {

                buscaNome();
            }

            if (rdbCodigo.Checked && cbocodContato.Text != string.Empty)
            {
                buscaCodigo();
            }
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            dgvFaleConosco.Rows.Clear();
            cbocodContato.Visible = true;
            txtDescricao.Enabled = false;
            cbocodContato.Enabled = true;

        }

        private void rdbEmail_CheckedChanged(object sender, EventArgs e)
        {
            dgvFaleConosco.Rows.Clear();
            txtDescricao.Enabled = true;
            cbocodContato.Visible = false;
            txtDescricao.Focus();


        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            dgvFaleConosco.Rows.Clear();
            txtDescricao.Enabled = true;
            cbocodContato.Visible = false;
            txtDescricao.Focus();

        }
    }
}
