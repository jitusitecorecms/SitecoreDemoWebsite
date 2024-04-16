﻿using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSD.DemoWebsite.Controllers
{
    public class MenuController : Sitecore.Mvc.Controllers.SitecoreController
    {
        public ActionResult Menu()
        {
            var dataSourceItem = RenderingContext.Current.ContextItem;
            return View(dataSourceItem);
        }
    }
}