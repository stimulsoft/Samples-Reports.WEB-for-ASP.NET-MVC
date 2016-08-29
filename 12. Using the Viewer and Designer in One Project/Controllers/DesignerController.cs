using Stimulsoft.Report;
using Stimulsoft.Report.MvcMobile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Samples.Controllers
{
    public class DesignerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReportTemplate()
        {
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));

            DataSet data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));

            report.RegData(data);

            return StiMvcMobileDesigner.GetReportTemplateResult(HttpContext, report);
        }

        public ActionResult GetReportSnapshot()
        {
            return StiMvcMobileDesigner.GetReportSnapshotResult(HttpContext);
        }

        public ActionResult SaveReportTemplate()
        {
            StiReport report = StiMvcMobileDesigner.GetReportObject(HttpContext);
            report.Save(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            
            return StiMvcMobileDesigner.SaveReportTemplateResult(HttpContext);
        }
        
        public ActionResult DesignerEvent()
        {
            return StiMvcMobileDesigner.DesignerEventResult(HttpContext);
        }
    }
}