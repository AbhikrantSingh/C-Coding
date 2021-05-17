using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1.PageObject
{
    [TestFixture]
   public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public IWebElement ChannelName()
        {
            IWebElement search = driver.FindElement(By.LinkText("Selena Gomez"));
            return search;
        }
        public void NavigateToChannel()
        {
           ChannelName().Click();

        }
    }
}
