<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WF1.aspx.vb" Inherits="Web1.WF1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 231%;
            margin-right: 46px;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
            width: 383px;
        }
        .auto-style7 {
            width: 383px;
            height: 34px;
        }
        .auto-style8 {
            height: 34px;
        }
        .auto-style9 {
            width: 5px;
        }
        .auto-style10 {
            width: 383px;
        }
        .auto-style11 {
            width: 915px;
        }
        .auto-style12 {
            width: 1357px;
        }
        .auto-style13 {
            margin-left: 950px;
        }
        .auto-style14 {
            margin-left: 302px;
        }
    </style>
</head>
<body style="margin-left: 3px">
    <form id="form1" runat="server">
    <div style="background-color:blueviolet; font-size:xx-large; color:white; text-align:center; " class="auto-style12">
        Gestion des Departments</div>
     <div style="padding:10px 0px ">

        <asp:Button ID="BtnDec" runat="server" BackColor="#3366FF" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="31px" style="margin-left: 0px" Text="Employees" Width="207px" />

        <asp:Button ID="BtnDec0" runat="server" BackColor="#3366FF" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="31px" Text="Déconnecter" Width="190px" CssClass="auto-style13" />

    </div>
        <br />
        <hr class="auto-style11" />
    <div>
        <p style="width: 287px"></p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8" style="font-weight: bold">ID<asp:TextBox ID="TextBox1" runat="server" Height="20px" style="margin-left: 46px" Width="192px"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" BackColor="#9900CC" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="27px" style="margin-left: 17px" Text="Chercher" Width="88px" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
        <p class="auto-style9">
            &nbsp;</p>
                </td>
                <td class="auto-style4" style="font-weight: bold">Nom<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 33px" Width="192px" Height="20px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td>
            <asp:Button ID="Button1" runat="server" BackColor="#9900CC" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="29px" style="margin-left: 67px" Text="Ajouter" Width="92px" Font-Bold="True" />
            <asp:Button ID="Button2" runat="server" BackColor="#9900CC" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="27px" style="margin-left: 17px" Text="Supprimer" Width="88px" OnClientClick="return confirm(&quot;Etes vous sur de Supprimer un department avec ses Employée ?&quot;);" Font-Bold="True" />
            <asp:Button ID="Button3" runat="server" BackColor="#9900CC" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="27px" style="margin-left: 17px" Text="Modifier" Width="88px" Font-Bold="True" />
                </td>
            </tr>
            </table>
        </p>
    </div>
         <br />
        <hr />
    <div style="width: 400px; margin-top: 1px">
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GestionEmpConnectionString %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="id" DataSourceID="SqlDataSource1" Width="665px" style="margin-right: 0px" CssClass="auto-style14">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nom" HeaderText="nom" SortExpression="nom" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="Black" Font-Bold="True" />
            <HeaderStyle BackColor="#9900CC" Font-Bold="True" ForeColor="White" Font-Size="Medium" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" BackColor="White" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
