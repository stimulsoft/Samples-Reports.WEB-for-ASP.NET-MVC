using Stimulsoft.Base;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Drawing;
using System.Web.Mvc;

namespace Adding_a_Font_to_the_Resource.Controllers
{
    public class DesignerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            var report = new StiReport();

            //Loading and adding a font to resources
            var fileContent = System.IO.File.ReadAllBytes(Server.MapPath("~/Fonts/Roboto-Black.ttf"));
            var resource = new StiResource("Roboto-Black", "Roboto-Black", false, StiResourceType.FontTtf, fileContent, false);
            report.Dictionary.Resources.Add(resource);

            //Adding a font from resources to the font collection
            StiFontCollection.AddResourceFont(resource.Name, resource.Content, "ttf", resource.Alias);

            //Creating a text component
            var dataText = new StiText();
            dataText.ClientRectangle = new RectangleD(1, 1, 3, 2);
            dataText.Text = "Sample Text";
            dataText.Font = StiFontCollection.CreateFont("Roboto-Black", 12, FontStyle.Regular);
            dataText.Border.Side = StiBorderSides.All;

            report.Pages[0].Components.Add(dataText);

            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }
    }
}