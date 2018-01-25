using LayoutAndViewsAssignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutAndViewsAssignment2.Controllers
{
    public class GuessingGameController : Controller
    {
        int guesses = 0;
        // GET: GuessingGame
        public ActionResult Index()
        {
            Session.Clear();
            Session["RandomNumber"] = GuessingGameModels.RandomNumberGenerator();
            ViewBag.Message = "";
            return View();
        }

        [HttpPost]
        public ActionResult CheckGuess()
        {
            string outputMessage;
            try
            {
                outputMessage = GuessingGameModels.CheckGuess(Convert.ToInt32(Request["txtGuess"]), Convert.ToInt32(Session["RandomNumber"].ToString()));
            }
            catch
            {
                ViewBag.Message = "Please try again";
                return View("Index");
            }
            Session["Guesses"] = guesses;
            ViewBag.Message = outputMessage;
            return View("Index");
        }
    }
}