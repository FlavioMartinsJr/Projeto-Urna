using MySql.Data.MySqlClient;
using projeto_urna.DAO_Controle;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_urna.DTO_Modelos
{
    public class Produtos
    {
        
        public int Id_chapa { get ; set ; }
        public string Nome_chapa { get ; set ; }
        public string Periodo_chapa { get ; set ; }
        public string Descricao_chapa { get ; set ; }
        public byte[] Foto { get ; set; }
        public string CaminhoFoto { get ; set ; }

        public void Get(int id, Produtos produto)
        {
            conexaoMySql objConexao = new conexaoMySql();
            MySqlConnection cn = objConexao.Conexao();

            try
            {   
                object result = new object();
                string comando = "select nome_chapa, periodo_chapa, descricao, foto from tb_chapa where cod_chapa =" + id;
                
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {

                    if(dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            produto.Id_chapa = id;
                            produto.Nome_chapa = dr["nome_chapa"].ToString();
                            produto.Periodo_chapa = dr["periodo_chapa"].ToString();
                            produto.Descricao_chapa = dr["descricao"].ToString();
                            produto.Foto = (byte[])dr["foto"];
                      
                        }
                        
                    }
                    else
                    {
                   
                        MessageBox.Show("Chapa não existe!!","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                       
                    }
                }
     

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
        public void Salvar(Produtos produto)
        {
            byte[] foto = GetFoto(produto.CaminhoFoto);
            conexaoMySql objConexao = new conexaoMySql();
            MySqlConnection cn = objConexao.Conexao();

            try
            {
                //Comandos para inserir
                string comando = "insert into tb_chapa(nome_chapa,periodo_chapa,descricao,foto)values(@nome_chapa,@periodo_chapa,@descricao,@foto)";

                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome_chapa", produto.Nome_chapa);
                cmd.Parameters.AddWithValue("@periodo_chapa", produto.Periodo_chapa);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao_chapa);
                cmd.Parameters.Add("@foto", MySql.Data.MySqlClient.MySqlDbType.VarBinary, foto.Length).Value = foto;


                //abrir conexão com o Banco de Dados
                cn.Open();
                //Executa o comando no banco de dados
                cmd.ExecuteNonQuery();


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

        private byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;
            using(var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using(var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }
            }
            return foto;
        }
    }
}
