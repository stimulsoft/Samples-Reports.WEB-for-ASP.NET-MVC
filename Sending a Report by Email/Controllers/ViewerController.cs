using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web.Mvc;

namespace Sending_a_Report_by_Email.Controllers
{
    public class ViewerController : Controller
    {
        static ViewerController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            // Create the report object
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            
            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }

        public ActionResult EmailReport()
        {
            var options = StiMvcViewer.GetEmailOptions();

            options.AddressFrom = "admin@test.com";
            //options.AddressTo = "manager@test.com";
            //options.Subject = "Quarterly Report";
            //options.Body = "Quarterly report on arrival of the goods.";

            options.Host = "smtp.test.com";
            //options.Port = 465;
            options.UserName = "admin@test.com";
            options.Password = "************";
            
            return StiMvcViewer.EmailReportResult(options);
        }
    }
}