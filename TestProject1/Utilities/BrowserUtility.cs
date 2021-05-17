using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
            driver=new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com";
            return driver;
        }
    }
}
