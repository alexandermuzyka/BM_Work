using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeeManufacture.Domain.Concrete;
using BeeManufacture.WebUI.Models;

namespace BeeManufacture.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private EFManufactureRepository repo = new EFManufactureRepository();
        public ActionResult Index()
        {
            return View(repo.BHTypes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(repo.BHouses);
        }

        public ViewResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            TotalBeeModel model = new TotalBeeModel();
            model.BHouses = repo.BHouses;
            model.BHTypes = repo.BHTypes;
            model.MBs = repo.MBs;

            return View(model);
        }

        public ViewResult List()
        {
            return View(repo.BHouses);
        }
    }
}