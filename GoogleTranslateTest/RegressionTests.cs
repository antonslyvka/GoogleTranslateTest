using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using GoogleTranslateTest.PageObjects;
using System.Threading;
using System;

namespace Tests
{


    [TestFixture]
    public class Tests
    {
        public static ChromeDriver driver;

        [SetUp]
        public void Setup()   
        {
            driver = BrowserActions.StartBrowser();
            //driver = new ChromeDriver(Constants.BrowserParam, BrowserActions.BrowserParamsToEnglish());
            //driver.BrowserParams();
            driver.GoToUrl(Constants.BaseURL);
            driver.CloseNotification();
        }

        [TearDown]
        public void TearDown()
        {
            driver.CloseBrowser();
        }


        [Test]
        public void BasicTranslateEnglishToUkrainian()
        {
            driver.ClickOnElements(PageElements.List1MoreLanguagsLocator, PageElements.List1EnlishLocator);
            driver.ClickOnElements(PageElements.List2MoreLanguagsLocator, PageElements.List2UkrainianLocator);
            driver.EnterText(PageElements.EnterTextFieldLocator, Constants.words1[0]);
            driver.VerifyTextInElement(PageElements.TranslatedTextLocator, Constants.words1[2]);
        }


        [Test]
        public void BasicTranslateUkrainianToEnglish()
        {
            driver.ClickOnElements(PageElements.List1MoreLanguagsLocator, PageElements.List1UkrainianLocator);
            driver.ClickOnElements(PageElements.List2MoreLanguagsLocator, PageElements.List2EnlishLocator);
            driver.EnterText(PageElements.EnterTextFieldLocator, Constants.words1[1]);
            driver.VerifyTextInElement(PageElements.TranslatedTextLocator, Constants.words1[0]);
        }


        [Test]
        public void VerifySwitchEnglishToUkrainian()
        {
            driver.ClickOnElements(PageElements.List1MoreLanguagsLocator, PageElements.List1EnlishLocator);
            driver.ClickOnElements(PageElements.List2MoreLanguagsLocator, PageElements.List2UkrainianLocator);
            driver.EnterText(PageElements.EnterTextFieldLocator, Constants.words1[0]);
            driver.ClickOnElement(PageElements.SwitchButtonLocator);
            driver.VerifyTextInElement(PageElements.TranslatedTextLocator, Constants.words1[0]);
        }


        [Test]
        public void VerifySwitchUkrainianToEnglish()
        {
            driver.ClickOnElements(PageElements.List1MoreLanguagsLocator, PageElements.List1UkrainianLocator);
            driver.ClickOnElements(PageElements.List2MoreLanguagsLocator, PageElements.List2EnlishLocator);
            driver.EnterText(PageElements.EnterTextFieldLocator, Constants.words1[1]);
            driver.ClickOnElement(PageElements.SwitchButtonLocator);
            driver.VerifyTextInElement(PageElements.TranslatedTextLocator, Constants.words1[1]);
        }


        [Test]
        public void VerifyAutoSelectEnglishLang()
        {
            driver.EnterText(PageElements.EnterTextFieldLocator, Constants.words1[0]);
            Thread.Sleep(3000);
            driver.CheckAutoDetectLang(PageElements.AutoSelectLangLocator, Constants.EnglishLang);
        }


        [Test]
        public void VerifyAutoSelectUkrainianLang()
        {
            driver.EnterText(PageElements.EnterTextFieldLocator, Constants.words1[1]);
            Thread.Sleep(3000);
            driver.CheckAutoDetectLang(PageElements.AutoSelectLangLocator, Constants.UkrainianLang);
        }





    }
}