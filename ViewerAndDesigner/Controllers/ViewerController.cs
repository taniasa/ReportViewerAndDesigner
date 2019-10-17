using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;
using ViewerAndDesigner.Classes;

namespace ViewerAndDesigner.Controllers
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
        public ActionResult Index(ReportList report)
        {
            TempData[Helpers.TempReportName] = report;
            ViewBag.Titulo = report.Description;
            return View();
        }

        public ActionResult AglReportIndexReportDesign(string id)
        {
            var report = TempData[Helpers.TempReportName] as ReportList;
            return RedirectToAction("../Designer/Index", report);
        }

        public ActionResult GetReport()
        {
            var reportTempData =  TempData[Helpers.TempReportName] as ReportList;
            StiReport report = new StiReport();
            //StiOptions.Dictionary.BusinessObjects.ColumnsSynchronizationMode = Stimulsoft.Report.Dictionary.StiColumnsSynchronizationMode.KeepAbsentColumns;
            report.Load(Server.MapPath($"~/Content/Reports/{reportTempData.Name}.mrt"));
            report = ReportData.RegisterData(reportTempData.Data, report);
            TempData[Helpers.TempReportName] = reportTempData;

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}