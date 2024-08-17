using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAVY4U.Areas.Admin.Controllers
{
    public class BackToHomePageController : Controller
    {
        // GET: Admin/BackToHomePage
        [HttpPost]
        public ActionResult BackToHomePage()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}