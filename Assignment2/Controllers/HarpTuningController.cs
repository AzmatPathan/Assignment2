using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class HarpTuningController : ApiController
    {
        [HttpGet]
        [Route("api/HarpTuning/{id}")]
        public IEnumerable<string> GetTunning(string id)
        {

            string ids = "AFB+8HC-4";
            string[] seperator = { "1","2","3","4","5","6","7","8","9","0" };
            string[] seperator2 = new string[10];
            string[] seperator3 = new string[10];

            for(int i = 0; i<seperator.Length;i++)
            {
                seperator2[i] = "+" + seperator[i];
                seperator2[i] = "-" + seperator[i];

            }
            
            string[] splittedString1 = ids.Split(seperator2, StringSplitOptions.RemoveEmptyEntries);

            //string[] splittedString2 = ids.Split(seperator3, StringSplitOptions.RemoveEmptyEntries);

            IEnumerable<string> enumerable = splittedString1.Select(x => x.Replace("+", " tighten "));
            //enumerable.Concat(splittedString2.Select(x => x.Replace("-", " loosen ")));

       

            return enumerable;
        }
    }
}