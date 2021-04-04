using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using GoogleTranslateTest.PageObjects;

namespace Tests
{
    [TestFixture]
    public class SmokeTests
    {
        public static ChromeDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = BrowserActions.StartBrowser();
        }

        [TearDown]
        public void TearDown()
        {
            driver.CloseBrowser();
        }

        [Test]
        public void PageIsOpened()
        {
            driver.GoToUrl(Constants.BaseURL);
        }

        // Added some data to check new branch - now from test to master


    }
}