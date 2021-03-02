using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webApp2.Models;

namespace webApp2.Controllers
{
    public class GiaiBaiController : Controller
    {
        // GET: GiaiBai
        public ActionResult XinChao()
        {
            ViewBag.Time = DateTime.Now.ToString();
            int hour = DateTime.Now.Hour;
            if (hour>=3 && hour <= 9)
            {
                ViewBag.Greeting = "Chao buoi sang!";
            }
            else if (hour >= 10 && hour <= 15)
            {
                ViewBag.Greeting = "Chao buoi trua!";
            }
            else if (hour >= 16 && hour <= 22)
            {
                ViewBag.Greeting = "Chao buoi toi!";
            }
            else
            {
                ViewBag.Greeting = "Khong chao nua, di ngu di!";
            }
            return View();
        }
        [HttpGet]
        public ActionResult DangKyThanhVien()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult DangKyThanhVien(string name,string email,string sdt, string confirm)
        {
            Models.KhachMoi myGuest = new Models.KhachMoi();
            myGuest.Ten = name;
            myGuest.Email = email;
            myGuest.Sdt = sdt;
            if (confirm == "Tham gia")
                myGuest.XacNhanThamGia = true;
            else
                myGuest.XacNhanThamGia = false;
            return RedirectToAction("DangKyThanhCong",myGuest);
        }
        //RedirectToRoute(new { controller= "GiaiBai", action= "DangKyThanhCong"})
        //[HttpPost]
        public ActionResult DangKyThanhCong(Models.KhachMoi myGuest)
        {
            ViewBag.Guest_Name = myGuest.Ten;
            ViewBag.Guest_Email = myGuest.Email;
            ViewBag.Guest_Phone = myGuest.Sdt;
            if (myGuest.XacNhanThamGia)
            {
                ViewBag.Guest_Confirm = "Sẽ tham gia";
                ViewBag.Footer = "Rất vui vì bạn đã đăng ký tham gia";
            }
            else
            {
                ViewBag.Guest_Confirm = "Không tham gia";
                ViewBag.Footer = "Rất tiếc vì bạn không tham gia. Hẹn gặp bạn lần sau";
            }
            return View();
        }
    }
}