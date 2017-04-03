using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_DemoFx.Controllers
{
    public class DesignController : Controller
    {
        // GET: Design
        public ActionResult Reports()
        {
            return View();
        }

        public ActionResult GetReportTemplate(string id)
        {
            // Create the report object and load data from xml file
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/ReportTemplates/" + id + ".mrt"));

            return StiMvcDesignerFx.GetReportResult(report);
        }

        public ActionResult SaveReportTemplate()
        {
            StiReport report = StiMvcDesignerFx.GetReportObject();

            // string packedReport = report.SavePackedReportToString();
            // ...
            // The save report code here
            // ...

            // Completion of the report saving without dialog box
            return StiMvcDesignerFx.SaveReportResult();
        }

        public ActionResult PreviewReport()
        {
            // Get the report template
            StiReport report = StiMvcDesignerFx.GetReportObject();

            // Register data, if necessary
            var data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));
            report.Dictionary.Databases.Clear();
            report.RegData(data);

            // Return the report snapshot result to the client
            return StiMvcDesignerFx.PreviewReportResult(report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesignerFx.DesignerEventResult();
        }

        public ActionResult ExitDesigner(string id)
        {
            return RedirectToAction("Reports", "View", new { id = id });
        }
    }
}