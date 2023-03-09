using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace HttpsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44332/api/Rest");
                //HTTP GET
                var responseTask = client.GetAsync("Employees");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Insurejoy[]>();
                    readTask.Wait();

                    var Insurejoy = readTask.Result;

                    foreach (var student in Insurejoy)
                    {
                        Console.WriteLine(Insurejoy.ID);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
