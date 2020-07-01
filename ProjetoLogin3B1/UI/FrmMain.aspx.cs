using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLogin3B1.UI
{
    public partial class FrmMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["emailUsuario"] != null)
            {
                this.emailUsuario.Text = Session["emailUsuario"].ToString();
            }
            else
            {
                Response.Redirect("signIn.Aspx");
            }

            
        }
    }
}