
using AventStack.ExtentReports.Model;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V121.Debugger;
using ReteiconAutomationProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorsJobs.PageObjects
{
    public class LoginPage
    {
        public IWebDriver driver;

        ILog log = LogManager.GetLogger(typeof(LoginPage));
        
        

        public LoginPage()
        {
            driver = BaseTest.driver;
           
           
        }

        private By loginButton = By.XPath("//li[@id='menu-item-2698']");
        private By loginWelcomePageDisplayed = By.XPath("//div[h2='Welcome!']/h2");
        private By emailAddress = By.Name("login[email]");
        private By yourPassword = By.Id("tu-passwordinput");
        private By wrongEmail = By.XPath("tuturn-modal-popup");
        private By wrongPassword = By.XPath("//div[@class='modal fade tuturn-profilepopup tu-uploadprofile tuturn-popup']");


        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }


        public bool VerifyLoginWelcomePageDisplayed()
        {
            return driver.FindElement(loginWelcomePageDisplayed).Displayed;
        }

        public void EnterEmailAddress(string address)
        {
            try
            {
                driver.FindElement(emailAddress).SendKeys(address);
                
            }
            catch (Exception NoSuchElementException)
            {
                log.Error(NoSuchElementException);
           
            }
            finally
            {

            }
        }

        public void EnterYourPassword(string password)
        {
            driver.FindElement(yourPassword).SendKeys(password);
        }

        public void ClickSubmit()
        {
            string Csspath = "div .form-group a span";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 100)", "");
            ((IJavaScriptExecutor)driver).ExecuteScript("document.querySelector(arguments[0],'Before').click()", Csspath);
        }




    }
}
