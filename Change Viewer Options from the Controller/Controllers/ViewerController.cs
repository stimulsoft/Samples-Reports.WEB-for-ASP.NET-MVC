using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;

namespace Change_Viewer_Options_from_the_Controller.Controllers
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
            var viewerOptions = new StiMvcViewerOptions();
            viewerOptions.Actions.GetReport = "GetReport";
            viewerOptions.Actions.ViewerEvent = "ViewerEvent";
            viewerOptions.Appearance.FullScreenMode = true;
            viewerOptions.Toolbar.Zoom = 75;
            viewerOptions.Toolbar.ViewMode = Stimulsoft.Report.Web.StiWebViewMode.MultiplePages;
            viewerOptions.Theme = Stimulsoft.Report.Web.StiViewerTheme.Office2013WhiteViolet;

            // Passing options via ViewBag
            ViewBag.ViewerOptions = viewerOptions;

            return View();
        }

        public ActionResult GetReport()
        {
            // Create the report object
            var report = new StiReport();

            // Load report snapshot
            report.LoadDocument(Server.MapPath("~/Content/Reports/SimpleList.mdc"));

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}