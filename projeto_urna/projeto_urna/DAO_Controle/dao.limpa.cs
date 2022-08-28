using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using projeto_urna;
using projeto_urna.DTO_Modelos;

namespace projeto_urna.DAO_Controle
{
    class dao_limpa
    {
        conexaoMySql objConexao = new conexaoMySql();

        #region Inserir candidato no Banco de dados
        public void Inserir()
        {
            MySqlConnection cn = objConexao.Conexao();

            try
            {
                //Comandos para inserir
                string comando = "Delete From tb_candidato; Delete From tb_chapa; Delete From tb_voto ";

                MySqlCommand cmd = new MySqlCommand(comando, cn);
                

                //abrir conexão com o Banco de Dados
                cn.Open();
                //Executa o comando no banco de dados


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        #endregion


    }
}
