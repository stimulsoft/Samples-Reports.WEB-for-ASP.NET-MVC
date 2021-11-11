using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;

namespace Adding_a_Custom_Function_to_the_Designer.Controllers
{
    public class DesignerController : Controller
    {
        public static string MyFunc(string value)
        {
            return value.ToUpper();
        }

        static DesignerController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            var ParamNames = new string[1];
            var ParamTypes = new Type[1];
            var ParamDescriptions = new string[1];

            ParamNames[0] = "value";
            ParamDescriptions[0] = "Descriptions";
            ParamTypes[0] = typeof(string);

            // How to add my function
            StiFunctions.AddFunction(
                "MyCategory",
                "MyFunc",
                "MyFunc",
                "Description",
                typeof(DesignerController),
                typeof(string),
                "Return Description",
                ParamTypes,
                ParamNames,
                ParamDescriptions);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            var report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/MyTwoSimpleLists.mrt"));

            // Add System.Web.Mvc.dll library to the report references
            var assemblies = new string[report.ReferencedAssemblies.Length + 1];
            Array.Copy(report.ReferencedAssemblies, assemblies, report.ReferencedAssemblies.Length);
            assemblies[assemblies.Length - 1] = "System.Web.Mvc.dll";
            report.ReferencedAssemblies = assemblies;

            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }
    }
}