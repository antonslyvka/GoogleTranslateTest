using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using GoogleTranslateTest.PageObjects;
using System;
using System.Threading;
using System.IO;

namespace GoogleTranslateTest.PageObjects
{
    public static class PageActions
    {

        public static string GetTextFromElement(this ChromeDriver driver, string locator)
        {
            return driver.FindElementByXPath(locator).Text;
        }


        public static void ClickOnElement(this ChromeDriver driver, string locator)
        {
            driver.FindElementByXPath(locator).Click();
        }


        //changes are here
        public static void EnterText(this ChromeDriver driver, string locator, string text)
        {
            driver.FindElement(By.XPath(locator)).SendKeys(text);
        }


        public static void VerifyTextInElement(this ChromeDriver driver, string locator, string text)
        {
            Assert.IsTrue(driver.FindElementByXPath(locator).Text.Equals(text));
        }


        public static void ClickOnElements(this ChromeDriver driver, params string[] locators)
        {
            foreach (var locator in locators)
            {
                ClickOnElement(driver, locator);
            }
        }


        public static bool IsElementPresent(this ChromeDriver driver, string locator)
        {
            try
            {
                driver.FindElementByXPath(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public static void CloseNotification(this ChromeDriver driver)
        {
            if (driver.IsElementPresent(PageElements.NotificationPopupLocator) == true)
            {
                driver.FindElementByXPath(PageElements.NotificationCloseLocator).Click();
            }
        }


        public static void CheckAutoDetectLang(this ChromeDriver driver, string locator, string word)
        {
            bool present = driver.FindElementByXPath(locator).Text.Contains(word);
            Assert.IsTrue(present);
        }


    }
}
