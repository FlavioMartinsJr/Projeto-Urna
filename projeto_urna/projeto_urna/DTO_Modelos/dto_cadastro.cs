using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_urna.DTO_Modelos
{
    class dto_cadastro
    {
        int id_primare_cadastro;
        string nome_cadastro;
        string rm_cadastro;
        string senha_cadastro;
        int usuario_cadastro;


        public int Id_primare_cadastro { get => id_primare_cadastro; set => id_primare_cadastro = value; }
        public string Nome_cadastro { get => nome_cadastro; set => nome_cadastro = value; }
        public string Rm_cadastro { get => rm_cadastro; set => rm_cadastro = value; }
        public string Senha_cadastro { get => senha_cadastro; set => senha_cadastro = value; }
        public int Usuario_cadastro { get => usuario_cadastro; set => usuario_cadastro = value; }

    }
}
