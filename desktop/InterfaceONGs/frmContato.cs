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

namespace InterfaceONGs
{
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
            Contato();
        }

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmContato_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void Contato()
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbContato(Nome,Email,Mensagem)" + " values(@Nome,@Email,@Mensagem)";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();

            comm.Parameters.Add("@Nome", MySqlDbType.VarChar, 155).Value = txtNomeContato.Text;
            comm.Parameters.Add("@Email", MySqlDbType.VarChar, 155).Value = txtEmail.Text;
            comm.Parameters.Add("@Mensagem", MySqlDbType.VarChar, 255).Value = txtMensagem.Text;

            comm.Connection = Conexao.obterConexao();

            comm.ExecuteNonQuery();

            Conexao.fecharConexao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o retorno a Página anterior ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                frmAdministrador abrirAdmin = new frmAdministrador();
                abrirAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Você clicou em cancelar,então o Retorno da Página foi cancelado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }
    }
}
