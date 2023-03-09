using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Project
{
    class Application
    {
       
        public static void GetAllEmployees()
        {
            using (var ctx = new HttpClient())
            {
                ctx.BaseAddress = new Uri("https://localhost:44332/api/");

                var responseTask = ctx.GetAsync("Rest");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Insure[]>();
                    readTask.Wait();

                    var insures = readTask.Result;
                    Console.WriteLine("All Details");
                    foreach (var student in insures)
                    {
                        Console.WriteLine(student.ID);
                        Console.WriteLine(student.FirstName);
                        Console.WriteLine(student.LastName);
                        Console.WriteLine(student.Gender);
                        Console.WriteLine(student.Salary);
                    }
                }
            }
        }

        public static void InsertNewRecord()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44332/api/Rest/");
                Console.WriteLine("Enter your Data");
                var students1 = new Insure()
                {

                    ID = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Gender = Console.ReadLine(),
                    Salary = Convert.ToInt32(Console.ReadLine())
                };

                var postTask = client.PostAsJsonAsync<Insure>("Rest", students1);
                postTask.Wait();

                var results = postTask.Result;
                if (results.IsSuccessStatusCode)
                {
                    Console.WriteLine("students1 {1} inserted with id: {0}", students1.ID, students1.FirstName, students1.LastName, students1.Gender, students1.Salary);
                }
                else
                {
                    Console.WriteLine(results.StatusCode);
                }
            }
        }
               
        public static void UpdateEmployee()
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine("Enter Your Information");
                Insure insure = new Insure 
                {
                    ID = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Gender = Console.ReadLine(),
                    Salary = Convert.ToInt32(Console.ReadLine())
                };
                client.BaseAddress = new Uri("https://localhost:44332/api/");
                var response = client.PutAsJsonAsync("Rest/Put", insure).Result;
                
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");
            }
        }
                
        public static void RemoveEmployee()
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine("which data you wan to delete");
               /* Insure insure = new Insure
                {
                    ID = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Gender = Console.ReadLine(),
                    Salary = Convert.ToInt32(Console.ReadLine())
                    
                };*/
                client.BaseAddress = new Uri("https://localhost:44332/api/Rest");
                var response = client.DeleteAsync("Rest/Delete/id").Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Delete successfully");
                }
                else
                    Console.Write("Somthing went wroung");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Operation");
            Console.WriteLine("Enter One for Get method");
            Console.WriteLine("Enter Two post method");
            Console.WriteLine("Enter Three Put method");
            Console.WriteLine("Enter Four Delete method");
           int x=Convert.ToInt32( Console.ReadLine());
            switch (x)
            {
                case 1:
                    GetAllEmployees();
                    break;

                case 2:
                    InsertNewRecord();
                    break;

                case 3:
                    UpdateEmployee();
                    break;

                case 4:
                    RemoveEmployee();
                    break;

                default:
                    Console.WriteLine("Invalid Methods");
                    break;
            }
        }
    }
}
        