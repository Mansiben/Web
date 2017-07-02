using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace phase1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button_SignUp_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection conn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
            connectionString = ConfigurationManager.ConnectionStrings["GameConnString"].ConnectionString;
            using (conn = new SqlConnection(connectionString))
            {
                sql = "insert into Players([Username], [EmailID], [Password]) values(@name,@Email,@Password)";
                conn.Open();
                using (SqlCommand sqlComm = new SqlCommand(sql, conn))
                {
                    
                        sqlComm.Parameters.AddWithValue("@name", TextBox_Username.Text);
                        sqlComm.Parameters.AddWithValue("@Email", TextBox_EmailID.Text);
                        sqlComm.Parameters.AddWithValue("@Password", TextBox_Password.Text);
                        Session["Username"] = TextBox_Username.Text;
                        Session["Password"] = TextBox_Password.Text;
                        sqlComm.ExecuteNonQuery();
                    if (TextBox_Username.Text == " " || TextBox_Password.Text == "" || TextBox_EmailID.Text == "" || TextBox_Confirm.Text == "")
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Please enter Username or Password" + "');", true);
                    }
                    else if (TextBox_Password.Text != TextBox_Confirm.Text)
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + "Password does not match" + "');", true);
                    }
                    else
                    {
                        Response.Redirect("Home3.aspx");
                    }
                        
                }
            }
        }
    }
}