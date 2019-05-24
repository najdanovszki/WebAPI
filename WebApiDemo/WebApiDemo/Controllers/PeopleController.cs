using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;
using System.Web.Http.Cors;

namespace WebApiDemo.Controllers
{
    [EnableCors(origins:"*", headers: "*", methods:"*")]
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Krisztián", LastName = "Najdnaovszki", Id = 1 });
            people.Add(new Person { FirstName = "Klári", LastName = "Najdnaovszki-Nagyajtai", Id = 2 });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id ==id).FirstOrDefault();
        }

        // POST: api/People
        public Person Post(Person val)
        {
            return new Person { FirstName="Béla"+val.FirstName, LastName="Nagy"+val.LastName, Id=5+val.Id};
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
