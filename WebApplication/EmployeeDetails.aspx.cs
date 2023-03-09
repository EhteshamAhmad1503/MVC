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
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetEmployees_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=INSUREJOY; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("select * from Rates_Format ", con);
                con.Open();
               ///SqlDataReader sdr = cm.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                repeater.DataSource = dt;
                repeater.DataBind();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }
    }
}