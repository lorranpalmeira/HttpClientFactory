using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ChamadasHttpClient.Chamadas;
using Microsoft.AspNetCore.Mvc;

namespace ChamadasHttpClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IHttpClientFactory _clientFactory;

        public ValuesController(IHttpClientFactory clientFactory)
        {
            this._clientFactory = clientFactory;     
        }
        
        [HttpGet]
        public ActionResult<string> Get()
        {
           var chamada = new Chamada(_clientFactory);
           var result = chamada.RetornaDadosApi();

            return  result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
