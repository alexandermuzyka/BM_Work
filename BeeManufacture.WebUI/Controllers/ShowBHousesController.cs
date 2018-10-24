using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeeManufacture.Domain.Abstract;
using BeeManufacture.Domain.Entities;

namespace BeeManufacture.WebUI.Controllers
{
    public class ShowBHousesController : Controller
    {

        private IManufactureRepository repository;

        public ShowBHousesController(IManufactureRepository repo)
        {
            this.repository = repo;
        }

        // GET: ShowBHouses
        public ViewResult List()
        {
            return View(repository.BHouses);
        }
    }
}