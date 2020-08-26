using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoLogin3B1.BLL;
using ProjetoLogin3B1.DTO;

namespace ProjetoLogin3B1.UI
{
    public partial class FrmConsultarFornecedores : System.Web.UI.Page
    {

        tblFornecedorBLL bllFornecedor = new tblFornecedorBLL();
        tblFornecedorDTO dtoFornecedor = new tblFornecedorDTO();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["emailUsuario"] != null)
            {

                if (Session["tipoUsuario"].ToString() == "2")
                {
                    Response.Redirect("FrmMain.Aspx");
                }
                this.GridFornecedores.DataSource = bllFornecedor.ListarFornecedores();
                this.GridFornecedores.DataBind();


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
            if(txtPesquisar.Text == ""){
                Response.Write("<script>alert('Complete o campo!');</script>");
            }
            string condicao = "nome like '%" + txtPesquisar.Text + "%' or email like '%" +
                                                            txtPesquisar.Text + "%' or telefone like '%" +
                                                        txtPesquisar.Text + "%' ";
             GridFornecedores.DataSource = bllFornecedor.PesquisarFornecedor(condicao);
             GridFornecedores.DataBind();       
        } 
    }
}