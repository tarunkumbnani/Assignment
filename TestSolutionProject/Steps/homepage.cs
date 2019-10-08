using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;
using TestSolutionProject.Pages;

namespace TestSolutionProject.Steps
{
    [Binding]
    public class HomePage
    {
        LoginPage loginPage;
        OfferPage offerPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver.InitBrowser();
        }

        [Given(@"I go to home page url '(.*)'")]
        public void GivenIGoToUrl(string url)
        {
            Driver.LoadApplication(url);
        }

        [When(@"I click on quick links on home page")]
        public void ClickOnQuickLinks()
        {
            loginPage = new LoginPage();
            loginPage.ClickQuickLinks();

        }

        [When(@"Enter '(.*)' and '(.*)'")]
        public void WhenIEnterAddressDetails(string search_area, string apartment_num)
        {
            offerPage = new OfferPage();
            offerPage.EnterAddressDetails(search_area, apartment_num);
        }

        [Then(@"Validate that atleast one offer is displayed")]
        public void ThenValidateTheOfferIsDisplayed()
        {
            Assert.That(offerPage.Offer.Displayed);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.CloseBrowser();
        }
    }
}
