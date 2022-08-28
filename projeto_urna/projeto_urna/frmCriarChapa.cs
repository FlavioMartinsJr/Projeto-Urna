using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_urna.DAO_Controle;
using projeto_urna.DTO_Modelos;
using projeto_urna.Resources;

namespace projeto_urna
{
    public partial class frmCriarChapa : Form
    {
        public string caminhoFoto = "";
        private Produtos produto = new Produtos();
        public frmCriarChapa()
        {
            InitializeComponent();
            lblNome_chapa.Focus();
        }

        private void RadCursando_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            CarregarFoto();
        }
        private void CarregarFoto()
        {
            var OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Arquivos de Imagens jpg e png|*.jpg; *.png";
            OpenFile.Multiselect = false;

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                caminhoFoto = OpenFile.FileName;
            }
            if(caminhoFoto != "")
            {
                picImagem.Load(caminhoFoto);
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
           
        }

        private void b_Click(object sender, EventArgs e)
        {
            Limpar.Limpa(this);
            produto.CaminhoFoto = "";
            produto.Foto = null;
            picImagem.Image = null;
            txtNome.Focus();

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
        private void Cadastrar()
        {
            try
            {
                produto.Nome_chapa = txtNome.Text;
                produto.Periodo_chapa = txtPeriodo.Text;
                produto.Descricao_chapa = txtDescricao.Text;
                produto.CaminhoFoto = caminhoFoto;
                produto.Salvar(produto);

                var result = MessageBox.Show("Registro foi inserido", "Result Permission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Limpar.Limpa(this);
                    produto.CaminhoFoto = "";
                    produto.Foto = null;
                    picImagem.Image = null;
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCriarChapa_Load(object sender, EventArgs e)
        {

        }
    }
}

