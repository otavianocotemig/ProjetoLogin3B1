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

            if (IsPostBack == false)
            {
                DataTable dtResult = bllCliente.ListarClientes(Session["emailUsuario"].ToString());
                this.txtnomeCliente.Text = dtResult.Rows[0]["nome_cliente"].ToString();
                this.txtsobreNomeCliente.Text = dtResult.Rows[0]["sobrenome_cliente"].ToString();
                this.txtcpf.Text = dtResult.Rows[0]["cpf_cliente"].ToString();
            }

        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMain.aspx");
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Inserindo valores no DTO
                dtoCliente.Nome_cliente = txtnomeCliente.Text;
                dtoCliente.Sobrenome_cliente = txtsobreNomeCliente.Text;
                dtoCliente.Cpf_cliente = txtcpf.Text;
                dtoCliente.Senha_cliente = txtPassword.Text;
                dtoCliente.Email_cliente = Session["emailUsuario"].ToString();

                this.msgerro.Visible = false;
                // Consistencia se a senha atual é igual a senha do banco
                if (txtSenhaAtual.Text != bllCliente.RecuperarSenha(Session["emailUsuario"].ToString()))
                {
                    this.msgerro.Visible = true;
                    this.msgerro.Text = "A senha atual digitada não confere";
                }
                if (txtPassword.Text != txtRPassword.Text)
                {
                    this.msgerro.Visible = true;
                    this.msgerro.Text = "As senhas digitadas não conferem";
                }
                // Chamada do metodo para alterar o cliente
                bllCliente.AlterarCliente(dtoCliente);
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }


        }
    }
}