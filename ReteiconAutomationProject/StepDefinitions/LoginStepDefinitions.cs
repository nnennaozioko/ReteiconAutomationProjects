
using MentorsJobs.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MentorsJobs.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage = new LoginPage();

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"login welcome page displayed")]
        public void ThenLoginWelcomePageDisplayed()
        {
            Assert.IsTrue(loginPage.VerifyLoginWelcomePageDisplayed());
        }


        [When(@"I enter the email address ""([^""]*)""")]
        public void WhenIEnterTheEmailAddress(string email)
        {
            loginPage.EnterEmailAddress(email);
        }

        [When(@"I enter your Password ""([^""]*)""")]
        public void WhenIEnterYourPassword(string password)
        {
            loginPage.EnterYourPassword(password);
        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            loginPage.ClickSubmit();
        }
    }
}
