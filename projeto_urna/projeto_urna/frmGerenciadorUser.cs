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

namespace projeto_urna
{
    public partial class frmPrincipal : Form
    {
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
        public frmPrincipal(string user,string senha ,string type)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            lblUser.Text = user;
            lblType.Text = type;
            lblSenha.Text = senha;

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void InformaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

      

        private void BtnVotar_Click(object sender, EventArgs e)
        {
         
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Você Realmente Quer Sair?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                                         
            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
         
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            #region barra de navegação 
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            pnlNav.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
            #endregion
            frmLogin voltar = new frmLogin();
            voltar.Show();
            this.Close();
        }

        private void btnVotar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnVotar_Click_2(object sender, EventArgs e)
        {
            #region barra de navegação 
            pnlNav.Height = btnVotar.Height;
            pnlNav.Top = btnVotar.Top;
            pnlNav.Left = btnVotar.Left;
            btnVotar.BackColor = Color.FromArgb(46, 51, 73);
            #endregion

            lblTitulos.Text = "Vota";
            this.pnlFormLoader.Controls.Clear();
            frmUrna gerenciador = new frmUrna(lblUser.Text, lblSenha.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gerenciador.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(gerenciador);
            gerenciador.Show();
        }

        private void btnRelato_Click(object sender, EventArgs e)
        {
            #region barra de navegação 
            pnlNav.Height = btnRelato.Height;
            pnlNav.Top = btnRelato.Top;
            pnlNav.Left = btnRelato.Left;
            btnRelato.BackColor = Color.FromArgb(46, 51, 73);
            #endregion

            lblTitulos.Text = "Relatório";
            this.pnlFormLoader.Controls.Clear();
            frmapuracao gerenciador = new frmapuracao(lblType.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            gerenciador.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(gerenciador);
            gerenciador.Show();
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region barra de navegação 
            pnlNav.Height = btnAdd.Height;
            pnlNav.Top = btnAdd.Top;
            pnlNav.Left = btnAdd.Left;
            btnAdd.BackColor = Color.FromArgb(46, 51, 73);
            #endregion

            if(lblType.Text == "Admin")
            {
                lblTitulos.Text = "Adicionar";
                this.pnlFormLoader.Controls.Clear();
                frmCriarChapa gerenciador = new frmCriarChapa() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                gerenciador.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(gerenciador);
                gerenciador.Show();
            }
      
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            #region barra de navegação 
            pnlNav.Height = btnFerramentas.Height;
            pnlNav.Top = btnFerramentas.Top;
            pnlNav.Left = btnFerramentas.Left;
            btnFerramentas.BackColor = Color.FromArgb(46, 51, 73);
            #endregion

            if (lblType.Text == "Admin")
            {
                lblTitulos.Text = "Ferramentas";
                this.pnlFormLoader.Controls.Clear();
                frmFerramentas gerenciador = new frmFerramentas() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                gerenciador.FormBorderStyle = FormBorderStyle.None;
                this.pnlFormLoader.Controls.Add(gerenciador);
                gerenciador.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            const string message = "Você Realmente Quer Sair?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVotar_Leave(object sender, EventArgs e)
        {
            btnVotar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRelato_Leave(object sender, EventArgs e)
        {
            btnRelato.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAdd_Leave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnFerramentas_Leave(object sender, EventArgs e)
        {
            btnFerramentas.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulos_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
