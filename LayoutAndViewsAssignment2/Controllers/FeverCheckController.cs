using LayoutAndViewsAssignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAndViewsAssignment2.Controllers
{
    public class FeverCheckController : Controller
    {
        // GET: FeverCheck
        public ActionResult Index()
        {
            return View();
        }

        // GET: FeverCheck/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FeverCheck/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FeverCheck/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CalculateTemperatureResult()
        {
            if (Request["txtTemperature"].ToString() == "")
            {
                return View("Index");
            }
            decimal temperatureAmount;
            try
            {
                temperatureAmount = Convert.ToDecimal(Request["txtTemperature"].ToString());
            }
            catch
            {
                ViewBag.Message = ("Please enter an acceptable number");
                return View("Index");
            }
            ViewBag.Message = FeverCheckModels.tempChecker(temperatureAmount);
            return View("Index");
        }
    }
}
