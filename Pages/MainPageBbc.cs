using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Driver;


namespace Pages
{
    public class MainPageBbc : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@data-alt='More']")]
        private readonly IWebElement _menu;

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-nav-links']//a[text()='News']")]
        private readonly IWebElement _news;

        public MainPageBbc() => PageFactory.InitElements(DriverOfChrome.GetDriver(), this);

        public void ClickOnMenu() => _menu.Click();

        public void ClickOnNews() => _news.Click();
    }
}
