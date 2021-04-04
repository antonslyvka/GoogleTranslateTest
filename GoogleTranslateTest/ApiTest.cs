using NUnit.Framework;
using System.Net;
using GoogleTranslateTest.PageObjects;

namespace Tests
{

    [TestFixture]
    public class ApiTest
    {
        WebClient client = new WebClient();

        [Test] 
        public void VerifyApiTranslateFromEnglishToUkrainian()
        {
            var zminna = client.ApiTranslate("en", "uk", Constants.words1[0]);
            Assert.IsTrue(zminna == Constants.words1[2],$"{zminna},{Constants.words1[2]}");
        }


        [Test]
        public void VerifyApiTranslateFromUkrainianToEnglish()
        {
            Assert.IsTrue(client.ApiTranslate("uk", "en", Constants.words1[1]) == Constants.words1[0]);
        }

    }


}