using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfaceONGs
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmVenda_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            try
            {
                pesquisaFuncionarios();
                buscarnomeProduto();
                buscarcodProd();
            }
            catch (Exception)
            {

                MessageBox.Show("O Banco de dados está desconectado, existem operações que necessitam dele para confirmar,fazer busca de informações e realizar alterações.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }

        private void limparCampos()
        {
            cboCodFunc.ResetText();
            cboNomeProd.ResetText();
            cboCodProd.ResetText();
            txtquantidadeVenda.Clear();
            txtNFunc.Text = "";
            mkdclienteCPF.ResetText();
            mkdvalorVenda.ResetText();
            rdbCredito.Checked = false;
            rdbDebito.Checked = false;
            dgvVenda.Rows.Clear();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbVenda (cpfCliente,nomeprodutoVenda,valorVenda,quantidadeVenda,dataVenda,Pagamento,codFunc,codLoja)" + "values(@cpfCliente,@nomeprodutoVenda,@valorVenda,@quantidadeVenda,@dataVenda,@Pagamento,@codFunc,@codLoja)";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@cpfCliente", MySqlDbType.VarChar, 15).Value = mkdclienteCPF.Text;
            comm.Parameters.Add("@nomeprodutoVenda", MySqlDbType.VarChar, 45).Value = cboNomeProd.Text;
            comm.Parameters.Add("@valorVenda", MySqlDbType.VarChar, 10).Value = mkdvalorVenda.Text;
            comm.Parameters.Add("@quantidadeVenda", MySqlDbType.VarChar, 5).Value = txtquantidadeVenda.Text;
            comm.Parameters.Add("@dataVenda", MySqlDbType.DateTime).Value = dtpdataVenda.Value;

            if (rdbCredito.Checked)
            {
                string Credito = "Crédito";
                comm.Parameters.Add("@Pagamento", MySqlDbType.VarChar, 2).Value = Credito;
            }
            if (rdbDebito.Checked)
            {
                string Debito = "Débito";
                comm.Parameters.Add("@Pagamento", MySqlDbType.VarChar, 2).Value = Debito;
            }
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 2).Value = cboCodFunc.Text;
            comm.Parameters.Add("@codLoja", MySqlDbType.VarChar, 7).Value = cboCodProd.Text;

            comm.Connection = Conexao.obterConexao();
            try
            {
                comm.ExecuteNonQuery();

                if (MessageBox.Show("Confirma a Venda do Produto", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MessageBox.Show("Nº da Autorização é:" + GerarProtocolo(), "Venda Confirmada");
                
 
                         string CPF, codProd, produto, quantidade, valor, pagamento, data, codFuncionario;

                        if (rdbCredito.Checked)
                        {
                            CPF = mkdclienteCPF.Text;
                            codProd = cboCodProd.Text;
                            produto = cboNomeProd.Text;
                            quantidade = txtquantidadeVenda.Text;
                            valor = mkdvalorVenda.Text;
                            pagamento = rdbCredito.Text;
                            data = dtpdataVenda.Text;
                            codFuncionario = cboCodFunc.Text;


                            dgvVenda.Rows.Add(CPF, codProd, produto, quantidade, valor, pagamento, data, codFuncionario);


                            tbcVenda.SelectedIndex = 1;
                            txtNFunc.Text = "";
                            cboCodFunc.Text = "";
                            mkdclienteCPF.Text = "";
                            cboCodProd.Text = "";
                            cboNomeProd.Text = "";
                            txtquantidadeVenda.Text = "";
                            mkdvalorVenda.Text = "";
                            dtpdataVenda.Text = "";

                        }
                        if (rdbDebito.Checked)
                    {
                        CPF = mkdclienteCPF.Text;
                        codProd = cboCodProd.Text;
                        produto = cboNomeProd.Text;
                        quantidade = txtquantidadeVenda.Text;
                        valor = mkdvalorVenda.Text;
                        pagamento = rdbDebito.Text;
                        data = dtpdataVenda.Text;
                        codFuncionario = cboCodFunc.Text;


                        dgvVenda.Rows.Add(CPF, codProd, produto, quantidade, valor, pagamento, data, codFuncionario);


                        //tbcVenda.SelectedIndex = 1;
                        //mkdclienteCPF.Text = "";
                        //cboCodProd.Items.Clear();
                        //cboNomeProd.Items.Clear();
                        //txtquantidadeVenda.Text = "";
                        //mkdvalorVenda.Text = "";
                        //dtpdataVenda.Text = "";
                        //cboCodFunc.Items.Clear();

                        tbcVenda.SelectedIndex = 1;
                        txtNFunc.Text = "";
                        cboCodFunc.Text = "";
                        mkdclienteCPF.Text = "";
                        cboCodProd.Text = "";
                        cboNomeProd.Text = "";
                        txtquantidadeVenda.Text = "";
                        mkdvalorVenda.Text = "";
                        dtpdataVenda.Text = "";
                    }
                }
                else 
                {
                    MessageBox.Show("Venda Cancelada", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    dgvVenda.Rows.Clear();

                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Todos os campos devem estar preenchidos", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            Conexao.fecharConexao();

            
        }

        //código de gerador de protocolo

        public string GerarProtocolo()
        {
            int Tamanho = 10; // Numero de digitos da senha
            string number = string.Empty;
            for (int i = 0; i < Tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                {
                    string _char = ((char)codigo).ToString();
                    if (!number.Contains(_char))
                    {
                        number += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return number;
        }

        //private void btnOK_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MySqlCommand comm = new MySqlCommand();
        //        comm.CommandText = "select * from tbFuncionario where codFunc= '" + cboCodFunc.Text + "';";
        //        comm.CommandType = CommandType.Text;
        //        comm.Connection = Conexao.obterConexao();
        //        MySqlDataReader dr;
        //        dr = comm.ExecuteReader();
        //        dr.Read();
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Código de Funcionário não encontrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        //    }
        //    Conexao.fecharConexao();

        //}

        //private void btnOKProd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MySqlCommand comm = new MySqlCommand();
        //        comm.CommandText = "select * from tbLoja where nomeProduto = '" + cboNomeProd.Text + "';";
        //        comm.CommandType = CommandType.Text;
        //        comm.Connection = Conexao.obterConexao();
        //        MySqlDataReader dr;
        //        dr = comm.ExecuteReader();
        //        dr.Read();
        //        txtCodProd.Text = dr.GetString(0);
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Digite somente o nome do produto", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //        cboNomeProd.Text = ("");
        //    }

        //    Conexao.fecharConexao();
        //}

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirmar a limpeza dos campos ?", "Venda de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                limparCampos();

                MessageBox.Show("Limpeza Concluída", "Mensagem do Sistema");
            }
            else
            {
                MessageBox.Show("Limpeza Cancelada", "Mensagem do Sistema");
            }
        }

        //Pegando codigo do funcionário
        public void pesquisaFuncionarios()
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codFunc` FROM `tbfuncionario` order by codFunc";
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader dr;

            dr = comm.ExecuteReader();
            cboCodFunc.Text = "";

            while (dr.Read())
            {
                cboCodFunc.Items.Add(dr.GetUInt32(0));

            }
            Conexao.fecharConexao();
        }

        

        private void buscanomeFunc()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbfuncionario  where  codFunc like '%" + cboCodFunc.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            txtNFunc.Clear();

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                txtNFunc.Text = dr.GetString(1);
               
            }

            Conexao.fecharConexao();

        }

        string pegaCodFunc;
        string peganomeFunc;


        private void cboCodFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cboCodFunc.SelectedItem.ToString();
            //string indice = cboCodFunc.Text.ToString();
            string indic = cboCodFunc.Text.ToString();

            pegaCodFunc = indice;
            peganomeFunc = indic;
        }

        private void cboCodFunc_TextChanged(object sender, EventArgs e)
        {
            buscanomeFunc();
        }




        private void cboCodFunc_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cboCodFunc.SelectedIndex == 0)
            //{
            //    txtNFunc.Text = "Thaina Araujo";
            //}
            //if (cboCodFunc.SelectedIndex == 1)
            //{
            //    txtNFunc.Text = "Victória Amorim";
            //}
            //if (cboCodFunc.SelectedIndex == 2)
            //{
            //    txtNFunc.Text = "Erik Costa";
            //}
            //if (cboCodFunc.SelectedIndex == 3)
            //{
            //    txtNFunc.Text = "Caio Consiglio";
            //}
            //if (cboCodFunc.SelectedIndex == 4)
            //{
            //    txtNFunc.Text = "José Hugo";
            //}
        }



        // Pegando o Codigo e vinculando o nome do produto

        private void buscarcodProd()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `codLoja` FROM `tbLoja` order by codLoja";
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();
            cboCodProd.Text = "";

            while (dr.Read())
            {
                cboCodProd.Items.Add(dr.GetInt32(0));
            }
            Conexao.fecharConexao();
        }

        private void buscaNomeProd()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbLoja where codLoja like '%" + cboCodProd.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

           
            cboNomeProd.Text = "";

            dr = comm.ExecuteReader();

            while (dr.Read())
            {

                cboNomeProd.Text = dr.GetString(1);
            }
            Conexao.fecharConexao();

        }

        string pegaNome;
        string pegaCod;
        

        private void cboCodProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cboCodProd.SelectedItem.ToString();
            string indic = cboCodProd.Text.ToString();

            string pegaNome = indic;
            string pegaCod = indice;
        }


        private void cboCodProd_TextChanged(object sender, EventArgs e)
        {
            buscaNomeProd();
        }

        // Pegando o nome e vinculando o codigo do produto

        // OK
        private void buscarnomeProduto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT `nomeProduto` FROM `tbloja`";
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            cboNomeProd.Text = "";

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cboNomeProd.Items.Add(dr.GetString(0));
            }
            Conexao.fecharConexao();
        }


        // testando carrega mais trava
        private void buscaCodigoProduto()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbLoja where  nomeProduto like '%" + cboNomeProd.Text + "%'";
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            cboCodProd.Text = "";

            while (dr.Read())
            {


                cboCodProd.Text =(dr.GetString(0));
            }

            Conexao.fecharConexao();

        }

        string pegaNomeProdut;
        string pegaCodigoProdut;

        //testando

        private void cboNomeProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indice = cboNomeProd.Text.ToString();
            string indic = cboNomeProd.SelectedItem.ToString();

            string pegaNomeProdut = indice;
            string pegaCodigoProdut = indic;
        }
        private void cboNomeProd_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void btnLoja_Click(object sender, EventArgs e)
        {
            frmLoja abrirLoja = new frmLoja();
             abrirLoja.Show();
            this.Hide();
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirma o retorno para a Página de login","Mensagem do Sistema",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.OK)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("O Retorno para a Página de login foi cancelado", "Mensagem do Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            
        }
    }
}

