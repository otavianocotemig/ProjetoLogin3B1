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
    <form id="form1" runat="server">
      <div>
             <img class="mb-4" src="../IMG/logocotemig.png" alt="" width="120" height="72">
          <h1 class="h3 mb-3 font-weight-normal">Loja Virtual Cotemig 3B1</h1>

            <asp:Label ID="emailUsuario" runat="server" ForeColor="green" Text="." Visible="true"></asp:Label>
            <br />
           <div class="jumbotron">
               <p><asp:Button ID="btnMeuPerfil"  class="btn btn-primary btn-lg" runat="server" Text="Meu Perfil" OnClick="btnMeuPerfil_Click" />
               <asp:Button ID="btnAdministracao"  class="btn btn-primary btn-lg" runat="server" Text="Administração" /></p>
                      
    
           </div>
        </div>
		
      
    </form>
</body>
</html>
