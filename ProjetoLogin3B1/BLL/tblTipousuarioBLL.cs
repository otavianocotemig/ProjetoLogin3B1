using ProjetoLogin3B1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoLogin3B1.BLL
{
    

    public class tblTipousuarioBLL
    {
        private DALMysql daoBanco = new DALMysql();

        public DataTable ListarTipoUsuario()
        {
            string sql = string.Format($@"select * from tbl_tipousuario");
            return daoBanco.ExecutarConsulta(sql);
        }



    }
}