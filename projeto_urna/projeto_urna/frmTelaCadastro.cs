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
    public partial class frmTelaCadastro : Form
    {

        public frmTelaCadastro()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rdbprof_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Bntcadas_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty || txtsenha.Text == string.Empty)
                {
                    MessageBox.Show("Insira os Campos PorFavor:", "Authentic", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    dto_cadastro usuario = new dto_cadastro();
                    //Recebendo os dados do formulário
                    usuario.Nome_cadastro = txtNome.Text;
                    usuario.Rm_cadastro = txtRM.Text;
                    usuario.Senha_cadastro = txtsenha.Text;
                    if (cbxAdministrador.Checked == true)
                    {
                        usuario.Usuario_cadastro = 1;
                       
                    }
                    if (cbxAdministrador.Checked == false)
                    {
                        usuario.Usuario_cadastro = 0;
                    }
                    if (txtRM.Enabled == false)
                    {
                        usuario.Rm_cadastro = " ";
                    }

                    dao_cadastro daoCadastro = new dao_cadastro();
                    object retorno = daoCadastro.Inserir(usuario);

                    if (retorno.ToString() == "1")
                    {
                        MessageBox.Show("Registro foi inserido", "Result Permission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Text = string.Empty;
                        txtRM.Text = string.Empty;
                        txtsenha.Text = string.Empty;
                        cbxAdministrador.Checked = false;
                        cbxProfessor.Checked = false;
                        cbxAluno.Checked = false;
                        cbxUsuário.Checked = false;
                        txtNome.Focus();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Rdbusuario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAluno.Checked == true)
            {
                cbxProfessor.Checked = false;
            }
        }

        private void cbxProfessor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxProfessor.Checked == true)
            {
                txtRM.Enabled = false;
                txtRM.BackColor = txtcor.BackColor;
                txtRM_border.BackColor = txtcor.BackColor;
                cbxAluno.Checked = false;
                
                
            }
            else
            {
                txtRM.Enabled = true;
                txtRM.BackColor = txtcor2.BackColor;
                txtRM_border.BackColor = txtcor2.BackColor;

            }
        }

        private void cbxUsuário_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUsuário.Checked == true)
            {
                cbxAdministrador.Checked = false;
            }
        }

        private void cbxAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAdministrador.Checked == true)
            {
                cbxUsuário.Checked = false;
                
            }
        }

        private void txtRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin login = new frmLogin();

            login.Show();
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

