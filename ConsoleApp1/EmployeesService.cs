using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employees.Models;
using Employees.Repository;

namespace Employees.Utilities
{
    //public class EmployeesService
    //{
    //}

    public class EmployeesService : 
    {
        //private readonly string _id_employee;
        //private readonly string _id_office; //is it necessary?
        public List<EmployeesModel> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();
            using (var db = new EmployeesEntities()) //khoi tao db
            {
                var re = (from a in db.Employees
                          join b in db.Offices
                          on a.Id_Office equals b.Id_Office
                          select new EmployeesModel
                          {
                              Id_Employee = a.Id_Employee,
                              Fullname = a.Fullname,
                              Name = b.Name,
                              Position = a.Position
                          }).ToList();

                return re;//.ToList() can set here;
            }
        }

        public List<EmployeesModel> GetEmployee(string _id_employee)
        {

            List<Employee> list = new List<Employee>();
            using (var db = new EmployeesEntities())
            {
                var re = (from a in db.Employees
                          join b in db.Offices
                          on a.Id_Office equals b.Id_Office
                          where a.Id_Employee == _id_employee
                          select new EmployeesModel
                          {
                              Id_Employee = _id_employee,
                              Fullname = a.Fullname,
                              Name = b.Name,
                              Position = a.Position
                          }).ToList();
                return re;
            }
        }
        public List<EmployeesModel> GetEmployeesInOffice(string _id_office)
        {
            List<Employee> list = new List<Employee>();
            using (var db = new EmployeesEntities())
            {
                var re = (from a in db.Employees
                          join b in db.Offices
                          on a.Id_Office equals b.Id_Office
                          where b.Id_Office == _id_office
                          select new EmployeesModel()
                          {
                              Id_Employee = a.Id_Employee,
                              Fullname = a.Fullname,
                              Name = b.Name,
                              Position = a.Position
                          }).ToList();

                return re;
            }
        }

        [HttpPost]
        public List<EmployeesModel> Create(EmployeesModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new EmployeesEntities())
                {
                    db.Employees.Add(new Employee
                    {
                        Id_Employee = model.Id_Employee,
                        Fullname = model.Fullname,
                        Position = model.Position
                    });
                    db.SaveChanges();
                    return //???;
                }
            }
            return //???;


        }

    }
}