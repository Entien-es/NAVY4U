using NAVY4U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheFourthPractice.Areas.Admin.Controllers
{
    public class NewArticleController : Controller
    {
        private static BanHangOnlineEntities database = new BanHangOnlineEntities();
        // GET: Admin/NewArticle
        public ActionResult Index()
        {
            return View();
        }

    }
}