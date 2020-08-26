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
            }
            
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }

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
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
    }
}