using Stimulsoft.Report;
using Stimulsoft.Report.Export;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace Report_Export_Service.Controllers
{
    public class ExportController : ApiController
    {
        // GET api/export/pdf
        public HttpResponseMessage Get(string id, string reportName)
        {
            // Check a report file in the 'Reports' folder
            var reportFilePath = Path.Combine(HttpRuntime.AppDomainAppPath, "Reports", reportName + ".mrt");
            if (!File.Exists(reportFilePath))
                reportFilePath = Path.Combine(HttpRuntime.AppDomainAppPath, "Reports", reportName + ".mdc");
            if (!File.Exists(reportFilePath))
                return GetHttpResponseMessage("The report file does not exist!");

            // Load and render the report template
            var report = new StiReport();
            if (reportFilePath.EndsWith(".mrt"))
            {
                report.Load(reportFilePath);
                report.Render(false);
            }
            // Load the rendered report document
            else
                report.LoadDocument(reportFilePath);

            MemoryStream stream;
            HttpResponseMessage result;

            switch (id)
            {
                // Export to PDF
                case "pdf":
                    var pdfSettings = new StiPdfExportSettings();
                    // settings, if required

                    stream = new MemoryStream();
                    report.ExportDocument(StiExportFormat.Pdf, stream, pdfSettings);
                    result = GetHttpResponseMessage(stream.ToArray(), "application/pdf");
                    stream.Close();
                    return result;

                // Export to Excel 2007+
                case "excel":
                    var excelSettings = new StiExcel2007ExportSettings();
                    // settings, if required

                    stream = new MemoryStream();
                    report.ExportDocument(StiExportFormat.Excel2007, stream, excelSettings);
                    result = GetHttpResponseMessage(stream.ToArray(), "application/vnd.ms-excel");
                    stream.Close();
                    return result;

                // Export to HTML
                case "html":
                    var htmlSettings = new StiHtmlExportSettings();
                    // settings, if required

                    stream = new MemoryStream();
                    report.ExportDocument(StiExportFormat.Html, stream, htmlSettings);
                    result = GetHttpResponseMessage(stream.ToArray(), "text/html");
                    stream.Close();
                    return result;

                default:
                    return GetHttpResponseMessage($"The export format [{id}] is not supported!");
            }
        }

        private HttpResponseMessage GetHttpResponseMessage(byte[] content, string mediaType)
        {
            var result = new HttpResponseMessage(HttpStatusCode.OK) { Content = new ByteArrayContent(content) };
            result.Content.Headers.ContentType = new MediaTypeHeaderValue(mediaType);
            
            return result;
        }

        private HttpResponseMessage GetHttpResponseMessage(string content)
        {
            var result = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(content) };
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");

            return result;
        }

        // POST api/export
        public void Post([FromBody] string value)
        {
        }

        // PUT api/export
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/export
        public void Delete(int id)
        {
        }
    }
}
