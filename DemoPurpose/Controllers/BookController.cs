using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using DemoPurpose.Models;
namespace DemoPurpose.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        customerRepo repo;
        public BookController()
        {
            repo = new customerRepo(new BookModel());
        }
        public ActionResult Index()
        {
            var customer = repo.GetCustomer();
            var data = new List<DemoPurpose.Models.customer>();
            foreach (var c in customer)
            {
                data.Add(customerMapper.Map(c));
            }
            return View(data);
        }

        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Registration reg)
        {
            if (ModelState.IsValid)
            {
                repo.AddCustomer(customerMapper.Maps(reg));
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult UpdateCustomer(int id)
        {
            var data = repo.GetCustomerById(id);
            return View(customerMapper.Map(data));
        }

        [HttpPost]
        public ActionResult UpdateCustomer(int id,Registration reg)
        {
            if (ModelState.IsValid)
            {
                repo.EditCustomer(id,customerMapper.Maps(reg));
                return RedirectToAction("Index");
            }
            return View();
        }



    }
}