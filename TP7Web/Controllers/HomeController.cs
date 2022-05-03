using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP7Web.Model;
namespace TP7Web.Controllers
{
    
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var data = db.Employees.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee E)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(E);
                int a = db.SaveChanges();
                return RedirectToAction("List");
            }
            return View();
        }
    }
}