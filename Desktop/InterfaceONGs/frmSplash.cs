using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceONGs
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            //ligando o timer
            trmSplash.Enabled = true;
        }

        private void trmSplash_Tick(object sender, EventArgs e)
        {
            //trmSplash.Enabled = false;
            ////o que você colocar aqui dentro ele vai executar

            ////executa caixa de dialogo
            //// MessageBox.Show("Aguarde o Programa está sendo iniciado..");

            ////carregando a barra de progresso
            //pgbBarra.Value = 100;


            ////abrir outra janela
            //frmLoguin abrirLogin = new frmLoguin();
            //abrirLogin.Show();
            ////esconder a página anterior da página de login
            //this.Hide();

            if (pgbBarra.Value <100)
            {
                pgbBarra.Value = pgbBarra.Value + 2;
                lblPorcentagem.Text = pgbBarra.Value.ToString() + "%"; 
            }
            else 
            {

                trmSplash.Enabled = false;
                this.Visible = false;   

                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
        
}
