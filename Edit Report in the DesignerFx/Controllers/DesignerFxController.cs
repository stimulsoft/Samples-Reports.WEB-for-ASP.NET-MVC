using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System.Data;
using System.Web.Mvc;

namespace HTML_Samples.Controllers
{
    public class DesignerFxController : Controller
    {
        static DesignerFxController()
        {
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

        public ActionResult DesignerEvent()
        {
            return StiMvcDesignerFx.DesignerEventResult();
        }
    }
}