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
        public ActionResult HeroBanner()
        {
            var dataSourceItem = RenderingContext.Current.ContextItem;
            return View(dataSourceItem);
        }


    }
}