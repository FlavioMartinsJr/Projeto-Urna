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
    class dao_voto
    {
        conexaoMySql objConexao = new conexaoMySql();

        #region Inserir candidato no Banco de dados
        public Object Inserir(dto_voto voto)
        {
            MySqlConnection cn = objConexao.Conexao();

            try
            {
                //Comandos para inserir
                string comando = "insert into tb_voto(tb_candidato,tb_chapa)values(@cod_cadidato,@cod_chapa)";

                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@cod_cadidato", voto.Cod_cadidato);
                cmd.Parameters.AddWithValue("@cod_chapa", voto.Cod_chapa);
                


                //abrir conexão com o Banco de Dados
                cn.Open();
                //Executa o comando no banco de dados
                return cmd.ExecuteNonQuery();







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