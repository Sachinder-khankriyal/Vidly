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

        //1. First Approach
        // public ActionResult Index()
        // {
        //     var customers = new List<Customer>
        //     {
        //         new Customer {Name="John",Id=1},
        //         new Customer {Name="Sheldon",Id=2 }
        //     };
        //     var viewModel = new CustomerViewModel()
        //     {
        //         Customers = customers
        //     };
        //     return View(viewModel);
        // }

        //[Route("Customers/Details/{Id:regex(\\d{1})}")]
        //public ActionResult Details()
        // {
        //     return View();
        // }


        //public class CustomersController : Controller
        //{
        //    public ViewResult Index()
        //    {
        //        var customers = GetCustomers();

        //        return View(customers);
        //    }

        //    public ActionResult Details(int id)
        //    {
        //        var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

        //        if (customer == null)
        //            return HttpNotFound();

        //        return View(customer);
        //    }

        //    private IEnumerable<Customer> GetCustomers()
        //    {
        //        return new List<Customer>
        //    {
        //        new Customer { Id = 1, Name = "John Smith" },
        //        new Customer { Id = 2, Name = "Mary Williams" }
        //    };
        //    }

        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id=1,Name="John Smith" },
                new Customer {Id=2,Name="Mary Jones" }
            };

        }
    }
        
}