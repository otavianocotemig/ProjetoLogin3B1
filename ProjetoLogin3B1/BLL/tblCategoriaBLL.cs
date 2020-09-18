using ProjetoLogin3B1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoLogin3B1.BLL
{
    public class tblCategoriaBLL
    {

        private DALMysql daoBanco = new DALMysql();

        public DataTable ListarCategorias()
        {
            string sql = string.Format($@"select * from tbl_Categoria");

            DataTable dt = daoBanco.ExecutarConsulta(sql);
            if (dt.Rows.Count >= 1)
            {
                return dt;
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
    }
}