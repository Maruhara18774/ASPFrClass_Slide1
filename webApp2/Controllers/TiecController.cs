using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApp2.Controllers
{
    public class TiecController : Controller
    {
        // GET: Tiec
        [HttpGet]
        public ActionResult GetForm()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult GetForm(Models.KhachMoi myGuest)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", myGuest);
            }
            else
            {
                return View();
            }
        }
    }
}