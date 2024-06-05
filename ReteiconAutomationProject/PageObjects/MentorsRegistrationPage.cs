using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ReteiconAutomationProject.Hooks;
using System;
using System.Collections.Generic;

namespace MentorsJob.PageObject
{
    class MentorsRegistrationPage
    {
        public IWebDriver driver;
        public MentorsRegistrationPage()
        {
            driver = BaseTest.driver;
        }

        private By joinMentor = By.XPath("//span[normalize-space()='Join as a Mentor']");
        private By welcomePageDisplayed = By.XPath("//h2[text()='Welcome!']");
        private By firstName = By.XPath("//input[@type='text'][1]");
        private By lastName = By.XPath("//input[@placeholder='Last name']");
        private By emailAddress = By.XPath("//input[@name='registration[email]']");
        private By passWord = By.CssSelector("#tu-passwordinput");
        private By mentorCheckbox = By.XPath("//label[@for='user_type_instructor']");
        private By termsAndConditions = By.XPath("//label[@for='tu-terms']");
        private By joinNow = By.XPath("//a[@class='tu-primbtn-lg tu-submit-registration']");
        private By myProfileTextDisplayed = By.CssSelector("div h4");
        private By popUpMessageDisplayed = By.Id("tuturn-modal-popup");
        private By addValidEmailPopUpDisplayed = By.XPath("//div[@class='modal fade tuturn-profilepopup tu-uploadprofile tuturn-popup']");

        //public object ExpectedConditions { get; private set; }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public void ClickJoinAsMentor()
        {
            driver.FindElement(joinMentor).Click();
        }

        public bool VerifyWelcomePageDisplayed()
        {
            return driver.FindElement(welcomePageDisplayed).Displayed;
        }
        public void EnterFirstName(string fnametxt)
        {
            driver.FindElement(firstName).SendKeys(fnametxt);
        }
        public void EnterLastName(string lnametxt)
        {
            driver.FindElement(lastName).SendKeys(lnametxt);
        }
        public void EntersEmailAddress(string emailtxt)
        {
            driver.FindElement(emailAddress).SendKeys(emailtxt);
        }
        public void EnterPassword(string passwordtxt)
        {
            driver.FindElement(passWord).SendKeys(passwordtxt);
        }

        public void ClickMentorCheckbox()
        {
            IList<IWebElement> options = driver.FindElements(mentorCheckbox);
            foreach (IWebElement option in options)
            {
                if (option.Text.Equals("Mentor"))
                {
                    option.Click();

                }
                //driver.FindElement(mentorCheckbox).Click();
            }
        }
        public void ClickTermsAndConditions()
        {
            driver.FindElement(termsAndConditions).Click();
        }
        public void ClickJoinNowButton()
        {
            driver.FindElement(joinNow).Click();
        }
        public bool VerifyMyProfileText()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(myProfileTextDisplayed));

            return driver.FindElement(myProfileTextDisplayed).Displayed;

        }

        public bool PopUpMessageDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(popUpMessageDisplayed));

            return driver.FindElement(popUpMessageDisplayed).Displayed;
            //return driver.FindElement(errorMsg).Text;

        }



        public bool AddValidEmailPopUpDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(addValidEmailPopUpDisplayed));

            driver.FindElement(addValidEmailPopUpDisplayed);
            return true;
        }


    }



}
