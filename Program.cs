using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using System.Collections.Generic;
using System.Threading;

namespace knock
{
    class Program
    {
        static void Main(string[] args)
        {
            // driver init
            FirefoxBinary binary = new FirefoxBinary();
            FirefoxOptions options = new FirefoxOptions();//optional
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            IWebDriver driver;

            //data
            string knockToolUrl = @"https://knockrentals.github.io/doorway-v3/"; 

            using (driver = new FirefoxDriver(@"C:\bin", options))
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

                driver.Navigate().GoToUrl(knockToolUrl);

                try{
                    // Test
                    Doorway_Page doorwayPage = new Doorway_Page(driver);
                    doorwayPage.click_schedule_a_tour();
                    
                    Schedule_Page schedulePage = new Schedule_Page(driver);
                    schedulePage.enter_frame();
                    // schedulePage.choose_time("10:30 am");
                    schedulePage.fill_first_name("John");
                    schedulePage.fill_last_name("Koropchak");
                    schedulePage.fill_email("john_koropchak@hotmail.comx");
                    schedulePage.fill_phone("2068908289x");
                    schedulePage.click_book_button();

                    // verify booking was scheduled
                    driver.FindElement(By.XPath("//button[.='Reschedule']")).Click();
                    schedulePage.exit_frame();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
