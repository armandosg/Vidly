using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Armando" },
            new Customer { Id = 2, Name = "Ricardo" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new IndexCustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            Customer customer;
            try
            {
                customer = customers.ElementAt(id - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}