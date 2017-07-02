<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="phase1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="StyleSheet2.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <div class="formDetails">
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox_Username" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email Id"></asp:Label>
            <asp:TextBox ID="TextBox_EmailID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label_Password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox_Password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label_Confirm" runat="server" Text="Confirm Password "></asp:Label>
            <asp:TextBox ID="TextBox_Confirm" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button_SignUp" runat="server" OnClick="Button_SignUp_Click" Text="Sign Up" />
        </div>
    </form>
</body>
</html>
