
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;


namespace ReteiconAutomationProject.Hooks
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;
      
        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
               // driver.Close();
               // driver.Dispose();
            }

        }
    }
}