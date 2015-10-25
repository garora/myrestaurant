using MyRestaurant.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MyRestaurant.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/menu")]
    public class MenuController : ApiController
    {
        [AllowAnonymous]
        [Route("latest")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            // Get a list of products from a database.
            IEnumerable<MenuViewModel> menus = new List<MenuViewModel>();

            // Write the list to the response body.
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, menus);
            return response;
        }
        [Route("details/{id:int}")]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, new MenuViewModel());
            return response;
        }
        [AllowAnonymous]
        [Route("{page:int=0}/{pageSize=3}/{filter?}")]
        public HttpResponseMessage Get(HttpRequestMessage request, int? page, int? pageSize, string filter = null)
        {
            int currentPage = page.Value;
            int currentPageSize = pageSize.Value;

            // Get a list of products from a database.
            IEnumerable<MenuViewModel> menus = new List<MenuViewModel>();

            // Write the list to the response body.
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, menus);
            return response;

        }

        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(HttpRequestMessage request, MenuViewModel menu)
        {
            //Add new menu items and return updated response
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, new MenuViewModel());
            return response;
        }
        [HttpPost]
        [Route("update")]
        public HttpResponseMessage Update(HttpRequestMessage request, MenuViewModel menu)
        {
            var id = menu.ID;

            //update the menu and return updated resource
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, new MenuViewModel());
            return response;
        }

        //[Route("images/upload")]
        //public HttpResponseMessage Post(HttpRequestMessage request, int movieId)
        //{
        //    //Upload MenuItem image and update the resource
        //}

    }
}