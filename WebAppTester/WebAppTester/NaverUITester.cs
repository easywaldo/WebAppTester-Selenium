using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace WebAppTester
{
    [TestClass]
    public class NaverUITester
    {
        private string naverBlogUrl = string.Empty;
        private string naverId = string.Empty;
        private string naverPwd = string.Empty;
        private IWebDriver driver;

        public NaverUITester()
        {
            SetupTest();
        }

        public void SetupTest()
        {
            driver = new ChromeDriver();
            Thread.Sleep(10000);
            //driver = new FirefoxDriver();
            //driver = new InternetExplorerDriver();
            //driver = new EdgeDriver();
            //driver = new OperaDriver();
            naverId = "acetious";
            naverPwd = "rlekflqk1!0214py";
            naverBlogUrl = "https://blog.naver.com";
        }

        public void tear_down_test()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }


        [TestMethod]
        public void naver_login_is_correctly()
        {
            driver.Navigate().GoToUrl(naverBlogUrl);

            IWebElement webElementById = driver.FindElement(
                By.Id("gnb_login_layer"));
            IWebElement webElementByXPath = driver.FindElement(
                By.XPath(@"//*[@id=""gnb_login_layer""]"));

            driver.FindElement(By.Id("gnb_login_layer")).Click();


            driver.FindElement(
                By.Id("id")).SendKeys(naverId);

            driver.FindElement(
                By.Id("pw")).SendKeys(naverPwd);


            driver.FindElement(By.ClassName("btn_global")).Click();

            string visitedValue = driver.FindElement(By.ClassName("text_today_guest")).Text;
            Assert.AreNotEqual(true, string.IsNullOrEmpty(visitedValue));


            TestScreen.ScreenCapture(driver);

        }
    }
}
