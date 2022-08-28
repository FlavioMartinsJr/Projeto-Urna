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
using projeto_urna.DTO_Modelos;
using projeto_urna.Resources;
using System.IO;
using projeto_urna.DAO_Controle;



namespace projeto_urna
{
    public partial class frmUrna : Form
    {
       
        private Produtos produto = new Produtos();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftReact,
            int nTopReact,
            int nRightReact,
            int nBottomReact,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public frmUrna(string User, string senha)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            lblSenha.Text = senha;
            lblNome.Text = User;
        }

        private void FrmUrna_Load(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "0";
            }else if(btnSecond.Text == " ")
            {
                btnSecond.Text = "0";
            }else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "1";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "1";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "2";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "2";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "3";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "3";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "4";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "4";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "5";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "5";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "6";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "6";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "7";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "7";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "8";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "8";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            #region ativar os numerais
            if (btnFirst.Text == " ")
            {
                btnFirst.Text = "9";
            }
            else if (btnSecond.Text == " ")
            {
                btnSecond.Text = "9";
            }
            else
            {
                MessageBox.Show("Os campos estão cheios, limpe para inserir outro", "Atenção");
            }
            #endregion
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btnFirst.Text = " ";
            btnSecond.Text = " ";
            picImagem.Image = null;
            lblDescricao.Text = "";
            lblPeriodo.Text = "";
            lblNomeChapa.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnFirst.Text == " " || btnSecond.Text == " ")
                {
                    MessageBox.Show("Insira os Campos PorFavor:", "Authentic", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    dto_voto voto = new dto_voto();
                    //Recebendo os dados do formulário
                    voto.Cod_cadidato = btnFirst.Text + btnSecond.Text;
                    

                    dao_voto daovoto = new dao_voto();
                    object retorno = daovoto.Inserir(voto);

                    if (retorno.ToString() == "1")
                    {
                        MessageBox.Show("Voto Registrado", "Result Permission", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Carregar(Convert.ToInt32("0" + btnFirst.Text + btnSecond.Text));
        }
        private void Carregar(int id)
        {
            try
            {

                produto.Get(id, produto);
             
                lblDescricao.Text = produto.Descricao_chapa;
                lblNomeChapa.Text = produto.Nome_chapa;
                lblPeriodo.Text = produto.Periodo_chapa;

                using (var foto = new MemoryStream(produto.Foto))
                {
                    picImagem.Image = Image.FromStream(foto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblPeriodo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnSecond_Click(object sender, EventArgs e)
        {

        }
    }
}
