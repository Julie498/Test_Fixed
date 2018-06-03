using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employees.Dtos

{
    public class EmployeesDto
    {
        public string Id_Employee { set; get; }
        public string Fullname { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}