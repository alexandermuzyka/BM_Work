using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeeManufacture.Domain.Concrete;
using BeeManufacture.Domain.Entities;
using BeeManufacture.WebUI.Models;
using BeeManufacture.Domain.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BeeManufacture.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public EFManufactureRepository repo = new EFManufactureRepository();
 

        public HomeController() { }

       
        
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
        /// <summary>
        /// ////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public ViewResult List()
        {
            return View(repo.BHouses);
        }
        
        public ViewResult Edit(int id)
        {
            BHouse bhouse = repo.BHouses
              .FirstOrDefault(p => p.Name == id);
            return View(bhouse);
        }

        [HttpPost]
        public ActionResult Edit(BHouse house)
        {
            if (ModelState.IsValid)
            {
                repo.SaveBHouse(house);
                TempData["message"] = string.Format("{0} has been saved", house.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(house);
            }
        }





        /// <summary>
        /// //////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public ViewResult List1()
        {
            return View(repo.BHTypes);
        }

        public ViewResult List2()
        {
            return View(repo.MBs);
        }
    }
}