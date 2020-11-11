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
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--lang=en");
            driver = new ChromeDriver(Constants.BrowserParam, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.WindowsMaximize();
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



    }
}