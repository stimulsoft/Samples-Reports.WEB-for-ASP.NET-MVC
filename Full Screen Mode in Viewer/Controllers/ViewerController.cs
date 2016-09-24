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
            StiReport report = new StiReport();
            report.LoadDocument(Server.MapPath("~/Content/Reports/SimpleList.mdc"));

            return StiMvcViewer.GetReportSnapshotResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}