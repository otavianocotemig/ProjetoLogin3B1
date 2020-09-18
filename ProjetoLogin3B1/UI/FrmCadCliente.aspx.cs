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
    public partial class FrmCadCliente : System.Web.UI.Page
    {
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();
        private int tipo_usuario = 2;

        protected void Page_Load(object sender, EventArgs e)
        {

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
                dtoCliente.Tp_usuario = tipo_usuario;
                //
                bllCliente.InserirCliente(dtoCliente);
                Response.Redirect("signin.aspx");
              
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }

        protected void btnRetornar_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }
    }
}