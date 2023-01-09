using JqueryAjaxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryAjaxMVC.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }

        //Implement action to view all
        public ActionResult ViewAll()
        {
            return View(GetAllEmployee());
        }

        IEnumerable<Employee>GetAllEmployee()
        {
            using (DBModel db = new DBModel())
            {
                return db.Employees.ToList<Employee>();
            }
        }

        //Implement action for Inserting

        public ActionResult AddOrEdit(int id = 0)
        {
            Employee emp = new Employee();

            return View(emp);
        }

        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }
	}
}