using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hayman.Lighthouse.Controllers
{
    public class ModelController : Controller
    {
		[HttpGet]
        public ActionResult Create()
        {
            return View();
        }

    }
}
