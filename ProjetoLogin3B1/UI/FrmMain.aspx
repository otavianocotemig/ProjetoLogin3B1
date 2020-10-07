<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMain.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema de Acesso Cotemig</title>
     <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />
</head>
<body>
   <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
  <a class="navbar-brand" href="#">Menu</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarsExampleDefault">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="FrmMain.aspx">Home <span class="sr-only">(current)</span></a>
      </li>
         <li class="nav-item active">
        <a class="nav-link" href="FrmProdutos.aspx">Produtos <span class="sr-only">(current)</span></a>
      </li>
      </ul>
        </div>
     
   </nav>


    <form id="form1" runat="server">
      <div>
             <img class="mb-4" src="../IMG/logocotemig.png" alt="" width="120" height="72">
          <h1 class="h3 mb-3 font-weight-normal">Loja Virtual Cotemig 3B1</h1>

            <asp:Label ID="emailUsuario" runat="server" ForeColor="green" Text="." Visible="true"></asp:Label>
            <br />
           <div class="jumbotron">
               <p><asp:Button ID="btnMeuPerfil"  class="btn btn-primary btn-lg" runat="server" Text="Meu Perfil" OnClick="btnMeuPerfil_Click" />
               <asp:Button ID="btnAdministracao"  class="btn btn-primary btn-lg" runat="server" Text="Consulta Clientes" OnClick="btnAdministracao_Click" />
               <asp:Button ID="btnConsultaFornecedor"  class="btn btn-primary btn-lg" runat="server" Text="Consulta Fornecedor" OnClick="Button1_Click"  />
               <asp:Button ID="btnClientes"  class="btn btn-primary btn-lg" runat="server" Text="Clientes" OnClick="btnClientes_Click"  />
               <asp:Button ID="btnProdutos"  class="btn btn-primary btn-lg" runat="server" Text="Produtos" OnClick="btnProdutos_Click"  /></p>
                      
    
           </div>
        </div>
		
      
    </form>
</body>

</html>
