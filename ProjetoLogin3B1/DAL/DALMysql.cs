using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLogin3B1.DAL
{
    public class DALMysql
    {
       private string string_conexao = "Persist Security info=false ; server=localhost; database=dbmvc;user=root;pwd=;";
       private MySqlConnection conexao;
    
       public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas na conexão com o Banco de Dados. " + e.Message);
            }
        }

        public void executarComando(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a instrução no Banco de Dados. " + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }


    }
}