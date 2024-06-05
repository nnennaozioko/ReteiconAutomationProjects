using log4net;
using MentorsJobs.PageObjects;
using OpenQA.Selenium;
using ReteiconAutomationProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteiconAutomationProject.PageObjects
{
    public class FindAMentorPage
    {

        public IWebDriver driver;
        ILog log = LogManager.GetLogger(typeof(LoginPage));



        public FindAMentorPage()
        {
            driver = BaseTest.driver;
        }


        private By FindAMentor = By.XPath("//a[text()='Find a Mentor']");




        public void clickFindAMentor()
        {
          driver.FindElement(FindAMentor).Click();
        }



    }
}
