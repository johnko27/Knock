using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace knock
{
    public class Schedule_Page
    {
        private IWebDriver Driver {get; set;}
        public Schedule_Page(IWebDriver driver)
        {
            Driver = driver;
        }

        public void enter_frame()
        {
            var frameElement = Driver.FindElement(By.ClassName("doorway-plugin-frame"));
            Driver.SwitchTo().Frame(frameElement);
        }
        public void exit_frame()
        {
            Driver.SwitchTo().DefaultContent();
        }
        public void fill_first_name(string text)
        {
            Driver.FindElement(By.XPath("//input[@placeholder='First name']")).SendKeys(text);            
        }        
        public void fill_last_name(string text)
        {
            Driver.FindElement(By.XPath("//input[@placeholder='Last name']")).SendKeys(text);
        }        
        public void fill_email(string text)
        {
            Driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys(text);
        }
        public void fill_phone(string text)
        {
            Driver.FindElement(By.XPath("//input[@placeholder='Phone']")).SendKeys(text);
        }
        public void click_book_button()
        {
            Driver.FindElement(By.XPath("//button[.='Book tour!']")).Click();
        }
        public void choose_time(string text)
        {
            // Create the object of the Select class
            SelectElement se = new SelectElement(Driver.FindElement(By.XPath("//input[@tabindex='3']")));
            
            // Select the option using the visible text
            se.SelectByText(text);
        }
    }
}