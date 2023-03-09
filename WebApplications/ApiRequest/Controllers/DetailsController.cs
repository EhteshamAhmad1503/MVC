using ApiRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ApiRequest.Controllers
{
    public class DetailsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Details> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44332/api/");
                var responseTask = client.GetAsync("Rest");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Details>>();
                    readTask.Wait();

                    students = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    students = Enumerable.Empty<Details>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(students);
        }
    
        public ActionResult Details(int id)
        {
            return View();
        }
               
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult Create(Details details)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44332/api/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<Details>("Rest", details);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(details);
        }
    
       [HttpPut]
        public ActionResult Edit(int id)
        {
            Details student = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44361/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Details?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Details>();
                    readTask.Wait();

                    student = readTask.Result;
                }
            }
            return View(student);
        }

        // POST: Methods/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Details details)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44361/api/");

                //HTTP POST
                var putTask = client.PutAsJsonAsync<Details>("Details/PutUpdateStudent", details);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(details);
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
