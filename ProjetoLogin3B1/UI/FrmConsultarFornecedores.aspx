<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmConsultarFornecedores.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmConsultarFornecedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
   <form id="form1" runat="server">
       <div class="jumbotron">
               <h1 class="h3 mb-3 font-weight-normal">Consultar Fornecedores</h1>

               <asp:TextBox ID="txtPesquisar" runat="server"></asp:TextBox>
               <asp:Button ID="btnPesquisar" runat="server"  Text="Pesquisar" OnClick="btnPesquisar_Click" />
               <asp:Button ID="btnVoltar" runat="server"  Text="Voltar" />
               <br />
               <asp:GridView ID="GridFornecedores" runat="server">
               </asp:GridView>

        </div>
    </form>
</body>
</html>
