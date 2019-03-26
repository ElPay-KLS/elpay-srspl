using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace daysinmonths.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        static List<string> strlis = new List<string>
        {
            "value1", "value2"
        };
        // List<int> dayList = new List<int> { };
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return strlis;
        }

        // GET api/values/5
        public string Get(int id)
        {
            /* return "value"*/
            
            return strlis[id];
        }

        [HttpPost]
        public void Post([FromBody] DateTime value)
        {
            //strlis.Add(value >= DateTime.Now.Date.AddMonths(-6) && value <= DateTime.Now.Date ?
            // new DateTimeOffset(value, TimeZoneInfo.Local.GetUtcOffset(value)).ToString("dddd") : "Invalid Date");


            //DateTime dayval = new DateTime();
            //dayval = value;
            //string date = dayval.ToString();
            //if (value <= DateTime.Now.Date.AddMonths(-6))
            //{
            //    throw new Exception("");
            //}
           // string day = TimeZoneInfo.Local.GetUtcOffset(value)).ToString("dddd");


            int year = value.Year;
            int month = value.Month;

            int days = DateTime.DaysInMonth(year, month);
            string s = days.ToString();
            strlis.Add(s);


            // return days;
        }

        // POST api/values
        //public void Post([FromBody]string value)
        //{
        //}


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
