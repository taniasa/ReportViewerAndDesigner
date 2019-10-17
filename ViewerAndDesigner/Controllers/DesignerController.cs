using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;
using ViewerAndDesigner.Classes;

namespace ViewerAndDesigner.Controllers
{
    public class DesignerController : Controller
    {
        static DesignerController()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public ActionResult Index(ReportList report)
        {
            TempData[Helpers.TempReportName] = report;

            return View();
        }

        public ActionResult GetReport()
        {
            var reportTempData = TempData[Helpers.TempReportName] as ReportList;
            StiReport report = new StiReport();
            //report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            report.Load(Server.MapPath($"~/Content/Reports/{reportTempData.Name}.mrt"));

            report = ReportData.RegisterData(reportTempData.Data, report);
            TempData[Helpers.TempReportName] = reportTempData;

            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult PreviewReport()
        {
            var reportTempData = TempData[Helpers.TempReportName] as ReportList;
            StiReport report = StiMvcDesigner.GetActionReportObject();
            //var dados = Help.RetornarPessoas();
            //report.RegBusinessObject("Pessoa", dados);
            //report.Dictionary.SynchronizeBusinessObjects(2);
            report = ReportData.RegisterData(reportTempData.Data, report);
            TempData[Helpers.TempReportName] = reportTempData;

            return StiMvcDesigner.PreviewReportResult(report);
        }

        public ActionResult SaveReport()
        {
            var reportTempData = TempData[Helpers.TempReportName] as ReportList;
            StiReport report = StiMvcDesigner.GetReportObject();
            report.Save(Server.MapPath($"~/Content/Reports/{reportTempData.Name}.mrt"));
            report = ReportData.RegisterData(reportTempData.Data, report);
            return StiMvcDesigner.SaveReportResult();
        }
        
        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }
    }
}