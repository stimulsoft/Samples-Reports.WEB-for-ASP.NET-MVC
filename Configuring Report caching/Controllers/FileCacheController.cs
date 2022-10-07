using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web.Mvc;
using System.IO;

namespace Configuring_Report_caching.Controllers
{
    public class StiFileCacheHelper : StiCacheHelper
    {
        public override StiReport GetReport(string guid)
        {
            var path = Path.Combine(HttpContext.Server.MapPath("~/CacheFiles"), guid);
            if (File.Exists(path))
            {
                var report = new StiReport();
                var packedReport = File.ReadAllText(path);
                if (guid.EndsWith(GUID_ReportTemplate)) report.LoadPackedReportFromString(packedReport);
                else report.LoadPackedDocumentFromString(packedReport);

                return report;
            }
            return null;
        }

        public override void SaveReport(StiReport report, string guid)
        {
            var packedReport = guid.EndsWith(GUID_ReportTemplate) ? report.SavePackedReportToString() : report.SavePackedDocumentToString();
            var path = Path.Combine(HttpContext.Server.MapPath("~/CacheFiles"), guid);
            File.WriteAllText(path, packedReport);
        }

        public override void RemoveReport(string guid)
        {
            var path = Path.Combine(HttpContext.Server.MapPath("~/CacheFiles"), guid);
            if (File.Exists(path))
                File.Delete(path);
        }
    }

    public class FileCacheController : Controller
    {
        static FileCacheController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public FileCacheController()
        {
            StiMvcViewer.CacheHelper = new StiFileCacheHelper();
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