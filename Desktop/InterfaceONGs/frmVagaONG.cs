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
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Utilities.Collections;

namespace InterfaceONGs
{
    public partial class frmVagaONG : Form
    {
        public string Nome = "";

        public frmVagaONG()
        {
            InitializeComponent();

        }

        public frmVagaONG(string Nome)
        {

            InitializeComponent();
            this.Nome = Nome;
            txtNomeONG.Text = Nome;

            if (txtNomeONG.Text != null)
            {
                btnAlterarVaga.Enabled = true;
                btnExcluirVaga.Enabled=true;

                txtDescricaoVagaONG.Enabled = true;
                txtNomeONG.Enabled = true;
                mkdVaga.Enabled = true;
                txtPeriodo.Enabled = true;
                cbbCategoriaVagaONG.Enabled = true;
                txtHorario.Enabled = true;
                txtEnderecoONG.Enabled = true;
                btnCriarVaga.Enabled = true;

                BuscaCodVaga();
            }

        }



        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);



        private void frmVagaONG_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

            Categorias();
        }


        private void btnNovoVaga_Click(object sender, EventArgs e)
        {
            limpar();

            txtDescricaoVagaONG.Enabled = true;
            txtNomeONG.Enabled = true;
            mkdVaga.Enabled = true;
            txtPeriodo.Enabled = true;
            cbbCategoriaVagaONG.Enabled = true;
            txtHorario.Enabled = true;
            txtEnderecoONG.Enabled = true;
            btnCriarVaga.Enabled = true;

            txtNomeONG.Focus();
        }

        public string codONG = "";

        private void btnCriarVaga_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();


                comm.CommandText = "insert into tbVagaONG (NomeONG,Vaga,Categoria,Descricao,Periodo,Horario,Endereco,codONG)" + "values (@NomeONG,@Vaga,@Categoria,@Descricao,@Periodo,@Horario,@Endereco,@codONG)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Clear();

                comm.Parameters.Add("@NomeONG", MySqlDbType.VarChar, 45).Value = txtNomeONG.Text;
                comm.Parameters.Add("@Vaga", MySqlDbType.VarChar, 45).Value = mkdVaga.Text;
                comm.Parameters.Add("@Categoria", MySqlDbType.VarChar, 20).Value = cbbCategoriaVagaONG.Text;
                comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 255).Value = txtDescricaoVagaONG.Text;
                comm.Parameters.Add("@Periodo", MySqlDbType.VarChar, 45).Value = txtPeriodo.Text;
                comm.Parameters.Add("@Horario", MySqlDbType.VarChar, 20).Value = txtHorario.Text;
                comm.Parameters.Add("@Endereco", MySqlDbType.VarChar, 45).Value = txtEnderecoONG.Text;
                comm.Parameters.Add("@codONG", MySqlDbType.VarChar, 11).Value = codONG;

                comm.Connection = Conexao.obterConexao();

                comm.ExecuteNonQuery();


                if (MessageBox.Show("Confirma a vinculação da "+(txtNomeONG.Text)+" a vaga ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {

                    MessageBox.Show("Vinculação da " +(txtNomeONG.Text)+" confirmada com sucesso !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();

                    btnNovoVaga.Focus();

                }
                else
                {
                    MessageBox.Show("Vinculação da " + (txtNomeONG.Text) + " foi cancelada!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Conexao.fecharConexao();


            }
            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos para vincular a vaga a ONG", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar() ;
            }

        }
            


        public string codVaga = "";
        private void BuscaCodVaga()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbVagaONG where NomeONG like '%" +txtNomeONG.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();


            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                codVaga = dr.GetString(0);
                mkdVaga.Text = dr.GetString(2);
                cbbCategoriaVagaONG.Text = dr.GetString(3);
                txtDescricaoVagaONG.Text = dr.GetString(4);
                txtPeriodo.Text = dr.GetString(5);
                txtHorario.Text = dr.GetString(6);
                txtEnderecoONG.Text = dr.GetString(7);
                codONG = dr.GetString(8);
                
            }
           

        }

        private void BuscaNomeONG()
        {
           
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT* FROM tbONG where nome like '%" + txtNomeONG.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Connection = Conexao.obterConexao();


            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            dr.Read();
            try
            {

                txtNomeONG.Text = dr.GetString(1);
                codONG = dr.GetString(0);
                txtEnderecoONG.Text = dr.GetString(6)+","+ dr.GetString(7);


            }
            catch (Exception)
            {

                MessageBox.Show("Essa ONG não está cadastrada, faça o cadastro para a vaga ser vinculada a ela", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCriarVaga.Enabled = false;
                btnLimparVaga.Focus();
            }

            Conexao.fecharConexao();
        }

        private void Categorias()
        {
            cbbCategoriaVagaONG.Items.Add("Designer");
            cbbCategoriaVagaONG.Items.Add("Front End");
            cbbCategoriaVagaONG.Items.Add("Back End");
            cbbCategoriaVagaONG.Items.Add("MySql");
        }

        private void limpar()
        {
            txtNomeONG.Text = "";
            txtEnderecoONG.Text = "";
            cbbCategoriaVagaONG.Text = "";
            txtHorario.Text = "";
            txtPeriodo.Text = "";
            mkdVaga.Text = "";
            txtDescricaoVagaONG.Text = "";


        }

        public bool apagar = false;

        private void btnLimparVaga_Click(object sender, EventArgs e)
        {
            if (txtNomeONG.Text == string.Empty)
            {
                MessageBox.Show("É necessário ter informações nos campos para poder apagar","Mensagem do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else if(MessageBox.Show("Confirma a limpeza dos campos da "+(txtNomeONG.Text)+" ? ", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Limpeza dos campos da " + (txtNomeONG.Text) + " concluída", "Mensagem do Sistema");
                limpar();
            }
            else
            {
                MessageBox.Show("Limpeza  dos campos da " + (txtNomeONG.Text) +"cancelada", "Mensagem do Sistema");
            }

        }

        private void btnAlterarVaga_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Confirma a alteração das informações da vaga da " + (txtNomeONG.Text), " ?" + "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {

                alterarVaga();

            }
            else
            {
                MessageBox.Show("Alteração das informações da" +(txtNomeONG.Text)+" foi cancelada", "Mensagem do Sistema");
            }

        }

        private void alterarVaga()
        { 
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = comm.CommandText = "update tbVagaONG set Vaga = @Vaga, Categoria = @Categoria ,Periodo = @Periodo , Horario = @Horario where codVaga ="+codVaga+"; ";

            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            comm.Parameters.Clear();
            comm.Parameters.Add("@Vaga", MySqlDbType.VarChar, 45).Value = mkdVaga.Text;
            comm.Parameters.Add("@Categoria", MySqlDbType.VarChar, 20).Value = cbbCategoriaVagaONG.Text;
            comm.Parameters.Add("@Descricao", MySqlDbType.VarChar, 255).Value = txtDescricaoVagaONG.Text;
            comm.Parameters.Add("@Periodo", MySqlDbType.VarChar, 45).Value = txtPeriodo.Text;
            comm.Parameters.Add("@Horario", MySqlDbType.VarChar, 20).Value = txtHorario.Text;
            
            comm.ExecuteNonQuery();

            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarVagasONG vagasONG = new frmPesquisarVagasONG();
            vagasONG.Show();
            this.Hide();
        }

        public bool Buscar = false;


        private void txtVagaONG_TextChanged(object sender, EventArgs e)
        {
            //if (Buscar = true)
            //{
            //    BuscaCodVaga();
            //}
        }

        private void txtNomeONG_Leave(object sender, EventArgs e)
        {

            BuscaNomeONG();
        }

        private void btnExcluirVaga_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbVagaONG where codVaga = @codVaga";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVaga", MySqlDbType.VarChar, 15).Value = codVaga;


            if (MessageBox.Show("Confirma a exclusão das informação da " + (txtNomeONG.Text) + " ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("A desvinculação da " +(txtNomeONG.Text)+"com  a vaga foi realizada com sucesso !", "Mensagem do Sistema");
                comm.ExecuteNonQuery();

                limpar();
            }
            else
            {
                MessageBox.Show("A desvinculação da " + txtNomeONG.Text + " com a vaga foi cancelada !", "Mensagem do Sistema");
            }
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmAdministrador abrirAdministrador = new frmAdministrador();
            abrirAdministrador.Show();
            this.Hide();
        }
    }

}
