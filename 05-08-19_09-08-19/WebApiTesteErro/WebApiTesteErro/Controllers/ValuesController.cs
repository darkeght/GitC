using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTesteErro.Models;

namespace WebApiTesteErro.Controllers
{
    public class ValuesController : ApiController
    {
        BibliotecaDBContext context = new BibliotecaDBContext();
        // GET api/values
        public List<Usuario> Get()
        {
            return context.Usuarios.ToList<Usuario>();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
