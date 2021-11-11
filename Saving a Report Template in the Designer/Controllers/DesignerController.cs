using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;

namespace Saving_a_Report_Template_in_the_Designer.Controllers
{
    public class DesignerController : Controller
    {
        static DesignerController()
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
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            
            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult SaveReport()
        {
            var report = StiMvcDesigner.GetReportObject();
            
            // Save the report template, for example to JSON string
            var json = report.SaveToJsonString();
            
            return StiMvcDesigner.SaveReportResult();
        }

        public ActionResult SaveReportAs()
        {
            return StiMvcDesigner.SaveReportResult();
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }
    }
}