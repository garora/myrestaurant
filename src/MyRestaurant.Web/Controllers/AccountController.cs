using MyRestaurant.Web.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyRestaurant.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        [AllowAnonymous]
        [Route("authenticate")]
        [HttpPost]
        public HttpResponseMessage Login(HttpRequestMessage request, LoginViewModel user)
        {
            //Verify the user and return 
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, true);
            return response;
        }

        [AllowAnonymous]
        [Route("register")]
        [HttpPost]
        public HttpResponseMessage Register(HttpRequestMessage request, RegistrationViewModel user)
        {
            //Register new customer and return
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, true);
            return response;
        }
    }
}
