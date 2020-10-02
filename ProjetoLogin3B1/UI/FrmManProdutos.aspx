<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmManProdutos.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmManProdutos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <title>Manutenção de Produtos</title>
     <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body class="align-content-center">
    <form id="form1" runat="server">
          <div class="jumbotron">
           
           <h1 class="h3 mb-3 font-weight-normal">Produtos</h1>

             <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
              <br />

              <asp:Label ID="Label5" runat="server" Text="Código "></asp:Label>
              <asp:TextBox ID="txtId" type="text" runat="server" CssClass="form-control" Enabled="False" ></asp:TextBox>

             <asp:Label ID="lblNome" runat="server" Text="Nome do Produto "></asp:Label>
             <asp:TextBox ID="txtNomeProduto" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="lblDescricao" runat="server" Text="Descrição do Produto "></asp:Label>
             <asp:TextBox ID="txtDescricao" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label2" runat="server" Text="Preço "></asp:Label>
             <asp:TextBox ID="txtPreco" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label3" runat="server" Text="Quantidade "></asp:Label>
             <asp:TextBox ID="txtQuantidade" type="text" runat="server" CssClass="form-control" ></asp:TextBox>

             <asp:Label ID="Label1" runat="server" Text="Peso"></asp:Label>
             <asp:TextBox ID="txtPeso" runat="server" CssClass="form-control" ></asp:TextBox>

              <asp:Label ID="Label4" runat="server" Text="Categoria"></asp:Label>
              <asp:DropDownList ID="drpCategoria" runat="server" CssClass="form-control"></asp:DropDownList>

              <asp:Label ID="Label6" runat="server" Text="Fornecedor"></asp:Label>
              <asp:DropDownList ID="drpFornecedor" runat="server" CssClass="form-control"></asp:DropDownList>
              <p>
                     <asp:Label ID="Label7" runat="server" Text="Foto do Produto"></asp:Label></p>
              <p>

                     <asp:Image ID="imgproduto" runat="server" Height="103px" Width="166px" />

                     <asp:FileUpload ID="FotoProduto" runat="server" CssClass="form-control"/>

              </p>
           
            <asp:Button ID="btnGravar" class="btn btn-lg btn-primary" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
            <asp:Button ID="btnRetornar" class="btn btn-lg btn-primary" runat="server" Text="Retornar" OnClick="btnRetornar_Click" />
       <br />
        </div>
    </form>
</body>
</html>
