using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSD.DemoWebsite.Controllers
{
    public class HeroBannerController : Sitecore.Mvc.Controllers.SitecoreController
    {
        // GET: HeroBanner
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HeroBanner()
        {
            return View();
        }


    }
}