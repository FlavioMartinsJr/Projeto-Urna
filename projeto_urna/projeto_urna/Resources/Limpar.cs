using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace projeto_urna.Resources
{
    class Limpar
    {
        public static void Limpa(Form formlimpar)
        {
            foreach (Control controle in formlimpar.Controls)
            {
                if (controle is GroupBox && controle.Name != "grpControles")
                {
                    for (int i = 0; i < controle.Controls.Count - 1; i++)
                    {
                        if (controle.Controls[i] is TextBox)
                        {
                            controle.Controls[i].Text = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
