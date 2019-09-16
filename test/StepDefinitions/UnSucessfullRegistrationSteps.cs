using System;
using TechTalk.SpecFlow;

namespace test.StepDefinitions
{
    [Binding]
    public class UnSucessfullRegistrationSteps
    {
        [Given(@"We have client and request")]
        public void GivenWeHaveClientAndRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Pass the Parameter")]
        public void GivenPassTheParameter()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Response  is collected")]
        public void WhenResponseIsCollected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"token is generated")]
        public void ThenTokenIsGenerated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
