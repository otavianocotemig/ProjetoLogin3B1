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
    public partial class FrmProdutos : System.Web.UI.Page
    {
        tblProdutoBLL bllProduto = new tblProdutoBLL();
        tblProdutoDTO dtoProduto = new tblProdutoDTO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.ExibirGridProdutos();
        }

        protected void GridProdutos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridProdutos.PageIndex = e.NewPageIndex;
            this.ExibirGridProdutos();
        }

        public void ExibirGridProdutos()
        {
            string Pesquisa = "NomeProduto like '%" + txtPesquisar.Text + "%' and c.descricao like '%" + txtPesquisar.Text + "%'";
            GridProdutos.DataSource = bllProduto.PesquisarProdutos(Pesquisa);
            GridProdutos.DataBind();
        }

        protected void GridProdutos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                dtoProduto.Id = Convert.ToInt32(e.Values[0]);
                bllProduto.ExcluirProduto(dtoProduto);
                this.ExibirGridProdutos();
            }
            catch (Exception ex)
            {
                this.msgerro.Visible = true;
                this.msgerro.Text = ex.Message;
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmManProdutos.aspx");
        }
    }
}