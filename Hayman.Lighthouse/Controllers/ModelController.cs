using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting;

namespace Hayman.Lighthouse.Controllers
{
	[RoutePrefix("api/model")]
    public class ModelController : Controller
    {
		[POST("")]
        public JsonResult Create()
        {
            return Json(new { Test = "Hello World" }, JsonRequestBehavior.AllowGet);
        }

    }
}
