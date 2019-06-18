using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI_TEST.Controllers
{
    public class TestController : ApiController
    {
        public string OneParameter(string key)
        {
            string response = "";
            //CODE 
            return response;
        }
        [Route("api/SYSPRO/{paramOne}/{paramTwo}")]
        public string TwoParameters(string key, string token)
        {
            string response = "";
            //Check if token is correct then post.
            if (token == "{token}")
            {
                //Code
            }
            else
            {
                response = "Incorrect Token Sent.";
            }
            return response;
        }
        [Route("api/SYSPRO/{paramOne}/{paramTwo}/{paramThree}")]
        public string ThreeParameters(string key, string token, int thirdParameter)
        {
            string response = "";
            //Check if token is correct then post.
            if (token == "{token}")
            {
                //Code
            }
            else
            {
                response = "Incorrect Token Sent.";
            }
            return response;
        }
    }
}
