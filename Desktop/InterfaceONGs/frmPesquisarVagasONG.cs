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
    public partial class frmPesquisarVagasONG : Form
    {
        public frmPesquisarVagasONG()
        {
            InitializeComponent();
        }

        private void frmPesquisarVagasONG_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbVaga.Checked == false && rdbID.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Por favor digite o registro de acordo com o formato selecionado acima", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }



            if (rdbID.Checked && txtDescricao.Text != string.Empty)
            {

                pesquisarID();
            }


            if (rdbVaga.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisarVaga();
            }

        }


        private void pesquisarID()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVagaONG where codVaga like '%" + txtDescricao.Text + "%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try { 
                dr = comm.ExecuteReader();

                lstInformacoesVagaONG.Items.Clear();


               while( dr.Read())
                
                    lstInformacoesVagaONG.Items.Add(dr.GetString(1));
                

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira um ID válido ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }

            Conexao.fecharConexao();
        }


        private void pesquisarVaga()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVagaONG where Vaga like '%" + txtDescricao.Text + "%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();

                lstInformacoesVagaONG.Items.Clear();


                dr.Read();
               
                    lstInformacoesVagaONG.Items.Add(dr.GetString(1));
                

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Não existe ONG com essa quantidade de vaga", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }

            Conexao.fecharConexao();

        }


        public static string dad0s = "";

        private void lstInformacoesVagaONG_SelectedIndexChanged(object sender, EventArgs e)
        {

            dad0s = lstInformacoesVagaONG.SelectedItem.ToString();
                frmVagaONG enviar = new frmVagaONG(dad0s);
                enviar.Show();
                this.Hide(); 
        }


        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtDescricao.Focus();
            
        }

        private void rdbVaga_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtDescricao.Focus();
        }
    }
}
