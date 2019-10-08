using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;

namespace TestSolutionProject.Pages
{
    class OfferPage
    {
        RemoteWebDriver _driver;
        public OfferPage() => _driver = Driver.GetDriver();


        public IWebElement AddressBox => _driver.FindElementById("Address");
        public IList<IWebElement> AddressDropDownList => _driver.FindElementsByCssSelector(".address-search-field__autocomplete__list__item.font-p");
        public IWebElement ApartmentNoDropdown => _driver.FindElementByCssSelector("[data-test=apartment-number-dropdown]");
        public IWebElement Offer => _driver.FindElementByCssSelector("[data-test=offer-preformatted-title]");

        public void EnterAddressDetails(string search_area, string apartment_num)
        {
            AddressBox.SendKeys(search_area);
            AddressDropDownList[0].Click();
            ApartmentNoDropdown.SendKeys(apartment_num);
        }
    }
}
