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


        public static ChromeOptions BrowserParamsToEnglish()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--lang=en");
            return options;
        }


        public static ChromeDriver BrowserParams(this ChromeDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.WindowsMaximize();
            return driver;
        }


        public static ChromeDriver StartBrowser()
        {
            ChromeDriver driver;
            driver = new ChromeDriver(Constants.BrowserParam, BrowserParamsToEnglish());
            driver.BrowserParams();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //driver.WindowsMaximize();
            return driver;
        }



    }
}
