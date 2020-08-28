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
    public class ContactController : Controller
    {

        // GLOBAL VARIABLE
        HomeModel HM;

        public ContactController()
        {
            HM = new HomeModel();
        }

        // GET: Contact
        public ActionResult Index()
        {
            // FETCH PAGE ITEMS
            List<HomeViewModel> model = new List<HomeViewModel>();
            model = HM.GetPageItems((int)PMSUtilities.PageType.Contact);

            return View(model);
        }
    }
}