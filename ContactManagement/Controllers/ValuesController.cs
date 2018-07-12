using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactManagement.Models;
namespace ContactManagement.Controllers
{
    public class ValuesController : ApiController
    {
        static List<Contact> contactList;
        static int b = 0;
        // GET api/values
        public IEnumerable<Contact> Get()
        {
            if (contactList == null) { contactList = new List<Contact>(); }
            Contact a = new Contact();
            b++;
            a.FirstName = "test"+b;
            a.LastName = "testLast" + b;
            contactList.Add(a);
            return contactList.ToList();
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
