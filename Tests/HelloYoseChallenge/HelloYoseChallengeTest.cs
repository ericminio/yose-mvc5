using System;
using NUnit.Framework;
using System.Net.Http;
using System.Web.Http;
using Yose;
using System.Net.Http.Headers;
using System.Net;

namespace Tests
{
    [TestFixture]
    public class HelloYoseChallengeTest : WebTest
    {
        HttpResponseMessage response;

        [SetUp]
        public void TheHelloYoseChallenge() 
        {
            client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/xml"));
            response = client.GetAsync ("http://localhost").Result;
        }

        [Test]
        public void ReturnsTheExpectedGreeting()
        {
            Assert.That (((StringContent)response.Content).ReadAsStringAsync().Result, Is.StringContaining ("Hello Yose")); 
        }
    }
}