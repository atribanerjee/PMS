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
    public class ResumeController : Controller
    {

        // GLOBAL VARIABLE
        HomeModel HM;

        public ResumeController()
        {
            HM = new HomeModel();
        }

        // GET: Resume
        public ActionResult Index()
        {
            // FETCH PAGE ITEMS
            List<HomeViewModel> model = new List<HomeViewModel>();
            model = HM.GetPageItems((int)PMSUtilities.PageType.Resume);
            return View(model);
        }
    }
}