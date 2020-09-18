﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCadCliente.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmCadCliente" %>

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
               <h1 class="h3 mb-3 font-weight-normal">Cadastro de Clientes</h1>
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

            <asp:Button ID="btnInserir" Class="btn btn-lg btn-primary" runat="server"  Text="Gravar" OnClick="btnInserir_Click"  />
            <asp:Button ID="btnRetornar" Class="btn btn-lg btn-primary" runat="server"  Text="Retornar" OnClick="btnRetornar_Click"  />
             </div>       
           
           
        </div>


    </form>
</body>
</html>
