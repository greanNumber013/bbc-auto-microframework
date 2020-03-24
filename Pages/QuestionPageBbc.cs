using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Driver;

namespace Pages
{
    public class QuestionPageBbc : BasePage
    {

        public QuestionPageBbc() => PageFactory.InitElements(DriverOfChrome.GetDriver(), this);

        public string ExtractTextareaErrorText() => ErrorMessage("question").Text;

        public string ExtractNameErrorText() => ErrorMessage("Name").Text;

        public string ExtractEmailErrorText() => ErrorMessage("Email").Text;

        public IWebElement ErrorMessage(string field) => DriverOfChrome.GetDriver().FindElement(By.XPath($"//*[contains(@placeholder, '{field}')]" +
            "/following-sibling::div[@class='input-error-message']"));

        public string GetPageUrl() => DriverOfChrome.GetDriver().Url;
    }
}
