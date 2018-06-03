using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Models;

namespace Employees.Abstract
{
    public interface IEmployees
    {
        List<EmployeesModel> GetAllEmployees();
        //EmployeesModel GetEmployee(string _id_employee);
        List<EmployeesModel> GetEmployeesInOffice(string _id_office);
        void CreateEmployee(string _id_employee, string _name_employee, string _name_office, string _position);
    }
}
