using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace phase1
{
    public partial class Login : System.Web.UI.Page
    {
        public static string Name,Pass;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {

            string connectionString = null;
            SqlConnection conn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
            connectionString = ConfigurationManager.ConnectionStrings["GameConnString"].ConnectionString;
            using (conn = new SqlConnection(connectionString))
            {
                sql = "Select * from Players where Username=@name and Password=@password";
                conn.Open();
                using (SqlCommand sqlComm = new SqlCommand(sql, conn))
                {

                    sqlComm.Parameters.AddWithValue("@name", TextBox_ID.Text);
                    sqlComm.Parameters.AddWithValue("@password", TextBox_pass.Text);
                   
                    SqlDataReader reader = sqlComm.ExecuteReader();
                    
                    bool x = reader.HasRows;
                    if (reader.Read())
                    {
                        Session["Username"] = reader["Username"].ToString();
                        Session["Password"] = reader["Password"].ToString();
                        Name = Session["Username"].ToString();
                        Pass = Session["Password"].ToString();
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Username or Pasword incorrect" + "');", true);
                    }
                    if (TextBox_ID.Text == "" || TextBox_pass.Text == "" || TextBox_ID.Text == null || TextBox_pass.Text == null)
                    {
                        Label3.Visible = true;
                        Label3.Text = "Please enter the fields:";
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Please enter Username or Password" + "');", true);
                    }

                }
            }
           

        }
            

        protected void ButtonSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}