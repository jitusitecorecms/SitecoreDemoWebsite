using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using Sitecore.ExperienceForms.Models;
using Sitecore.ExperienceForms.Mvc.Models.Validation;
using Sitecore.ExperienceForms.Processing;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Sitecore.ExperienceForms.Mvc.Models.Fields;

namespace MSD.DemoWebsite.Validator
{
    public class AlphanumericValidator : ValidationElement<string>
    {
        private const string AlphaNumericPattern = "^[a-zA-Z0-9]+$";
        public AlphanumericValidator(ValidationDataModel validationItem) : base(validationItem)
        {
        }
        public string Title { get; set; }
        public override IEnumerable<ModelClientValidationRule> ClientValidationRules
        {
            get
            {
                var clientValidationRule = new ModelClientValidationRule
                {
                    ErrorMessage = FormatMessage(Title),
                    ValidationType = "regex"
                };
                clientValidationRule.ValidationParameters.Add("pattern", AlphaNumericPattern);
                yield return clientValidationRule;
            }
        }

        public override ValidationResult Validate(object value)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }
            var regex = new Regex(AlphaNumericPattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled);
            var stringValue = (string)value;
            if (string.IsNullOrEmpty(stringValue) || regex.IsMatch(stringValue))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(FormatMessage(Title));
        }

        public override void Initialize(object validationModel)
        {
            base.Initialize(validationModel);
            var obj = validationModel as StringInputViewModel;
            if (obj != null)
            {
                Title = obj.Title;
            }
        }

    }
}