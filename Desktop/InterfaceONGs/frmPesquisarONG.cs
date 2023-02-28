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
    public partial class frmPesquisarONG : Form
    {


        public frmPesquisarONG()
        {
            InitializeComponent();
        }

        private void frmPesquisarONG_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == false && rdbEmail.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


            ////////////////////////////////////////////////////////////////////////////////

            if (rdbEmail.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisarEmail();

            }
            if (rdbNome.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisarNome();
            }
            else
            {
                MessageBox.Show("Por favor digite o registro de acordo com o formato selecionado acima", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void pesquisarEmail()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbONG where Email = '" + txtDescricao.Text + "';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();
            lstInformacoesONG.Items.Clear();
            dr.Read();
            {
                lstInformacoesONG.Items.Add(dr.GetString(2));

            }
            Conexao.fecharConexao();
        }



        private void pesquisarNome()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbONG where nome like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            lstInformacoesONG.Items.Clear();

            while (dr.Read())
            {
                lstInformacoesONG.Items.Add(dr.GetString(1));
            }

            Conexao.fecharConexao();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lstInformacoesONG.Items.Clear();
            txtDescricao.Focus();
        }

        private void rdbEmail_CheckedChanged(object sender, EventArgs e)
        {
            lstInformacoesONG.Items.Clear();
            txtDescricao.Focus();
        }


        public static string inf0r = "";


        private void lstInformacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

                inf0r = lstInformacoesONG.SelectedItem.ToString();
                frmONG enviar = new frmONG(inf0r);
                enviar.Show();
                this.Hide();
         
        }
    }

}


