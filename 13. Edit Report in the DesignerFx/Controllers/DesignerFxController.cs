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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReportTemplate()
        {
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            
            return StiMvcDesignerFx.GetReportTemplateResult(report);
        }

        public ActionResult GetReportSnapshot()
        {
            DataSet data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));
            
            StiReport report = StiMvcDesignerFx.GetReportObject();
            report.RegData(data);

            return StiMvcDesignerFx.GetReportSnapshotResult(report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesignerFx.DesignerEventResult();
        }
    }
}