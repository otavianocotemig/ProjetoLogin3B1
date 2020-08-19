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
                if (Session["tipoUsuario"].ToString() == "1")
                {
                    this.btnAdministracao.Visible = false;
                }
            }
            else
            {
                Response.Redirect("signIn.Aspx");

            }

            
        }

        protected void btnMeuPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMeuPerfil.aspx");
        }

        protected void btnAdministracao_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmConsultarClientes.aspx");
        }
    }
}