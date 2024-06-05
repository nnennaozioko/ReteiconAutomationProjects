using OpenQA.Selenium;
using ReteiconAutomationProject.Hooks;
using ReteiconAutomationProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteiconAutomationProject.PageObjects
{
    public class FileLocationPage
    {
       public IWebDriver driver;
        public FileLocation fl;


        public FileLocationPage()
        {
            driver = BaseTest.driver;
           fl = new FileLocation();
        }


       private By uploadPhoto = By.XPath("//a[@class='tu-primbtn']");
       

      public void UploadPhoto(string fileImage)
        {
            {
                string imageFolder = fl.GetFolderLocation("TestDataImages");
                driver.FindElement(uploadPhoto).SendKeys(imageFolder + fileImage);
            }

        }


    }
}
