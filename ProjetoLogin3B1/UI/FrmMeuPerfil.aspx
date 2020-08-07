<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMeuPerfil.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmMeuPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Meu Perfil</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          <div class="jumbotron">
               <h1 class="h3 mb-3 font-weight-normal">Meu Perfil</h1>
             <br />
             <asp:Label  runat="server" Text="Nome"></asp:Label>
             <asp:TextBox  class="form-control" ID="nomeCliente" runat="server"></asp:TextBox>
             <asp:Label  runat="server" Text="SobreNome"></asp:Label>
             <asp:TextBox  class="form-control" ID="sobreNomeCliente" runat="server"></asp:TextBox>
            
             <asp:Label ID="lblPassword"  runat="server" Text="Nova Senha"></asp:Label>
             <asp:TextBox type="password" class="form-control" ID="txtPassword" runat="server"></asp:TextBox>
             
             <asp:Label ID="Label1"  runat="server" Text="Repita a Nova Senha"></asp:Label>
             <asp:TextBox type="password" class="form-control" ID="txtRPassword" runat="server"></asp:TextBox>
              
            <br />
            <asp:Button ID="btnEntrar" Class="btn btn-lg btn-primary btn-block" runat="server"  Text="Gravar"  />
            <asp:Button ID="btnRetornar" Class="btn btn-lg btn-primary btn-block" runat="server"  Text="Retornar" OnClick="btnRetornar_Click"  />

            <br />
        </div>
    </form>
</body>
</html>
