using PMS.Helpers;
using PMS.Models;
using PMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class HomeController : Controller
    {

        // GLOBAL VARIABLE
        HomeModel HM;

        public HomeController()
        {
            HM = new HomeModel();
        }

        // GET: Home
        public ActionResult Index()
        {
            // FETCH PAGE ITEMS
            List<HomeViewModel> model = new List<HomeViewModel>();
            model = HM.GetPageItems((int)PMSUtilities.PageType.Home);

            return View(model);
        }

        // FETCH ALL MENU ITEMS
        public PartialViewResult FetchMenuItems()
        {
            List<HomeViewModel> model = new List<HomeViewModel>();
            // FETCHING MENUS
            model = HM.GetMenuItems();

            return PartialView("_MenuItems", model);
        }


    }// CLASS
}// NAMESPACE