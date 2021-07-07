using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_Demo.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Reports()
        {
            return View();
        }

        public ActionResult GetReport(string id = "SimpleList")
        {
            // Create the report object and load data from xml file
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/" + id + ".mrt"));

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }

        public ActionResult Design(string id)
        {
            return RedirectToAction("Reports", "Design", new { id });
        }
    }
}