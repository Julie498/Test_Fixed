using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employees.Models
{
    public class EmployeesModel
    {
        public string Id_Employee { set; get; }
        public string Name_Employee { get; set; }
        public string Name_Office { get; set; }
        public string Position { get; set; }
    }
}