using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewerAndDesigner.Classes;

namespace ViewerAndDesigner.Controllers
{
    public class HomeController : Controller
    {
        public List<ReportList> Reports { get; set; } = Get();
        public ActionResult Index()
        {
            //return RedirectToAction("../Viewer/Index");

            return View(Reports);
        }

        public static List<ReportList> Get()
        {
            return new List<ReportList>()
                {
                    new ReportList(4, "alvara", "Error object", DataReportEnum.Alvara ),
                    new ReportList(3, "alvaraMemory", "Memory overflow", DataReportEnum.Alvara ),
                    new ReportList(2, "multiLevelBussinesObject", "Multilevel business object", DataReportEnum.Multilevel ),
                    new ReportList(1, "pessoa", "Pessoa", DataReportEnum.Pessoa),
                };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Designer()
        {
            return RedirectToAction("Index", "Designer");
        }

        public ActionResult Viewer()
        {
            return RedirectToAction("Index", "Viewer");
        }
    }
}