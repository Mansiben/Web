<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SnakeGame.aspx.cs" Inherits="phase1.SnakeGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Snake.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
         <h1><b>Snake And Ladder..</b></h1>
         <div class="MainContent">
                
                <asp:Label ID="Label3" runat="server" Text="Player1"></asp:Label>
                <asp:TextBox ID="TextBox_Player1" runat="server"></asp:TextBox>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Player2"></asp:Label>
                <asp:TextBox ID="TextBox_Player2" runat="server"></asp:TextBox>
            </p>
           
       
            <p style="margin-left: 80px">
                <asp:Button ID="Play_Game" runat="server" Text="Play Game" OnClick="Play_Game_Click" />
            </p>
          </div>
        <div class="Main" style="margin-left: 320px">
            <div class="AllLabels">
                <aside>
                    <asp:Label ID="Player1_Label" runat="server" Text="Player1" Visible="False"></asp:Label>
                    <asp:Label ID="Label1" runat="server" Text="name 1" Visible="False"></asp:Label><br />
                    <asp:Label ID="Player2_Label" runat="server" Text="Player2" Visible="False"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="name 2" Visible="False"></asp:Label><br />
                    <asp:Label ID="Current_Label" runat="server" Text="Current Player" Visible="False"></asp:Label><br />
                    <asp:Label ID="Status" runat="server" Text="Status" Visible="false"></asp:Label><br />
                    <asp:Button ID="Roll_Dice" runat="server" Text="Roll Dice" OnClick="Roll_Dice_Click" Visible="False" />
                    &nbsp;&nbsp;
                    <asp:Image ID="DiceImages" runat="server" /><br /><br />
                    <asp:Label ID="HighScore" runat="server" Text="Score:" Visible="false"></asp:Label><br />

                    
                   
                    
                </aside>
            </div>
            
            <div class="ImageButton">
                 <asp:Button ID="Play_Again" runat="server" Text="Play Again"  Visible="False" OnClick="Play_Again_Click" /> 
                 <asp:Button ID="Reset" runat="server" Text="Reset Board" OnClick="Reset_Click" Visible="False" />
                 <asp:Button ID="Exit" runat="server" Text="Exit Game" OnClick="Exit_Click" Visible="False" /> <br />
                 <asp:ImageButton ID="Board_Image" runat="server" Height="516px" ImageUrl="~/Final_Board.jpg" Width="584px" Visible="False" />

            </div>
        </div>
    </form>
</body>
</html>
