using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_urna.DTO_Modelos
{
    internal class dto_voto
    {
        string cod_cadidato;
        string cod_chapa;
        int cod_id;

        public string Cod_cadidato { get => cod_cadidato; set => cod_cadidato = value; }
        public string Cod_chapa { get => cod_chapa; set => cod_chapa = value; }
        public int Cod_id { get => cod_id; set => cod_id = value; }
    }
}
