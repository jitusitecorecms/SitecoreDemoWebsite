using Sitecore.Diagnostics;
using Sitecore.ExperienceForms.Models;
using Sitecore.ExperienceForms.Processing;
using Sitecore.ExperienceForms.Processing.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSD.DemoWebsite.CustomSubmitAction
{
    public class SendDataToThirdParty : SubmitActionBase<string>
    {
        public SendDataToThirdParty(ISubmitActionData submitActionData) : base(submitActionData)
        {
        }
        protected override bool Execute(string data, FormSubmitContext formSubmitContext)
        {
            var formData = ExtractFormData(formSubmitContext);

            // Write a logic to intgerate with Third Party

            LogFields(formData);
            return true;
        }

        private Dictionary<string, string> ExtractFormData(FormSubmitContext formSubmitContext)
        {
            var formData = new Dictionary<string, string>();
            foreach (var field in formSubmitContext.Fields)
            {
                var fieldName = field.Name;
                var fieldValue = field.GetType().GetProperty("Value")?.GetValue(field, null)?.ToString();

                if (fieldName.Equals("Name", StringComparison.OrdinalIgnoreCase) ||
                    fieldName.Equals("Email", StringComparison.OrdinalIgnoreCase))
                {
                    formData.Add(fieldName, fieldValue);
                }
            }
            return formData;

        }

        private void LogFields(Dictionary<string, string> formData)
        {
            foreach (var field in formData)
            {
                Log.Info($"Form Field - {field.Key}: {field.Value}", this);
            }
        }
        protected override bool TryParse(string value, out string target)
        {
            target = string.Empty;
            return true;
        }
    }
}