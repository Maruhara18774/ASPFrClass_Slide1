using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApp2.Controllers
{
    public class MyPageController : Controller
    {
        // GET: MyPage
        public ViewResult Index()
        {
            return View();
        }
    }
}