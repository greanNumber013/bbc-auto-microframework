using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using Driver;

namespace Pages
{
    public class ComplexForm
    {  
        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        private readonly IWebElement _submitButton;

        public ComplexForm() => PageFactory.InitElements(DriverOfChrome.GetDriver(), this);

        public IWebElement FormField(string field) => DriverOfChrome.GetDriver().FindElement(By.XPath($"//*[contains(@placeholder, '{field}')]"));

        public void FillForm(Dictionary<string, string> fieldsAndValues)
        {
            foreach (string item in fieldsAndValues.Keys)
            {
                FormField(item).SendKeys(fieldsAndValues[item]);
            }
        }
        public void SubmitInfo() => _submitButton.Click();
    }
}
