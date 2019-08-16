using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        LocacaoDB locacao = new LocacaoDB();
        
        // GET api/values
        public List<Carro> Get()
        {
            return locacao.Carros.ToList<Carro>();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return new string[] { "café", "corona" }[id] ;
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
