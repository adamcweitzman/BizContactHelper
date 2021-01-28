using BizContactHelper.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BizContactHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private BizContactHelperContext _context;

        public ContactsController(BizContactHelperContext context)
        {
            _context = context;
        }
        // GET: api/<ContactsController>
        [HttpGet]
        public IEnumerable<Data.Models.Contact> Get()
        {
            var test = _context.Contacts.Select(x => x).ToList();

            return test;
        }

        // GET api/<ContactsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContactsController>
        [HttpPost]
        public int Post([FromBody] Data.Models.SalesContact contact)
        {
            _context.Contacts.Add(contact);

            return _context.SaveChanges();
        }

        // PUT api/<ContactsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
