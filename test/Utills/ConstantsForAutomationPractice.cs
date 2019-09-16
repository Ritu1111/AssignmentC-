using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Utills
{
    class ConstantsForAutomationPractice
    {
        public const string automationtestingUrl = "http://automationpractice.com/index.php";
        public const string AutomationPracticeTitle = "My Store";
        public const string AutPracSignin = "//a[@class='login']";
        public const string AutPracEmail = "//input[@id='email']";
        public const string AutPracPasswd = "//input[@id='passwd']";
        public const string AutPracSignInBtn = "//p[@class='submit']//span[1]";
        public const string EmptyEmailPasswd = "//li[contains(text(),'An email address required.')]";
        public const string EmptyPass = "//li[contains(text(),'Password is required.')]";
        public const string EmptyEmail = "//li[contains(text(),'An email address required.')]";
        public const string InvalidCredentials = "//li[contains(text(),'Authentication failed.')]";
    }
}
