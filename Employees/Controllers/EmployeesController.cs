using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Employees.Models;
using Employees.Repository;

namespace Employees.Controllers
{
    public class EmployeesController : ApiController
    {
        private EmployeesEntities1 db = new EmployeesEntities1();
        private readonly string _id_employee;
        private readonly string _id_office;
        private readonly string _name_employee;
        private readonly string _position;

        // GET: api/Category
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            EmployeesService employees = new EmployeesService();
            return request.CreateResponse(HttpStatusCode.OK, employees.GetAllEmployees());
        }

        public HttpResponseMessage GetEmployee(HttpRequestMessage request)
        {
            EmployeesService employees = new EmployeesService();
            return request.CreateResponse(HttpStatusCode.OK, employees.GetEmployee(_id_employee));
        }

        public HttpResponseMessage GetEmployeesInOffice(HttpRequestMessage request)
        {
            EmployeesService employees = new EmployeesService();
            return request.CreateResponse(HttpStatusCode.OK, employees.GetEmployeesInOffice(_id_office));
        }
        [HttpPost]
        public HttpResponseMessage CreateEmployee(HttpRequestMessage request)
        {
            EmployeesService employees = new EmployeesService();
            //  return request.CreateResponse(HttpStatusCode.OK, employees.CreateEmployee(_id_employee, _name_employee, _id_office, _position));
            try
            {
                employees.CreateEmployee(_id_employee, _name_employee, _id_office, _position);
                return request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return request.CreateResponse(HttpStatusCode.BadRequest, ex.ToString());
            }
        }
    }
}
