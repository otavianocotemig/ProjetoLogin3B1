using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLogin3B1
{
    public partial class signIn : System.Web.UI.Page
    {
        // é chamado quando do carregamento da página pelo Browser
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNomeEmpresa.Text = ConfigurationManager.AppSettings.Get("nomeEmpresa");
        }
    }
}