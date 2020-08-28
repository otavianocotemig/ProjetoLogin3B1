<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmConsultarClientes.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmConsultarClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultar Clientes</title>
     <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="jumbotron">
               <h1 class="h3 mb-3 font-weight-normal">Consultar Clientes</h1>

               <asp:TextBox ID="txtPesquisar" runat="server"></asp:TextBox>
               <asp:Button ID="btnPesquisar" runat="server" OnClick="btnPesquisar_Click" Text="Pesquisar" />
               <asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />
               <br />
               <asp:GridView ID="GridClientes"  CssClass="table table-striped" runat="server">
                  
               </asp:GridView>

        </div>
    </form>
</body>
</html>
