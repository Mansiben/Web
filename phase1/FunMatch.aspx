<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FunMatch.aspx.cs" Inherits="phase1.FunMatch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Fun.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Fun Match Game</h1>
    </div>
        <asp:Button ID="NewGame" Text="New Game" runat="server" OnClick="NewGame_Click" />
        <br />
    <div class="table">
       
             <table>
                <tr>
                    <td><asp:ImageButton ID="image1" runat="server" Height="100px" Width="100px" OnClick="image1_Click" ImageUrl="~/PAge.jpg" Visible="False"/></td>
                    <td><asp:ImageButton ID="image2" runat="server" Height="100px" ImageUrl="~/PAge.jpg" Width="100px" OnClick="image2_Click" Visible="False" /></td>
                    <td class="auto-style1"><asp:ImageButton ID="image3" runat="server" Height="100px" ImageUrl="~/PAge.jpg" Width="100px" OnClick="image3_Click" Visible="False" /></td>
                </tr>
                <tr>
                    <td><asp:ImageButton ID="image4" runat="server" Height="100px" ImageUrl="~/PAge.jpg" Width="100px" OnClick="image4_Click" Visible="False" /></td>
                    <td><asp:ImageButton ID="image5" runat="server" Height="100px" ImageUrl="~/PAge.jpg" Width="100px" OnClick="image5_Click" Visible="False" /></td>
                    <td class="auto-style1"><asp:ImageButton ID="image6" runat="server" Height="100px" ImageUrl="~/PAge.jpg" Width="100px" OnClick="image6_Click" Visible="False" /></td>

                </tr>
                <tr>
                    <td><asp:ImageButton ID="image7" runat="server" Height="100px" ImageUrl="~/PAge.jpg" Width="100px" OnClick="image7_Click" Visible="False" /></td>
                    <td><asp:ImageButton ID="image8" runat="server" Height="100px" ImageUrl="~/PAge.jpg" Width="100px" OnClick="image8_Click" Visible="False" /></td>
                </tr>
              </table>
       
       
    </div>
    <div class="info">
        <br />
        <asp:Label ID="Turn" Text="This is Turn # 1"  runat="server" Visible="False"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Go" Text="Go" runat="server" Visible="False" OnClick="Go_Click" />&nbsp;
        <asp:Button ID="PlayAgain" runat="server" OnClick="PlayAgain_Click" Text="Play Again" Visible="False" />
        <asp:Button ID="PickAgain" Text="Pick Again" runat="server" Visible="False" OnClick="PickAgain_Click" />
        <br />
        <asp:Button ID="Exit" Text="Exit Game" runat="server" OnClick="Exit_Click" Visible="False" />
    </div>
    </form>
</body>
</html>
