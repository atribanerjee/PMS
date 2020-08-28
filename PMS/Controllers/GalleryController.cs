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
    public class GalleryController : Controller
    {

        // GLOBAL VARIABLE
        HomeModel HM;

        public GalleryController()
        {
            HM = new HomeModel();
        }

        // GET: Gallery
        public ActionResult Index()
        {
            // FETCH PAGE ITEMS
            List<HomeViewModel> model = new List<HomeViewModel>();
            model = HM.GetPageItems((int)PMSUtilities.PageType.Gallery);

            return View(model);
        }

        // GET: Gallery modal images
        public ActionResult ModalImages(int imageType)
        {
            // FETCH PAGE ITEMS
            List<HomeViewModel> model1 = new List<HomeViewModel>();
            List<HomeViewModel> model = new List<HomeViewModel>();
            model1 = HM.GetPageItems((int)PMSUtilities.PageType.Gallery);
            model = model1.Where(w => w.TypeID == imageType).ToList();

            return PartialView("_GalleryModal", model);
        }

    }
}