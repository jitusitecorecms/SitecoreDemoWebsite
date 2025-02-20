using Newtonsoft.Json.Linq;
using Sitecore.Data;
using Sitecore.ExperienceForms.Mvc.Models.Fields;
using Sitecore.ExperienceForms.Mvc.Models.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MSD.DemoWebsite.Custom_Fields.Captcha
{
    public class CaptchaV3Validator : ValidationElement<string>
    {
        public override IEnumerable<ModelClientValidationRule> ClientValidationRules
        {
            get
            {
                if (string.IsNullOrEmpty(this.ApiKey))
                {
                    yield break;
                }
            }
        }

        protected virtual string ApiKey { get; set; }
        protected virtual string Title { get; set; }
        protected virtual string FieldName { get; set; }

        public CaptchaV3Validator(ValidationDataModel validationItem) : base(validationItem)
        {

        }

        public override void Initialize(object validationModel)
        {
            base.Initialize(validationModel);
            StringInputViewModel stringInputViewModel = validationModel as StringInputViewModel;
            if (stringInputViewModel != null)
            {
                var fieldItem = Sitecore.Context.Database.GetItem(ID.Parse(stringInputViewModel.ItemId));
                if (fieldItem != null)
                {
                    this.ApiKey = fieldItem["Api Key"];
                }
                this.Title = stringInputViewModel.Title;
                this.FieldName = stringInputViewModel.Name;
            }
        }

        public override ValidationResult Validate(object value)
        {
            if (value == null)
            {
                return new ValidationResult("Captcha is Inavlid.");// ValidationResult.Success;
            }
            var isCaptchaValid = ValidateCaptcha((string)value, this.ApiKey);
            if (!isCaptchaValid)
            {
                return new ValidationResult(this.FormatMessage(new object[] { this.Title }));
            }
            return ValidationResult.Success;
        }
        public static bool ValidateCaptcha(string response, string secret)
        {
            HttpClient httpClient = new HttpClient();

            var res = httpClient.GetAsync($"https://www.google.com/recaptcha/api/siteverify?secret=" + secret + "&response=" + response + "").Result;

            if (res.StatusCode != HttpStatusCode.OK)
                return false;

            string JSONres = res.Content.ReadAsStringAsync().Result;
            dynamic JSONdata = JObject.Parse(JSONres);

            if (JSONdata.success != "true")
                return false;

            return true;
        }
    }
}