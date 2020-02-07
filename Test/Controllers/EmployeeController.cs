using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using DomainModels.Models;

namespace Test.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly DALService _service = new DALService();
        public HttpResponseMessage Get()
        {
            var response = _service.ListEmployees();
            if (response.IsValid) {
                return Request.CreateResponse(HttpStatusCode.OK, response.Content);
            }
            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, new Exception(response.ErrorMessage));
        }

        public HttpResponseMessage Post([FromBody] Employee model)
        {
            var response = _service.AddEmployee(model);
            if (response.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.OK, response.Content);
            }
            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, new Exception(response.ErrorMessage));
        }
    }
}
