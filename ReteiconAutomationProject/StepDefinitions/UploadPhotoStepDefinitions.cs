using ReteiconAutomationProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ReteiconAutomationProject.StepDefinitions
{
    [Binding]
    public class UploadPhotoStepDefinitions
    {
        FileLocationPage fileLocationPage = new FileLocationPage();

        [When(@"I uploadPhoto ""([^""]*)""")]
        public void WhenIUploadPhoto(string fileImage)
        {
            fileLocationPage.UploadPhoto(fileImage);
        }
    }
}
