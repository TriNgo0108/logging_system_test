using analyze_1.services;
using Serilog;
using System;
using System.Collections.Generic;

using System.Web.Http;
using System.Web.Http.Filters;

namespace analyze_1.Controllers
{

    [Filters]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
           throw new NotImplementedException();
        }

        // GET api/values/5
        public string Get(int id)
        {
            Log.Information("asdasdsakjdas");
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
