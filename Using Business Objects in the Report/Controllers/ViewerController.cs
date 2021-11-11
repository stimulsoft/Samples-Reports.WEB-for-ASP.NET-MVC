using BusinessObjects;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;

namespace Using_Business_Objects_in_the_Report.Controllers
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

        public ActionResult ActionITypedList()
        {
            return View("ViewITypedList");
        }

        public ActionResult ActionIEnumerable()
        {
            return View("ViewIEnumerable");
        }

        public ActionResult ActionITypedListBO()
        {
            return View("ViewITypedListBO");
        }

        public ActionResult ActionIEnumerableBO()
        {
            return View("ViewIEnumerableBO");
        }

        public ActionResult GetReportITypedList()
        {
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/BusinessObjects_ITypedList.mrt"));
            report.RegData("EmployeeITypedList", CreateBusinessObjectsITypedList.GetEmployees());
            CheckReference(report);

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult GetReportIEnumerable()
        {
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/BusinessObjects_IEnumerable.mrt"));
            report.RegData("EmployeeIEnumerable", CreateBusinessObjectsIEnumerable.GetEmployees());
            CheckReference(report);

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult GetReportITypedListBO()
        {
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/BusinessObjects_ITypedList_BO.mrt"));
            report.RegBusinessObject("EmployeeITypedList", CreateBusinessObjectsITypedList.GetEmployees());
            report.Dictionary.SynchronizeBusinessObjects(2);
            CheckReference(report);

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult GetReportIEnumerableBO()
        {
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/BusinessObjects_IEnumerable_BO.mrt"));
            report.RegBusinessObject("EmployeeIEnumerable", CreateBusinessObjectsIEnumerable.GetEmployees());
            report.Dictionary.SynchronizeBusinessObjects(2);
            CheckReference(report);

            return StiMvcViewer.GetReportResult(report);
        }

        private void CheckReference(StiReport report)
        {
            var assemblyName = Assembly.GetExecutingAssembly().ManifestModule.Name;
            var refs = new List<string>(report.ReferencedAssemblies);
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