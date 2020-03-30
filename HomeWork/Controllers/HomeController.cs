using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWork.Repositories;

namespace HomeWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly DetailRepo _detailRepo = new DetailRepo();

        public ActionResult Index()
        {
            var detailList = _detailRepo.GetAllDetail();
            return View(detailList);
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
    }
}