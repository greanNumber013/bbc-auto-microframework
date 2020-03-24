using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using Driver;

namespace Pages
{
    public class NewsPageBbc : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#1']" +
                "//h3[contains(@class, 'gs-c-promo-heading__title')]")]
        public readonly IWebElement _headlineArticleTitle;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'nw-c-top-stories__secondary-item')]" +
                "//a//h3[contains(@class, 'gs-c-promo-heading')]")]
        private readonly IList<IWebElement> _secondaryArticlesTitles;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'inline-block@m')]" +
            "//a[contains(@class, 'gs-c-section-link')]")]
        private readonly IWebElement _headlineArticleCategory;

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-modules']//span[contains(@class, 'gel-long-primer')]")]
        private readonly IWebElement _moreButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='nw-c-nav__wide-overflow']//span[text()='Have Your Say']")]
        private readonly IWebElement _haveYourSayLink;

        public NewsPageBbc() => PageFactory.InitElements(DriverOfChrome.GetDriver(), this);

        public string ExtractMainHeaderText() => _headlineArticleTitle.Text;

        public string ExtractHeadlineArticleCategoryText() => _headlineArticleCategory.Text;

        public bool SecondaryTitlesAreEqualTo(List<string> elements)
        {
            bool result = false;
            foreach (string item1 in elements)
            {
                foreach (var item2 in _secondaryArticlesTitles)
                {
                    if (item1 == item2.Text) { result = true; break; }
                    else result = false; 
                }
                if (!result) break;
            }
            return result;
        }

        public void ClickOnMore() => _moreButton.Click();

        public void ClickOnHaveYourSay() => _haveYourSayLink.Click();
    }
}
