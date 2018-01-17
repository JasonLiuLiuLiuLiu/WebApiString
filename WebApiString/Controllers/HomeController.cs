using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiString.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        [Route("~/Post/{Str1}/{Str2}")]
        public string Post(string Str1,string Str2)
        {
            return string.Format("第一个str是：{0},第二个str是{1}",Str1,Str2);
        }
    }
    public class Str{
        public string Str1 { get; set; }
        public string Str2 { get; set; }
    }
}
