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
    class dao_urna
    {
        conexaoMySql objConexao = new conexaoMySql();

        #region Inserir candidato no Banco de dados
        public void Inserir(dto_urna usuario)//object
        {
            MySqlConnection cn = objConexao.Conexao();

            try
            {
                //Comandos para inserir
                //string comando = "insert into tb_candidato(nome_candidato,rm,senha,usuario_administrador)values(@nome_cand,@rm,@senha,@user_admin)";

                //MySqlCommand cmd = new MySqlCommand(comando, cn);
               


                //abrir conexão com o Banco de Dados
                cn.Open();
                //Executa o comando no banco de dados
                //return cmd.ExecuteNonQuery();




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