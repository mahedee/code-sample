using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPA.Controllers
{
    public class TrainingsController : ApiController
    {
        // GET api/trainings
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/trainings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/trainings
        public void Post([FromBody]string value)
        {
        }

        // PUT api/trainings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/trainings/5
        public void Delete(int id)
        {
        }
    }
}
