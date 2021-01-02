using FontsPriject.Models;
using FontsPriject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

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
        public ActionResult About()
        {
            return View("View_About");
        }
        public ActionResult Contact()
        {
            return View("View_Contact");
        }

 
        public ActionResult SubmitContact(FontContact contact)
        {
            try
            {
           
                service.ContactUs(contact);
                return View("View_Contact");
            }
            catch
            {
                return View("View_Contact");
            }

        }
        public ActionResult Disclaimer()
        {
            return View("View_Disclaimer");
        }

        public ActionResult PrivacyPolicy()
        {
            return View("View_PrivacyPolicy");
        }

        public ActionResult TermCondition()
        {
            return View("View_TermCondition");
        }

        //public ActionResult SiteMap()
        //{
        //    return View("SiteMap");
        //}

        //public ActionResult SubmitMap(Sitemap_Model site)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    List<Sitemap_Model> fieldList = new List<Sitemap_Model>();
        //    doc.Load(Server.MapPath("sitemap.xml"));
        //    foreach (XmlNode node in doc.SelectNodes("/urlset/url"))
        //    {
        //        fieldList.Add(new Sitemap_Model
        //        {
        //            Url = node["loc"].InnerText,
        //            ModifiedDate = node["lastmod"].InnerText,
        //            Priority = node["priority"].InnerText
        //        });
        //    }
        //    return View("SiteMap");
        //}
    }
    


}