using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace projeto_urna.DAO_Controle
{
    class conexaoMySql
    {
        
        public MySqlConnection Conexao()
        {
            return new MySqlConnection("user id=root;server=localhost;database=urna;port=3306");

        }

        public void selecionar()
        {

            DataTable tabela = new DataTable();
            MySqlDataAdapter adaptador = null;

            string selecionar = "SELECT * FROM tb_candidato WHERE nome_candidato = @nome_login AND senha = @senha_login AND usuario_administrador = @usuario_login";

            adaptador = new MySqlDataAdapter(selecionar, this.Conexao());

            adaptador.Fill(tabela);

            foreach(DataRow linha in tabela.Rows)
            {


            }

        }

    }
}
