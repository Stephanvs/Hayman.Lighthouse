using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting;

namespace Hayman.Lighthouse.Controllers
{
	[RoutePrefix("")]
    public class DashboardController : Controller
    {
		[GET("")]
        public ActionResult Index()
        {
            return View();
        }

		[GET("/api/messages")]
		public JsonResult Messages()
		{
			return Json(new
			{
			    name = "@Twitter",
				action = "Lorum ipsum dolor sit amet"
			}, 
			JsonRequestBehavior.AllowGet);
		}
    }
}
