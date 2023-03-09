using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Page
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =.;database = JOINS;integrated security=sspi");
                SqlCommand cmd = new SqlCommand("insert into Practice values('" + FirstName.Text + "','" + LastName.Text + "','" + Mobile.Text + "','" + Dob.Text + " ','" + Email.Text + "','" + Password.Text + "')", con);
                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {
                    sucess.Text = "success fully inserted.....";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
    }
