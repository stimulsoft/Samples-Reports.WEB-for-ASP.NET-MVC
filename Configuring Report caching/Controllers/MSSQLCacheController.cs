using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Web;
using Reports;
using System;
using System.Data;
using System.Web.Mvc;

namespace Configuring_Report_caching.Controllers
{
    public class StiDefaultCacheHelper : StiCacheHelper
    {
        public override StiReport GetReport(string guid)
        {
            return base.GetReport(guid);
        }

        public override void SaveReport(StiReport report, string guid)
        {
            base.SaveReport(report, guid);
        }

        public override void RemoveReport(string guid)
        {
            base.RemoveReport(guid);
        }
    }

    public class DefaultCacheController : Controller
    {
        static DefaultCacheController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public DefaultCacheController()
        {
            StiMvcViewer.CacheHelper = new StiDefaultCacheHelper();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport(int id = 1)
        {
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}