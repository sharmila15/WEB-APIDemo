using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebAPIDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        [System.Web.Http.AcceptVerbs("GET", "POST","DELETE")]
        //[HttpGet]
        //[Route("api/Employees/{id}/{term}")]

        //public IEnumerable<Employee> GetAll()
        //{
        //    using (angulardbEntities entities = new angulardbEntities())
        //    {
        //        return entities.Employees.ToList();
        //    }
        //}


        public Employee GetById(int id)
        {
            using (angulardbEntities entities = new angulardbEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.Id == id);
            }
        }



        public Employee GetByFn(string term)
        {
            using (angulardbEntities entities = new angulardbEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.FirstName == term);
            }
        }

        [HttpPost]
        public void Post([FromBody]Employee employee)
        {
            try
            {
                using (angulardbEntities entities = new angulardbEntities())
                {
                    entities.Employees.Add(employee);
                    entities.SaveChanges();

                    //var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    //message.Headers.Location = new Uri(Request.RequestUri + employee.Id.ToString());
                    //return message;
                }
            }
            catch (Exception ex)
            {
                Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

        [HttpDelete]
        public void Delete(int id)
        {
            using (angulardbEntities entities = new angulardbEntities())
            {
                entities.Employees.Remove(entities.Employees.FirstOrDefault(e => e.Id == id));
                entities.SaveChanges();
            }
        }

        [HttpPut]
        public void Put(int id, [FromBody]Employee employee)
        {
            using (angulardbEntities entities = new angulardbEntities())
            {
                var entity = entities.Employees.FirstOrDefault(e => e.Id == id);

                entity.FirstName = employee.FirstName;
                entity.LastName = employee.LastName;

                entities.SaveChanges();
            }
        }

    }
}
