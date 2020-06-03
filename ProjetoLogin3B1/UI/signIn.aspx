<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="ProjetoLogin3B1.UI.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign In</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="lblNomeEmpresa" runat="server" Text="nomeEmpresa"></asp:Label>
            <br />
            <br>
       </div>
        <div class="container-fluid">

            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox type="email" ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator id="ValidacaoEMail" 
                ControlToValidate="txtEmail"
                ErrorMessage="Informe o email"
                Forecolor="Red"
                runat="server"/>


            <br />
             <asp:Label ID="lblPassword"  runat="server" Text="Senha"></asp:Label>
             <asp:TextBox type="password" class="form-control" ID="txtPassword" runat="server"></asp:TextBox>

            <br />

            <br />
            <asp:Button ID="btnEntrar" Class="btn btn-lg btn-primary btn-block" runat="server" OnClick="Button1_Click" Text="Entrar" Width="171px" />

            <br />
            <asp:LinkButton ID="btnCadastrar" runat="server">Não sou Cadastrado. Clique aqui</asp:LinkButton>

        </div>
      
    </form>
</body>
</html>
