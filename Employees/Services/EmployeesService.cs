using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employees.Models;
using Employees.Repository;
using Employees.Abstract;

namespace Employees
{
    public class EmployeesService :IEmployees
    {
        private EmployeesEntities1 repo;
        //private readonly string _id_employee;
        //private readonly string _id_office;
        public List<EmployeesModel> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();
            using (var db = new EmployeesEntities1()) //khoi tao db
            {
                var re = (from a in db.Employees
                          join b in db.Offices
                          on a.Id_Office equals b.Id_Office
                          select new EmployeesModel
                          {
                              Id_Employee = a.Id_Employee,
                              Name_Employee = a.Name_Employee,
                              Name_Office = b.Name_Office,
                              Position = a.Position
                          }).ToList();

                return re;//.ToList() can set here;
            }
        }

        public List<EmployeesModel> GetEmployee(string _id_employee)
        {

            List<Employee> list = new List<Employee>();
            using (var db = new EmployeesEntities1())
            {
                var re = (from a in db.Employees
                          join b in db.Offices
                          on a.Id_Office equals b.Id_Office
                          where a.Id_Employee == _id_employee
                          select new EmployeesModel
                          {
                              Id_Employee = _id_employee,
                              Name_Employee = a.Name_Employee,
                              Name_Office = b.Name_Office,
                              Position = a.Position
                          }).ToList();
                return re;
            }
        }
        public List<EmployeesModel> GetEmployeesInOffice(string _id_office)
        {
            List<Employee> list = new List<Employee>();
            using (var db = new EmployeesEntities1())
            {
                var re = (from a in db.Employees
                          join b in db.Offices
                          on a.Id_Office equals b.Id_Office
                          where b.Id_Office == _id_office
                          select new EmployeesModel()
                          {
                              Id_Employee = a.Id_Employee,
                              Name_Employee = a.Name_Employee,
                              Name_Office = b.Name_Office,
                              Position = a.Position
                          }).ToList();

                return re;
            }
        }

        public void CreateEmployee(string _id_employee, string _name_employee, string _id_office, string _position)
        {
            var employee = new Employee()
            {
                Id_Employee = _id_employee,
                Name_Employee = _name_employee,
                Id_Office = _id_office,
                Position = _position
            };
            repo.Employees.Add(employee);
            repo.SaveChanges();
        }
    }
}