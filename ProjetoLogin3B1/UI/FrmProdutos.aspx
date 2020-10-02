<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmProdutos.aspx.cs" Inherits="ProjetoLogin3B1.UI.FrmProdutos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Produtos</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/signin.css" rel="stylesheet" />

    
<script type="text/javascript">
 function LoadDiv(url)
 {
    var img = new Image();
    var bcgDiv = document.getElementById("divBackground");
    var imgDiv = document.getElementById("divImage");
    var imgFull = document.getElementById("imgFull");
    var imgLoader= document.getElementById("imgLoader");

    imgLoader.style.display = "block";
    img.onload = function() {
        imgFull.src = img.src;
        imgFull.style.display = "block";
        imgLoader.style.display = "none";
    };
    img.src= url;
    var width = document.body.clientWidth;
    if (document.body.clientHeight > document.body.scrollHeight)
    {
        bcgDiv.style.height = document.body.clientHeight + "px";
    }
    else
    {
        bcgDiv.style.height = document.body.scrollHeight + "px" ;
    }

    imgDiv.style.left = (width-650)/2 + "px";
    imgDiv.style.top =  "20px";
    bcgDiv.style.width="100%";
    
     bcgDiv.style.display="block";
    imgDiv.style.display="block";
    return false;
 } 
 function HideDiv()
 {
    var bcgDiv = document.getElementById("divBackground");
    var imgDiv = document.getElementById("divImage");
    var imgFull = document.getElementById("imgFull");
    if (bcgDiv != null)
    {
        bcgDiv.style.display="none";
        imgDiv.style.display="none";
        imgFull.style.display = "none";
    }
 }
</script>

<style type="text/css">
     body 
     {
        margin:0;
        padding:0;
        height:100%; 
        overflow-y:auto;  
     }
     .modal
     {
        display: none; 
        position: absolute;
        top: 0px; 
        left: 0px;
        background-color:black;
        z-index:100;
        opacity: 0.8;
        filter: alpha(opacity=60);
        -moz-opacity:0.8;
        min-height: 100%;
     }
     #divImage
     {
        display: none;
        z-index: 1000;
        position: fixed;
        top: 0;
        left: 0;
        background-color:White;
        height: 550px;
        width: 600px;
        padding: 3px;
        border: solid 1px black;
     }
     * html #divImage {position:absolute;}
</style>
<!--[if lte IE 6]>
   <style type="text/css">
   /*<![CDATA[*/ 
html {overflow-x:auto; overflow-y:hidden;}
   /*]]>*/
   </style>
<![endif]-->

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
               <asp:Button ID="btnNovo" Class="btn btn-lg btn-primary" runat="server"  Text="Novo Produto" OnClick="btnNovo_Click"  /> 
               <asp:Button ID="btnVoltar" Class="btn btn-lg btn-primary" runat="server"  Text="Voltar" OnClick="btnVoltar_Click" />
               </p>
               
           <asp:GridView ID="GridProdutos" CssClass="table-responsive-sm" runat="server" AllowPaging="True" OnPageIndexChanging="GridProdutos_PageIndexChanging" OnRowDeleting="GridProdutos_RowDeleting">
               <Columns>
                   <asp:CommandField ShowDeleteButton="True" />
                   <asp:TemplateField>
                       <ItemTemplate>
                           <a href='FrmManProdutos.aspx?idProduto=<%# Eval("id") %>'> Alterar</a>
                       </ItemTemplate>

                   </asp:TemplateField>

                   <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="imgBtn1" runat="server" ImageUrl='<%# "~//imgProdutos//"+Eval("foto") %>' Width="50px" Height="50px" OnClientClick ="return LoadDiv(this.src);" />
                        </ItemTemplate>
                   </asp:TemplateField>
               </Columns>
                  
               <PagerSettings PageButtonCount="10" Position="TopAndBottom" />
                  
            </asp:GridView>

           </div>

                
<div id="divBackground" class="modal">
</div>
<div id="divImage" class = "info">
    <table style="height: 100%; width: 100%">
        <tr>
            <td valign="middle" align="center">
                <img id="imgLoader" alt=""
                 src="images/loader.gif" />
                <img id="imgFull" runat="server" alt="" src="" 
                 style="display: none;
                height: 500px;width: 590px" />
            </td>
        </tr>
        <tr>
            <td align="center" valign="bottom">
                <input id="btnClose" type="button" value="Fechar"
                    onclick="HideDiv()" />
            </td>
        </tr>
    </table>
</div>
    </form>
</body>
</html>
