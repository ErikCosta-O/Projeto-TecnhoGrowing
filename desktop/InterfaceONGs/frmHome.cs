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
using Org.BouncyCastle.X509;

namespace InterfaceONGs
{
    public partial class frmHome : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public string login = "";


        public frmHome()
        {
            InitializeComponent();


        }


        public string guardar = "";


        public frmHome(string login)
        {
            InitializeComponent();
            this.login = login;
            guardar = login;


            codigo();

            nome();
        }


        public void codigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codFunc FROM tbusuario where login like '%" + guardar + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;

            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                textBox2.Text = dr.GetString(0);
            }

            Conexao.fecharConexao();
        }


        public string cargo = "";

        public void nome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionario where codFunc like '%" + textBox2.Text + "%'";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader dr;
            dr = comm.ExecuteReader();
            dr.Read();
            textBox1.Text = dr.GetString(1);
            cargo= dr.GetString(15);
           
            Conexao.fecharConexao();




            if (cargo == "Administrador")
            {
                btnAdmin.Enabled = true;
                btnLoja.Enabled = true;
                btnSAC.Enabled = true;
            }

            if (cargo == "SAC")
            {
                btnAdmin.Enabled = false;
                btnLoja.Enabled = false;
                btnSAC.Enabled = true;
            }

            if (cargo == "Loja")
            {
                btnAdmin.Enabled = false;
                btnLoja.Enabled = true;
                btnSAC.Enabled = false;
            }


        }
 
    







        private void btnSair_Click(object sender, EventArgs e)
        {
            string message = "Deseja realmente encerrar a aplicação ?";
            string title = "Mensagem do Sistema";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(" Programa está sendo encerrado....");
                Application.Exit();
            }
            else
            {
                MessageBox.Show(" Encerramento Cancelado ");
            }
        }

        private void BtnSuporte_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdministrador abrirAdmin = new frmAdministrador();
            abrirAdmin.Show();
            //esconder a página anterior da página de login
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        
        }

        private void btnSAC_Click(object sender, EventArgs e)
        {
            frmSAC abrirSAC = new frmSAC();
            abrirSAC.Show();
            this.Hide();
        }

        private void btnSupevisor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Somente o Administrador e o SAC estão funcionando");
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            frmVenda abrirVenda = new frmVenda();
            abrirVenda.Show();
            this.Hide();
        }

    }
}
