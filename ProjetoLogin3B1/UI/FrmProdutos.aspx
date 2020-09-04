<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmProdutos.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmProdutos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Produtos</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
         <div class="jumbotron">
               <h1 class="h3 mb-3 font-weight-normal">Produtos</h1>
              <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
             <br />
        </div>
           <p>
               <asp:TextBox ID="txtPesquisar" class="form-control" runat="server"></asp:TextBox>
               <asp:Button ID="btnPesquisar" Class="btn btn-lg btn-primary" runat="server"  Text="Pesquisar" OnClick="btnPesquisar_Click" />
               <asp:Button ID="btnNovo" Class="btn btn-lg btn-primary" runat="server"  Text="Novo Produto"  /> 
               <asp:Button ID="btnVoltar" Class="btn btn-lg btn-primary" runat="server"  Text="Voltar" OnClick="btnVoltar_Click" />
               </p>
               
           <asp:GridView ID="GridProdutos" CssClass="table-responsive-sm" runat="server" AllowPaging="True" OnPageIndexChanging="GridProdutos_PageIndexChanging" OnRowDeleting="GridProdutos_RowDeleting" PageSize="5">
               <Columns>
                   <asp:CommandField ShowDeleteButton="True" />
                   <asp:CommandField ShowSelectButton="True" />
               </Columns>
                  
               <PagerSettings PageButtonCount="5" Position="TopAndBottom" />
                  
            </asp:GridView>

           </div>

    </form>
</body>
</html>
