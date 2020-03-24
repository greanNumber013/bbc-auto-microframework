using Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Pages
{
    public class HaveYourSayPageBbc : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//h3[text()='Do you have a question for BBC News?']" +
                "/parent::a[contains(@class, 'gs-c-promo-heading')]")]
        private readonly IWebElement _questionLink;

        public HaveYourSayPageBbc() => PageFactory.InitElements(DriverOfChrome.GetDriver(), this);

        public void ClickOnQuestionLink() => _questionLink.Click();
    }
}
