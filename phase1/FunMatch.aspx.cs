using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace phase1
{
    public partial class FunMatch : System.Web.UI.Page
    {
        public static string flag1;
        public static string flag2;
        public static string flag3;
        public static string flag4;
        public static string flag5;
        public static string flag6;
        public static string flag7;
        public static string flag8;
        public static int count;
        public static int cc;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NewGame_Click(object sender, EventArgs e)
        {
            image1.Visible = true;
            image2.Visible = true;
            image3.Visible = true;
            image4.Visible = true;
            image5.Visible = true;
            image6.Visible = true;
            image7.Visible = true;
            image8.Visible = true;
            Turn.Visible = true;
            Go.Visible = true;
            PickAgain.Visible = false;
            Exit.Visible = true;
            count = 0;
            cc = 0;

        }

        protected void image1_Click(object sender, ImageClickEventArgs e)
        {
            flag1 = "Tom";
            image1.Enabled = false;
        }

        protected void image2_Click(object sender, ImageClickEventArgs e)
        {
            flag3 = "Noddy";
            image2.Enabled = false;
        }

        protected void image3_Click(object sender, ImageClickEventArgs e)
        {
            flag6 = "Doraemon";
            image3.Enabled = false;
        }

        protected void image4_Click(object sender, ImageClickEventArgs e)
        {
            flag4 = "Noddy";
            image4.Enabled = false;
        }

        protected void image5_Click(object sender, ImageClickEventArgs e)
        {
            flag7 = "Shinchan";
            image5.Enabled = false;
        }

        protected void image6_Click(object sender, ImageClickEventArgs e)
        {

            flag8 = "Shinchan";
            image6.Enabled = false;
        }

        protected void image7_Click(object sender, ImageClickEventArgs e)
        {
            flag5 = "Doraemon";
            image7.Enabled = false;
        }

        protected void image8_Click(object sender, ImageClickEventArgs e)
        {
            flag2 = "Tom";
            image8.Enabled = false;
        }

        protected void Go_Click(object sender, EventArgs e)
        {

            count++;
            image1.Enabled = true;
            image2.Enabled = true;
            image3.Enabled = true;
            image4.Enabled = true;
            image5.Enabled = true;
            image6.Enabled = true;
            image7.Enabled = true;
            image8.Enabled = true;
            Go.Text = "Pick Again";
            Turn.Visible = true;
            Turn.Text = "Oops Turn #" + (count + 1);
            if (image1.Enabled == false)
            {
                image1.ImageUrl = "TomJerry-300x300.jpg";
            }
            if (image2.Enabled == false)
            {
                image2.ImageUrl = "noddy_and_friends_Noddy_2.jpg";
            }
            if (image3.Enabled == false)
            {
                image3.ImageUrl = "Doraemon.jpg";
            }
            if (image4.Enabled == false)
            {
                image4.ImageUrl = "noddy_and_friends_Noddy_2.jpg";
            }
            if (image5.Enabled == false)
            {
                image5.ImageUrl = "Shinchan.jpg";
            }
            if (image6.Enabled == false)
            {
                image6.ImageUrl = "Shinchan.jpg";
            }
            if (image7.Enabled == false)
            {
                image7.ImageUrl = "Doraemon.jpg";
            }
            if (image8.Enabled == false)
            {
                image8.ImageUrl = "TomJerry-300x300.jpg";
            }



            if (flag1 == "Tom" && flag2 == "Tom")
            {


                flag1 = null;
                flag2 = null;
                cc++;
                image1.ImageUrl = "TomJerry-300x300.jpg";
                image8.ImageUrl = "TomJerry-300x300.jpg";
                image1.Enabled = false;
                image8.Enabled = false;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Match Found" + "');", true);

            }
            else if (flag3 == "Noddy" && flag4 == "Noddy")
            {


                flag3 = null;
                flag4 = null;
                cc++;
                image2.ImageUrl = "noddy_and_friends_Noddy_2.jpg";
                image4.ImageUrl = "noddy_and_friends_Noddy_2.jpg";
                image2.Enabled = false;
                image4.Enabled = false;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Match Found" + "');", true);


            }
            else if (flag5 == "Doraemon" && flag6 == "Doraemon")
            {


                flag5 = null;
                flag6 = null;
                cc++;
                image3.ImageUrl = "Doraemon.jpg";
                image7.ImageUrl = "Doraemon.jpg";
                image3.Enabled = false;
                image7.Enabled = false;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Match Found" + "');", true);


            }
            else if (flag7 == "Shinchan" && flag8 == "Shinchan")
            {
                flag7 = null;
                flag8 = null;
                cc++;
                image5.ImageUrl = "Shinchan.jpg";
                image6.ImageUrl = "Shinchan.jpg";
                image5.Enabled = false;
                image6.Enabled = false;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Match Found" + "');", true);

            }

            else if (cc == 4)
            {
                Turn.Visible = false;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Game Over.. You took  " + count + " Turns to win" + "');", true);
                PlayAgain.Visible = true;

            }

            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Pick Again" + "');", true);
                flag1 = null;
                flag2 = null;
                flag3 = null;
                flag4 = null;
                flag5 = null;
                flag6 = null;
                flag7 = null;
                flag8 = null;


            }
        }

        protected void PlayAgain_Click(object sender, EventArgs e)
        {
            image1.Visible = true;
            image2.Visible = true;
            image3.Visible = true;
            image4.Visible = true;
            image5.Visible = true;
            image6.Visible = true;
            image7.Visible = true;
            image8.Visible = true;
            Turn.Visible = true;
            count = 0;
            cc = 0;
            Turn.Text = "This is Turn #" + (count + 1);
            Go.Visible = true;
            PickAgain.Visible = false;
            PlayAgain.Visible = false;

            image1.ImageUrl = "PAge.jpg";
            image2.ImageUrl = "PAge.jpg";
            image3.ImageUrl = "PAge.jpg";
            image4.ImageUrl = "PAge.jpg";
            image5.ImageUrl = "PAge.jpg";
            image6.ImageUrl = "PAge.jpg";
            image7.ImageUrl = "PAge.jpg";
            image8.ImageUrl = "PAge.jpg";
        }

        protected void PickAgain_Click(object sender, EventArgs e)
        {

        }

        protected void Exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}