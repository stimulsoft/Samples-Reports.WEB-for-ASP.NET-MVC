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
    public class ViewerFxController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReportSnapshot(int? id)
        {
            // Create the report object
            StiReport report = new StiReport();

            // Load report
            switch (id)
            {
                // Load report snapshot
                case 1:
                    report.LoadDocument(Server.MapPath("~/Content/Reports/SimpleList.mdc"));
                    break;

                // Load report template
                case 2:
                    report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
                    break;

                // Load compiled report class
                case 3:
                    report = new StiMasterDetail();
                    break;

                // Load compiled report class
                case 4:
                    report = new StiParametersSelectingCountryReport();
                    break;

                // Load report snapshot
                default:
                    report.LoadDocument(Server.MapPath("~/Content/Reports/SimpleList.mdc"));
                    break;
            }

            // Load data from XML file for report template
            if (!report.IsDocument)
            {
                DataSet data = new DataSet("Demo");
                data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));

                report.RegData(data);
            }

            return StiMvcViewerFx.GetReportSnapshotResult(report);
        }
    }
}