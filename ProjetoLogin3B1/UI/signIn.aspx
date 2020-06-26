<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="ProjetoLogin3B1.UI.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign In</title>
     <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form id="form1" class="form-signin" runat="server">
        
        <div>
             <img class="mb-4" src="../IMG/logocotemig.png" alt="" width="120" height="72">
      <h1 class="h3 mb-3 font-weight-normal">Acesso ao Sistema</h1>

            <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox type="email" ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
           

            <br />
             <asp:Label ID="lblPassword"  runat="server" Text="Senha"></asp:Label>
             <asp:TextBox type="password" class="form-control" ID="txtPassword" runat="server"></asp:TextBox>

            <br />

            <br />
            <asp:Button ID="btnEntrar" Class="btn btn-lg btn-primary btn-block" runat="server" OnClick="Button1_Click" Text="Entrar"  />

            <br />
            <asp:LinkButton ID="btnCadastrar" class="btn btn-link"  runat="server">Não sou Cadastrado. Clique aqui</asp:LinkButton>
            <asp:LinkButton ID="btnEsqueciSenha" class="btn btn-link"  runat="server" OnClick="btnEsqueciSenha_Click">Esqueci Minha Senha</asp:LinkButton>

        </div>
      <p class="mt-5 mb-3 text-muted">
            <asp:Label  ID="lblNomeEmpresa"  runat="server" Text ="nomeEmpresa"></asp:Label>
          &copy; 2017-2018</p>
    </form>
</body>
</html>
