<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="home.aspx.vb" Inherits="Web1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 452px;
        }
        .auto-style4 {
            height: 23px;
            width: 452px;
        }
        .auto-style5 {
            margin-left: 963px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div style="background-color:blueviolet; font-size:xx-large; color:white; text-align:center">
    Gestion des Employées 
</div>
    <div style="padding:10px 0px ">

        <asp:Button ID="BtnDec" runat="server" BackColor="#3366FF" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="31px" style="margin-left: 0px" Text="Depatments" Width="181px" />

        <asp:Button ID="BtnDeco" runat="server" BackColor="#3366FF" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="31px" Text="Déconnecter" Width="200px" CssClass="auto-style5" />

    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="idEmp" runat="server" Font-Bold="True" Font-Size="Medium" Text="ID Employee"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="id_emp" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
        <asp:Button ID="btnCherch" runat="server" BackColor="#9900FF" BorderStyle="None" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="32px" style="margin-left: 4px" Text="Chercher" Width="89px" />
       
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="nniEmp" runat="server" Font-Bold="True" Font-Size="Medium" Text="NNI"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="nni_emp" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="nomEmp" runat="server" Font-Bold="True" Font-Size="Medium" Text="Nom"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="nom_emp" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="prenomEmp" runat="server" Font-Bold="True" Font-Size="Medium" Text="Prénom"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="prenom_emp" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="telEmp" runat="server" Font-Bold="True" Font-Size="Medium" Text="Téléphone"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tel_emp" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="idEmp4" runat="server" Font-Bold="True" Font-Size="Medium" Text="ID Department"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="idDep" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id" Font-Size="Medium" Height="24px" Width="208px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GestionEmpConnectionString %>" SelectCommand="SELECT [id], [nom] FROM [Department]"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>
        <asp:Button ID="btnAdd" runat="server" BackColor="#9900FF" BorderStyle="None" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="32px" style="margin-left: 456px" Text="Ajouter" Width="89px" />
       
        &nbsp;<asp:Button ID="btnUpdate" runat="server" BackColor="#9900FF" BorderStyle="None" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="32px" style="margin-left: 9px" Text="Modifier" Width="89px" />
       
        <asp:Button ID="btndelete" runat="server" BackColor="#9900FF" BorderStyle="None" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="32px" style="margin-left: 13px" Text="Supprimer" Width="89px" OnClientClick="return confirm(&quot;Etes vous sur ?&quot;);" />
       
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
&nbsp;
       
        <div style="text-align:center">
            <hr />

            <asp:GridView ID="DonnesEmp" runat="server" style="margin-left: 117px" Width="80%">
                <HeaderStyle BackColor="#9900FF" ForeColor="White" />
            </asp:GridView>

        </div>
         </form>
</body>
</html>
