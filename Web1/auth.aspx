<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="auth.aspx.vb" Inherits="Web1.auth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            width: 170px;
            margin-left: 20px;
        }
        #TextBox2 {
            margin-left: 20px;
        }
    </style>
</head>
<body style="">
    <div style="background-color:blueviolet; font-size:xx-large; color:white; text-align:center">
    Gestion des Employées 
</div>
    <br />
<div style="text-align:center">
    <fieldset style="background-color: blueviolet; color: white; width: 379px; text-align:center;margin-left:500px">
        <legend style="color: blue">&nbsp;</legend>

    <form id="form1" runat="server">
    <h1 style="width: 278px; margin-left: 60px;color: white; height: 39px;">Authentification</h1>

        <div>
        <p style="width: 287px">Login<asp:TextBox ID="TextBox1" runat="server" Height="20px" style="margin-left: 60px" Width="177px"></asp:TextBox>
        </p>
    </div>
        <p style="width: 289px" id="Passe">
            Mot de pass<asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="177px" TextMode="Password"></asp:TextBox>
        </p> 
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#0099CC" BorderStyle="None" Font-Size="Medium" ForeColor="White" Height="34px" style="margin-left: 0px" Text="Connecter" Width="120px" />
        </p>
    </form>
    </fieldset>
    </div>
</body>
</html>
