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
            return File(System.IO.File.ReadAllBytes(Server.MapPath("~/Files/Requirement.txt")), "text");
            
            // return action download file text
            //return File(Url.Content("~/Files/Requirement.txt"), "text", "download.txt");
        }
        public JsonResult GetFriendsList()
        {
            // 1. Return custom json file
            //return Json(System.IO.File.ReadAllText(Server.MapPath("~/Files/FriendsList.json")), "text",JsonRequestBehavior.AllowGet);
            
            // 2. Return new json file
            return Json(new { name = "Linh", age = 18 }, JsonRequestBehavior.AllowGet);
            // Luu y: Khi khong co cum dang sau new Json, ma se ko dc thuc thi vi asp auto block
        }
        public JavaScriptResult AccessPage()
        {
            // 1. Class JavaScript ben duoi la cach su dung bth
            return JavaScript("alert('Hello Javascript Result');");

            // 2. Con cai nay lam code JS thuc thi
            // *Kieu tra ve JavaScriptResult --> ActionResult
            //return Content("<script> alert('Hello Javascript Result'); </script>");
        }
        public RedirectResult Link1()
        {
            // Dan toi link ben ngoai
            return Redirect("https://www.youtube.com/watch?v=SCUo9vYSu6g");
            // Dang nghe bai nay chill chill nen bo vao thui
        }
        public RedirectToRouteResult Link2()
        {
            return RedirectToRoute(new { controller = "Home", action = "GetRequirement" });
        }
        public HttpStatusCodeResult HttpRS()
        {
            //return new HttpStatusCodeResult(System.Net.HttpStatusCode.Unauthorized, "Lin not found :((");
            //return new HttpUnauthorizedResult("Lin not found :((");
            return HttpNotFound("Lin not found :((");
        }
    }
}