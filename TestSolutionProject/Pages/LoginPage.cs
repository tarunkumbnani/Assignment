using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace TestSolutionProject.Pages
{
    class LoginPage
    {
        RemoteWebDriver _driver;

        public LoginPage() => _driver = Driver.GetDriver();

        public IWebElement AcceptCookies => _driver.FindElementByCssSelector("[data-test=accept-cookies-button]");
        public IWebElement HandlaButton => _driver.FindElementByCssSelector("[data-test=Handla]");
        public IWebElement BroadbandButton => _driver.FindElementByCssSelector("[data-test=Bredbandsabonnemang]");

        public void ClickQuickLinks()
        {
            AcceptCookies.Click();
            HandlaButton.Click();
            BroadbandButton.Click();
        }
    }
}
