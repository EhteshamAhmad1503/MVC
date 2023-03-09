using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication
{
    public partial class Web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data Source=.;database=JOINS;integrated security=sspi");
                SqlCommand cmd = new SqlCommand("insert into Employee values('" + Name.Text + "','" + Address.Text + "','" + Branch.Text + "','" + Mobile.Text + "','" + Email.Text + "','" + Salary.Text + "')", con);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if(x==1)
                {
                    Success.Text = "Successfully inserted";
                }
                con.Close();
              }catch(Exception ex)
            {
                Console.WriteLine(ex);
                Success.Text = "something went wroung"; 
            }
        }
    }
}