using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_urna.DTO_Modelos
{
    class dto_login
    {
    
        string nome_login;
        string senha_login;
        int usuario_login;

        public string Nome_login { get => nome_login; set => nome_login = value; }
        public string Senha_login { get => senha_login; set => senha_login = value; }
        public int Usuario_login { get => usuario_login; set => usuario_login = value; }

    }
}
