using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using System;
using System.Data;
using System.Web.Mvc;
using ViewerAndDesigner;

namespace HTML_Samples.Controllers
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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetReport()
        {
            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            var dados = Help.RetornarPessoas();
            report.RegBusinessObject("Pessoa", dados);
            report.Dictionary.SynchronizeBusinessObjects(2);
            return StiMvcDesigner.GetReportResult(report);
        }

        public ActionResult PreviewReport()
        {
            StiReport report = StiMvcDesigner.GetActionReportObject();
            var dados = Help.RetornarPessoas();
            report.RegBusinessObject("Pessoa", dados);
            report.Dictionary.SynchronizeBusinessObjects(2);

            return StiMvcDesigner.PreviewReportResult(report);
        }

        public ActionResult SaveReport()
        {
            StiReport report = StiMvcDesigner.GetReportObject();
            report.Save(Server.MapPath("~/Content/Reports/TwoSimpleLists.mrt"));
            
            return StiMvcDesigner.SaveReportResult();
        }
        
        public ActionResult DesignerEvent()
        {
            return StiMvcDesigner.DesignerEventResult();
        }
    }
}