using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppLogin.Models;

namespace WebAppLogin.Controllers
{
    public class TextController : Controller
    {
        // GET: Text
        public ActionResult Index()
        {
      webapplogindatabaseEntities db = new webapplogindatabaseEntities();
      Employee employee = db.Employees.SingleOrDefault(x => x.EmployeeId == 1);
      EmployeeViewModel vm = new EmployeeViewModel();
      vm.EmployeeId = employee.EmployeeId;
      vm.Name = employee.Name;
      vm.DId = employee.DId;
      vm.Address = employee.Address;

        return View(vm);
      //return Content("hello");
    }
    }
}
