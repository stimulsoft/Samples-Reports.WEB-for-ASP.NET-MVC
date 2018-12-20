using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web.Mvc;

namespace HTML_Samples.Controllers
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
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));

            // Load data from XML file for report template
            DataSet data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));

            report.RegData(data);
            
            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }

        public ActionResult PrintReport()
        {
            StiReport report = StiMvcViewer.GetReportObject();

            // Some actions with report when printing

            return StiMvcViewer.PrintReportResult(report);
        }

        public ActionResult ExportReport()
        {
            StiReport report = StiMvcViewer.GetReportObject();
            StiRequestParams parameters = StiMvcViewer.GetRequestParams();

            if (parameters.ExportFormat == StiExportFormat.Pdf)
            {
                // Some actions with report when exporting to PDF
            }
            
            return StiMvcViewer.ExportReportResult(report);
        }
    }
}