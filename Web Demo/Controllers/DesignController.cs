using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;

namespace Web_Demo.Controllers
{
    public class DesignController : Controller
    {
        // GET: Design
        public ActionResult Reports()
        {
            return View();
        }

        public ActionResult GetReport(string id = "SimpleList")
        {
            // Create the report object and load data from xml file
            var report = new StiReport();
            report.Load(Server.MapPath($"~/Content/ReportTemplates/{id}.mrt"));

            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult SaveReport()
        {
            StiReport report = StiMvcDesigner.GetReportObject();

            // string packedReport = report.SavePackedReportToString();
            // ...
            // The save report code here
            // ...

            // Completion of the report saving without dialog box
            return StiMvcDesigner.SaveReportResult();
        }

        public ActionResult PreviewReport()
        {
            // Get the report template
            var report = StiMvcDesigner.GetActionReportObject();

            // Register data, if necessary
            var data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));
            report.Dictionary.Databases.Clear();
            report.RegData(data);

            // Return the report snapshot result to the client
            return StiMvcDesigner.PreviewReportResult(report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }

        public ActionResult ExitDesigner(string id)
        {
            return RedirectToAction("Reports", "View", new { id });
        }
    }
}