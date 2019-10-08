using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace TestSolutionProject.Pages
{
    class Driver
    {
        private static RemoteWebDriver _driver;

        public static void InitBrowser() {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
        }

        public static void LoadApplication(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static RemoteWebDriver GetDriver()
        {
            return _driver;
        }

        public static void CloseBrowser()
        {
            _driver.Quit();
        }
    }
}
