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
    public partial class FrmManProdutos : System.Web.UI.Page
    {
        // Instanciar as classes BLL e DTO
        tblProdutoBLL produtoBLL = new tblProdutoBLL();
        tblProdutoDTO produtoDTO = new tblProdutoDTO();
        tblFornecedorBLL fornecedorBLL = new tblFornecedorBLL();
        tblCategoriaBLL categoriaBLL = new tblCategoriaBLL();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar a sessão do usuario logado
            if (Session["emailUsuario"] == null)
            {
                Response.Redirect("signin.aspx");
            }
            //
            if (!IsPostBack)
            {
                if (Request.QueryString["idProduto"] != null)
                {
                    int idproduto = int.Parse(Request.QueryString["idProduto"]);
                    txtId.Text = Request.QueryString["idProduto"];
                    // Chamar Bll para Pesquisar os dados do produto
                    DataTable cursor = produtoBLL.ConsultarProduto(idproduto);
                    if (cursor.Rows.Count > 0)
                    {
                        txtNomeProduto.Text = cursor.Rows[0][1].ToString();
                        txtDescricao.Text = cursor.Rows[0][2].ToString();
                        txtPreco.Text = cursor.Rows[0][3].ToString();
                        txtQuantidade.Text = cursor.Rows[0][4].ToString();
                        txtPeso.Text = cursor.Rows[0][5].ToString();
                        drpCategoria.SelectedValue = cursor.Rows[0][6].ToString();
                        drpFornecedor.SelectedValue = cursor.Rows[0][7].ToString();
                    }
                    this.btnGravar.Text = "Alterar";
                }
                else
                {
                    this.btnGravar.Text = "Inserir";
                }
                this.PreencheCamposDrop();
            }


        }
        // Metodo para Preencher o Combo do Fornecedor e Categoria
        public void PreencheCamposDrop()
        {
            drpCategoria.DataSource = categoriaBLL.ListarCategorias();
            drpCategoria.DataTextField = "descricao";
            drpCategoria.DataValueField = "id";
            drpCategoria.DataBind();

            drpFornecedor.DataSource = fornecedorBLL.ListarFornecedores();
            drpFornecedor.DataTextField = "nome";
            drpFornecedor.DataValueField = "id";
            drpFornecedor.DataBind();
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                produtoDTO.NomeProduto = txtNomeProduto.Text;
                produtoDTO.Descricao = txtDescricao.Text;
                produtoDTO.Preco = double.Parse(txtPreco.Text);
                produtoDTO.Quantidade = int.Parse(txtQuantidade.Text);
                produtoDTO.Peso = double.Parse(txtPeso.Text);
                produtoDTO.Tbl_categoria_id = int.Parse(drpCategoria.SelectedValue.ToString());
                produtoDTO.Tbl_fornecedor_id = int.Parse(drpFornecedor.SelectedValue.ToString());

                if (btnGravar.Text == "Inserir")
                {
                    // Inserir na tabela de clientes
                    produtoBLL.InserirProduto(produtoDTO);
                }
                else
                {
                    produtoDTO.Id = int.Parse(txtId.Text);
                    produtoBLL.AlterarProduto(produtoDTO);
                }
                Response.Redirect("/UI/FrmProdutos.aspx");


            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UI/FrmProdutos.aspx");
        }
    }
}