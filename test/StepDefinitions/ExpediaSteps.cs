using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Assignment.Utills;
using System.Threading;


namespace Assignment.StepDefinitions
{
    [Binding]
    public class ExpediaSteps
    {
        BasePage methods = new BasePage();
        ExpediaUtills ExpUtl = new ExpediaUtills();


        //Search Expedia on Chrome 
        [Given(@"I am on home")]
        public void GivenIAmOnHome()
        {
            methods.OpenBrowser("chrome");
            methods.HitURL(ConstantsForExpedia.ExpediaUrl);
        }


        //Checkink title
        [Given(@"title of the page is Expedia Travel: Search Hotels, Cheap Flights, Car Rentals & Vacations")]
        public void GivenTitleOfThePageIsExpediaTravelSearchHotelsCheapFlightsCarRentalsVacations()
        {

            methods.CheckTitle(ConstantsForExpedia.ExpediaTitle);
        }


        [Then(@"I have clicked on flights button")]
        public void ThenIHaveClickedOnFlightsButton()
        {
            BasePage.driver.FindElement(By.XPath(ConstantsForExpedia.FlightsBtn)).Click();
        }


        //Selecting multi-city option
        [Given(@"I have clicked on multi-city button")]
        public void GivenIHaveClickedOnMulti_CityButton()
        {
            BasePage.driver.FindElement(By.XPath(ConstantsForExpedia.MultiCityBtn)).Click();
        }


        //First port
        [Given(@"I have entered the first origin and destination")]
        public void GivenIHaveEnteredTheFirstOriginAndDestination()
        {
            
            ExpUtl.PortSelection(ConstantsForExpedia.FirstSourcePort, "Delhi, India");
            ExpUtl.PortSelection(ConstantsForExpedia.FirstDestinationPort, "Goa, India");
        }


        
        [When(@"I have enterd departing date")]
        public void WhenIHaveEnterdDepartingDate()
        {
            ExpUtl.DateSelection(ConstantsForExpedia.FirstDepartDate, "10/20/2019");
        }



        [Then(@"I have enterd the adult count")]
        public void ThenIHaveEnterdTheAdultCount()
        {
            ExpUtl.AddAdults(ConstantsForExpedia.AddPass, ConstantsForExpedia.PassCount, ConstantsForExpedia.AddSymbol, 4);
        }



        [Then(@"I have entered the second destination")]
        public void ThenIHaveEnteredTheSecondDestination()
        {
            ExpUtl.PortSelection(ConstantsForExpedia.SecondsourcePort, "Goa, India");
            ExpUtl.PortSelection(ConstantsForExpedia.SecondDestinationPort, "Mumbai, India");
        }



        [Then(@"I have enterd second departing date")]
        public void ThenIHaveEnterdSecondDepartingDate()
        {
            ExpUtl.DateSelection(ConstantsForExpedia.SecondDepartDate, "10/23/2019");
        }


        [When(@"I have cliked on add another flight")]
        public void WhenIHaveClikedOnAddAnotherFlight()
        {
            BasePage.driver.FindElement(By.XPath(ConstantsForExpedia.AddAnotherFlight)).Click();
            Thread.Sleep(2000);
        }



        [Then(@"I have entered the third destination")]
        public void ThenIHaveEnteredTheThirdDestination()
        {
            ExpUtl.PortSelection(ConstantsForExpedia.ThirdSourcePort, "Mumbai, India");
            ExpUtl.PortSelection(ConstantsForExpedia.ThirdDestinationPort, "Delhi, India");
        }



        [Then(@"I have enterd third departing date")]
        public void ThenIHaveEnterdThirdDepartingDate()
        {
            ExpUtl.DateSelection(ConstantsForExpedia.ThirdDepartDate, "10/27/2019");
        }



        [Then(@"Click On the Search BUtton")]
        public void ThenClickOnTheSearchBUtton()
        {
            BasePage.driver.FindElement(By.XPath(ConstantsForExpedia.SearchBtn)).Click();
        }



        [Then(@"Display the successfull message")]
        public void ThenDisplayTheSuccessfullMessage()
        {
            ExpUtl.SelectFlights(ConstantsForExpedia.SelectFirstFlight, ConstantsForExpedia.SelectSecondFlight, ConstantsForExpedia.SelectThirdFlight);
            ExpUtl.ChangeTab();
            ((IJavaScriptExecutor)BasePage.driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            BasePage.driver.FindElement(By.XPath(ConstantsForExpedia.ContinueBookingBtn)).Click();

           
        }



        [When(@"ENsuring correct information of all three flights")]
        public void WhenENsuringCorrectInformationOfAllThreeFlights()
        {
            ExpUtl.ConfMsg(ConstantsForExpedia.ConfFirstFlight, ConstantsForExpedia.confSecondFlight, ConstantsForExpedia.ConfThirdFlight);
        }



        [Then(@"Ensuring the correct amount per person")]
        public void ThenEnsuringTheCorrectAmountPerPerson()
        {
            ExpUtl.TicketAmount(ConstantsForExpedia.Amount1, ConstantsForExpedia.FinalAmount);
        }



        [Then(@"dismis browser")]
        public void ThenDismisBrowser()
        {
            BasePage.driver.Quit();
        }
    }
}
