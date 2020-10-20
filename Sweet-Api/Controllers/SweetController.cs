using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntitiesNew;
using BL;
using SystemUtils;
using System.Web.Http.Cors;

namespace Sweet_Api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SweetController : ApiController
    {
        // GET: api/Sweet
        public GetAllItemsList GetValues()
        {
            GetAllItemsList response = new GetAllItemsList();
            try
            {
                using (SweetManager manager = new SweetManager())
                {
                    //Dim _usr = Token.GetCurrentUser()

                    response.Fooditems = manager.GetAllFoodItems();
                    response.rc = 0;
                }
            }catch (Exception e)
            {
                utils.adderr(e);
            }
            return response;
        }

        // GET: api/Sweet/5
        //public GetSpecificCategoryList GetValues(int category)
        //{
        //    return null;
        //}
        
    }
}
