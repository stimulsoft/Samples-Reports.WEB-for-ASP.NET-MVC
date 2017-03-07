using Stimulsoft.Report;
using Stimulsoft.Report.MvcMobile;
using System;
using System.Data;
using System.Web.Mvc;

namespace HTML_Samples.Controllers
{
    public class DesignerController : Controller
    {
        static DesignerController()
        {
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReportTemplate()
        {
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            
            return StiMvcMobileDesigner.GetReportTemplateResult(HttpContext, report);
        }

        public ActionResult GetReportSnapshot()
        {
            StiReport report = StiMvcMobileDesigner.GetReportObject(HttpContext);

            DataSet data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));

            report.RegData(data);

            return StiMvcMobileDesigner.GetReportSnapshotResult(HttpContext, report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcMobileDesigner.DesignerEventResult(HttpContext);
        }
    }
}