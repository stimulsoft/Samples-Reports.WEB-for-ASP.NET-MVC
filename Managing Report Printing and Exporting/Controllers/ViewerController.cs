using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web.Mvc;

namespace Managing_Report_Printing_and_Exporting.Controllers
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

        public ActionResult PrintReport()
        {
            var report = StiMvcViewer.GetReportObject();

            // Some actions with report when printing

            return StiMvcViewer.PrintReportResult(report);
        }

        public ActionResult ExportReport()
        {
            var report = StiMvcViewer.GetReportObject();
            var parameters = StiMvcViewer.GetRequestParams();

            if (parameters.ExportFormat == StiExportFormat.Pdf)
            {
                // Some actions with report when exporting to PDF
            }
            
            return StiMvcViewer.ExportReportResult(report);
        }
    }
}