using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntitiesNew;
using DAL;

namespace Sweet_Api.Controllers
{

    public class SweetController : ApiController
    {
        // GET: api/Sweet
        public GetAllItemsList GetValues()
        {
            DALsweets d = new DALsweets();
            d.Select();
            return null;
        }

        // GET: api/Sweet/5
        //public GetSpecificItemsList GetValues(ref string id)
        //{
        //    return null;
        //}
    }
}
