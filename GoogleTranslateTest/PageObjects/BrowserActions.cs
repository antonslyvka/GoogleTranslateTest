using OpenQA.Selenium.Chrome;
using System;

namespace GoogleTranslateTest.PageObjects
{
    public static class BrowserActions
    {

        public static void WindowsMaximize(this ChromeDriver driver)
        {
            driver.Manage().Window.Maximize();
        }


        public static void GoToUrl(this ChromeDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public static void CloseBrowser(this ChromeDriver driver)
        {
            driver.Close();
        }


    }
}
