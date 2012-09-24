using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirteenDaysAWeek.Mvc4CustomErrorPage.Web.Models;

namespace ThirteenDaysAWeek.Mvc4CustomErrorPage.Web.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Index(int statusCode, Exception exception)
        {
            ErrorModel model = new ErrorModel {HttpStatusCode = statusCode, Exception = exception};

            Response.StatusCode = statusCode;

            return View(model);
        }
    }
}
