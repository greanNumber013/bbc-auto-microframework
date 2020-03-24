using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Driver;

namespace Pages
{
    public class SearchResultsPageBbc : BasePage
    {     
        [FindsBy(How = How.XPath, Using = "//ol[@class='editors-choice results']//li[@data-result-number='1']//h1[@itemprop]")]
        private readonly IWebElement _firstResult;

        public SearchResultsPageBbc() => PageFactory.InitElements(DriverOfChrome.GetDriver(), this);

        public string ExtractFirstSearchResultText() => _firstResult.Text;
    }
}
