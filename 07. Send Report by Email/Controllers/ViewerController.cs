using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Samples.Controllers
{
    public class ViewerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReportSnapshot()
        {
            // Create the report object
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));

            // Load data from XML file for report template
            DataSet data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));

            report.RegData(data);
            
            return StiMvcViewer.GetReportSnapshotResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }

        public ActionResult EmailReport()
        {
            StiEmailOptions options = StiMvcViewer.GetEmailOptions();

            options.AddressFrom = "admin@test.com";
            options.AddressTo = "manager@test.com";
            options.Subject = "Quarterly Report";
            options.Body = "Quarterly report on arrival of the goods.";

            options.Host = "smtp.test.com";
            //options.Port = 465;
            options.UserName = "admin@test.com";
            options.Password = "************";
            
            return StiMvcViewer.EmailReportResult(options);
        }
    }
}