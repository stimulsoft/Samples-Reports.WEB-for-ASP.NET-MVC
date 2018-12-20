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
    public class DesignerFxController : Controller
    {
        static DesignerFxController()
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
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            
            return StiMvcDesignerFx.GetReportResult(report);
        }

        public ActionResult PreviewReport()
        {
            DataSet data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));
            
            StiReport report = StiMvcDesignerFx.GetReportObject();
            report.RegData(data);

            return StiMvcDesignerFx.PreviewReportResult(report);
        }

        public ActionResult SaveReport()
        {
            StiReport report = StiMvcDesignerFx.GetReportObject();

            // Store the report object in the session
            Session["SaveReportTemplate"] = report;
            return View("SaveDialog");
        }

        public ActionResult SaveReportFromDialog(string filename)
        {
            StiReport report = Session["SaveReportTemplate"] as StiReport;

            // Save report
            // report.Save(filepath + filename);

            return View("Index");
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesignerFx.DesignerEventResult();
        }
    }
}