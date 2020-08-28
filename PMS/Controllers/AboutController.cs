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
    public class AboutController : Controller
    {

        // GLOBAL VARIABLE
        HomeModel HM;

        public AboutController()
        {
            HM = new HomeModel();
        }

        // GET: About
        public ActionResult Index()
        {
            // FETCH PAGE ITEMS
            List<HomeViewModel> model = new List<HomeViewModel>();
            model = HM.GetPageItems((int)PMSUtilities.PageType.About);

            return View(model);
        }
    }
}