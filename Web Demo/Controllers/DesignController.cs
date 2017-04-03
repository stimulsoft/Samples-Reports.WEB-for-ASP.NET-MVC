using Stimulsoft.Report;
using Stimulsoft.Report.MvcMobile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
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

        public ActionResult GetReportTemplate(string id)
        {
            // Create the report object and load data from xml file
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/ReportTemplates/" + id + ".mrt"));

            return StiMvcMobileDesigner.GetReportTemplateResult(this.HttpContext, report);
        }

        public ActionResult SaveReportTemplate()
        {
            StiReport report = StiMvcMobileDesigner.GetReportObject(this.HttpContext);

            // string packedReport = report.SavePackedReportToString();
            // ...
            // The save report code here
            // ...

            // Completion of the report saving without dialog box
            return StiMvcMobileDesigner.SaveReportTemplateResult(this.HttpContext);
        }

        public ActionResult GetReportSnapshot()
        {
            // Get the report template
            StiReport report = StiMvcMobileDesigner.GetReportObject(this.HttpContext);

            // Register data, if necessary
            var data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));
            report.Dictionary.Databases.Clear();
            report.RegData(data);

            // Return the report snapshot result to the client
            return StiMvcMobileDesigner.GetReportSnapshotResult(this.HttpContext, report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcMobileDesigner.DesignerEventResult(this.HttpContext);
        }

        public ActionResult ExitDesigner(string id)
        {
            return RedirectToAction("Reports", "View", new { id = id });
        }
    }
}