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
    public partial class frmPesquisarVoluntarios : Form
    {

        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmVoluntariosONG voluntariosONG = new frmVoluntariosONG();
            voluntariosONG.Show();
            this.Hide();
        }

        public void pesquisaPorCPF()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where CPF like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

                dr = comm.ExecuteReader();

                lstInformacoesVoluntario.Items.Clear();

                dr.Read();
                
                    lstInformacoesVoluntario.Items.Add(dr.GetString(1));
                

                Conexao.fecharConexao();

        }

        public void pesquisaPorNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where nome like '%" + txtDescricao.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();


            while (dr.Read())

                lstInformacoesVoluntario.Items.Add(dr.GetString(1));



            Conexao.fecharConexao();

        }

        public static string Voluntario = "";

        private void lstInformacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Voluntario = lstInformacoesVoluntario.SelectedItem.ToString();
            frmVoluntariosONG enviar = new frmVoluntariosONG(Voluntario);
            enviar.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == false && rdbCPF.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item ", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            if (rdbCPF.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisaPorCPF();

            }
            if (rdbNome.Checked && txtDescricao.Text != string.Empty)
            {
                pesquisaPorNome();
            }
            else
            {
                MessageBox.Show("Por favor digite o registro de acordo com o formato selecionado acima", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmPesquisarVoluntarios_Load(object sender, EventArgs e)
        {

        }
    }
}
