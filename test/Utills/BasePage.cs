using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Utills
{
    class BasePage
    {
        public static IWebDriver driver;

        public void OpenBrowser(String browser)
        {
            try
            {
                switch (browser.ToLower())
                {
                    case "chrome":
                        driver = new ChromeDriver("C:\\Users\\ritu01\\source\\repos\\test\\test\\Utills\\Drivers");
                        break;
                    case "firefox":
                        driver = new FirefoxDriver("C:\\Users\\ritu01\\source\\repos\\test\\test\\Utills\\Drivers");
                        break;
                    case "ie":
                        driver = new InternetExplorerDriver("C:\\Users\\ritu01\\source\\repos\\test\\test\\Utills\\Drivers");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void HitURL(string URL)
        {
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
        }

        public void CheckTitle(string title)
        {
            string PageTitle = driver.Title;

            if (title.Equals(PageTitle))
            {
                Console.WriteLine(PageTitle);
            }
            else
                driver.Quit();
        }
    }
}
