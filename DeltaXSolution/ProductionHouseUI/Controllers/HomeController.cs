using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DALayer;

namespace ProductionHouseUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult MainPage()
        {
            return View();
        }
        public ActionResult AddNewMovie()
        {
            ProductionHouseEntities DALObj = new ProductionHouseEntities();
            var getProducerList = DALObj.ProducerEntities.ToList();
            SelectList list = new SelectList(getProducerList, "Producer_Id", "Producer_Name");
            ViewBag.ProducerListName = list;
            return View();
        }
    }
}