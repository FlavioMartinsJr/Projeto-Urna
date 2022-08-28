using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_urna.DTO_Modelos;
using projeto_urna.DAO_Controle;
using projeto_urna.Resources;


namespace projeto_urna
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTelaCadastro cadastrar = new frmTelaCadastro();

            cadastrar.Show();
            this.Hide();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cbxUsu_Adm.Checked == true)
                {
                    dto_login login_adm = new dto_login
                    {
                        //Recebendo os dados do formulário
                        Nome_login = txtUsuario.Text,
                        Senha_login = txtSenha.Text,
                        Usuario_login = 1,
                    };

                    dao_login daoLogin = new dao_login();
                    int retorno = daoLogin.efetuaLogin_Adm(login_adm);
                    if (retorno.ToString() == "1")
                    {

                        frmPrincipal logar = new frmPrincipal(txtUsuario.Text, txtSenha.Text, "Admin");
                        this.Hide();
                        logar.Show();
                    }
                }
                if (cbxUsu_Adm.Checked == false)
                {
                    dto_login login_use = new dto_login
                    {
                        //Recebendo os dados do formulário
                        Nome_login = txtUsuario.Text,
                        Senha_login = txtSenha.Text,
                        Usuario_login = 0,
                    };

                    dao_login daoLogin = new dao_login();
                    int retorno = daoLogin.efetuaLogin_Usu(login_use);
                    if (retorno.ToString() == "1")
                    {
                        frmPrincipal logar = new frmPrincipal(txtUsuario.Text, txtSenha.Text, "User");
                        this.Hide();
                        logar.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
