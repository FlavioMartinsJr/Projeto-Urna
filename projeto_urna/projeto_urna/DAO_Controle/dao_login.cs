using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_urna.Resources;
using MySql.Data.MySqlClient;
using projeto_urna.DTO_Modelos;

namespace projeto_urna.DAO_Controle
{
    class dao_login
    {
        conexaoMySql objConexao = new conexaoMySql();

        #region buscar candidato Usuarios no banco de dados
        public int efetuaLogin_Adm(dto_login login_adm)
        {
            MySqlConnection cn = objConexao.Conexao();

            try
            {
                //Comandos para inserir
                Object result = new object();
                string comando = "SELECT * FROM tb_candidato WHERE nome_candidato = @nome_login AND senha = @senha_login AND usuario_administrador = @usuario_login";

                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome_login", login_adm.Nome_login);
                cmd.Parameters.AddWithValue("@senha_login", login_adm.Senha_login);
                cmd.Parameters.AddWithValue("@usuario_login", login_adm.Usuario_login);

                //abrir conexão com o Banco de Dados
                cn.Open();

                MySqlDataReader dados = cmd.ExecuteReader();

                if (dados.Read())
                {
                    //Executa o comando no banco de dados
                    MessageBox.Show("Administrador Encontrado, Logado com Sucesso", "Condição Aceita", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    result = 1;
                    

                }
                else
                {
                    MessageBox.Show("Dados incorretos, login ou senha invalidados!!", "Condição Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = 0;
                }
                return (int)result;

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

        #region buscar candidato Administrador no banco de dados
        public int efetuaLogin_Usu(dto_login login_use)
        {
            MySqlConnection cn = objConexao.Conexao();

            try
            {
                //Comandos para inserir
                Object result = new object();
                string comando = "SELECT * FROM tb_candidato WHERE nome_candidato = @nome_login AND senha = @senha_login AND usuario_administrador = @usuario_login";

                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome_login", login_use.Nome_login);
                cmd.Parameters.AddWithValue("@senha_login", login_use.Senha_login);
                cmd.Parameters.AddWithValue("@usuario_login", login_use.Usuario_login);

                //abrir conexão com o Banco de Dados
                cn.Open();

                MySqlDataReader dados = cmd.ExecuteReader();

                if (dados.Read())
                {
                    //Executa o comando no banco de dados
                    MessageBox.Show("Usuario Encontrado, Logado com Sucesso", "Condição Aceita", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    result = 1;

                }
                else
                {
                    MessageBox.Show("Dados incorretos, login ou senha invalidados!!", "Condição Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = 0;
                }
                return (int)result;

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
