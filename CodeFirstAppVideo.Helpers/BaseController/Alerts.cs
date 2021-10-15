using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstAppVideo.Helpers.BaseController
{
    public class Alerts
    {
        public string AlertType { get; set; }
        public string AlertTitle { get; set; }
        public string AlertMessage { get; set; }

        public Alerts(string type, string title, string message)
        {
            AlertType = type;
            AlertTitle = title;
            AlertMessage = message;
        }
    }
}
