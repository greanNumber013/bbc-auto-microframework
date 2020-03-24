using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Driver;

namespace Pages
{

    public class BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='orb-search-q']")]
        private readonly IWebElement _searchField;

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-search-button']")]
        private readonly IWebElement _searchButton;

        public BasePage() => PageFactory.InitElements(DriverOfChrome.GetDriver(), this);

        public void ClearSearchField() => _searchField.Clear();

        public void SendValueToSearchField(string value) => _searchField.SendKeys(value);

        public void ClickSearchButton() => _searchButton.Click();
    }
}
