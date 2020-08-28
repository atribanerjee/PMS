using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.ViewModels
{
    public class HomeViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TypeID { get; set; }
        public string Description { get; set; }
        public int ParentID { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ImageText { get; set; }
    }
}