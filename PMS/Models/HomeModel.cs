using PMS.Helpers;
using PMS.ViewModels;
using PMSDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.Models
{
    public class HomeModel
    {

        // TO GET THE MENU ITEMS
        public List<HomeViewModel> GetMenuItems()
        {
            List<HomeViewModel> lstHome = new List<HomeViewModel>();
            using (PMSDBContext db = new PMSDBContext(GlobalConstants.DBConn()))
            {
                lstHome = db.Content.Where(w => w.TypeID == (int)PMSUtilities.MasterType.Menu).ToArray()
                    .OrderBy(or => or.ID)
                    .Select(s => new HomeViewModel { 
                        ID = s.ID,
                        Name = s.Name
                    } ).ToList();
            }
            return lstHome;
        }

        // TO GET PAGE ITEMS
        public List<HomeViewModel> GetPageItems(int pageType)
        {
            List<HomeViewModel> lstPage = new List<HomeViewModel>();
            using (PMSDBContext db = new PMSDBContext(GlobalConstants.DBConn()))
            {
                lstPage = db.Content.Where(w => w.ParentID == pageType).ToArray()
                    .OrderBy(or => or.ID)
                    .Select(s => new HomeViewModel
                    {
                        ID = s.ID,
                        Name = s.Name,
                        TypeID = s.TypeID,
                        Description = s.Description,
                        ImageText = s.ImageText
                    }).ToList();
            }
            return lstPage;
        }

    }// CLASS
}// NAMESPACE