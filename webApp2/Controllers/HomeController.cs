using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public PartialViewResult GetMenu()
        {
            return PartialView("_Menu");
        }
        public FileResult GetRequirement()
        {
            // return content of file text
            //return File(System.IO.File.ReadAllBytes(Server.MapPath("~/Files/Requirement.txt")), "text");
            
            // return action download file text
            return File(Url.Content("~/Files/Requirement.txt"), "text", "download.txt");
        }
        public JsonResult GetFriendsList()
        {
            return Json(System.IO.File.ReadAllText(Server.MapPath("~/Files/FriendsList.json")), "text",JsonRequestBehavior.AllowGet);
        }
    }
}