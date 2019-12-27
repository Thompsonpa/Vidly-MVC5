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
        // GET: Customers/view
        public ActionResult view()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Patrick Thompson", Id = 1},
                new Customer { Name = "Samantha Thompson", Id = 2},
                new Customer { Name = "Brian Thompson", Id = 3},
                new Customer { Name = "Leroy Thompson", Id = 4}

            };


            var viewModel = new CustomerListViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}