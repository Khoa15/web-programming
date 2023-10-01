using Bai5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai5.Controllers
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

        public ActionResult MHViewBagList()
        {
            ViewBag.Countries = new List<CountryModel>()
            {
                new CountryModel("Viet Nam"),
                new CountryModel("Thai Lan"),
                new CountryModel("Singapore"),
                new CountryModel("Indonesia"),
                new CountryModel("Japan"),
            };
            return View();
        }

        public ActionResult CreateEmployee()
        {
            return View();
        }
    }
}