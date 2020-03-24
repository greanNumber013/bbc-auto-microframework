using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Driver
{
    public class DriverOfChrome
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
                driver = new ChromeDriver();
            return driver;
        } 

        public static void ConfigureDriver()
        {
            driver = GetDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public static void CloseDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}
