using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Security.Claims;
using StarterApi.Models;
using System.Collections.Generic;

namespace StarterApi.Controllers
{
    public class CommonController : ApiController
    {
        [HttpGet]
        public async Task<HttpResponseMessage> GetTestList(int id)
        {
            HttpResponseMessage msg = null;
            try
            {
                var principal = User as ClaimsPrincipal;
                List<DDLDispValueVM> ctrList = new List<DDLDispValueVM> {
                   new DDLDispValueVM { Disp="one", Value="1"},
                   new DDLDispValueVM { Disp="two", Value="2"}
                };
                //var ctrList = await commonBLLHdl.GetCenterListByUserId(id);
                msg = Request.CreateResponse(HttpStatusCode.OK, ctrList);
            }
            catch (Exception ex)
            {
                msg = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return msg;
        }

    }
}
