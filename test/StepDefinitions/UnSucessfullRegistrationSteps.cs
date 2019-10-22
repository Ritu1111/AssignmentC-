using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace test.StepDefinations
{
    [Binding]
    public class UnSucessfullRegistrationSteps
    {
        RestClient client;
        RestRequest request;
        [Given(@"We have client and request")]
        public void GivenWeHaveClientAndRequest()
        {
            client = new RestClient("https://reqres.in/.");
            request = new RestRequest("/api/login", Method.POST);
        }

        [Given(@"Pass the Parameter")]
        public void GivenPassTheParameter()
        {
            request.AddParameter("email", "sydney@fife");
        }

        [When(@"Response  is collected")]
        public void WhenResponseIsCollected()
        {
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
            Deser deserializedProduct = JsonConvert.DeserializeObject<Deser>(content);
            Assert.AreEqual(deserializedProduct.id, 0);
            Assert.AreEqual(deserializedProduct.token, "QpwL5tke4Pnpja7X4");
            Console.ReadLine();
        }

    }
}
