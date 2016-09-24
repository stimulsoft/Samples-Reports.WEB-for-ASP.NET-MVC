using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using StiReports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Samples.Controllers
{
    public class ViewerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReportSnapshot(int? id)
        {
            // Create the report object
            StiReport report = new StiReport();

            switch (id)
            {
                // Dynamic sorting
                case 1:
                    report.Load(Server.MapPath("~/Content/Reports/DrillDownSorting.mrt"));
                    break;

                // Drill down
                case 2:
                    report.Load(Server.MapPath("~/Content/Reports/DrillDownListOfProducts.mrt"));
                    break;

                // Collapsing
                case 3:
                    report.Load(Server.MapPath("~/Content/Reports/DrillDownGroupWithCollapsing.mrt"));
                    break;

                // Bookmarks
                case 4:
                    report = new StiMasterDetail();
                    break;

                // Parameters
                case 5:
                    report = new StiParametersSelectingCountryReport();
                    break;

                default:
                    report.Load(Server.MapPath("~/Content/Reports/DrillDownSorting.mrt"));
                    break;
            }

            // Load data from XML file for report template
            DataSet data = new DataSet("Demo");
            data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));
            report.Dictionary.Databases.Clear();
            report.RegData(data);

            return StiMvcViewer.GetReportSnapshotResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}