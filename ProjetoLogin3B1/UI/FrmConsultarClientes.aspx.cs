using ProjetoLogin3B1.BLL;
using ProjetoLogin3B1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLogin3B1.UI
{
    public partial class FrmConsultarClientes : System.Web.UI.Page
    {
        // Instanciar a Classe para Uso - BLL / DTO
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se tem usuario logado
            if (Session["emailUsuario"] != null)
            {

                if (Session["tipoUsuario"].ToString() == "1")
                {
                    Response.Redirect("FrmMain.Aspx");
                }
                this.GridClientes.DataSource = bllCliente.ListarClientes();
                this.GridClientes.DataBind();


            }
            else
            {
                Response.Redirect("signIn.Aspx");

            }


           
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.Aspx");
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            string condicao = "nome_cliente like '%" + txtPesquisar.Text + "%' or sobrenome_cliente like '%" +
                                                       txtPesquisar.Text + "%' or email_cliente like '%" + 
                                                       txtPesquisar.Text + "%' ";
            GridClientes.DataSource = bllCliente.PesquisarClientes(condicao);
            GridClientes.DataBind();

        }
    }
}