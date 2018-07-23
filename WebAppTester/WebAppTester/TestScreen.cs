using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTester
{
    public class TestScreen
    {
        public static void ScreenCapture(IWebDriver driver)
        {
            Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();
            sc.SaveAsFile(
                string.Format(@"{0}\\ScreenShot_{1}.png",
                AppInfo.SCREEN_SHOT_PATH,
                DateTime.Now.ToString("yyyy-MM-dd_hhMMss")),
                ScreenshotImageFormat.Png);
        }

    }
}
