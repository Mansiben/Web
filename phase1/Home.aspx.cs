using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace phase1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Username"]!=null && Session["Password"]!=null)
            {
                Label_session.Text = " Welcome.." + Session["Username"].ToString();
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Please enter Username or Password" + "');", true);
            }
        }

        protected void Snake_Ladder_Click(object sender, EventArgs e)
        {
            Response.Redirect("SnakeGame.aspx");
        }

        protected void Fun_Match_Click(object sender, EventArgs e)
        {
            Response.Redirect("FunMatch.aspx");
            
        }

        protected void Button_LogOut_Click(object sender, EventArgs e)
        {
            Session["Username"] = null;
            Session["Password"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}