using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;
using ViewerAndDesigner;

namespace HTML_Samples.Controllers
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

        public ActionResult AglReportIndexReportDesign(string id)
        {
            return RedirectToAction("../Designer/Index");
        }

        public ActionResult GetReport()
        {
            StiReport report = new StiReport();
            //StiOptions.Dictionary.BusinessObjects.ColumnsSynchronizationMode = Stimulsoft.Report.Dictionary.StiColumnsSynchronizationMode.KeepAbsentColumns;
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            var dados = Help.RetornarPessoas();
            report.RegBusinessObject("Pessoa", dados);
            report.Dictionary.SynchronizeBusinessObjects(2);

            return StiMvcViewer.GetReportResult(report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcViewer.ViewerEventResult();
        }
    }
}