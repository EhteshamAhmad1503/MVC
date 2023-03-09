using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().GetData();
        }
        public void GetData()
        {
            SqlConnection con = null;
            try
            {
              con = new SqlConnection("data source=.; database=JOINS; integrated security=SSPI");
              SqlCommand cm = new SqlCommand("select * from Employee", con);
                SqlCommand cmd = new SqlCommand("Select * from  Infromation",con);
                con.Open();
                
               SqlDataReader sdr = cm.ExecuteReader();
               while (sdr.Read())
               {
                    Console.WriteLine(sdr["Name"] + " " + sdr["Address"]);
               }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
             finally
            {
                con.Close();
            }
            }

    }
}