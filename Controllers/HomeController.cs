using FontsPriject.Models;
using FontsPriject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FontsPriject.Controllers
{
    public class HomeController : Controller
    {
        FontService service = new FontService();

        public ActionResult Index()
        {
            return View("Index", null);
        }
        public ActionResult GetFonts(string text)
        {
            Font_List fontList = service.getFontList();
            fontList.text = text;
            return View("Index" ,fontList);
        }

        //public ActionResult GetFontSize(string text)
        //{
        //    Font_Size fontSize = service.getFontSize();
        //    fontSize.text = text;
        //    return View(fontSize);
        //}

        public ActionResult CustomFonts()
        {
            ViewBag.Message = "Your contact page.";

            return View("HomePage");
        }
    }
}