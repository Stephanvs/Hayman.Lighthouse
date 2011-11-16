using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hayman.Lighthouse.ViewModels;

namespace Hayman.Lighthouse.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Index(int? id)
        {
        	var vm = new ItemInfo(id.HasValue ? id.Value : 0);
        	vm.Label = "Atos";
        	vm.MetaItem = "Company";

            return View(vm);
        }
    }
}
