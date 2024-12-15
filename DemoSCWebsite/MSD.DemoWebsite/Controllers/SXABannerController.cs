using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSD.DemoWebsite.Controllers
{
    public class SXABannerController : Sitecore.Mvc.Controllers.SitecoreController
    {
        // GET: SXABanner
        public ActionResult SXABanner()
        {
            var dataSourceId = RenderingContext.Current.Rendering.DataSource;
            var item = Sitecore.Context.Database.GetItem(dataSourceId);
            return View(item);
        }
    }
}