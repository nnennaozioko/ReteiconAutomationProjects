using ReteiconAutomationProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ReteiconAutomationProject.StepDefinitions
{
    [Binding]
    public class FindAMentorStepDefinitions
    {
        FindAMentorPage findAMentorPage = new FindAMentorPage();
        [When(@"I click find a mentor")]
        public void WhenIClickFindAMentor()
        {
            findAMentorPage.clickFindAMentor();
        }

        [When(@"I select quality testing from the category")]
        public void WhenISelectQualityTestingFromTheCategory()
        {
            throw new PendingStepException();
        }

        [When(@"click search now")]
        public void WhenClickSearchNow()
        {
            throw new PendingStepException();
        }

        [When(@"I select Olusegun Yakubu")]
        public void WhenISelectOlusegunYakubu()
        {
            throw new PendingStepException();
        }
    }
}
