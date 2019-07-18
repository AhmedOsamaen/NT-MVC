using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NT_MVC_Task.Models;
using System.Web.Mvc;

namespace NT_MVC_Task.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Movie_Index()
        {
            Customers c1 = new Customers() { id = 1, fname = "ahmed", lname = "OSAMA" };
            Customers c2 = new Customers() { id = 2, fname = "mhmd", lname = "hany" };
            Customers c3 = new Customers() { id = 3, fname = "mhnd", lname = "hatem" };
            List<Customers> c_list = new List<Customers> { c1, c2, c3 };
            Movies spider_man = new Movies() { id = 1, name = "Spider Man", cust_list = c_list };
            return View(spider_man);
        }
    }
}