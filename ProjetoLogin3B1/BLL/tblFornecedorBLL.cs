using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ProjetoLogin3B1.DAL;
using ProjetoLogin3B1.DTO;

namespace ProjetoLogin3B1.BLL
{
    public class tblFornecedorBLL
    {
        private DALMysql daoBanco = new DALMysql();

        public DataTable ListarFornecedores()
        {
            string sql = string.Format($@"select * from tbl_fornecedor");

            DataTable dt = daoBanco.ExecutarConsulta(sql);
            if(dt.Rows.Count >= 1)
            {
                return dt;
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
        
        public DataTable PesquisarFornecedor(string pesquisa)
        {
            string sql = string.Format($@"select * from tbl_fornecedor where {pesquisa}");

            DataTable dt = daoBanco.ExecutarConsulta(sql);
            if (dt.Rows.Count >= 1)
            {
                return dt;
            }
            else
            {
                throw new Exception("Pesquisa não encontrada!");
            }
        }

    }
}