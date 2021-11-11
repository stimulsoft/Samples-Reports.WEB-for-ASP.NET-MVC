using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exporting_and_Printing_a_Report_from_Code.Controllers
{
    public class HomeController : Controller
    {
        static HomeController()
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private StiReport GetReport()
        {
            var reportPath = Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            return report;
        }

        public ActionResult PrintPdf()
        {
            var report = this.GetReport();
            return StiMvcReportResponse.PrintAsPdf(report);
        }

        public ActionResult PrintHtml()
        {
            var report = this.GetReport();
            return StiMvcReportResponse.PrintAsHtml(report);
        }

        public ActionResult ExportPdf()
        {
            var report = this.GetReport();
            return StiMvcReportResponse.ResponseAsPdf(report);
        }

        public ActionResult ExportHtml()
        {
            var report = this.GetReport();
            return StiMvcReportResponse.ResponseAsHtml(report);
        }

        public ActionResult ExportXls()
        {
            var report = this.GetReport();
            return StiMvcReportResponse.ResponseAsXls(report);
        }
    }
}