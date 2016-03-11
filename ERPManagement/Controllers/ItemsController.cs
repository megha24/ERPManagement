using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERPManagement.DAL;
using ERPManagement.Models;
using Microsoft.Ajax.Utilities;

namespace ERPManagement.Controllers
{
    public class ItemsController : ApiController
    {
        private ERPContext context;

        public ItemsController()
        {
            context = new ERPContext();
        }
        // GET api/values
        public IEnumerable<Item> Get()
        {
            return context.Items;
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