using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstAppVideo.Helpers.BaseController
{
    public class BaseController : Controller
    {
        public void MessageSuccess(string message, bool dismissable = true)
        {
            AddAlert(AlertStyles.Success, message);
        }

        public void MessageInformation(string message, bool dismissable = true)
        {
            AddAlert(AlertStyles.Information, message);
        }

        public void MessageWarning(string message, bool dismissable = true)
        {
            AddAlert(AlertStyles.Warning, message);
        }

        public void MessageDanger(string message, bool dismissable = true)
        {
            AddAlert(AlertStyles.Danger, message);
        }

        private void AddAlert(string type, string message)
        {



            ViewBag.Messages = new[] {
                    new Alerts(type, "Success!", message),
                    //new Alerts("warning", "Warning!", "The object was added with a warning!"),
                    //new Alerts("danger", "Danger!", "The object was not added!")
                };
        }
    }
    public static class AlertStyles
    {
        public const string Success = "success";// "bg-success text-white";
        public const string Information = "warning"; // "bg-info text-white";
        public const string Warning = "bg-warning text-white";
        public const string Danger = "danger";//"bg-danger text-white";
    }
}
