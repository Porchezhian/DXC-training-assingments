using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeptEmp.Models;

namespace DeptEmp.Controllers
{
    public class HomeController : Controller
    {
        Model entity = new Model();
        public ActionResult Index()
        {
            if (entity.Departments.Count() == 0 && entity.Employees.Count() == 0)
            {
                Department dept1 = new Department() { Id = 1, Name = "HR" };
                Department dept2 = new Department() { Id = 2, Name = "IT" };
                Department dept3 = new Department() { Id = 3, Name = "Payroll" };
                Employee emp1 = new Employee() { Name = "Porsche", Age = 21, Location = "Chennai", DepartmentId = 2 };
                Employee emp2 = new Employee() { Name = "Sam", Age = 24, Location = "Banglore", DepartmentId = 1 };
                Employee emp3 = new Employee() { Name = "Mike", Age = 31, Location = "Chennai", DepartmentId = 3 };
                Employee emp4 = new Employee() { Name = "Jim", Age = 24, Location = "Delhi", DepartmentId = 2 };
                Employee emp5 = new Employee() { Name = "Jessy", Age = 45, Location = "Chennai", DepartmentId = 1 };
                entity.Departments.Add(dept1);
                entity.Departments.Add(dept2);
                entity.Departments.Add(dept3);
                entity.Employees.Add(emp1);
                entity.Employees.Add(emp2);
                entity.Employees.Add(emp3);
                entity.Employees.Add(emp4);
                entity.Employees.Add(emp5);
                entity.SaveChanges();
            }
            return View(entity.Departments.ToList());
        }

        [HttpPost]
        public ActionResult List(int Id)
        {
            ViewBag.department = entity.Departments.FirstOrDefault(x => x.Id == Id).Name;
            List<Employee> employees = entity.Employees.Where(x => x.DepartmentId == Id).ToList();
            ViewBag.count = entity.Employees.Where(x => x.DepartmentId == Id).Count()+1;
            return View(employees);
        }
    }
}