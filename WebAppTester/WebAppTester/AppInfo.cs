using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTester
{
    public class AppInfo
    {
        public static string SCREEN_SHOT_PATH
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["ScreenShotPath"].ToString();
            }
        }
    }
}
