<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="phase1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <link rel="stylesheet" href="StyleSheet2.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label_session" runat="server" Text="Label1"></asp:Label>
        <h1>GAME HOUSE..</h1>
    </div>
         <div class="Main">
            
            <br />
            <br />
            <asp:Button ID="Snake_Ladder" runat="server" Text="Snake And Ladder" OnClick="Snake_Ladder_Click" />
            <br />
            <br />
            <asp:Button ID="Fun_Match" runat="server" Text="Fun Match" OnClick="Fun_Match_Click" />
             <br />
             <br />
             <asp:Button ID="Log" runat="server" OnClick="Button_LogOut_Click" Text="Logout" />
             <br />
        </div>
    </form>
</body>
</html>
