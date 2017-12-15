using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 0, Name = "John Smith" },
                new Customer { Id = 1, Name = "Mary Williams" }
            };

            var viewModel = new CustomersViewModel
            {
               Customers = customers
            };

            return View(viewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            switch (id)
            {
                case 0:
                    return View(new Customer { Id = 0, Name = "John Smith" });
                case 1:
                    return View(new Customer { Id = 1, Name = "Mary Williams" });
            }

            return HttpNotFound();
        }
    }
}