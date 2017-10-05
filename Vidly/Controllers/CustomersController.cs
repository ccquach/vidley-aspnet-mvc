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
        // GET: Customers
        public ActionResult Index()
        {
            // Create customer list
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            // Assign customers list to view model
            var viewModel = new CustomerListViewModel
            {
                Customers = customers
            };

            // Render Customer List View Model
            return View(viewModel);
        }

        // GET: Customers/Details
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}