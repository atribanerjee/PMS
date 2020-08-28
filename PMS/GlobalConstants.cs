using System;
using System.Configuration;
using System.Web;

namespace PMS
{
    public class GlobalConstants
    {
        public static String DBConn()
        {
               return ConfigurationManager.ConnectionStrings["PMSDBContext"].ToString();
        }
    }
}