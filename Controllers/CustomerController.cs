using NT_MVC_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NT_MVC_Task.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customers c1 = new Customers() { id = 1, fname = "ahmed", lname="OSAMA" };
           
            return View(c1);
        }
    }
}