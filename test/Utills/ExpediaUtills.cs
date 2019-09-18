using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using NUnit.Framework;
using System.Threading;

namespace Assignment.Utills
{
    class ExpediaUtills
    {
        public void PortSelection(string xpath, string place)
        {
            BasePage.driver.FindElement(By.XPath(xpath)).Click();
            BasePage.driver.FindElement(By.XPath(xpath)).SendKeys(place);
        }

        public void DateSelection(string xpath, string date)
        {
            BasePage.driver.FindElement(By.XPath(xpath)).Click();
            BasePage.driver.FindElement(By.XPath(xpath)).SendKeys(date);
        }

        public void AddAdults(string xpath_AddPassanger, string xpath_count, string xpath_AddSym, int n)
        {
            BasePage.driver.FindElement(By.XPath(xpath_AddPassanger)).Click();
            string VisibleCount = BasePage.driver.FindElement(By.XPath(xpath_count)).Text;
            int m = Convert.ToInt16(VisibleCount);
            for (int i = m; i < n; i++)
            {
                BasePage.driver.FindElement(By.XPath(xpath_AddSym)).Click();
            }
        }

        public void SelectFlights(string xpath_First, string xpath_Second, string xpath_Third)
        {
            BasePage.driver.FindElement(By.XPath(xpath_First)).Click();
            Thread.Sleep(10000);
            BasePage.driver.FindElement(By.XPath(xpath_Second)).Click();
            Thread.Sleep(10000);
            BasePage.driver.FindElement(By.XPath(xpath_Third)).Click();
            Thread.Sleep(10000);
        }

        public void ConfMsg(string xpath_FstFlight, string xpath_SndFlight, string xpath_TrdFlight)
        {
            string FirstMsg = BasePage.driver.FindElement(By.XPath(xpath_FstFlight)).Text;
            Assert.AreEqual(FirstMsg.ToLower(), "Delhi (DEL) to Goa (GOI)".ToLower());
            string SecondMsg = BasePage.driver.FindElement(By.XPath(xpath_SndFlight)).Text;
            Assert.AreEqual(SecondMsg.ToLower(), "Goa (GOI) to Mumbai (BOM)".ToLower());
            string ThirdMsg = BasePage.driver.FindElement(By.XPath(xpath_TrdFlight)).Text;
            Assert.AreEqual(ThirdMsg.ToLower(), "Mumbai (BOM) to Delhi (DEL)".ToLower());
        }

        public void TicketAmount(string xpath_Amount1, string xpath_AmountTotal)
        {
            string Amount_OnePass= BasePage.driver.FindElement(By.XPath(xpath_Amount1)).Text;
            double AmountPerPass = double.Parse(Amount_OnePass.Replace(",", "").Replace("$", ""));
            double Final = AmountPerPass * 4;

            string Amount_Total = BasePage.driver.FindElement(By.XPath(xpath_AmountTotal)).Text;
            double FinalAmount = double.Parse(Amount_Total.Replace(",", "").Replace("$", ""));

            Assert.AreEqual(Final, FinalAmount);
        }

        public void ChangeTab()
        {
            IList<string> tabs = new List<string>(BasePage.driver.WindowHandles);
            BasePage.driver.SwitchTo().Window(tabs[1]);
            Thread.Sleep(1000);
        }
    }
}
