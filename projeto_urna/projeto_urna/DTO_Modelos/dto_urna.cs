using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_urna.DTO_Modelos
{
    internal class dto_urna
    {
        string cod_urna;
        string usuario_urna;
        int chapa_urna;

        public string Cod_urna { get => cod_urna; set => cod_urna = value; }
        public string Usuario_urna { get => usuario_urna; set => usuario_urna = value; }
        public int Chapa_urna { get => chapa_urna; set => chapa_urna = value; }
    }
}
