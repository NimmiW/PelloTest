using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebRole1.Models;

namespace WebRole1.Controllers
{
    public class TweetsController : ApiController
    {
        // GET api/tweets
        public IEnumerable<Tweet> Get()
        {
            IEnumerable<Tweet> items;
            string path = HttpContext.Current.Request.MapPath("~\\json_files\\tweets.json");

            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Tweet>>(json);
            }
            return items;
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