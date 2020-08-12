using ProjetoLogin3B1.BLL;
using ProjetoLogin3B1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLogin3B1.UI
{
    public partial class FrmMeuPerfil : System.Web.UI.Page
    {
        // Instanciar a Classe para Uso - BLL / DTO
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtResult = bllCliente.ListarClientes(Session["emailUsuario"].ToString());
            this.txtnomeCliente.Text = dtResult.Rows[0]["nome_cliente"].ToString();
            this.txtsobreNomeCliente.Text = dtResult.Rows[0]["sobrenome_cliente"].ToString();

        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }
    }
}