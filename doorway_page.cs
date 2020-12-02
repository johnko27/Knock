using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;

namespace knock
{
    public class Doorway_Page
    {
        private IWebDriver Driver {get; set;}
        public Doorway_Page(IWebDriver driver)
        {
            Driver = driver;
        }

        public void click_schedule_a_tour()
        {
            var frameElement = Driver.FindElement(By.ClassName("doorway-notification-frame"));
            Driver.SwitchTo().Frame(frameElement);
            Driver.FindElement(By.XPath("//button[.='Schedule a Tour']")).Click();
            Driver.SwitchTo().DefaultContent();
        }
    }
}