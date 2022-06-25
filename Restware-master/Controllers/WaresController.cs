using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restware.Manager;
using Restware.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restwares.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaresController : ControllerBase
    {
        // GET: api/<WaresController>
        private WaresManager _manager = new WaresManager();
        [HttpGet]
        public IEnumerable<Wares> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<WaresController>/5
        [HttpGet("{id}")]
        public Wares Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<WaresController>
        [HttpPost]
        public void Post([FromBody] Wares value)
        {
            _manager.Add(value);
        }

        // PUT api/<WaresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Wares value)
        {
            _manager.Update(id, value);
        }

        // DELETE api/<WaresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _manager.Delete(id);
        }
    }
}