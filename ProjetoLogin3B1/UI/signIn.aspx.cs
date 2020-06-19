using ProjetoLogin3B1.BLL;
using ProjetoLogin3B1.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLogin3B1.UI
{
    public partial class signIn : System.Web.UI.Page
    {
        // é chamado quando do carregamento da página pelo Browser
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNomeEmpresa.Text = ConfigurationManager.AppSettings.Get("nomeEmpresa");
            //
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a DTO para armazenamento dos dados da tela
                tblClienteDTO cliente = new tblClienteDTO();
                cliente.Email_cliente = txtEmail.Text;
                cliente.Senha_cliente = txtPassword.Text;
                //Instanciando a BLL para chamar metodos da classe
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(cliente.Email_cliente, cliente.Senha_cliente))
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Cliente Localizado";
                }
                else
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Cliente não Localizado";
                }
            }catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }

        }
    }
}