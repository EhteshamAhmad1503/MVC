using CRUDWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CRUDWebApi.Controllers
{
    public class CRUDController : Controller
    {
        HttpClient client = new HttpClient();

        [HttpGet]
        public ActionResult Index()
        {
            List<Employee> list = new List<Employee>();
            client.BaseAddress = new Uri("https://localhost:44368/api/WebAPI");
            var response = client.GetAsync("WebAPI");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Employee>>();
                display.Wait();
                list = display.Result;
            }
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            client.BaseAddress = new Uri("https://localhost:44368/api/WebAPI");
            var response = client.PostAsJsonAsync<Employee>("WebAPI", emp);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create");
        }

        public ActionResult Details(int id)
        {
            Employee emp = null;
            client.BaseAddress = new Uri("https://localhost:44368/api/WebAPI");
            var response = client.GetAsync("WebAPI?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                emp = display.Result;
            }
            return View(emp);
        }

        public ActionResult Edit(int id)
        {
            Employee emp = null;
            client.BaseAddress = new Uri("https://localhost:44368/api/WebAPI");
            var response = client.GetAsync("WebAPI?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                emp = display.Result;
            }
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            client.BaseAddress = new Uri("https://localhost:44368/api/WebAPI");
            var response = client.PutAsJsonAsync<Employee>("WebAPI", e);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Edit");
        }

        public ActionResult Delete(int id)
        {
            Employee emp = null;
            client.BaseAddress = new Uri("https://localhost:44368/api/WebAPI");
            var response = client.GetAsync("WebAPI?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                emp = display.Result;
            }
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("https://localhost:44368/api/WebAPI");
            var response = client.DeleteAsync("WebAPI/" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Delete");
        }
    }
}