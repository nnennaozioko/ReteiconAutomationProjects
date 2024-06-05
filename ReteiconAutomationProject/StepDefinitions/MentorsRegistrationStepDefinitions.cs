using MentorsJob.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ReteiconAutomationProject.StepDefinitions
{
    [Binding]
    public class MentorsRegistrationStepDefinitions
    {

        MentorsRegistrationPage mentorsRegistrationPage = new MentorsRegistrationPage();

        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            mentorsRegistrationPage.Navigate("https://mentorskid.com");
        }


        

        [When(@"I click join as a mentor")]
        public void WhenIClickJoinAsAMentor()
        {
            mentorsRegistrationPage.ClickJoinAsMentor();
        }

        [Then(@"welcome page displayed")]
        public void ThenWelcomePageDisplayed()
        {
            Assert.IsTrue(mentorsRegistrationPage.VerifyWelcomePageDisplayed(), "Welcome!");
        }

        [When(@"I enter first name ""([^""]*)""")]
        public void WhenIEnterFirstName(string fnametxt)
        {
            mentorsRegistrationPage.EnterFirstName(fnametxt);
        }

        [When(@"I enter last name ""([^""]*)""")]
        public void WhenIEnterLastName(string lnametxt)
        {
            mentorsRegistrationPage.EnterLastName(lnametxt);
        }

        [When(@"I enter the email ""([^""]*)""")]
        public void WhenIEnterTheEmail(string emailtxt)
        {
            mentorsRegistrationPage.EntersEmailAddress(emailtxt);
        }

        [When(@"I enter Password ""([^""]*)""")]
        public void WhenIEnterPassword(string passtxt)
        {
            mentorsRegistrationPage.EnterPassword(passtxt);
        }

        [When(@"I click mentor checkbox")]
        public void WhenIClickMentorCheckbox()
        {
            mentorsRegistrationPage.ClickMentorCheckbox();
        }

        [When(@"I click terms and condition")]
        public void WhenIClickTermsAndCondition()
        {
            mentorsRegistrationPage.ClickTermsAndConditions();
        }

        [When(@"I click join now")]
        public void WhenIClickJoinNow()
        {
            mentorsRegistrationPage.ClickJoinNowButton();
        }

        [Then(@"my profile page displayed")]
        public void ThenMyProfilePageDisplayed()
        {
            Assert.IsTrue(mentorsRegistrationPage.VerifyMyProfileText());
        }

        [Then(@"the text ""([^""]*)""is displayed")]
        public void ThenTheTextIsDisplayed(string text)
        {
            Assert.IsTrue(mentorsRegistrationPage.PopUpMessageDisplayed());

        }

        [Then(@"the text ""([^""]*)"" is displayed")]
        public void TheTextIsDisplayed(string invalidtext)
        {
            Assert.IsTrue(mentorsRegistrationPage.AddValidEmailPopUpDisplayed());
        }



    }
}
