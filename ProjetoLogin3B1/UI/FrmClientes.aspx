<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmClientes.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Manutenção de Clientes</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
 <div class="container">
  <div class="jumbotron">
               <h1 class="h3 mb-3 font-weight-normal">Clientes</h1>
              <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
             <br />
             <asp:Label  runat="server" Text="Nome"></asp:Label>
             <asp:TextBox  class="form-control" ID="txtNome" runat="server"></asp:TextBox>

             <asp:Label  runat="server" Text="SobreNome"></asp:Label>
             <asp:TextBox  class="form-control" ID="txtSobreNome" runat="server"></asp:TextBox>
      
             <asp:Label  runat="server" Text="Email"></asp:Label>
             <asp:TextBox  class="form-control" ID="txtEmail" runat="server"></asp:TextBox>
      
             <asp:Label  runat="server" Text="CPF"></asp:Label>
             <asp:TextBox  class="form-control" ID="txtCpf" runat="server"></asp:TextBox>
        
             <asp:Label ID="Label2"  runat="server" Text="Senha"></asp:Label>
             <asp:TextBox type="password" class="form-control" ID="txtSenha" runat="server"></asp:TextBox>

             <asp:Label ID="Label1"  runat="server" Text="Tipo Usuario"></asp:Label>
             <asp:DropDownList ID="drpTipoUsuario" runat="server" class="form-control"></asp:DropDownList>

              <asp:Label ID="Label3"  runat="server" Text="CEP"></asp:Label>
              <asp:Button ID="btnConsultarCep" Class="btn btn-lg btn-primary" runat="server"  Text="Consultar CEP" OnClick="btnConsultarCep_Click"   />
              <asp:TextBox  class="form-control" ID="txtCep" runat="server"></asp:TextBox>

              <asp:Label ID="Label4"  runat="server" Text="Endereço"></asp:Label>  
              <asp:TextBox  class="form-control" ID="txtEndereco" runat="server"></asp:TextBox>

            <asp:Button ID="btnInserir" Class="btn btn-lg btn-primary" runat="server"  Text="Gravar" OnClick="btnInserir_Click"  />
            <asp:Button ID="btnRetornar" Class="btn btn-lg btn-primary" runat="server"  Text="Retornar" OnClick="btnRetornar_Click"  />
             </div>       
            <asp:GridView ID="GridClientes"  CssClass="table table-striped" runat="server" OnRowDeleting="GridClientes_RowDeleting" OnRowCancelingEdit="GridClientes_RowCancelingEdit" OnRowEditing="GridClientes_RowEditing" OnRowUpdating="GridClientes_RowUpdating" OnPageIndexChanging="GridClientes_PageIndexChanging1" PageSize="5" AllowPaging="True">
                 <Columns>
                     <asp:CommandField HeaderText="Alterar" ShowEditButton="true" />
                     <asp:CommandField HeaderText="Excluir" ShowDeleteButton="true" />

                 </Columns> 
                          
                 <PagerSettings PageButtonCount="5" Position="TopAndBottom" Mode="NumericFirstLast" />
                          
            </asp:GridView>
            <br />
        </div>


    </form>
</body>
</html>
