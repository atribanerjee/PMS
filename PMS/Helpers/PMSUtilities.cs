using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.Helpers
{
    public class PMSUtilities
    {

        public enum MasterType
        {
            Menu = 1,
            SiteHeader = 2,
            SiteSubHeader = 3,
            SocialMediaLinks = 4,
            Image = 5,
            Header = 6,
            SubHeader = 7,
            Body = 8,
            OtherFile = 9,
            GalleryHeadShotImage = 10,
            GalleryOnTheJobImage = 11,
            GalleryModelingImage = 12,
            Video = 13
        }

        public enum PageType
        {
            Home = 1,
            About = 2,
            Resume = 3,
            Reel = 4,
            Gallery = 5,
            Contact = 6
        }

    }
}