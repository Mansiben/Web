<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="phase1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Login33.css" type="text/css" />
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div>
    <h1><b>Games.. Go for it</b></h1>
        <h1><b>Create an account  to get more fun with games...</b></h1>
    </div>
        <p>
            &nbsp;</p>
        <p style="margin-left: 320px">
            &nbsp;</p>
        <p style="margin-left: 440px">
            <asp:Label ID="Label1" runat="server" Text="Username" Font-Bold="true" Font-Size="Larger"></asp:Label>
            <asp:TextBox ID="TextBox_ID" runat="server"></asp:TextBox>
            &nbsp;</p>
        <p style="margin-left: 440px">
            <asp:Label ID="Label2" runat="server" Text="Password"  Font-Bold="true" Font-Size="Larger"></asp:Label>
            <asp:TextBox ID="TextBox_pass" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p style="margin-left: 440px">
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <div style="margin-left: 480px">
            <asp:Button ID="Button_Login" runat="server" OnClick="Button_Login_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonSignup" runat="server" OnClick="ButtonSignup_Click" Text=" Sign Up" />
        </div>
        <p style="margin-left: 320px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
