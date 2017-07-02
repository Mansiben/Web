<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home3.aspx.cs" Inherits="phase1.Home3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet2.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome..<br />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br /><br />
             <asp:Button ID="Snake_Ladder" runat="server" Text="Snake And Ladder" OnClick="Snake_Ladder_Click" />
            <br />
            <br />
            <asp:Button ID="Fun_Match" runat="server" Text="Fun Match" OnClick="Fun_Match_Click" />
        </p>
        <p>
            
            <asp:Button ID="LogOut" runat="server" OnClick="Button_LogOut_Click" Text="Logout" />
        </p>
    </form>
</body>
</html>
