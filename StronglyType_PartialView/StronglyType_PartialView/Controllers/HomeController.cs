using StronglyType_PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyType_PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        List<Product> ProductsList = new List<Product>()
        {
            new Product { Id=101, Name = "Bike", Price=10000,  Picture="~/Image/Bike.jpeg"},
            new Product { Id=102, Name = "Car", Price=1000000, Picture="~/Image/Car.jpeg"},
            new Product { Id=103, Name = "Watch", Price=1000,  Picture="~/Image/Watch.jpg"},


        };

        public ActionResult Index()
        {
            return View(ProductsList);
        }
    }
}