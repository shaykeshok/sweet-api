using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntitiesNew;

namespace Sweet_Api.Controllers
{
    public class WelcomeController : ApiController
    {
        // GET: api/Welcome
        public WelcomeResponse GetValues()
        {
            WelcomeResponse res = new WelcomeResponse();
            res.about = "about about about about about about about about about about about about ";
            return res;
        }
    }
}
