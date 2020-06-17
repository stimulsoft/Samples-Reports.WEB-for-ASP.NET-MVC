using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;

namespace Connect_to_Data_from_the_Code.Controllers
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
            // Loading the report template
            var reportPath = Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt");
            var report = new StiReport();
            report.Load(reportPath);

            // Deleting connections in the report template
            report.Dictionary.Databases.Clear();

            // Loading data from the XML file
            var dataPath = Server.MapPath("~/Content/Data/Demo.xml");
            var data = new DataSet();
            data.ReadXml(dataPath);

            // Registering data in the report
            report.RegData(data);

            // Syncing the data structure, if required
            //report.Dictionary.Synchronize();

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}