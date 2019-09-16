using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Assignment.Utills;
using System.Runtime.InteropServices;

namespace Assignment.StepDefinitions

{
    [Binding]

    public class SignInSteps
    {
        BasePage methods = new BasePage();
        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            methods.OpenBrowser("chrome");
            methods.HitURL(ConstantsForAutomationPractice.automationtestingUrl);
        }

        [When(@"title of home page is My Store")]
        public void WhenTitleOfHomePageIsMyStore()
        {
            methods.CheckTitle(ConstantsForAutomationPractice.AutomationPracticeTitle);
        }

        [Then(@"I click on Sign in option")]
        public void ThenIClickOnSignInOption()
        {
            BasePage.driver.FindElement(By.XPath(ConstantsForAutomationPractice.AutPracSignin)).Click();
        }

        [When(@"I enter ""(.*)"" and ""(.*)""")]
        public void AndIenter(string p0, string p1)
        {
            BasePage.driver.FindElement(By.XPath(ConstantsForAutomationPractice.AutPracEmail)).SendKeys(p0);
            BasePage.driver.FindElement(By.XPath(ConstantsForAutomationPractice.AutPracPasswd)).SendKeys(p1);
        }

        [When(@"I click on signIn button")]
        public void WhenIClickOnSignInButton()
        {
            BasePage.driver.FindElement(By.XPath(ConstantsForAutomationPractice.AutPracSignInBtn)).Click();
        }

        [Then(@"empty credentials appears")]
        public void ThenEmptyCredentialsAppears()
        {
            String msg = BasePage.driver.FindElement(By.XPath(ConstantsForAutomationPractice.EmptyEmailPasswd)).Text;
            Assert.AreEqual(msg, "An email address required.");
        }

        [Then(@"empty password appears")]
        public void ThenEmptyPasswordAppears()
        {
            String msg = BasePage.driver.FindElement(By.XPath(ConstantsForAutomationPractice.EmptyPass)).Text;
            Assert.AreEqual(msg, "Password is required.");
        }

        [Then(@"empty emai appears")]
        public void ThenEmptyEmaiAppears()
        {
            String msg = BasePage.driver.FindElement(By.XPath(ConstantsForAutomationPractice.EmptyEmail)).Text;
            Assert.AreEqual(msg, "An email address required.");
        }

        [Then(@"invalid credentials appears")]
        public void ThenInvalidCredentialsAppears()
        {
            string msg = BasePage.driver.FindElement(By.XPath(ConstantsForAutomationPractice.InvalidCredentials)).Text;
            Assert.AreEqual(msg, "Authentication failed.");
        }
    }
    
}
