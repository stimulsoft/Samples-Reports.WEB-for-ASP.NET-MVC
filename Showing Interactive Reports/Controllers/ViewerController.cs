using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using StiReports;
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

        public ActionResult GetReport(int id = 1)
        {
            // Create the report object
            var report = new StiReport();

            switch (id)
            {
                // Dynamic sorting
                case 1:
                    report.Load(Server.MapPath("~/Content/Reports/Sorting.mrt"));
                    break;

                // Drill down
                case 2:
                    report.Load(Server.MapPath("~/Content/Reports/ListOfProducts.mrt"));
                    break;

                // Collapsing
                case 3:
                    report.Load(Server.MapPath("~/Content/Reports/GroupWithCollapsing.mrt"));
                    break;

                // Bookmarks
                case 4:
                    report = new StiMasterDetail();
                    break;

                // Parameters
                case 5:
                    report = new StiParametersSelectingCountryReport();
                    break;
            }

            // Load data from XML file for report template
            var data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));
            report.Dictionary.Databases.Clear();
            report.RegData(data);

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}