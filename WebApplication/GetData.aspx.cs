using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication
{
    public partial class GetData : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlParameter sp1 = new SqlParameter();
        SqlParameter sp2 = new SqlParameter();
        SqlParameter sp3 = new SqlParameter();
        SqlParameter sp4 = new SqlParameter();
        SqlParameter sp5 = new SqlParameter();
        SqlParameter sp6 = new SqlParameter();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                int Smoker=3;

                 if (DropDownList2.SelectedValue.Equals("Smoker"))
                    {
                    Smoker = 1;
                }
                else if(DropDownList2.SelectedValue.Equals("Smoker")) 
                {
                    Smoker = 1;
                }
                con = new SqlConnection("data source=.; database=INSUREJOY;integrated security=SSPI");
                cmd.Parameters.AddWithValue("@age", SqlDbType.Int).Value = Convert.ToInt32(Age.Text);
                cmd.Parameters.AddWithValue("@gender", SqlDbType.Char).Value = Convert.ToChar(DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@smoker", SqlDbType.Bit).Value =Convert.ToBoolean(Smoker);
                cmd.Parameters.AddWithValue("@PolicyTerm", SqlDbType.Int).Value = Convert.ToInt32(PolicyTerm.Text);
                cmd.Parameters.AddWithValue("@PayingTerm", SqlDbType.Int).Value = Convert.ToInt32(PolicyTerm.Text);
                cmd.Parameters.AddWithValue("@SumAssured", SqlDbType.Int).Value = Convert.ToInt32(SumAssured.Text);
                cmd.Connection = con;
                cmd.CommandText = "TermPremium1";
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataSet dt = new DataSet();
                 da.Fill(dt);
                 repeater2.DataSource = dt;
                 repeater2.DataBind();
                 con.Close();
            }
           
        }
    }
}