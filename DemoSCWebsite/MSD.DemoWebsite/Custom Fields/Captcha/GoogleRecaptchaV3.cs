using Sitecore.Data.Items;
using Sitecore.ExperienceForms.Mvc.Models.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSD.DemoWebsite.Custom_Fields.Captcha
{
    public class GoogleRecaptchaV3 : StringInputViewModel
    {
        public string ApiKey { get; set; }

        public string ErrorMessage { get; set; }

        protected override void InitItemProperties(Item item)
        {
            base.InitItemProperties(item);

            ApiKey = Sitecore.StringUtil.GetString(item.Fields["Api Key"]);
            ErrorMessage = Sitecore.StringUtil.GetString(item.Fields["Error Message"]);
        }

        protected override void UpdateItemFields(Item item)
        {
            base.UpdateItemFields(item);

            item.Fields["Api Key"].SetValue(ApiKey, true);
            item.Fields["Error Message"].SetValue(ErrorMessage, true);
        }
    }
}

//Site Key: 6LeitsoqAAAAAOlZsRAAN_nc5oLKFHybfvzxx5RH
//Secret Key: 6LeitsoqAAAAABD2SzIRqB-jgoh-vn6iYl_ANXyp