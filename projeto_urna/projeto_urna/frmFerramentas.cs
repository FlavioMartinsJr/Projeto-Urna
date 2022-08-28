using projeto_urna.DAO_Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_urna
{
    public partial class frmFerramentas : Form
    {
        public frmFerramentas()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                const string message = "Você Realmente Quer Apagar?";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.Yes)
                {
                    
                    dao_limpa daolimpa = new dao_limpa();
                    daolimpa.Inserir();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
    

