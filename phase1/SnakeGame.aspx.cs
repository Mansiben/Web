using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace phase1
{
    public partial class SnakeGame : System.Web.UI.Page
    {
        bool PlayerTurn = true;
        int DiceNumber = 0;
        public static int count;
        public static int Playerturncount;
        public static int Player1Locat;//count for player1
        public static int Player2Locat;// count for player2
        public string Player1_name;
        public string Player2_name;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Play_Again_Click(object sender, EventArgs e)
        {
            TextBox_Player1.Visible = true;
            TextBox_Player2.Visible = true;
            Play_Game.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Player1_Label.Visible = false;
            Player2_Label.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Reset.Visible = false;
            Roll_Dice.Visible = false;
            Board_Image.Visible = false;
            Current_Label.Visible = false;
            Play_Again.Visible = false;
            DiceImages.Visible = false;
            Status.Visible = false;
            TextBox_Player1.Text = "";
            TextBox_Player2.Text = "";
            HighScore.Visible = false;
            count = 0;
        }

        protected void Play_Game_Click(object sender, EventArgs e)
        {
            Player1_name = TextBox_Player1.Text.ToString();
            Player2_name = TextBox_Player2.Text.ToString();
            TextBox_Player1.Visible = false;
            TextBox_Player2.Visible = false;
            Play_Game.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Player1_Label.Visible = true;
            Player2_Label.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label1.Text = Player1_name;
            Label2.Text = Player2_name;
            Reset.Visible = true;
            Exit.Visible = true;
            Roll_Dice.Visible = true;
            Board_Image.Visible = true;
            Current_Label.Visible = true;
            Play_Again.Visible = true;
            HighScore.Visible = false;
            count = 0;
        }

        protected void Roll_Dice_Click(object sender, EventArgs e)
        {
            Current_Label.Visible = true;
            Random rn = new Random();
            int RandomDiceNumber = rn.Next(1, 7);
            switch (RandomDiceNumber)
            {
                case 1:
                    DiceImages.Visible = true;
                    DiceImages.ImageUrl = "1.jpg";
                    break;
                case 2:
                    DiceImages.Visible = true;
                    DiceImages.ImageUrl = "2.jpg";
                    break;
                case 3:
                    DiceImages.Visible = true;
                    DiceImages.ImageUrl = "3.jpg";
                    break;
                case 4:
                    DiceImages.Visible = true;
                    DiceImages.ImageUrl = "4.jpg";
                    break;
                case 5:
                    DiceImages.Visible = true;
                    DiceImages.ImageUrl = "5.jpg";
                    break;
                case 6:
                    DiceImages.Visible = true;
                    DiceImages.ImageUrl = "6.jpg";
                    break;


            }
            DiceNumber = RandomDiceNumber;
            Playerturncount++;
            if (Playerturncount % 2 == 0)
            {
                PlayerTurn = true;
                Current_Label.Text = "Current Player:" + TextBox_Player1.Text;
            }
            else
            {
                PlayerTurn = false;
                Current_Label.Text = "Current Player:" + TextBox_Player2.Text;
            }
            if (PlayerTurn == true)
            {

                Player1Locat = Player1Locat + RandomDiceNumber;
                Status.Visible = true;
                Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                //region snake 
                switch (Player1Locat)
                {
                    case 12:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player1Locat = 2;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 20:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player1Locat = 5;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 39:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player1Locat = 22;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 44:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player1Locat = 15;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 47:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player1Locat = 30;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 54:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player1Locat = 19;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                }
                //region end
                // region Laddar
                switch (Player1Locat)
                {
                    case 3:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player1Locat = 10;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 9:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player1Locat = 21;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 18:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player1Locat = 35;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 13:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player1Locat = 31;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 25:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player1Locat = 40;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 36:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player1Locat = 51;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                    case 48:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player1Locat = 50;
                        Status.Text = "Player1 You are here at" + Player1Locat.ToString();
                        break;
                }
                //region end
                //Winning
                if (Player1Locat >= 55 && Player1Locat <= 65)
                {
                    count++;
                    HighScore.Visible = true;
                    HighScore.Text = TextBox_Player1.Text + "You scored:-" + count;
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Congratulations..Player1 Wins:)" + "');", true);
                    Player1Locat = 66;
                    Player2Locat = 66;

                }
                //end winning
            }
            else if (PlayerTurn == false)
            {
                Player2Locat = Player2Locat + RandomDiceNumber;
                Status.Visible = true;
                Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                //region snake 
                switch (Player2Locat)
                {
                    case 12:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player2Locat = 2;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 20:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player2Locat = 5;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 39:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player2Locat = 22;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 44:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player2Locat = 15;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 47:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player2Locat = 30;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 54:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Bite By Snake:(" + "');", true);
                        Player2Locat = 19;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                }
                //region end
                // region Laddar
                switch (Player2Locat)
                {
                    case 3:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player2Locat = 10;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 9:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player2Locat = 21;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 18:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player1Locat = 35;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 13:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player2Locat = 31;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 25:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player2Locat = 40;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 36:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player2Locat = 51;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                    case 48:
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "You Got Laddar:)" + "');", true);
                        Player2Locat = 50;
                        Status.Text = "Player2 You are here at" + Player2Locat.ToString();
                        break;
                }
                //region end
                if (Player2Locat >= 55 && Player2Locat <= 65)
                {
                    count++;
                    HighScore.Visible = true;
                    HighScore.Text = TextBox_Player1.Text + "You scored:-" + count;
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Congratulations..Player1 Wins:)" + "');", true);
                    Player1Locat = 66;
                    Player2Locat = 66;

                }
                //end winning

            }
        }

        protected void Reset_Click(object sender, EventArgs e)
        {

            PlayerTurn = true;
            DiceNumber = 0;
            Playerturncount = 0;
            Player1Locat = 0;
            Player2Locat = 0;
            Current_Label.Visible = false;
            Status.Visible = false;
            DiceImages.Visible = false;
            HighScore.Visible = false;
            count = 0;

        }

        protected void Exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}