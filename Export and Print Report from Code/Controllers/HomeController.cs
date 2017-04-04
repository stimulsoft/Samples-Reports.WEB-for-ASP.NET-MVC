using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Samples.Controllers
{
    public class HomeController : Controller
    {
        static HomeController()
        {
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
            string reportPath = Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            string dataPath = Server.MapPath("~/Content/Data/Demo.xml");
            var data = new DataSet("Demo");
            data.ReadXml(dataPath);
            report.RegData(data);

            return report;
        }

        public ActionResult PrintPdf()
        {
            StiReport report = this.GetReport();
            StiReportResponse.PrintAsPdf(report);
            return View();
        }

        public ActionResult PrintHtml()
        {
            StiReport report = this.GetReport();
            StiReportResponse.PrintAsHtml(report);
            return View();
        }

        public ActionResult ExportPdf()
        {
            StiReport report = this.GetReport();
            StiReportResponse.ResponseAsPdf(report);
            return View();
        }

        public ActionResult ExportHtml()
        {
            StiReport report = this.GetReport();
            StiReportResponse.ResponseAsHtml(report);
            return View();
        }

        public ActionResult ExportXls()
        {
            StiReport report = this.GetReport();
            StiReportResponse.ResponseAsXls(report);
            return View();
        }
    }
}