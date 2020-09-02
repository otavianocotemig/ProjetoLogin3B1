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
    public partial class FrmClientes : System.Web.UI.Page
    {
        // instanciar BLLs e Dto
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();
        tblTipousuarioBLL bllTipousuario = new tblTipousuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                this.PreencheTipoUsuario();
                this.ExibirGrid();
            }
            

            
        }
        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }
        // Metodo utilizado para exibir Grid
        public void ExibirGrid()
        {
            GridClientes.DataSource = bllCliente.ListarClientes();
            GridClientes.DataBind();
        }
        // Metodo Utilizando para Preenher DropDownList do Tipo do Usuario
        public void PreencheTipoUsuario()
        {
            drpTipoUsuario.DataSource = bllTipousuario.ListarTipoUsuario();
            drpTipoUsuario.DataTextField = "descricao";
            drpTipoUsuario.DataValueField = "id";
            drpTipoUsuario.DataBind();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                // Envio de dados para o DTO
                dtoCliente.Nome_cliente = txtNome.Text;
                dtoCliente.Sobrenome_cliente = txtSobreNome.Text;
                dtoCliente.Cpf_cliente = txtCpf.Text;
                dtoCliente.Senha_cliente = txtSenha.Text;
                dtoCliente.Email_cliente = txtEmail.Text;
                dtoCliente.Tp_usuario = int.Parse(drpTipoUsuario.SelectedValue.ToString());
                //
                bllCliente.InserirCliente(dtoCliente);
                msgerro.Visible = true;
                msgerro.Text = "Cliente inserido com sucesso";
                this.LimparCampos();
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        // metodo para limpar campos do formulario
        public void LimparCampos()
        {
            txtNome.Text = "";
            txtSobreNome.Text = "";
            txtCpf.Text = "";
            txtSenha.Text = "";
            txtEmail.Text = "";
        }

        protected void GridClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                dtoCliente.Id_cliente = Convert.ToInt32(e.Values[0]);
                bllCliente.ExcluirCliente(dtoCliente);
                this.ExibirGrid();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        protected void GridClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridClientes.EditIndex = e.NewEditIndex;
            ExibirGrid();
        }

        protected void GridClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                dtoCliente.Nome_cliente = e.NewValues[1].ToString();
                dtoCliente.Sobrenome_cliente = e.NewValues[2].ToString();
                dtoCliente.Senha_cliente = e.NewValues[4].ToString();
                dtoCliente.Cpf_cliente = e.NewValues[5].ToString();
                dtoCliente.Email_cliente = e.NewValues[3].ToString();
                bllCliente.AlterarCliente(dtoCliente);
                GridClientes.EditIndex = -1;
                ExibirGrid();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        protected void GridClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridClientes.EditIndex = -1;
            ExibirGrid();
        }

        protected void GridClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           

        }

        protected void GridClientes_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridClientes.PageIndex = e.NewPageIndex;
            ExibirGrid();
        }
    }
}