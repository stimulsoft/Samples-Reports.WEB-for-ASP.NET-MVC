using BusinessObjects;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

        public ActionResult ActionIEnumerable()
        {
            return View("ViewIEnumerable");
        }

        public ActionResult ActionITypedList()
        {
            return View("ViewITypedList");
        }
        
        public ActionResult GetReportSnapshotIEnumerable()
        {
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/BusinessObjects_IEnumerable.mrt"));
            report.RegData("EmployeeIEnumerable", CreateBusinessObjectsIEnumerable.GetEmployees());
            CheckReference(report);

            return StiMvcViewer.GetReportSnapshotResult(report);
        }

        public ActionResult GetReportSnapshotITypedList()
        {
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/BusinessObjects_ITypedList.mrt"));
            report.RegData("EmployeeITypedList", CreateBusinessObjectsITypedList.GetEmployees());
            CheckReference(report);

            return StiMvcViewer.GetReportSnapshotResult(report);
        }

        private void CheckReference(StiReport report)
        {
            string assemblyName = Assembly.GetExecutingAssembly().ManifestModule.Name;
            List<string> refs = new List<string>(report.ReferencedAssemblies);
            if (!refs.Contains(assemblyName))
            {
                refs.Add(assemblyName);
                report.ReferencedAssemblies = refs.ToArray();
            }
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}