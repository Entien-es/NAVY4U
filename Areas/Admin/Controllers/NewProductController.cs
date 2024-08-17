using NAVY4U.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace TheFourthPractice.Areas.Admin.Controllers
{
    public class NewProductController : Controller
    {
        
        // GET: Admin/NewProduct
        public ActionResult Index()
        {
            return View();
        }
    }
}