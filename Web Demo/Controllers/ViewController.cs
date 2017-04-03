using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_Demo.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Reports()
        {
            return View();
        }

        private string GetReportName()
        {
            RouteValueDictionary routeValues = StiMvcViewer.GetRouteValues();
            string reportName = routeValues["id"].ToString();
            string query = Request.UrlReferrer.Query;
            if (!string.IsNullOrEmpty(query) && query.IndexOf("reportname") > 0)
            {
                var oldReportName = query.Substring(query.IndexOf("=") + 1);
                if (!string.IsNullOrEmpty(oldReportName)) reportName = oldReportName;
            }

            return reportName;
        }

        public ActionResult GetReport(string id)
        {
            // Create the report object and load data from xml file
            var report = new StiReport();

            // Load report from MDZ document file
            // If not found - load from MRT template
            switch (id)
            {
                // Interactive Reports
                case "DrillDownSorting":

                // Parameters
                case "ParametersDetailedCategories":
                case "ParametersDetailedOrders":
                case "ParametersHighlightCondition":
                case "ParametersSelectingCountry":
                case "ParametersInvoice":

                // {Today} function is used
                case "MultiColumnListContainers":
                    var data = new DataSet("Demo");
                    data.ReadXml(Server.MapPath("~/Content/Data/Demo.xml"));
                    report.Load(Server.MapPath("~/Content/ReportTemplates/" + id + ".mrt"));
                    report.RegData(data);
                    break;

                default:
                    report.LoadPackedDocument(Server.MapPath("~/Content/ReportSnapshots/" + id + ".mdz"));
                    break;
            }

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }

        public ActionResult Design(string id)
        {
            return RedirectToAction("Reports", "Design", new { id = id });
        }
    }
}