using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting;

namespace Hayman.Lighthouse.Controllers
{
	[RoutePrefix("api/metaitem")]
    public class MetaItemController : Controller
    {
		[GET("create")]
        public ActionResult Create()
        {
            return View();
        }
    }
}
